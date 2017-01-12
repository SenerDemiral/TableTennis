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
    public partial class ECmodifyXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;
        public int gtID = 0;
        public string gtNAME = "";

        public ECmodifyXF()
        {
            InitializeComponent();
        }

        private void ECmodifyXF_Load(object sender, EventArgs e)
        {
			this.Text = string.Format("{0}->Create/Remove Classification", ttID);
			this.etTableAdapter.FillByTT(this.dataSet.ET, ttID);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string msj = queriesTableAdapter.EC_MODIFY(gtID, ttID, etIDLookUpEdit.EditValue.ToString(), actionRadioGroup.EditValue.ToString()).ToString();
            if (!string.IsNullOrWhiteSpace(msj))
                MessageBox.Show(msj, "Create Event Classifications");
        }
    }
}