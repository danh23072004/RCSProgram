using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.IO;
namespace RCSv1._0
{
    public class SettingManager
    {
        public List<Target> targets = new List<Target>();
        public List<Source> sources = new List<Source>();
        public List<string> models = new List<string>();

        public string[] targetVnNames {
            get {
                List<string> arr = new List<string>();
                foreach (var item in targets) {
                    arr.Add(item.vnName);
                }
                
                return arr.ToArray();
            }
        }

        public string[] targetEnNames
        {
            get
            {
                List<string> arr = new List<string>();
                foreach (var item in targets)
                {
                    arr.Add(item.enName);
                }

                return arr.ToArray();
            }
        }

        public List<bool> getTargetSupport(string vnName) {
            List<bool> output = new List<bool>();
            foreach (var item in targets) {
                output.Add(!item.modelNotSupports.Contains(vnName));
            }
            return output;
        }

        public static SettingManager shared = new SettingManager();


        public SettingManager()
        {

            FileStream file = new FileStream(Application.StartupPath + @"/cauhinhBia", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);
            string line = "";
            int lineIndex = -1;

            while (reader.EndOfStream == false)
            {
                lineIndex++;
                line = reader.ReadLine();
                if (lineIndex == 0)
                {
                    models = parseModels(line);
                }
                else
                {
                    targets.Add(parseTarget(line, models));
                }
            }
            reader.Close();
            file.Close();


            file = new FileStream(Application.StartupPath + @"/cauhinhNguon", FileMode.Open, FileAccess.Read);
            reader = new StreamReader(file);
            line = "";
            lineIndex = -1;
            while (reader.EndOfStream == false)
            {
                lineIndex++;
                line = reader.ReadLine();
                if (lineIndex > 0) {
                    sources.Add(parseSource(line));
                }
            }
            reader.Close();
            file.Close();
        }

        static Source parseSource(string line)
        {
            Source output = new Source();
            string[] parts = line.Split(new char[] { '\t' });
            output.vnName = parts[0];
            output.enName = parts[1];
            return output;
        }

        static Target parseTarget(string line, List<string> models)
        {
            Target output = new Target();
            string[] parts = line.Split(new char[] { '\t' });
            output.vnName = parts[0];
            output.enName = parts[1];
            for (int pi = 2; pi < parts.Length; pi++)
            {
                if (parts[pi] == "x")
                {
                    output.modelNotSupports.Add(models[pi - 2]);
                }
            }
            return output;
        }

        static List<string> parseModels(string line1)
        {
            string[] parts = line1.Split(new char[] { '\t' });
            List<string> output = new List<string>();
            for (int i = 2; i < parts.Length; i++)
            {
                output.Add(parts[i]);
            }
            return output;
        }
        /// <summary>
        /// BIA
        /// </summary>
        public class Target
        {
            public string enName = "";
            public string vnName = "";
            public List<string> modelNotSupports = new List<string>();
        }

        /// <summary>
        /// NGUON
        /// </summary>
        public class Source
        {
            public string enName = "";
            public string vnName = "";
        }
    }
}
