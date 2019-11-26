using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RCSv1._0
{
    class DoseFileReader
    {
        public DoseTable findDoseTable(string filePath, string model)
        {
            DoseTable output = null;
            FileStream file = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line = "";
            while (reader.EndOfStream == false)
            {
                line = reader.ReadLine();

                if (isModelLine(line))
                {
                    output = new DoseTable();
                    readTable(reader, output);
                    break;
                }
            }
            reader.Close();
            file.Close();
            return output;
        }

        private void readTable(StreamReader reader, DoseTable output)
        {
            string line = "";
            string[] columnNames = new string[0];
            while (reader.EndOfStream == false)
            {
                line = reader.ReadLine();
                if (isFragmentLine(line))
                {
                    break;
                }

                if (isListColumnOrganLine(line))
                {
                    columnNames = Parts(line);
                    continue;
                }

                if (isDoseLine(line))
                {
                    string[] rParts = Parts(line);
                    string rName = rParts[0];
                    for (int ci = 0; ci < columnNames.Length; ci++)
                    {
                        string cName = columnNames[ci];
                        string key = cName + "+" + rName;
                        double value = Double.Parse(rParts[ci + 1]);
                        output.DoseDict.Add(key, value);
                    }
                }
            }
        }

        private bool isNuclideLine(string line)
        {
            return line.Trim().StartsWith("Nuclide:");
        }

        private string NuclideName(string line)
        {
            return line.Trim().Replace("Nuclide:", "").Trim();
        }

        private bool isModelLine(string line)
        {
            return line.Trim().StartsWith("Dose Conversion Factors");
        }

        private string ModelName(string line)
        {
            return line.Trim().Replace("Model:", "").Trim();
        }

        private bool isBlankLine(string line)
        {
            return line.Trim().Length == 0;
        }

        private bool isListColumnOrganLine(string line)
        {
            return line.StartsWith("               ");
        }

        private List<string> ListColumnOrganNames(string line)
        {
            line = line.Replace("  ", "@");
            while (line.Contains("@@"))
            {
                line = line.Replace("@@", "@");
            }
            line = line.Trim(new char[] { '@' });
            string[] parts = line.Split(new char[] { '@' });
            return new List<string>(parts);
        }

        private bool isFragmentLine(string line)
        {
            return line.StartsWith("----------------");
        }

        private bool isDoseLine(string line)
        {
            return !isBlankLine(line) && !isFragmentLine(line) && !isNuclideLine(line) && !isModelLine(line) && !isListColumnOrganLine(line);
        }

        private string[] Parts(string line)
        {
            line = line.Replace("  ", "@");
            while (line.Contains("@@"))
            {
                line = line.Replace("@@", "@");
            }
            line = line.Trim(new char[] { '@' });
            return line.Split(new char[] { '@' });
        }

    }

    class DoseTable
    {

        /// <summary>
        /// Lưu giá trị liều theo dictionary:
        /// Key: ColunmOrganName+RowOrganName 
        /// Value: Liều
        /// </summary>
        public Dictionary<string, double> DoseDict = new Dictionary<string, double>();

        public List<float> calculate(List<float> timeSourceOrgan) {
            var output = new List<float>();
            for (int bi = 0; bi < timeSourceOrgan.Count; bi++) {
                var targetEnName = SettingManager.shared.targetEnNames[bi];
                output.Add((float)sum(timeSourceOrgan[bi], findDoseOf(targetEnName)));
            }
            return output;
        }

        private double sum(float time, Dictionary<string, double> doses) {
            double output = 0;
            foreach (var value in doses.Values) {
                output += value * time * 3600;
            }
            return output;
        }

        private Dictionary<string, double> findDoseOf(string target) {
            Dictionary<string, double> output = new Dictionary<string, double>();
            foreach (var key in DoseDict.Keys) {
                var trimKey = key.Trim();
                if (trimKey.StartsWith(target + "+")) {
                    output.Add(trimKey, DoseDict[key]);
                }
            }
            return output;
        }
    }
}
