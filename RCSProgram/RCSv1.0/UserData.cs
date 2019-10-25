﻿using System;
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

        public static bool[] HumanAge = new bool[10]
        {
            false, false, false, false, false, false, false, false, false, false
        };
        // There are total 97 elements

        
        public static int nuclideIndex;
        public static int isotopeIndex;


        public static bool[] fullData = new bool[]
        {
            false, false, false,
            // 1: RadioIsotopes 2: Models 3: Kinetics
        };

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
