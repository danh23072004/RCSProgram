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
    class KineticsInputPanel
    {
        #region Properties

        private Panel pnlKineticsInput = new Panel();
        private TextBox[] arrTxbKinetics = new TextBox[30];
        private Keys[] arrAcceptKeys = new Keys[12];

        #endregion

        #region Method

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

            string[] arrTxbName = new string[28]
            {
                "Tuyến thượng thận", "Não", "Ngực", "Túi mật", "Ruột già (dưới)", "Ruột non",
                "Dạ dày", "Ruột già (trên)", "Tim (bên trong)", "Tim (bên ngoài)", "Thận", "Gan", "Phổi", "Cơ", "Buồng trứng",
                "Tuyến tụy", "Tủy đỏ", "Buồng trứng", "Tuyến tụy", "Tủy đỏ", "Xương đặc", "Xương xốp", "Lá lách",
                "Tuyến ức", "Tuyến giáp", "Bàng quang", "Tử cung", "Tổng cân nặng cơ thể/Còn lại",
            };

            // Draw textbox at first column
            int locationX = 10;
            int locationY = 90;
            for (int i = 0; i < 14; i++)
            {
                arrTxbKinetics[i] = new TextBox()
                {
                    Location = new Point(locationX, locationY),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Size = new Size(150, 30),
                    Text = "0.00000",
                };
                arrTxbKinetics[i].KeyPress += KineticsInputPanel_KeyPress;
                pnlKineticsInput.Controls.Add(arrTxbKinetics[i]);
                locationY += 28;
            }

            // Darw textbox at second column
            locationX = 356;
            locationY = 90;
            for (int i = 14; i < 28; i++)
            {
                arrTxbKinetics[i] = new TextBox()
                {
                    Location = new Point(locationX, locationY),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Size = new Size(150, 30),
                    Text = "0.00000",
                };
                arrTxbKinetics[i].KeyPress += KineticsInputPanel_KeyPress;
                pnlKineticsInput.Controls.Add(arrTxbKinetics[i]);
                locationY += 28;
            }

            // Draw label for each textbox at first column
            Label[] arrTextBoxLabel = new Label[28];
            locationX = 200;
            locationY = 90;
            for (int i = 0; i < 14; i++)
            {
                arrTextBoxLabel[i] = new Label()
                {
                    Location = new Point(locationX, locationY),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Size = new Size(150, 30),
                    Text = arrTxbName[i],
                };
                pnlKineticsInput.Controls.Add(arrTextBoxLabel[i]);
                locationY += 28;
            }

            // Draw label for each textbox at second column
            locationX = 520;
            locationY = 90;
            for (int i = 14; i < 28; i++)
            {
                arrTextBoxLabel[i] = new Label()
                {
                    Location = new Point(locationX, locationY),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Size = new Size(195, 30),
                    Text = arrTxbName[i],
                };
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

        public bool CheckFullData()
        {
            bool check = false;
            for (int i = 0; i < 28; i++)
            {
                if (arrTxbKinetics[i].Text != "0.00000")
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
