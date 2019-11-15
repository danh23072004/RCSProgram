using System;
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
            UserData.HumanAge = modelsInputPanel.ReturnHumanAgeOption();
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

        private void HidePanels()
        {
            pnlNuclideInput.Visible = false;
            pnlModelsInput.Visible = false;
            pnlKineticsInput.Visible = false;
            pnlHomeInput.Visible = false;
            pnlDoseOutput.Visible = false;
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
                UserData.HumanAge = modelsInputPanel.ReturnHumanAgeOption();
                DrawColourMouseHoverMenuButton(btnDose);
                pnlDoseOutput.BringToFront();
            }
        }

        #endregion
    }
}
