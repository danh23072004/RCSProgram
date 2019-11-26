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

        #endregion

        #region Method

        public HomeInputPanel(Panel PnlHomeInput)
        {
            pnlHomeInput = PnlHomeInput;
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
                Font = new Font("Segoe UI", 17, FontStyle.Regular),
                ForeColor = Color.White,
                BackColor = Color.Transparent,
            };
            pnlHomeInput.Controls.Add(lbInstruction);
            lbInstruction.BringToFront();

            TextBox txbInstruction = new TextBox()
            {
                Location = new Point(11, 71),
                Multiline = true,
                Size = new Size(717, 325),
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ReadOnly = true,
            };
            pnlHomeInput.Controls.Add(txbInstruction);
        }

        #endregion
    }
}
