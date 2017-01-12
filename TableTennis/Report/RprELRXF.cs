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

namespace TableTennis.Report
{
    public partial class RprELRXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;

        public RprELRXF()
        {
            InitializeComponent();
        }

        private void RprELRXF_Load(object sender, EventArgs e)
        {
            this.RprELRTableAdapter.Fill(this.reportDataSet.RPR_ELR, ttID);
        }
    }
}