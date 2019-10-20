using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Drawing.Text;
using System.Drawing;

namespace RCSv1._0
{
    class HomeInputPanel
    {
        #region Properties

        private Panel pnlHomeInput = new Panel();
        private BunifuThinButton2 btnDose = new BunifuThinButton2();

        #endregion

        #region Method

        public HomeInputPanel(Panel PnlHomeInput)
        {
            pnlHomeInput = PnlHomeInput;
        }

        public void DrawHomeInputPanel()
        {
            var pfc = new PrivateFontCollection();
            string fontLocation = Application.StartupPath.Remove(Application.StartupPath.Length - 10, 10) + "\\Resources\\OpenSans-SemiBold.ttf";
            pfc.AddFontFile(fontLocation);
            // This uses for adding new fonts

            btnDose.ButtonText = "Tính liều";
            btnDose.Location = new Point(22, 273);
            btnDose.Size = new Size(157, 45);
            btnDose.Font = new Font(pfc.Families[0], 14, FontStyle.Regular);
            pnlHomeInput.Controls.Add(btnDose);
            btnDose.Click += BtnDose_Click;

            Button btnInstruction = new Button()
            {
                Text = "",
                ForeColor = Color.White,
                Location = new Point(12, 3),
                BackColor = Color.DarkRed,
                Size = new Size(231, 45),
                FlatStyle = FlatStyle.Flat,
                Enabled = false,
            };
            btnInstruction.FlatAppearance.BorderColor = Color.DarkRed;
            pnlHomeInput.Controls.Add(btnInstruction);

            Label lbInstruction = new Label()
            {
                Text = "Hướng dẫn",
                Location = new Point(12, 3),
                Size = new Size(231, 45),
                Font = new Font(pfc.Families[0], 17, FontStyle.Regular),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
            };
            pnlHomeInput.Controls.Add(lbInstruction);
            lbInstruction.BringToFront();
        }


        private void BtnDose_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
