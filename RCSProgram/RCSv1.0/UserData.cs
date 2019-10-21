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
        public static bool[] HumanAge = new bool[10]
        {
            false, false, false, false, false, false, false, false, false, false
        };
        public static List<string> listNuclide = new List<string>
        {
            "Ac","Ag","Al","Am","Ar","As","At","Au","Ba","Be","Bi","Bk","Br","C","Ca",
            "Cd","Ce","Cf","Cl","Cm","Co","Cr","Cs","Cu","Dy","Er","Es","Eu","F","Fe",
            "Fm","Fr","Ga","Gd","Ge","H","Hf","Hg","Ho","I","In","Ir","K","Kr","La","Lu",
            "Mg","Mn","Mo","N","Na","Nb","Nd","Ne","Ni","Np","O","Os","P","Pa","Pb","Pd",
            "Pm","Po","Pr","Pt","Pu","Ra","Rb","Re","Rh","Rn","Ru","S","Sb","Sc","Se","Si",
            "Sm","Sn","Sr","Ta","Tb","Tc","Te","Th","Ti","Tl","Tm","U","V","W","Xe","Y","Yb",
            "Zn","Zr"
        };
        public static AutoCompleteStringCollection listNuclideAutoComplete = new AutoCompleteStringCollection()
        {
            "Ac","Ag","Al","Am","Ar","As","At","Au","Ba","Be","Bi","Bk","Br","C","Ca",
            "Cd","Ce","Cf","Cl","Cm","Co","Cr","Cs","Cu","Dy","Er","Es","Eu","F","Fe",
            "Fm","Fr","Ga","Gd","Ge","H","Hf","Hg","Ho","I","In","Ir","K","Kr","La","Lu",
            "Mg","Mn","Mo","N","Na","Nb","Nd","Ne","Ni","Np","O","Os","P","Pa","Pb","Pd",
            "Pm","Po","Pr","Pt","Pu","Ra","Rb","Re","Rh","Rn","Ru","S","Sb","Sc","Se","Si",
            "Sm","Sn","Sr","Ta","Tb","Tc","Te","Th","Ti","Tl","Tm","U","V","W","Xe","Y","Yb",
            "Zn","Zr"
        };
    }
}
