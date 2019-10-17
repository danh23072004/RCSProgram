using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;

namespace RCSv1._0
{
    class NuclideInputPanel
    {
        #region Properties

        private Panel pnlNuclideInput = new Panel();
        private Button button;
        private Label lbChoosingIsolate;

        #endregion

        #region Public Method

        public NuclideInputPanel(Panel PnlNuclideInput)
        {
            pnlNuclideInput = PnlNuclideInput;
        }

        public void DrawNuclideInputPanel()
        {
            var pfc = new PrivateFontCollection();
            string fontLocation = Application.StartupPath.Remove(Application.StartupPath.Length - 10, 10) + "\\Resources\\OpenSans-Light.ttf";
            pfc.AddFontFile(fontLocation);
            // This uses for adding new fonts

            lbChoosingIsolate = new Label()
            {
                Text = "Chọn đồng vị phóng xạ",
                Location = new Point(43, 70),
                Font = new Font(pfc.Families[0], 16, FontStyle.Regular),
                Size = new Size(250, 50),
            };
            pnlNuclideInput.Controls.Add(lbChoosingIsolate);
        }
        #endregion 
    }
}
