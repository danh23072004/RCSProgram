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
        }

        #endregion
    }
}
