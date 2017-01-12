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
    public partial class RprELXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;

        public RprELXF()
        {
            InitializeComponent();
        }

        private void RprELXF_Load(object sender, EventArgs e)
        {
            this.rprELTableAdapter.Fill(this.reportDataSet.RPR_EL, ttID);
        }
    }
}