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
            new string [] { "I-121", "I-122", "I-123", "I-124", "I-125", "I-126", "I-128", "I-129",
            "I-130", "I-131", "I-132m", "I-132", "I-133", "I-134", "I-135"},
            new string [] { "In-109", "In-110", "In-110m", "In-111", "In-111m", "In-112", "In-113m",
            "In-114m1", "In-114m2", "In-114", "In-115", "In-116m1", "In-117", "In-117m", "In-119m",
            "In-119"},
            new string [] { "Ir-184", "Ir-185", "Ir-186", "Ir-187", "Ir-188", "Ir-189", "Ir-190",
            "Ir-190m2", "Ir-191m1", "Ir-192", "Ir-192m2", "Ir-192m1", "Ir-194m2", "Ir-194", "Ir-195"},
            new string [] { "K-38", "K-40", "K-42", "K-43", "K-44", "K-45" },
            new string [] { "Kr-74", "Kr-76", "Kr-77", "Kr-79", "Kr-81m", "Kr-81", "Kr-83m", "Kr-85m",
            "Kr-85", "Kr-87", "Kr-88"},
            new string [] { "La-131", "La-132", "La-134", "La-135", "La-137", "La-138", "La-140",
            "La-141", "La-142", "La-143"},
            new string [] { "Lu-169", "Lu-170", "Lu-171", "Lu-172", "Lu-173", "Lu-174", "Lu-174m",
            "Lu-176", "Lu-176m", "Lu-177m", "Lu-177", "Lu-178m", "Lu-178", "Lu-179"},
            new string [] { "Mg-28"},
            new string [] { "Mn-51", "Mn-52m", "Mn-52", "Mn-53", "Mn-54", "Mn-56" },
            new string [] { "Mo-90", "Mo-93", "Mo-93m", "Mo-99", "Mo-101" },
            new string [] { "N-13"},
            new string [] { "Na-22", "Na-24" },
            new string [] { "Nb-88", "Nb-89m", "Nb-89", "Nb-90", "Nb-93m", "Nb-94", "Nb-95", "Nb-95m",
            "Nb-96", "Nb-97", "Nb-98m" },
            new string [] { "Nd-136", "Nd-138", "Nd-139", "Nd-140", "Nd-141m", "Nd-141", "Nd-147",
            "Nd-149", "Nd-151"},
            new string [] { "Ne-19"},
            new string [] { "Ni-56", "Ni-57", "Ni-59", "Ni-63", "Ni-65", "Ni-66" },
            new string [] { "Np-232", "Np-233", "Np-234", "Np-235", "Np-236", "Np-236m", "Np-237",
            "Np-238", "Np-239", "Np-240"},
            new string [] { "O-14", "O-15", "O-19" },
            new string [] { "Os-180", "Os-181", "Os-182", "Os-185", "Os-189m", "Os-190m", "Os-191",
            "Os-193", "Os-194"},
            new string [] { "P-30", "P-32", "P-33" },
            new string [] { "Pa-228", "Pa-230", "Pa-231", "Pa-232", "Pa-233", "Pa-234", "Pa-234m" },
            new string [] { "Pb-195m", "Pb-198", "Pb-199", "Pb-200", "Pb-201", "Pb-202m", "Pb-203",
            "Pb-204m", "Pb-209", "Pb-210", "Pb-212", "Pb-214"},
            new string [] { "Pd-100", "Pd-101", "Pd-103", "Pd-107", "Pd-109"},
            new string [] { "Pm-141", "Pm-142", "Pm-143", "Pm-144", "Pm-145", "Pm-146", "Pm-147",
            "Pm-148m", "Pm-148", "Pm-149", "Pm-150", "Pm-151"},
            new string [] { "Po-203", "Po-205", "Po-207", "Po-209", "Po-210", "Po-211", "Po-212",
            "Po-213", "Po-214", "Po-215", "Po-216", "Po-218"}
        };

    }
}
