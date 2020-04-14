using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Drawing;
using System.IO;


namespace RCSv1._0
{
    public partial class MainForm : Form
    {
        /* These variables are different from the panel in the MainForm, these are used for 
         * supporting the way approaching those panel
         */

        private HomeInputPanel homeInputPanel;
        private NuclideInputPanel nuclideInputPanel;
        private ModelsInputPanel modelsInputPanel;
        private KineticsInputPanel kineticsInputPanel;
        private DoseOutputPanel doseOutputPanel;

        #region Support Method

        public MainForm()
        {
            InitializeComponent();

            homeInputPanel = new HomeInputPanel(pnlHomeInput);
            nuclideInputPanel = new NuclideInputPanel(pnlNuclideInput);
            modelsInputPanel = new ModelsInputPanel(pnlModelsInput);
            kineticsInputPanel = new KineticsInputPanel(pnlKineticsInput);
            doseOutputPanel = new DoseOutputPanel(pnlDoseOutput);
            pnlHomeInput.BringToFront();
            UserData.humanPhantom = modelsInputPanel.ReturnHumanAgeOption();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void DrawColourMouseHoverMenuButton(BunifuThinButton2 btn)
        {
            btnNuclideInput.IdleFillColor = Color.White;
            btnNuclideInput.IdleForecolor = Color.SeaGreen;
            btnModelsInput.IdleFillColor = Color.White;
            btnModelsInput.IdleForecolor = Color.SeaGreen;
            btnKineticsInput.IdleFillColor = Color.White;
            btnKineticsInput.IdleForecolor = Color.SeaGreen;
            btnDose.IdleFillColor = Color.White;
            btnDose.IdleForecolor = Color.SeaGreen;
            btnHomeInput.IdleFillColor = Color.White;
            btnHomeInput.IdleForecolor = Color.SeaGreen;
            btn.IdleFillColor = Color.SeaGreen;
            btn.IdleForecolor = Color.White;
        }

        bool isOrganName(string text)
        {
            bool check = true;
            char[] number = new char[10]
            {
                '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
            };
            foreach (var item in number)
            {
                if (text.IndexOf(item) != -1)
                {
                    check = false;
                }
            }
            if (check == false || text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        bool isModelName(string text, int index, string[] modelname)
        {
            bool check = false;
            if (text.IndexOf(modelname[index]) != -1)
            {
                check = true;
            }
            return check;
        }

        List<string> GetSourceOrgan(ref int indexLineSourceOrganName, string[] modelName, int modelIndex)
        {
            List<string> listSourceOrgan = new List<string>();
            string fileLocation = @"D:\NHHSchool\RCSProgram\Tc-99m.txt";
            FileStream file = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line = "";
            string listSourceOrganNameStr = "";
            indexLineSourceOrganName = 0;
            bool isFinishReading = false;
            while (reader.EndOfStream == false)
            {
                line = reader.ReadLine();
                indexLineSourceOrganName++;
                if (isModelName(line, modelIndex, modelName) == true)
                {
                    while (reader.EndOfStream == false)
                    {
                        line = reader.ReadLine();
                        indexLineSourceOrganName++;
                        if (isOrganName(line) == true && indexLineSourceOrganName != 1)
                        {
                            listSourceOrganNameStr = line;
                            isFinishReading = true;
                            break;
                        }
                    }
                }
                if (isFinishReading == true)
                {
                    break;
                }
            }
            // Line lúc này mang giá trị của dòng sau cơ quan bia, giá trị liều (số)
            // đóng vai trò làm khuôn (vị trí) để lấy ra tên của cơ quan
            line = reader.ReadLine();
            char[] number = new char[10]
            {
                '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'
            };
            bool check = false;
            int count = 0;
            while (check == false)
            {
                line = line.Remove(0, 1);
                count++;
                foreach (var item in number)
                {
                    if (line[0] == item)
                    {
                        check = true;
                    }
                }
            }

            listSourceOrganNameStr = listSourceOrganNameStr.Remove(0, count);
            line = line.Remove(line.Length - 2, 2);
            count = 0;
            // count lúc này là khoảng cách giữa tên cơ quan này và tên cơ quan

            while (line.IndexOf(' ') != -1)
            {
                if (listSourceOrganNameStr[0] == ' ')
                {
                    listSourceOrganNameStr = listSourceOrganNameStr.Remove(0, 1);
                }
                if (line[0] == ' ')
                {
                    line = line.Remove(0, 1);
                }
                else if (count <= listSourceOrganNameStr.Length)
                {
                    // Ngoại trừ trường hợp cơ quan cuối cùng, lúc này cơ quan cuối cùng chỉ cần lấy tên
                    // bằng cách add thẳng biến line vào trong listSourceOrgan
                    count = line.IndexOf(' ');
                    while (line[count] == ' ' && line[count + 1] == ' ')
                    {
                        count++;
                        line = line.Remove(line.IndexOf(' '), 1);
                    }
                    line = line.Remove(0, count);
                    listSourceOrgan.Add(listSourceOrganNameStr.Substring(0, count));
                    listSourceOrganNameStr = listSourceOrganNameStr.Remove(0, count);
                }
                else
                {
                    listSourceOrgan.Add(listSourceOrganNameStr); // Add cơ quan cuối cùng vào listSourceOrgan
                }

            }
            file.Close();

            return listSourceOrgan;
        }

        List<OrganDose> GetTargetOrgan(int lineLocation)
        {
            // lineLocation là biến chỉ vị trí (số dòng) trong file text để tìm kiếm danh sách cquan nguồn
            string fileLocation = Application.StartupPath + @"\data\";
            FileStream file = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line = "";
            string text = "";
            string number = "";
            string dose = "";

            List<OrganDose> organDoses = new List<OrganDose>();
            for (int i = 0; i < lineLocation; i++)
            {
                reader.ReadLine();
            }
            line = reader.ReadLine();
            while (line != "")
            {
                OrganDose lineData = new OrganDose();

                #region Text

                // Biến này dùng để lưu vị trí của kí tự số trong biến line
                int minNumberPosition = line.Length;
                for (int i = 0; i <= 9; i++)
                {
                    if (line.IndexOf(i.ToString()) <= minNumberPosition)
                    {
                        minNumberPosition = line.IndexOf(i.ToString());
                    }
                }
                text = line.Substring(0, minNumberPosition - 1);
                // Xóa khoảng trắng ở cuối tên cơ quan
                while (text[text.Length - 1] == ' ')
                {
                    text = text.Remove(text.Length - 1, 1);
                }
                lineData.organTargetName = text;

                #endregion

                #region Number

                dose = line.Substring(minNumberPosition, line.Length - minNumberPosition);
                while (dose != "")
                {
                    number = dose.Substring(0, dose.IndexOf(' '));
                    lineData.listDoses.Add(float.Parse(number));
                    dose = dose.Remove(0, number.Length + 1);
                    if (dose != " ")
                    {
                        while (dose[0] == ' ')
                        {
                            dose = dose.Remove(0, 1);
                        }
                    }
                    else break;
                }

                #endregion

                organDoses.Add(lineData);
                line = reader.ReadLine();
            }
            return organDoses;
        }

        private string filePath(string nuclideName, string modelName) { 
            return Application.StartupPath + @"\data\" + modelName + "." + nuclideName;
        }

        List<float> Dose(string nuclideName, string modelName, List<float> timeSourceOrgan) {
            List<float> output = new List<float>();
            string fileLocation = filePath(nuclideName, modelName);
            DoseFileReader reader = new DoseFileReader();
            var doseTable = reader.findDoseTable(fileLocation, modelName);
            
            output = doseTable.calculate(timeSourceOrgan);
            return output;
        }

        #endregion

        #region Events

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void BtnNuclideInput_Click(object sender, EventArgs e)
        {
            DrawColourMouseHoverMenuButton(btnNuclideInput);
            pnlNuclideInput.BringToFront();
        }

        private void BtnModelsInput_Click(object sender, EventArgs e)
        {
            DrawColourMouseHoverMenuButton(btnModelsInput);
            pnlModelsInput.BringToFront();
        }

        private void BtnKineticsInput_Click(object sender, EventArgs e)
        {
            UserData.humanPhantom = modelsInputPanel.ReturnHumanAgeOption();
            kineticsInputPanel.DisableTextBox();
            DrawColourMouseHoverMenuButton(btnKineticsInput);
            pnlKineticsInput.BringToFront();
        }

        private void BtnHomeInput_Click(object sender, EventArgs e)
        {
            DrawColourMouseHoverMenuButton(btnHomeInput);
            pnlHomeInput.BringToFront();
        }

        private void BtnDose_Click(object sender, EventArgs e)
        {
            // Checking data by the value in UserData get from Panel
            // If there is any data is not checked, show a message box
            UserData.fullData[0] = nuclideInputPanel.CheckFullNuclideData();
            UserData.fullData[1] = modelsInputPanel.CheckFullData();
            UserData.fullData[2] = kineticsInputPanel.CheckFullKineticsData();

            bool check = true;

            string errorMessage = "LỖI! Bạn chưa nhập ";
            for (int i = 0; i < 3; i++)
            {
                if (UserData.fullData[i] == false)
                {
                    check = false;
                    switch (i)
                    {
                        case 0:
                            errorMessage += "đồng vị phóng xạ, ";
                            break;
                        case 1:
                            errorMessage += "mô hình người, ";
                            break;
                        case 2:
                            errorMessage += "thời gian lưu trú, ";
                            break;
                        default:
                            break;
                    }
                }
            }
            errorMessage = errorMessage.Remove(errorMessage.Length - 2);

            if (check == false)
            {
                MessageBox.Show(errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DrawColourMouseHoverMenuButton(btnDose);
                pnlDoseOutput.BringToFront();
                UserData.humanPhantom = modelsInputPanel.ReturnHumanAgeOption();    // Đây là listModelIndex
                UserData.kineticsData = kineticsInputPanel.GetKineticsData();   // Đây là timeSourceOrgan
                List<float> listOrganDose = new List<float>();  // Lưu theo danh sách kết quả tính liều của từng phantom
                listOrganDose = Dose(nuclideInputPanel.selectedNuclideName(), UserData.humanPhantom, UserData.kineticsData);
                doseOutputPanel.showResult(listOrganDose);
                pnlDoseOutput.BringToFront();
            }
        }

        #endregion
    }
    public class OrganDose
    {
        public string organTargetName = "";
        // Lưu tên của cơ quan bia
        public List<float> listDoses = new List<float>();
        // Lưu danh sách các giá trị S của cqnguồn -> cqbia
    }
}
