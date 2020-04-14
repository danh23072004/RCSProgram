using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using Bunifu.Framework.UI;
using System.Linq.Expressions;

namespace RCSv1._0
{
    class KineticsInputPanel
    {
        #region Properties

        private Panel pnlKineticsInput = new Panel();
        private TextBox[] arrTxbKinetics = new TextBox[SettingManager.shared.targets.Count];
        private Keys[] arrAcceptKeys = new Keys[12];
        private Label[] arrTextBoxLabel = new Label[SettingManager.shared.targets.Count];

        #endregion

        #region Method

        /// <summary>
        /// Disable some unecessary textBox (because the data at the current textbox is null)
        /// </summary>
        public void DisableTextBox()
        {
            var supportTargets = SettingManager.shared.getTargetSupport(UserData.humanPhantom);
            for (int i = 0; i < arrTxbKinetics.Length; i++) {
                arrTxbKinetics[i].Enabled = supportTargets[i];
            }
        }

        public KineticsInputPanel(Panel PnlKineticsInput)
        {
            pnlKineticsInput = PnlKineticsInput;

            // Draw main label
            Label lbTimeExist = new Label()
            {
                Text = "Thời gian lưu trú của các cơ quan",
                Location = new Point(26, 30),
                Font = new Font("Segoe UI", 16, FontStyle.Regular),
                Size = new Size(400, 30),
            };
            pnlKineticsInput.Controls.Add(lbTimeExist);

            string[] arrTxbName = SettingManager.shared.targetVnNames;

            // Draw textbox at first column
            int locationX = 10;
            int locationY = 90;
            for (int i = 0; i < 14; i++)
            {
                arrTxbKinetics[i] = makeTextbox(locationX, locationY);
                arrTxbKinetics[i].KeyPress += KineticsInputPanel_KeyPress;
                pnlKineticsInput.Controls.Add(arrTxbKinetics[i]);
                locationY += 28;
            }

            // Darw textbox at second column
            locationX = 356;
            locationY = 90;
            for (int i = 14; i < arrTxbKinetics.Length; i++)
            {
                arrTxbKinetics[i] = makeTextbox(locationX, locationY);
                arrTxbKinetics[i].KeyPress += KineticsInputPanel_KeyPress;
                pnlKineticsInput.Controls.Add(arrTxbKinetics[i]);
                locationY += 28;
            }

            // Draw label for each textbox at first column
            locationX = 100;
            locationY = 90;
            for (int i = 0; i < 14; i++)
            {
                arrTextBoxLabel[i] = makeLabel(locationX, locationY, arrTxbName[i]);
                pnlKineticsInput.Controls.Add(arrTextBoxLabel[i]);
                locationY += 28;
            }

            // Draw label for each textbox at second column
            locationX = 450;
            locationY = 90;
            for (int i = 14; i < arrTxbKinetics.Length; i++)
            {
                arrTextBoxLabel[i] = makeLabel(locationX, locationY, arrTxbName[i]);
                pnlKineticsInput.Controls.Add(arrTextBoxLabel[i]);
                locationY += 28;
            }

            // Set value for arrAcceptKey
            for (int i = 48; i <= 57; i++)
            {
                arrAcceptKeys[i - 48] = (Keys)i;
            }
            arrAcceptKeys[11] = Keys.Back;
        }

        private TextBox makeTextbox(int x, int y) {
            return new TextBox()
            {
                Location = new Point(x, y),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Size = new Size(90, 30),
                Text = "0.00000",
            };
        }

        private Label makeLabel(int x, int y, string text) {
            return new Label()
            {
                Location = new Point(x, y),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                Size = new Size(150, 30),
                Text = text,
            };
        }

        // This event is used for checking the character of key press action
        private void KineticsInputPanel_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool check = false;
            foreach (var item in arrAcceptKeys)
            {
                if (e.KeyChar == (char)item )
                {
                    check = true;
                    break;
                }
            }
            if (check == false)
            {
                e.Handled = true;
            }
        }

        public bool CheckFullKineticsData()
        {
            bool check = false;
            for (int i = 0; i < arrTxbKinetics.Length; i++)
            {
                double number;
                if (Double.TryParse(arrTxbKinetics[i].Text, out number) && number != 0) {
                    check = true;
                    break;
                }
            }
            return check;
        }

        public List<float> GetKineticsData()
        {
            List<float> kineticsData = new List<float>();
            for (int i = 0; i < arrTxbKinetics.Length; i++)
            {
                var value = arrTxbKinetics[i].Enabled ? float.Parse(arrTxbKinetics[i].Text) : 0;
                kineticsData.Add(value);
            }
            return kineticsData;
        }

        #endregion

    }

}
