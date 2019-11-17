using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RCSTest
{
    public class OrganDose
    {
        public string organSourceName = "";  
        // Lưu tên của cơ quan bia
        public List<float> doses = new List<float>();
        // Lưu danh sách các giá trị S của cqnguồn -> cqbia
    }
    class Program
    {


        /*
        static LineLieu parse(string line) { 
        
        }
        */
        static void Main(string[] args)
        {
            // Mảng này dùng để lưu index của những model được chọn để tính
            List<int> arrSourceOrgan = new List<int>() { 0, 2 };

            // Khi đưa vào MainForm, kích cỡ của mảng sẽ phụ thuộc vào số lượng textbox
            float[] arrTimeSourceOrgan = new float[28]
            { 
                0,0.01f,0,0.02f,0,
                0,0,0,0,0,
                0,0,0,0,0,
                0,0,0,0,0,
                0,0,0,0,0,
                0,0,0,
            };
            

            for (int i = 12; i <= 14; i++)
            {
                Console.WriteLine("Model " + (i + 1));
                test(i, arrSourceOrgan, arrTimeSourceOrgan);
                Console.WriteLine();
            }


            Console.ReadLine();
        }

        static bool isOrganName(string text)
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

        static bool isModelName(string text, int index, string[] modelname)
        {
            bool check = false;
            if (text.IndexOf(modelname[index]) != -1)
            {
                check = true;
            }
            return check;
        }

        static List<string> GetSourceOrgan(ref int indexLineSourceOrganName, string[] modelName, int modelIndex)
        {
            List<string> listTargetOrgan = new List<string>();
            string fileLocation = @"D:\NHHSchool\RCSProgram\Tc-99m";
            FileStream file = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line = "";
            string listTargetOrganNameStr = "";
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
                            listTargetOrganNameStr = line;
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

            listTargetOrganNameStr = listTargetOrganNameStr.Remove(0, count);
            line = line.Remove(line.Length - 2, 2);
            count = 0;  
            // count lúc này là khoảng cách giữa tên cơ quan này và tên cơ quan

            while (line.IndexOf(' ') != -1)
            {
                if (listTargetOrganNameStr[0] == ' ')
                {
                    listTargetOrganNameStr = listTargetOrganNameStr.Remove(0, 1);
                }
                if (line[0] == ' ')
                {
                    line = line.Remove(0, 1);
                }
                else if (count <= listTargetOrganNameStr.Length) 
                {
                    // Ngoại trừ trường hợp cơ quan cuối cùng, lúc này cơ quan cuối cùng chỉ cần lấy tên
                    // bằng cách add thẳng biến line vào trong listTargetOrgan
                    count = line.IndexOf(' ');
                    while (line[count] == ' ' && line[count + 1] == ' ')
                    {
                        count++;
                        line = line.Remove(line.IndexOf(' '), 1);
                    }
                    line = line.Remove(0, count);
                    listTargetOrgan.Add(listTargetOrganNameStr.Substring(0, count));
                    listTargetOrganNameStr = listTargetOrganNameStr.Remove(0, count);
                }
                else
                {
                    listTargetOrgan.Add(listTargetOrganNameStr); // Add cơ quan cuối cùng vào listTargetOrgan
                }
                
                
            }
            file.Close();

            return listTargetOrgan;
        }

        static List<OrganDose> GetTargetOrgan(int lineLocation)
        {
            // lineLocation là biến chỉ vị trí (số dòng) trong file text để tìm kiếm danh sách cquan nguồn
            string fileLocation = @"D:\NHHSchool\RCSProgram\Tc-99m";
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
                lineData.organSourceName = text;

                #endregion

                #region Number

                dose = line.Substring(minNumberPosition, line.Length - minNumberPosition);
                while (dose != "")
                {
                    number = dose.Substring(0, dose.IndexOf(' '));
                    lineData.doses.Add(float.Parse(number));
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


        static void test(int modelIndex, List<int> listtargetOrganOrdinal, float[] timeSourceOrgan) 
        {
            // arrTimeSourceOrgan : là thời gian lưu trú của từng cơ quan
            // listtargetOrganOrdinal : là dãy model (phantom) mà mình cần xét
            // modelIndex : Số thứ từ của model (phantom) cần xét
            // listtargetOrganOrdinal : danh sach cac model (phantom) can tinh
            string fileLocation = @"D:\NHHSchool\RCSProgram\Tc-99m";
            FileStream file = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            // Thời gian lưu trú của cơ quan nguồn
            string[] modelName = new string[]
            {
                "Adult Male",
                "Adult Female",
                "15-year-old Male",
                "10-year-old Male",
                "5-year-old Male",
                "1-year-old Male",
                "Newborn Male",
                "15-year-old Female",
                "10-year-old Female",
                "5-year-old Female",
                "1-year-old Female",
                "Newborn Female",
                "3-month Pregnant Female",
                "6-month Pregnant Female",
                "9-month Pregnant Female",

            };
            List<string> fileText = new List<string>();


            int index = 0; 
            List<string> targetOrgan = GetSourceOrgan(ref index, modelName, modelIndex);

            //List<string> targetOrgan = GetTargetOrgan(index);
            List<OrganDose> organDoses = GetTargetOrgan(index);

            /*
            Không thể liệt kê rồi cố định các cơ quan (đối với phantom/model cũng tương tự), 
            bởi khi thêm vào một cơ quan mới (hay phantom/model) mới nào thì phần mềm sẽ không xử lý được
            */


            for (int i = 0; i < organDoses.Count; i++)
            {
                Console.WriteLine(organDoses[i].organSourceName);
                for (int t = 0; t < targetOrgan.Count; t++)
                {
                    if (timeSourceOrgan[i] != 0)
                    {
                        Console.WriteLine(targetOrgan[t]);
                        Console.Write(organDoses[i].doses[t] + "  ");
                    }
                }
                Console.WriteLine();
            }

            reader.Close();
            file.Close();
        }
    }
}
