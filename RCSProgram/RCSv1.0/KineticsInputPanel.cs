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

        #endregion

        #region Method

        public KineticsInputPanel(Panel PnlKineticsInputPanel)
        {
            pnlKineticsInputPanel = PnlKineticsInputPanel;
        }

        public void DrawKineticsInputPanel()
        {
            
            var pfc = new PrivateFontCollection();
            string fontLocation = Application.StartupPath.Remove(Application.StartupPath.Length - 10, 10) + "\\Resources\\OpenSans-Light.ttf";
            pfc.AddFontFile(fontLocation);
            // This uses for adding new fonts

            Label lbTimeExist = new Label()
            {
                Text = "Thời gian lưu trú của các nội tạng",
                Location = new Point(26, 70),
                Font = new Font(pfc.Families[0], 16, FontStyle.Regular),
                Size = new Size(250, 50),
            };
            pnlKineticsInputPanel.Controls.Add(lbTimeExist);

        }

        #endregion

    }
}
