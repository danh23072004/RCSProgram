﻿using System;
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

        private BunifuCheckbox[] ckbHumanAge = new BunifuCheckbox[10];
        private Panel pnlModelsInput = new Panel();
        private Label lbChoose;

        #endregion

        #region Local Variables

        private string[] arrHumanAgeCheckboxName = new string[10]
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
        Label[] arrHumanAgeCheckboxLabel = new Label[10];

        #endregion

        #endregion

        #region Method

        public ModelsInputPanel(Panel PnlModelsInput)
        {
            pnlModelsInput = PnlModelsInput;
            var pfc = new PrivateFontCollection();
            string fontLocation = Application.StartupPath.Remove(Application.StartupPath.Length - 10, 10) + "\\Resources\\OpenSans-Light.ttf";
            pfc.AddFontFile(fontLocation);
            // This uses for adding new fonts

            lbChoose = new Label()
            {
                Text = "Chọn mô hình người",
                Location = new Point(26, 30),
                Font = new Font(pfc.Families[0], 17, FontStyle.Bold),
                Size = new Size(250, 50),
            };
            pnlModelsInput.Controls.Add(lbChoose);

            int locationY = 80;
            int locationX = 20;
            // Position of ckbHumanAge and arrHumanAgeCheckboxLabel
            for (int i = 0; i < 10; i++)
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
                    Font = new Font(pfc.Families[0], 10, FontStyle.Regular),
                    Size = new Size(360, 30),
                };
                pnlModelsInput.Controls.Add(ckbHumanAge[i]);
                pnlModelsInput.Controls.Add(arrHumanAgeCheckboxLabel[i]);
                locationY += 30;
            }
        }

        public bool[] ReturnHumanAgeOption()
        {
            bool[] value = new bool[10];
            for (int i = 0; i < 10; i++)
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
            int count = 0;
            foreach (var ckb in ckbHumanAge)
            {
                if (ckb.Checked)
                {
                    count++;
                }
            }
            if (count == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
