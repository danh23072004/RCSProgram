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
            

            for (int i = 5; i < 7; i++)
            {
                //Console.WriteLine("Model " + (i + 1));
                //test(i, arrSourceOrgan, arrTimeSourceOrgan);
                //Console.WriteLine();
            }
            int index = 0;  // just for test
            int length = GetTargetOrgan(ref index).Count;
            List<string> result = GetTargetOrgan(ref index);
            for (int i = 1; i < length; i++)
            {
                Console.WriteLine(result[i]);
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

        static List<string> GetTargetOrgan(ref int indexLineSourceOrganName)
        {
            List<string> listSourceOrgan = new List<string>();
            string fileLocation = @"D:\NHHSchool\RCSProgram\Tc-99m";
            FileStream file = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line = "";
            string listSourceOrganNameStr = "";
            indexLineSourceOrganName = 0;
            while (reader.EndOfStream == false)
            {
                line = reader.ReadLine();
                indexLineSourceOrganName++;
                if (isOrganName(line) == true && indexLineSourceOrganName != 1)
                {
                    listSourceOrganNameStr = line;
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
            count = 0;  // count lúc này là khoảng cách giữa tên cơ quan này và tên cơ quan kia
            while (line.IndexOf(' ') != -1)
            {
                if (line[0] == ' ')
                {
                    line = line.Remove(0, 1);
                }
                else
                {
                    count = line.IndexOf(' ') + 1;
                    line = line.Remove(0, count);
                    listSourceOrgan.Add(listSourceOrganNameStr.Substring(0, count));
                    listSourceOrganNameStr = listSourceOrganNameStr.Remove(0, count);
                }
            }

            //while (listSourceOrganNameStr.IndexOf(' ') != -1)
            //{
            //    if (listSourceOrganNameStr[0] == ' ')
            //    {
            //        listSourceOrganNameStr = listSourceOrganNameStr.Remove(0, 1);
            //    }
            //    else
            //    {
            //        listSourceOrgan.Add(listSourceOrganNameStr.Substring(0, listSourceOrganNameStr.IndexOf(' ')));
            //        listSourceOrganNameStr = listSourceOrganNameStr.Remove(0, listSourceOrganNameStr.IndexOf(' '));
            //    }
            //}

            return listSourceOrgan;
        }

        static void test(int modelIndex, List<int> listsourceOrganOrdinal, float[] timeSourceOrgan) {
            // arrTimeSourceOrgan : là thời gian lưu trú của từng cơ quan
            // listsourceOrganOrdinal : là dãy model (phantom) mà mình cần xét
            // modelIndex : Số thứ từ của model (phantom) cần xét
            // listsourceOrganOrdinal : danh sach cac model (phantom) can tinh
            int indexLineSourceOrganName = 0;
            string fileLocation = @"C:\Users\COMPUTER\Documents\RCSProgram\Tc-99m";
            FileStream file = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            // Thoi gian luu tru cua co quan nguon
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
            
            string[] sourceOrgan = new string[28]
            {
                "Adrenals", "Brain", "Breasts", "GB Cont", "LLI Cont",
                "SI Cont" , "StomCont", "ULI Cont", "HeartCon", "Hrt Wall",
                "Kidneys", "Liver", "Lungs", "Muscle", "Ovaries", "Pancreas",
                "Red Mar.", "CortBoneS", "TrabBone", "CortBoneV", "TrabBoneV",
                "Spleen", "Thymus", "Thyroid", "UB Cont", "Uterus", "Fetus",
                "TotBody"
            };
            /*
            Không thể liệt kê rồi cố định các cơ quan (đối với phantom/model cũng tương tự), 
            bởi khi thêm vào một cơ quan mới (hay phantom/model) mới nào thì phần mềm sẽ không xử lý được
            */

            float[,] SsourceOrgan = new float[25, 28];

            // Ten cua cac co quan bia
            string[] targetOrgan = new string[25]
            {
                "Adrenals", "Brain", "Breasts", "Gallbladder Wall", "LLI Wall", "Small Intestine",
                "Stomach Wall", "ULI Wall", "Heart Wall", "Kidneys", "Liver", "Lungs",
                "Muscle", "Ovaries", "Pancreas", "Red Marrow", "Osteogenic Cells", "Skin",
                "Spleen", "Thymus", "Thyroid", "Urinary Bladder Wall", "Uterus", "Fetus", "Total Body",
            };
            float[] doseTargetOrgan = new float[25];




            // Nhap stt cac co quan co thoi gian luu tru

            int countSourceOrgan = listsourceOrganOrdinal.Count;

            // Dung de dem cac co quan nguon co thoi gian luu tru
            listsourceOrganOrdinal = new List<int>();
  
            /*
            while (sourceOrganOrdinal != -1)
            {
                countSourceOrgan++;
                listsourceOrganOrdinal.Add(sourceOrganOrdinal);
                sourceOrganOrdinal = int.Parse(Console.ReadLine());
            }
            */
            

            // Doc tung dong cua file
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
                            int index = 0;
                            string dose = "";
                            line = reader.ReadLine();
                            for (int t = 0; t < 25; t++)
                            {
                                Console.WriteLine(targetOrgan[t]);
                                for (int i = 0; i < 28; i++)
                                {
                                    if (timeSourceOrgan[i] != 0)
                                    {
                                        Console.WriteLine(sourceOrgan[i]);
                                        index = listSourceOrganName.IndexOf(sourceOrgan[i]);
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

                /*
                if (checkModelName == true && isOrganName(line) == true)
                {
                    listSourceOrganName = reader.ReadLine();
                }
                else if (countline > 2 && isModelName(line, modelIndex, modelName) == true)
                {
                    int index = 0;
                    string dose = "";

                    for (int i = 0; i < 28; i++)
                    {
                        if (listsourceOrganOrdinal.IndexOf(i) != -1)
                        {
                            Console.WriteLine(sourceOrgan[i]);
                            timeSourceOrgan[i] = float.Parse(Console.ReadLine());
                            if (timeSourceOrgan[i] != 0)
                            {
                                index = listSourceOrganName.IndexOf(sourceOrgan[i]);
                                dose = line.Substring(index);
                                dose = dose.Remove(dose.IndexOf(' '));
                                SsourceOrgan[i, countline - 3] = float.Parse(dose);
                            }
                            Console.WriteLine();
                        }
                    }
                }
                */
            }
            reader.Close();
            file.Close();
        }
    }
}
