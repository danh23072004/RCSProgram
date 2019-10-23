using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

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
            kineticsInputPanel = new KineticsInputPanel(pnlKineticsInput);
            doseOutputPanel = new DoseOutputPanel(pnlDoseOutput);

            homeInputPanel.DrawHomeInputPanel();
            pnlHomeInput.Show();
            modelsInputPanel.DrawModelsInputPanel();
            pnlModelsInput.Hide();
            nuclideInputPanel.DrawNuclideInputPanel();
            pnlNuclideInput.Hide();
            kineticsInputPanel.DrawKineticsInputPanel();
            pnlKineticsInput.Hide();
            doseOutputPanel.DrawDoseOutputPanel();
            pnlDoseOutput.Hide();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public void DrawColourMouseHoverMenuButton(BunifuThinButton2 btn)
        {
            btnNuclideInput.IdleFillColor = Color.White;
            btnNuclideInput.IdleForecolor = Color.SeaGreen;
            btnModelsInput.IdleFillColor = Color.White;
            btnModelsInput.IdleForecolor = Color.SeaGreen;
            btnKineticsInput.IdleFillColor = Color.White;
            btnKineticsInput.IdleForecolor = Color.SeaGreen;
            btnDose.IdleFillColor = Color.White;
            btnDose.IdleForecolor = Color.SeaGreen;
            btnHomeInput.IdleFillColor = Color.White;
            btnHomeInput.IdleForecolor = Color.SeaGreen;
            btn.IdleFillColor = Color.SeaGreen;
            btn.IdleForecolor = Color.White;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void BtnNuclideInput_Click(object sender, EventArgs e)
        {
            pnlNuclideInput.Show();
            pnlModelsInput.Hide();
            pnlHomeInput.Hide();
            pnlDoseOutput.Hide();
            pnlKineticsInput.Hide();
            //btnNuclideInput.IdleFillColor = Color.SeaGreen;
            //btnNuclideInput.IdleForecolor = Color.White;
            try
            {
                DrawColourMouseHoverMenuButton(btnNuclideInput);
            }
            catch (ArgumentException exception)
            {
                DrawColourMouseHoverMenuButton(btnNuclideInput);
                throw;
            }
        }

        private void BtnModelsInput_Click(object sender, EventArgs e)
        {
            pnlModelsInput.Show();
            pnlNuclideInput.Hide();
            pnlHomeInput.Hide();
            pnlDoseOutput.Hide();
            pnlKineticsInput.Hide();
            //btnModelsInput.IdleFillColor = Color.SeaGreen;
            //btnModelsInput.IdleForecolor = Color.White;
            DrawColourMouseHoverMenuButton(btnModelsInput);
            try
            {
                DrawColourMouseHoverMenuButton(btnModelsInput);
            }
            catch (AccessViolationException exception)
            {
                DrawColourMouseHoverMenuButton(btnModelsInput);
                throw;
            }
        }

        private void BtnKineticsInput_Click(object sender, EventArgs e)
        {
            pnlKineticsInput.Show();
            pnlDoseOutput.Hide();
            pnlHomeInput.Hide();
            pnlNuclideInput.Hide();
            pnlModelsInput.Hide();
            //btnKineticsInput.IdleFillColor = Color.SeaGreen;
            //btnKineticsInput.IdleForecolor = Color.White;
            DrawColourMouseHoverMenuButton(btnKineticsInput);
            try
            {
                DrawColourMouseHoverMenuButton(btnKineticsInput);
            }
            catch (ArgumentException exception)
            {
                DrawColourMouseHoverMenuButton(btnKineticsInput);
                throw;
            }
        }

        private void BtnHomeInput_Click(object sender, EventArgs e)
        {
            pnlHomeInput.Show();
            pnlNuclideInput.Hide();
            pnlModelsInput.Hide();
            pnlKineticsInput.Hide();
            pnlDoseOutput.Hide();
            //btnHomeInput.IdleFillColor = Color.SeaGreen;
            //btnHomeInput.IdleForecolor = Color.White;
            UserData.HumanAge = modelsInputPanel.ReturnHumanAgeOption();
            DrawColourMouseHoverMenuButton(btnHomeInput);

        }

        private void BtnDose_Click(object sender, EventArgs e)
        {
            //btnDose.IdleFillColor = Color.SeaGreen;
            //btnDose.IdleForecolor = Color.White;
            DrawColourMouseHoverMenuButton(btnDose);
        }
    }
}
