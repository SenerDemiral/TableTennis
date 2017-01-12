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
    public partial class AntetXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;

        public AntetXF()
        {
            InitializeComponent();
        }

        private void Save()
        {
            this.Validate();
            this.antetBindingSource.EndEdit();
            this.antetTableAdapter.Update(this.dataSet.ANTET);

        }

        private void AntetXF_Load(object sender, EventArgs e)
        {
            var res = this.antetTableAdapter.FillByTT(this.dataSet.ANTET, ttID);
			if(res == 0)
				dataSet.ANTET.AddANTETRow(ttID, "", "");
        }

        private void AntetXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.antetBindingSource.EndEdit();

			if (dataSet.HasChanges())
            {
                DialogResult dr = MessageBox.Show("Do you want to Save?", "Confirm Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Save();
                }
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

    }
}