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
    class ModelsInputPanel
    {
        #region Properties

        #region Controls

        private RadioButton[] ckbHumanAge = new RadioButton[SettingManager.shared.models.Count];
        private Panel pnlModelsInput = new Panel();

        #endregion

        #region Local Variables

        #endregion

        #endregion

        #region Method

        public ModelsInputPanel(Panel PnlModelsInput)
        {

            pnlModelsInput = PnlModelsInput;

            var lbChoose = new Label()
            {
                Text = "Chọn mô hình người",
                Location = new Point(26, 30),
                Font = new Font("Segoe UI", 17, FontStyle.Bold),
                Size = new Size(250, 50),
            };
            pnlModelsInput.Controls.Add(lbChoose);

            int locationY = 80;
            int locationX = 20;
            SettingManager setting = SettingManager.shared;
            GroupBox groupBox = new GroupBox();
            // Position of ckbHumanAge and arrHumanAgeCheckboxLabel
            for (int i = 0; i < setting.models.Count; i++)
            {
                
                ckbHumanAge[i] = new RadioButton()
                {
                    Location = new Point(locationX, locationY),
                    Size = new Size(400, 20),
                    Checked = false,
                    Text = setting.models[i]
                };
                groupBox.Controls.Add(ckbHumanAge[i]);
             
                pnlModelsInput.Controls.Add(ckbHumanAge[i]);
                locationY += 25;
            }
            ckbHumanAge[0].Checked = true;
        }

        public string ReturnHumanAgeOption()
        {
            List<int> value = new List<int>();
            for (int i = 0; i < SettingManager.shared.models.Count; i++)
            {
                if (ckbHumanAge[i].Checked)
                {
                    return ckbHumanAge[i].Text;
                }
            }
            return null;
        }

        public bool CheckFullData()
        {
            bool check = false;
            foreach (var ckb in ckbHumanAge)
            {
                if (ckb.Checked == true)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        #endregion
    }
}
