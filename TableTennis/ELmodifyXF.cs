using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TableTennis
{
    public partial class ELmodifyXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;
        public int gtID = 0;
        public string gtNAME = " ";

        public ELmodifyXF()
        {
            InitializeComponent();
        }

        private void ELmodifyXF_Load(object sender, EventArgs e)
        {
			this.Text = string.Format("{0}->Create|Remove Plan", ttID);

			this.gtTableAdapter.Fill(this.dataSet.GT);
            this.etTableAdapter.FillByTT(this.dataSet.ET, ttID);
            this.gtTableAdapter.Fill(this.dataSet.GT);
            GTlookUpEdit.EditValue = gtID;
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
			var aaaaa = actionRadioGroup.EditValue;

			gtID = Convert.ToInt32(GTlookUpEdit.EditValue);
            string msj = queriesTableAdapter.EL_MODIFY(Convert.ToInt32(GTlookUpEdit.EditValue), ttID, ETlookUpEdit.EditValue.ToString(), actionRadioGroup.EditValue.ToString()).ToString();
            if (!string.IsNullOrWhiteSpace(msj))
                MessageBox.Show(msj, "Create|Remove Plan");
        }
    }
}