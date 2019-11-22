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
        private TextBox[] arrTxbKinetics = new TextBox[28];
        private Keys[] arrAcceptKeys = new Keys[12];
        private Label[] arrTextBoxLabel = new Label[28];

        #endregion

        #region Method

        /// <summary>
        /// Disable some unecessary textBox (because the data at the current textbox is null)
        /// </summary>
        public void DisableTextBox()
        {
            bool isMalePhantom = false;
            bool isFemalePhantom = false;
            arrTxbKinetics[26].Enabled = false;
            for (int i = 0; i < UserData.humanPhantom.Count; i++)
            {
                if (Array.Exists(Constant.malePhantom, element => element == UserData.humanPhantom[i]) == true)
                {
                    isMalePhantom = true;
                }
                if (Array.Exists(Constant.femalePhantom, element => element == UserData.humanPhantom[i]) == true)
                {
                    isFemalePhantom = true;
                }
                if (Array.Exists(Constant.placentaFemalePhantom, element => element == UserData.humanPhantom[i]) == true)
                {
                    arrTxbKinetics[26].Enabled = true;
                }
            }
            if (isMalePhantom == true && isFemalePhantom == true)
            {
                arrTxbKinetics[14].Enabled = true;
                arrTxbKinetics[20].Enabled = true;
            }
            else if (isMalePhantom == true)
            {
                arrTxbKinetics[14].Enabled = false;
                arrTxbKinetics[20].Enabled = true;
                arrTxbKinetics[26].Enabled = false;
            }
            else if (isFemalePhantom == true)
            {
                arrTxbKinetics[20].Enabled = false;
                arrTxbKinetics[14].Enabled = true;
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

            string[] arrTxbName = new string[28]
            {
                "Tuyến thượng thận", "Não", "Ngực", "Túi mật", "Ruột già (dưới)", "Ruột non",
                "Dạ dày", "Ruột già (trên)", "Tim (bên trong)", "Tim (bên ngoài)", "Thận", "Gan", "Phổi", "Cơ", "Buồng trứng",
                "Tuyến tụy", "Tủy đỏ", "Xương đặc", "Xương xốp", "Lá lách", "Tinh hoàn", "Tuyến ức", "Tuyến giáp",
                "Bàng quang", "Tử cung", "Thai nhi", "Nhau thai", "Tổng cân nặng cơ thể/Còn lại",
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

        public bool CheckFullKineticsData()
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

        public List<float> GetKineticsData()
        {
            List<float> kineticsData = new List<float>();
            for (int i = 0; i < arrTxbKinetics.Length; i++)
            {
                if (arrTxbKinetics[i].Enabled == true)
                {
                    kineticsData.Add(float.Parse(arrTxbKinetics[i].Text));
                    if (arrTextBoxLabel[i].Text == "Xương đặc" || arrTextBoxLabel[i].Text == "Xương xốp")
                    {
                        kineticsData.Add(float.Parse(arrTxbKinetics[i].Text));
                    }

                }
            }
            return kineticsData;
        }

        #endregion

    }
}
