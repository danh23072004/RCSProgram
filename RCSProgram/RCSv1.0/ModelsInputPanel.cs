using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Bunifu.Framework.UI;

namespace RCSv1._0
{
    class ModelsInputPanel
    {
        #region Properties

        #region Controls

        private BunifuCheckbox[] ckbHumanAge = new BunifuCheckbox[10];
        private Panel pnlModelsInput = new Panel();
        private Label lbChoose;

        #endregion

        #region Local Variables

        string[] arrHumanAgeCheckboxName = new string[10]
        {
            "Đàn ông trưởng thành",
            "Phụ nữ trưởng thành",
            "Trẻ em (15 tuổi)",
            "Trẻ em (10 tuổi)",
            "Trẻ em (5 tuổi)",
            "Trẻ em (1 tuổi)",
            "Trẻ em sơ sinh",
            "Phụ nữ mang thai (3 tháng)",
            "Phụ nữ mang thai (6 tháng)",
            "Phụ nữ mang thai (9 tháng)",
        };

        #endregion

        #endregion

        #region Method

        public ModelsInputPanel(Panel PnlModelsInput)
        {
            pnlModelsInput = PnlModelsInput;
        }

        public void DrawModelsInputPanel()
        {
            lbChoose = new Label()
            {
                Text = "This is a test label",
                Location = new Point(97, 138),
            };
            pnlModelsInput.Controls.Add(lbChoose);

            for (int i = 0; i < 10; i++)
            {
                ckbHumanAge[i] = new BunifuCheckbox()
                {
                    BackColor = Color.Blue,
                    CheckedOnColor = Color.Blue,
                    Location = new Point(25, 21),
                };

            }

        }

        #endregion
    }
}
