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
        private ComboBox cmbChooseNuclide = new ComboBox();

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

            // Modify lbChoosingIsolate
            Label lbChoosingIsolate = new Label()
            {
                Text = "Chọn đồng vị phóng xạ",
                Location = new Point(26, 70),
                Font = new Font(pfc.Families[0], 16, FontStyle.Regular),
                Size = new Size(250, 50),
            };
            pnlNuclideInput.Controls.Add(lbChoosingIsolate);

            // Modify cmbChooseNuclide
            cmbChooseNuclide.DataSource = UserData.listNuclide;
            cmbChooseNuclide.AutoCompleteCustomSource = UserData.listNuclideAutoComplete;
            cmbChooseNuclide.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbChooseNuclide.DropDownHeight = 250;
            cmbChooseNuclide.Size = new Size(237, 28);
            cmbChooseNuclide.MaxLength = 2;
            cmbChooseNuclide.Font = new Font(pfc.Families[0], 12, FontStyle.Regular);
            cmbChooseNuclide.Location = new Point(26, 145);
            pnlNuclideInput.Controls.Add(cmbChooseNuclide);
        }
        #endregion 
    }
}
