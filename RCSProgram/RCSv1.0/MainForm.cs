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

        // This uses for storing data
        private UserData data = new UserData();

        public MainForm()
        {
            InitializeComponent();

            homeInputPanel = new HomeInputPanel(pnlHomeInput);
            nuclideInputPanel = new NuclideInputPanel(pnlNuclideInput);
            modelsInputPanel = new ModelsInputPanel(pnlModelsInput);
            modelsInputPanel.DrawModelsInputPanel();
            pnlModelsInput.Hide();
            homeInputPanel.DrawHomeInputPanel();
            pnlHomeInput.Hide();
            nuclideInputPanel.DrawNuclideInputPanel();
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
        }

        private void btnIModelsInput_Click(object sender, EventArgs e)
        {
            pnlModelsInput.Show();
            pnlNuclideInput.Hide();
            pnlHomeInput.Hide();
        }

        private void btnKineticsInput_Click(object sender, EventArgs e)
        {

        }

        private void btnHomeInput_Click(object sender, EventArgs e)
        {
            pnlHomeInput.Show();
            pnlNuclideInput.Hide();
            pnlModelsInput.Hide();
            data.HumanAge = modelsInputPanel.ReturnHumanAgeOption();
        }

    }
}
