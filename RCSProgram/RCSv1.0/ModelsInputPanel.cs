using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using Bunifu.Framework.UI;

namespace RCSv1._0
{
    class ModelsInputPanel
    {
        #region Properties

        #region Controls

        private BunifuCheckbox[] ckbHumanAge = new BunifuCheckbox[15];
        private Panel pnlModelsInput = new Panel();
        private Label lbChoose;

        #endregion

        #region Local Variables

        private string[] arrHumanAgeCheckboxName = new string[15]
        {
            "Đàn ông trưởng thành",
            "Phụ nữ trưởng thành",
            "Trẻ em nam (15 tuổi)",
            "Trẻ em nam(10 tuổi)",
            "Trẻ em nam (5 tuổi)",
            "Trẻ em nam (1 tuổi)",
            "Trẻ em nam sơ sinh",
            "Trẻ em nữ (15 tuổi)",
            "Trẻ em nữ (10 tuổi)",
            "Trẻ em nữ (5 tuổi)",
            "Trẻ em nữ (1 tuổi)",
            "Trẻ em nữ sơ sinh",
            "Phụ nữ mang thai (3 tháng)",
            "Phụ nữ mang thai (6 tháng)",
            "Phụ nữ mang thai (9 tháng)",
        };
        Label[] arrHumanAgeCheckboxLabel = new Label[15];

        #endregion

        #endregion

        #region Method

        public ModelsInputPanel(Panel PnlModelsInput)
        {

            pnlModelsInput = PnlModelsInput;

            lbChoose = new Label()
            {
                Text = "Chọn mô hình người",
                Location = new Point(26, 30),
                Font = new Font("Segoe UI", 17, FontStyle.Bold),
                Size = new Size(250, 50),
            };
            pnlModelsInput.Controls.Add(lbChoose);

            int locationY = 80;
            int locationX = 20;
            // Position of ckbHumanAge and arrHumanAgeCheckboxLabel
            for (int i = 0; i < 15; i++)
            {
                ckbHumanAge[i] = new BunifuCheckbox()
                {
                    BackColor = Color.Blue,
                    CheckedOnColor = Color.Blue,
                    Location = new Point(locationX, locationY),
                    Size = new Size(20, 20),
                    Checked = false,
                };
                arrHumanAgeCheckboxLabel[i] = new Label()
                {
                    Text = arrHumanAgeCheckboxName[i],
                    Location = new Point(locationX + 40, locationY),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Size = new Size(360, 30),
                };
                pnlModelsInput.Controls.Add(ckbHumanAge[i]);
                pnlModelsInput.Controls.Add(arrHumanAgeCheckboxLabel[i]);
                locationY += 30;
            }
        }

        public bool[] ReturnHumanAgeOption()
        {
            bool[] value = new bool[15];
            for (int i = 0; i < 15; i++)
            {
                if (ckbHumanAge[i].Checked == true)
                {
                    value[i] = true;
                }
                else
                {
                    value[i] = false;
                }
            }
            return value;
        }

        public bool CheckFullData()
        {
            bool check = false;
            foreach (var ckb in ckbHumanAge)
            {
                if (ckb.Checked == true)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        #endregion
    }
}
