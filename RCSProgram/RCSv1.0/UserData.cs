using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCSv1._0
{
    public static class UserData
    {
        #region Properties

        // Store the list of checked phantoms in ModelsInputPanel
        public static List<int> humanPhantom = new List<int>();

        public static List<float> doseResult = new List<float>();

        public static List<string> targetOrganName = new List<string>();

        // There are total 97 elements
        public static int nuclideIndex;
        public static int isotopeIndex;


        public static bool[] fullData = new bool[]
        {
            false, false, false,
            // 1: RadioIsotopes 2: Models 3: Kinetics
        };

        public static List<float> kineticsData = new List<float>();

        #endregion

        #region Method

        public static void SetDefaultUserData()
        {
            nuclideIndex = 0;
            isotopeIndex = 0;
        }

        #endregion
    }
}
