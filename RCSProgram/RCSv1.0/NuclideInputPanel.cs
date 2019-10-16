using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
            lbChoosingIsolate = new Label()
            {
                Text = "Chọn đồng vị phóng xạ",
                Location = new Point(43, 70),
            };
            pnlNuclideInput.Controls.Add(lbChoosingIsolate);
            button = new Button()
            {
                Text = "Hello world",
            };
            pnlNuclideInput.Controls.Add(button);
        }
        #endregion 
    }
}
