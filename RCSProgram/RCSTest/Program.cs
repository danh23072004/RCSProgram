using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RCSTest
{
    class Program
    {
        class LineLieu 
        {
            String organ = "";  // Lưu tên của cơ quan bia
            // Lưu danh sách các giá trị S của cqnguồn -> cqbia
            List<float> doses = new List<float>();  
        }

        /*
        static LineLieu parse(string line) { 
        
        }
        */
        static void Main(string[] args)
        {
            List<int> arrSourceOrgan = new List<int>() { 0, 2 };
            float[] arrTimeSourceOrgan = new float[28]
            { 
                0,0.01f,0,0.02f,0,
                0,0,0,0,0,
                0,0,0,0,0,
                0,0,0,0,0,
                0,0,0,0,0,
                0,0,0,
            };
            

            for (int i = 5; i <= 7; i++)
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

        static List<string> GetTargetOrgan(ref int indexLineSourceOrganName, string[] modelName, int modelIndex)
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

        static List<string> GetSourceOrgan(int lineLocation)
        {
            string fileLocation = @"D:\NHHSchool\RCSProgram\Tc-99m";
            FileStream file = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line = "";
            List<string> sourceOrgan = new List<string>();
            for (int i = 0; i < lineLocation; i++)
            {
                reader.ReadLine();
            }
            line = reader.ReadLine();
            while (line != "")
            {
                line = line.Substring(0, line.IndexOf(' '));
                sourceOrgan.Add(line);
                line = reader.ReadLine();
            }
            return sourceOrgan;
        }

        static void test(int modelIndex, List<int> listsourceOrganOrdinal, float[] timeSourceOrgan) {
            // arrTimeSourceOrgan : là thời gian lưu trú của từng cơ quan
            // listsourceOrganOrdinal : là dãy model (phantom) mà mình cần xét
            // modelIndex : Số thứ từ của model (phantom) cần xét
            // listsourceOrganOrdinal : danh sach cac model (phantom) can tinh
            int indexLineSourceOrganName = 0;
            string fileLocation = @"D:\NHHSchool\RCSProgram\Tc-99m";
            FileStream file = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            // Thời gian lưu trú của cơ quan nguồn
            string[] modelName = new string[]
            {
                "Adult Male",
                "Adult Female",
                "1-year-old Male",
                "5-year-old Male",
                "10-year-old Male",
                "3-month Pregnant Female",
                "6-month Pregnant Female",
                "9-month Pregnant Female",
            };
            List<string> fileText = new List<string>();
            string listSourceOrganName = "";
            // Ten cua cac co quan nguon

            int index = 0; 
            List<string> targetOrgan = GetTargetOrgan(ref index, modelName, modelIndex);
            List<string> sourceOrgan = GetSourceOrgan(index);

            /*
            Không thể liệt kê rồi cố định các cơ quan (đối với phantom/model cũng tương tự), 
            bởi khi thêm vào một cơ quan mới (hay phantom/model) mới nào thì phần mềm sẽ không xử lý được
            */

            float[,] SsourceOrgan = new float[25, 28];

            // Ten cua cac co quan bia
            sourceOrgan = new List<string>()
            {
                "Adrenals", "Brain", "Breasts", "Gallbladder Wall", "LLI Wall", "Small Intestine",
                "Stomach Wall", "ULI Wall", "Heart Wall", "Kidneys", "Liver", "Lungs",
                "Muscle", "Ovaries", "Pancreas", "Red Marrow", "Osteogenic Cells", "Skin",
                "Spleen", "Thymus", "Thyroid", "Urinary Bladder Wall", "Uterus", "Fetus", "Total Body",
            };
            float[] doseTargetOrgan = new float[25];
            

            // Đọc từng dòng của file
            string line = "";
            // bool isModelName = false;
            while (reader.EndOfStream == false)
            {
                line = reader.ReadLine();
                if (isModelName(line, modelIndex, modelName) == true)
                {
                    //checkModelName = true;
                    // Dùng để lưu lại kết quả là đã tìm ra bảng model cần tìm

                    while (reader.EndOfStream == false) {

                        line = reader.ReadLine();
                        if (isOrganName(line) == true)
                        {
                            listSourceOrganName = line;
                        }
                        if (listSourceOrganName != "")
                        {
                            index = 0;
                            string dose = "";
                            line = reader.ReadLine();
                            for (int t = 0; t < sourceOrgan.Count; t++)
                            {
                                Console.WriteLine(sourceOrgan[t]);
                                for (int i = 0; i < targetOrgan.Count; i++)
                                {
                                    if (timeSourceOrgan[t] != 0)
                                    {
                                        Console.WriteLine(targetOrgan[i]);
                                        index = listSourceOrganName.IndexOf(targetOrgan[i]);
                                        dose = line.Substring(index);
                                        dose = dose.Remove(dose.IndexOf(' '));
                                        SsourceOrgan[t, i] = float.Parse(dose);
                                        Console.WriteLine(SsourceOrgan[t, i]);
                                    }
                                }
                                line = reader.ReadLine();
                            }
                            break;
                            // Khi đã đọc hết dữ liệu của bảng cần tìm, out ra khỏi file
                        }
                    }
                }


            }

            reader.Close();
            file.Close();
        }
    }
}
