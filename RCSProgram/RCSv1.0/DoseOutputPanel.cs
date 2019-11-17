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

        #endregion

        #region Method

        public DoseOutputPanel(Panel PnlDoseOutput)
        {
            pnlDoseOutput = PnlDoseOutput;

            // Draw main label
            Label lbDoseResult = new Label()
            {
                Text = "Kết quả tính liều",
                Location = new Point(26, 30),
                Font = new Font("Segoe UI", 16, FontStyle.Regular),
                Size = new Size(400, 50),
            };
            pnlDoseOutput.Controls.Add(lbDoseResult);

            int locationX = 10;
            int locationY = 90;

            BunifuThinButton2 nextPhantom = new BunifuThinButton2()
            {
                ButtonText = "Mô hình sau     >>",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                Location = new Point(533, 146),
                Size = new Size(195, 54),
            };
            pnlDoseOutput.Controls.Add(nextPhantom);

            BunifuThinButton2 previousPhantom = new BunifuThinButton2()
            {
                ButtonText = "<<     Mô hình trước",
                Font = new Font("Segoe UI", 14, FontStyle.Regular),
                Location = new Point(39, 146),
                Size = new Size(195, 54),
            };
            pnlDoseOutput.Controls.Add(previousPhantom);

            for (int i = 0; i < UserData.targetOrganName.Count; i++)
            {
                TextBox txbDose = new TextBox()
                {
                    Size = new Size(150, 30),
                    Font = new Font("Segoe UI", 10, FontStyle.Regular),

                };
            }
        }

        #endregion
    }
}
