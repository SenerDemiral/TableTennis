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
using System.Diagnostics;

namespace TableTennis
{
	public partial class PrntChldXF : DevExpress.XtraEditors.XtraForm
	{
		public PrntChldXF()
		{
			InitializeComponent();
		}

		private void PrntChldXF_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSet.PRNT' table. You can move, or remove it, as needed.
			prntTableAdapter.ClearBeforeFill = true;
			chldTableAdapter.ClearBeforeFill = false;

Stopwatch watch = new Stopwatch();

watch.Start();

for(int i = 0; i < 5; i++) {
	dataSet.PRNT.Clear();
	dataSet.CHLD.Clear();
	this.prntTableAdapter.Fill(this.dataSet.PRNT);
	foreach(var c in this.dataSet.PRNT) {
		this.chldTableAdapter.FillByPID(this.dataSet.CHLD, c.ID);
	}
}
watch.Stop();
MessageBox.Show(string.Format("Compare took: {0}", watch.Elapsed));

		}
	}
}