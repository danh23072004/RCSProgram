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

        private Panel pnlKineticsInputPanel = new Panel();
        private TextBox[] arrTxbKinetics = new TextBox[30];

        #endregion

        #region Method

        public KineticsInputPanel(Panel PnlKineticsInputPanel)
        {
            pnlKineticsInputPanel = PnlKineticsInputPanel;
            var pfc = new PrivateFontCollection();
            string fontLocation = Application.StartupPath.Remove(Application.StartupPath.Length - 10, 10) + "\\Resources\\OpenSans-Light.ttf";
            pfc.AddFontFile(fontLocation);
            // This uses for adding new fonts

            Label lbTimeExist = new Label()
            {
                Text = "Thời gian lưu trú của các cơ quan",
                Location = new Point(26, 30),
                Font = new Font(pfc.Families[0], 16, FontStyle.Regular),
                Size = new Size(400, 30),
            };
            pnlKineticsInputPanel.Controls.Add(lbTimeExist);

            string[] arrTxbName = new string[28]
            {
                "Tuyến thượng thận", "Não", "Ngực", "Túi mật", "Ruột già (dưới)", "Ruột non",
                "Dạ dày", "Ruột già (trên)", "Tim (bên trong)", "Tim (bên ngoài)", "Thận", "Gan", "Phổi", "Cơ", "Buồng trứng",
                "Tuyến tụy", "Tủy đỏ", "Buồng trứng", "Tuyến tụy", "Tủy đỏ", "Xương đặc", "Xương xốp", "Lá lách",
                "Tuyến ức", "Tuyến giáp", "Bàng quang", "Tử cung", "Tổng cân nặng cơ thể/Còn lại",
            };

            // Draw first column
            int locationX = 10;
            int locationY = 90;
            for (int i = 0; i < 14; i++)
            {
                arrTxbKinetics[i] = new TextBox()
                {
                    Location = new Point(locationX, locationY),
                    Font = new Font(pfc.Families[0], 10, FontStyle.Regular),
                    Size = new Size(150, 30),
                    Text = "0.00000",
                };
                pnlKineticsInputPanel.Controls.Add(arrTxbKinetics[i]);
                locationY += 28;
            }

            locationX = 356;
            locationY = 90;
            for (int i = 14; i < 28; i++)
            {
                arrTxbKinetics[i] = new TextBox()
                {
                    Location = new Point(locationX, locationY),
                    Font = new Font(pfc.Families[0], 10, FontStyle.Regular),
                    Size = new Size(150, 30),
                    Text = "0.00000",
                };
                pnlKineticsInputPanel.Controls.Add(arrTxbKinetics[i]);
                locationY += 28;
            }

            Label[] arrTextBoxLabel = new Label[28];
            locationX = 200;
            locationY = 90;
            for (int i = 0; i < 14; i++)
            {
                arrTextBoxLabel[i] = new Label()
                {
                    Location = new Point(locationX, locationY),
                    Font = new Font(pfc.Families[0], 10, FontStyle.Regular),
                    Size = new Size(150, 30),
                    Text = arrTxbName[i],
                };
                pnlKineticsInputPanel.Controls.Add(arrTextBoxLabel[i]);
                locationY += 28;
            }

            locationX = 520;
            locationY = 90;
            for (int i = 14; i < 28; i++)
            {
                arrTextBoxLabel[i] = new Label()
                {
                    Location = new Point(locationX, locationY),
                    Font = new Font(pfc.Families[0], 10, FontStyle.Regular),
                    Size = new Size(195, 30),
                    Text = arrTxbName[i],
                };
                pnlKineticsInputPanel.Controls.Add(arrTextBoxLabel[i]);
                locationY += 28;
            }
        }

        public bool CheckFullData()
        {
            bool check = false;
            foreach (var txb in arrTxbKinetics)
            {
                if (txb.Text != null)
                {
                    check = true;
                }
            }
            return check;
        }

        #endregion

    }
}
