using System;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Drawing;

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

        //[HandleProcessCorruptedStateExceptions]
        private void BtnNuclideInput_Click(object sender, EventArgs e)
        {
            DrawColourMouseHoverMenuButton(btnNuclideInput);
            pnlNuclideInput.Visible = true;
            pnlModelsInput.Visible = false;
            pnlHomeInput.Visible = false;
            pnlDoseOutput.Visible = false;
            pnlKineticsInput.Visible = false;
        }

        //[HandleProcessCorruptedStateExceptions]
        private void BtnModelsInput_Click(object sender, EventArgs e)
        {
            DrawColourMouseHoverMenuButton(btnModelsInput);
            pnlModelsInput.Visible = true;
            pnlNuclideInput.Visible = false;
            pnlHomeInput.Visible = false;
            pnlDoseOutput.Visible = false;
            pnlKineticsInput.Visible = false;
        }

        //[HandleProcessCorruptedStateExceptions]
        private void BtnKineticsInput_Click(object sender, EventArgs e)
        {
            DrawColourMouseHoverMenuButton(btnKineticsInput);
            pnlKineticsInput.Visible = true;
            pnlModelsInput.Visible = false;
            pnlNuclideInput.Visible = false;
            pnlHomeInput.Visible = false;
            pnlDoseOutput.Visible = false;
        }

        //[HandleProcessCorruptedStateExceptions]
        private void BtnHomeInput_Click(object sender, EventArgs e)
        {
            DrawColourMouseHoverMenuButton(btnHomeInput);
            pnlModelsInput.Visible = false;
            pnlNuclideInput.Visible = false;
            pnlHomeInput.Visible = true;
            pnlDoseOutput.Visible = false;
            pnlKineticsInput.Visible = false;
            UserData.HumanAge = modelsInputPanel.ReturnHumanAgeOption();
        }

        //[HandleProcessCorruptedStateExceptions]
        private void BtnDose_Click(object sender, EventArgs e)
        {
            pnlDoseOutput.Visible = true;
            pnlModelsInput.Visible = false;
            pnlNuclideInput.Visible = false;
            pnlHomeInput.Visible = false;
            pnlKineticsInput.Visible = false;
            DrawColourMouseHoverMenuButton(btnDose);

            // Checking data by the value in UserData get from Panel
            // If there is any data is not checked, show a message box
            UserData.fullData[1] = nuclideInputPanel.CheckFullData();
            UserData.fullData[2] = modelsInputPanel.CheckFullData();
            UserData.fullData[3] = kineticsInputPanel.CheckFullData();

            foreach (var check in UserData.fullData)
            {
                if (check == false)
                {

                }
            }
        }
    }
}
