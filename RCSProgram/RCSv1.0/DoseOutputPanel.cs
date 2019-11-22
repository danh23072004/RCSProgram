using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Drawing.Text;
using System.Drawing;

namespace RCSv1._0
{
    class DoseOutputPanel
    {
        #region Properties

        private Panel pnlDoseOutput = new Panel();
        private List<TextBox> arrTxbDose = new List<TextBox>();
        private List<Label> arrTextBoxLabel = new List<Label>();

        #endregion

        #region Method

        public DoseOutputPanel(Panel PnlDoseOutput)
        {
            pnlDoseOutput = PnlDoseOutput;

            BunifuThinButton2 nextPhantom = new BunifuThinButton2()
            {
                ButtonText = "Mô hình sau     >>",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                Location = new Point(13, 8),
                Size = new Size(195, 54),
                ActiveFillColor = Color.SeaGreen,
                ActiveForecolor = Color.White,
                ActiveLineColor = Color.SeaGreen,
            };
            pnlDoseOutput.Controls.Add(nextPhantom);

            BunifuThinButton2 previousPhantom = new BunifuThinButton2()
            {
                ButtonText = "<<     Mô hình trước",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                Location = new Point(507, 8),
                Size = new Size(195, 54),
                ActiveFillColor = Color.SeaGreen,
                ActiveForecolor = Color.White,
                ActiveLineColor = Color.SeaGreen,
            };
            pnlDoseOutput.Controls.Add(previousPhantom);


            // Draw Textbox
            int locationX = 13;
            int locationY = 82;

            for (int i = 0; i < UserData.targetOrganName.Count / 2; i++)
            {
                TextBox txbDose = new TextBox()
                {
                    Size = new Size(150, 30),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Location = new Point(locationX, locationY),
                    Modified = false,
                };
                locationY += 31;
                arrTxbDose.Add(txbDose);
                pnlDoseOutput.Controls.Add(arrTxbDose[i]);
            }
            locationX = 82;
            locationY = 552;
            for (int i = UserData.targetOrganName.Count / 2; i < UserData.targetOrganName.Count; i++)
            {
                TextBox txbDose = new TextBox()
                {
                    Size = new Size(150, 30),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),
                    Location = new Point(locationX, locationY),
                    Modified = false,
                };
                locationY += 31;
                arrTxbDose.Add(txbDose);
                pnlDoseOutput.Controls.Add(arrTxbDose[i]);
            }
        }

        #endregion
    }
}
