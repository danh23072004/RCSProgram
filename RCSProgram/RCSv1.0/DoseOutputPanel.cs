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
        }

        public void showResult(List<float> results)
        {
            pnlDoseOutput.Controls.Clear();
            int x = 20;
            int y = 10;
            for(var ri = 0; ri < results.Count; ri ++)
            {
                var result = results[ri];
                var vnNguonName = SettingManager.shared.sourceVnName[ri];

                var label = new Label()
                {
                    Text = vnNguonName + " -- " + result,
                    Size = new Size(600, 20),
                    Location = new Point(x, y),
                    ForeColor = Color.Black
                };
                y += 20;
                pnlDoseOutput.Controls.Add(label);
            }
        }

        #endregion
    }
}
