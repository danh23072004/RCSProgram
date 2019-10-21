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
        // There are total 97 elements
        public static List<string> listNuclide = new List<string>()
        {
            "Ac","Ag","Al","Am","Ar","As","At","Au","Ba","Be","Bi","Bk","Br","C","Ca",
            "Cd","Ce","Cf","Cl","Cm","Co","Cr","Cs","Cu","Dy","Er","Es","Eu","F","Fe",
            "Fm","Fr","Ga","Gd","Ge","H","Hf","Hg","Ho","I","In","Ir","K","Kr","La","Lu",
            "Mg","Mn","Mo","N","Na","Nb","Nd","Ne","Ni","Np","O","Os","P","Pa","Pb","Pd",
            "Pm","Po","Pr","Pt","Pu","Ra","Rb","Re","Rh","Rn","Ru","S","Sb","Sc","Se","Si",
            "Sm","Sn","Sr","Ta","Tb","Tc","Te","Th","Ti","Tl","Tm","U","V","W","Xe","Y","Yb",
            "Zn","Zr"
        };
        public static string[][] listNuclideIsotopes =
        {
            new string [] { "Ac-223", "Ac-224", "Ac-225", "Ac-226", "Ac-228"},
            new string [] { "Ag-102", "Ag-103", "Ag-104m", "Ag-104", "Ag-105,", "Ag-106",
            "Ag-106m", "Ag-108m", "Ag-108", "Ag-109m", "Ag-110m", "Ag-110", "Ag-112", "Ag-115"},
            new string [] { "Al-26", "Al-28"},
            new string [] { "Am-237", "Am-238", "Am-239", "Am-240", "Am-241", "Am-242m1", "Am-242",
            "Am-243", "Am-244m", "Am-245", "Am-246m", "Am-246"},
            new string [] { "Ar-37", "Ar-39", "Ar-41"},
            new string [] { "As-69", "As-70", "As-71", "As-72", "As-73", "As-74", "As-76", "As-77",
            "As-78"},
            new string [] { "At-207", "At-211", "At-215", "At-216", "At-217", "At-218"},
            new string [] { "Au-193", "Au-194", "Au-195", "Au-195m", "Au-198m", "Au-198", "Au-199",
            "Au-200", "Au-201"},
            new string [] { "Ba-128", "Ba-131m", "Ba-133m", "Ba-133", "Ba-135m", "Ba-137m",
            "Ba-139", "Ba-140", "Ba-141", "Ba-142"},
            new string [] { "Be-10"},
            new string [] { "Bi-200", "Bi-201", "Bi-202", "Bi-203", "Bi-204", "Bi-205", "Bi-206",
            "Bi-207", "Bi-210m", "Bi-211", "Bi-212", "Bi-213", "Bi-214"},
            new string [] { "Bk-245", "Bk-246", "Bk-247", "Bk-249", "Bk-250" },
            new string [] { "Br-74", "Br-74m", "Br-75", "Br-76", "Br-77", "Br-80m", "Br-80",
            "Br-82", "Br-83", "Br-84"},
            new string [] { "C-11", "C-14" },
            new string [] { "Ca-41", "Ca-45", "Ca-47", "Ca-49" },
            new string [] { "Cd-104", "Cd-107", "Cd-109", "Cd-113", "Cd-113m", "Cd-115", "Cd-115m",
            "Cd-117m", "Cd-117" },
            new string [] { "Ce-134", "Ce-135m", "Ce-135", "Ce-137", "Ce-137m", "Ce-139", "Ce-141",
            "Ce-143", "Ce-144"},
            new string [] { "Cf-246", "Cf-248", "Cf-250", "Cf-253" },
            new string [] { "Cl-34", "Cl-34m", "Cl-36", "cl-38", "cl-39" },
            new string [] { "Cm-240", "Cm-241", "Cm-244", "Cm-245", "Cm-246", "Cm-247", "Cm-249",
            "Cm-251" },
            new string [] { "Co-55", "Co-56", "Co-57", "Co-58m", "Co-58", "Co-60", "Co-60m", "Co-61",
            "Co-62m"},
            new string [] { "Cr-48", "Cr-49", "Cr-51" },
            new string [] { "Cs-125", "Cs-126", "Cs-127", "Cs-128", "Cs-129", "Cs-130", "Cs-131",
            "Cs-132", "Cs-134m", "Cs-134", "Cs-135m", "Cs-135", "Cs-136", "Cs-137", "Cs-138"},
            new string [] { "Cu-57", "Cu-60", "Cu-61", "Cu-62", "Cu-64", "Cu-66", "Cu-67" },
            new string [] { "Dy-155", "Dy-157", "Dy-159m", "Dy-165", "Dy-166" },
            new string [] { "Er-161", "Er-165", "Er-167m", "Er-171", "Er-172" },
            new string [] { "Es-250", "Es-251", "Es-253", "Es-254m", "Es-254" } ,
            new string [] { "Eu-145", "Eu-146", "Eu-147", "Eu-148", "Eu-149", "Eu-150", "Eu-150m",
            "Eu-152m1", "Eu-152", "Eu-154", "Eu-155", "Eu-156", "Eu-157", "Eu-158"},
            new string [] { "F-17", "F-18" },
            new string [] { "Fe-52", "Fe-55", "Fe-59", "Fe-60" },
            new string [] { "Fm-252", "Fm-253", "Fm-254", "Fm-255" },
            new string [] { "Fr-219", "Fr-220", "Fr-221", "Fr-222", "Fr-223" },
            new string [] { "Ga-65", "Ga-66", "Ga-67", "Ga-68", "Ga-70", "Ga-72", "Ga-73" },
            new string [] { "Gd-145", "Gd-146", "Gd-147", "Gd-148", "Gd-149", "Gd-151", "Gd-152",
            "Gd-153", "Gd-149"},
            new string [] { "Ge-66", "Ge-67", "Ge-68", "Ge-69", "Ge-71", "Ge-77", "Ge-78" },
            new string [] { "H-3"},
            new string [] { "Hf-170", "Hf-172", "Hf-173", "Hf-175", "Hf-177m2", "Hf-178m2", "Hf-179m2",
            "Hf-180m", "Hf-181", "Hf-182", "Hf-182m", "Hf-183", "Hf-184"},
            new string [] { "Hg-193", "Hg-193m", "Hg-194", "Hg-195m", "Hg-195", "Hg-197", "Hg-197m",
            "Hg-199m", "Hg-203", "Hg-206"},
            new string [] { "Ho-155", "Ho-157", "Ho-159", "Ho-161", "Ho-162m", "Ho-164", "Ho-164m",
            "Ho-166m", "Ho-166", "Ho-167"},
            new string [] {""}

        };

    }
}
