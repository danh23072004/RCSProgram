using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCSv1._0
{
    public partial class MainForm : Form
    {
        /* These variables are different from the panel in the MainForm, these are used for 
         * supporting the way approaching those panel
         */
        private HomeInputPanel homeInputPanel;
        private NuclideInputPanel nuclideInputPanel;
        private ModelsInputPanel modelsInputPanel;
        private KineticsInputPanel kineticsInputPanel;
        private DoseOutputPanel doseOutputPanel;

        public MainForm()
        {
            InitializeComponent();

            homeInputPanel = new HomeInputPanel(pnlHomeInput);
            nuclideInputPanel = new NuclideInputPanel(pnlNuclideInput);
            modelsInputPanel = new ModelsInputPanel(pnlModelsInput);
            doseOutputPanel = new DoseOutputPanel(pnlDoseOutput);

            modelsInputPanel.DrawModelsInputPanel();
            pnlModelsInput.Hide();
            homeInputPanel.DrawHomeInputPanel();
            pnlHomeInput.Show();
            nuclideInputPanel.DrawNuclideInputPanel();
            pnlNuclideInput.Hide();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void btnNuclideInput_Click(object sender, EventArgs e)
        {
            pnlNuclideInput.Show();
            pnlModelsInput.Hide();
            pnlHomeInput.Hide();
            pnlDoseOutput.Hide();
        }

        private void btnIModelsInput_Click(object sender, EventArgs e)
        {
            pnlModelsInput.Show();
            pnlNuclideInput.Hide();
            pnlHomeInput.Hide();
            pnlDoseOutput.Hide();
        }

        private void btnKineticsInput_Click(object sender, EventArgs e)
        {
            pnlDoseOutput.Show();
            pnlHomeInput.Hide();
            pnlNuclideInput.Hide();
            pnlModelsInput.Hide();
        }

        private void btnHomeInput_Click(object sender, EventArgs e)
        {
            pnlHomeInput.Show();
            pnlNuclideInput.Hide();
            pnlModelsInput.Hide();
            pnlDoseOutput.Hide();
            UserData.HumanAge = modelsInputPanel.ReturnHumanAgeOption();
        }

        private void btnDose_Click(object sender, EventArgs e)
        {

        }
    }
}
