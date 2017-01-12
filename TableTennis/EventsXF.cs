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
using DevExpress.XtraGrid.Views.Grid;

namespace TableTennis
{
    public partial class EventsXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;
		public string ttNM = "";

        public EventsXF()
        {
            InitializeComponent();
            Program.MF.GridControlInit(etGridControl);
           
        }

        public void Save()
        {
            try
            {
                this.Validate();
                this.etBindingSource.EndEdit();
                this.etTableAdapter.Update(this.dataSet.ET);

                this.etTableAdapter.FillByTT(this.dataSet.ET, ttID);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadData()
        {
            this.etTableAdapter.FillByTT(this.dataSet.ET, ttID);
        }

        private void EventsXF_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0}->{1}", ttID, "Events");
            LoadData();
        }

        private void etGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as GridView;

            view.SetFocusedRowCellValue("TTID", ttID);
            view.SetFocusedRowCellValue("PL", "T");
            view.SetFocusedRowCellValue("KL", "T");
			view.SetFocusedRowCellValue("NOK", "0");
		}

		private void etGridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            Program.MF.GridControl_EmbeddedNavigator_ButtonClick(etGridView, e, this);
        }

        private void etGridView_KeyUp(object sender, KeyEventArgs e)
        {
            Program.MF.GridView_KeyUp(sender, e);
        }

        private void etGridView_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            Program.MF.GridView_RowChanged(sender as GridView, this.dataSet);
        }

        private void preliminaryLapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string etID = etGridView.GetFocusedRowCellValue("ETID").ToString();

            //PreliminaryRoundXF frm = new PreliminaryRoundXF();
            EventPreliminaryLapXF frm = new EventPreliminaryLapXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.etID = etID;
            frm.etNM = etGridView.GetFocusedRowCellValue("FULLNAME").ToString();
            frm.Show();
        }

        private void knockoutLapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string etID = etGridView.GetFocusedRowCellValue("ETID").ToString();
            //FinalRoundXF frm = new FinalRoundXF();
            EventKnockoutLapXF frm = new EventKnockoutLapXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.etID = etID;
            frm.etNM = etGridView.GetFocusedRowCellValue("FULLNAME").ToString();
            frm.Show();
        }

        private void classificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string etID = etGridView.GetFocusedRowCellValue("ETID").ToString();
            EventClassificationXF frm = new EventClassificationXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.etID = etID;
            frm.Show();
        }

		private void knockoutResultsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string etID = etGridView.GetFocusedRowCellValue("ETID").ToString();
			KnockoutResultsXF frm = new KnockoutResultsXF();
			frm.MdiParent = Program.MF;
			frm.ttID = ttID;
			frm.etID = etID;
			frm.ttNM = ttNM;
			frm.etNM = etGridView.GetFocusedRowCellDisplayText("NAME");
			frm.NOK = (int)etGridView.GetFocusedRowCellValue("NOK");
			frm.Show();
		}
	}
}