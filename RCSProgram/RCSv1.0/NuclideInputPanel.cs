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
        private ComboBox cmbChooseIsotopes = new ComboBox();

        #endregion

        #region Public Method

        public NuclideInputPanel(Panel PnlNuclideInput)
        {
            pnlNuclideInput = PnlNuclideInput;

            // Modify lbChoosingIsolate
            Label lbChoosingIsolate = new Label()
            {
                Text = "Chọn đồng vị phóng xạ",
                Location = new Point(26, 70),
                Font = new Font("Segoe UI", 16, FontStyle.Regular),
                Size = new Size(290, 50),
            };
            pnlNuclideInput.Controls.Add(lbChoosingIsolate);

            // Modify cmbChooseNuclide
            cmbChooseNuclide.Text = null;
            cmbChooseNuclide.DataSource = Constant.arrNuclide;
            cmbChooseNuclide.DropDownStyle = ComboBoxStyle.DropDown;
            cmbChooseNuclide.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbChooseNuclide.DropDownHeight = 250;
            cmbChooseNuclide.Size = new Size(237, 28);
            cmbChooseNuclide.MaxLength = 2;
            cmbChooseNuclide.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            cmbChooseNuclide.Location = new Point(26, 145);
            pnlNuclideInput.Controls.Add(cmbChooseNuclide);

            ////Modify cmbChooseIsotopes
            //cmbChooseIsotopes.DataSource = Constant.arrNuclideIsotopes[0];
            //cmbChooseNuclide.Text = null;
            //cmbChooseIsotopes.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmbChooseIsotopes.DropDownHeight = 250;
            //cmbChooseIsotopes.Size = new Size(237, 28);
            //cmbChooseIsotopes.MaxLength = 2;
            //cmbChooseIsotopes.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            //cmbChooseIsotopes.Location = new Point(400, 145);
            //cmbChooseIsotopes.MaxLength = 7;
            //cmbChooseIsotopes.DropDownStyle = ComboBoxStyle.DropDownList;
            //pnlNuclideInput.Controls.Add(cmbChooseIsotopes);
            //string[] arr = new string[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    arr[i] = Constant.arrNuclideIsotopes[0][i];
            //}

            cmbChooseNuclide.SelectedValueChanged += CmbChooseNuclide_SelectedValueChanged;
            //cmbChooseIsotopes.SelectedValueChanged += CmbChooseIsotopes_SelectedValueChanged;
        }

        //private void CmbChooseIsotopes_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    UserData.nuclideIndex = cmbChooseNuclide.SelectedIndex;
        //    UserData.isotopeIndex = cmbChooseIsotopes.SelectedIndex;
        //}

        private void CmbChooseNuclide_SelectedValueChanged(object sender, EventArgs e)
        {
            // cmbChooseNuclide.SelectedIndex shows the position of the pointed nuclide
            //cmbChooseIsotopes.DataSource = Constant.arrNuclideIsotopes[cmbChooseNuclide.SelectedIndex];
            UserData.nuclideIndex = cmbChooseNuclide.SelectedIndex;
            UserData.isotopeIndex = 0;
        }

        public bool CheckFullNuclideData()
        {
            if (cmbChooseNuclide.Text == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        #endregion
    }
}
