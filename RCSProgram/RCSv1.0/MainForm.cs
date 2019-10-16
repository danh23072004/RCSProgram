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
        private NuclideInputPanel nuclideInputPanel;
        private ModelsInputPanel modelsInputPanel;
        private KineticsInputPanel kineticsInputPanel;

        public MainForm()
        {
            InitializeComponent();
            nuclideInputPanel = new NuclideInputPanel(pnlNuclideInput);
            nuclideInputPanel.DrawNuclideInputPanel();

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
            nuclideInputPanel.DrawNuclideInputPanel();
        }

        private void btnIModelsInput_Click(object sender, EventArgs e)
        {

        }
    }
}
