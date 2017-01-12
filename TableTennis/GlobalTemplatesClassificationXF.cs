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
    public partial class GlobalTemplatesClassificationXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;
        public int gtID = 0;

        public GlobalTemplatesClassificationXF()
        {
            InitializeComponent();
            Program.MF.GridControlInit(gtcGridControl);
        }

        public void Save()
        {
            try
            {
                this.Validate();
                this.gtcBindingSource.EndEdit();
                this.gtcTableAdapter.Update(this.dataSet.GTC);
                LoadData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadData()
        {
            this.gtcTableAdapter.FillByGT(this.dataSet.GTC, gtID);
        }

        private void EventsXF_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0}->{1}->{2}", ttID, gtID, "ClassificationTemplate");
            LoadData();
        }

        private void etGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as GridView;

            view.SetFocusedRowCellValue("GTID", gtID);
        }

        private void etGridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            Program.MF.GridControl_EmbeddedNavigator_ButtonClick(gtcGridView, e, this);
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
            string etID = gtcGridView.GetFocusedRowCellValue("ETID").ToString();

            //PreliminaryRoundXF frm = new PreliminaryRoundXF();
            EventPreliminaryLapXF frm = new EventPreliminaryLapXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.etID = etID;
            frm.Show();
        }

        private void knockoutLapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string etID = gtcGridView.GetFocusedRowCellValue("ETID").ToString();
            //FinalRoundXF frm = new FinalRoundXF();
            EventKnockoutLapXF frm = new EventKnockoutLapXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.etID = etID;
            frm.Show();
        }

    }
}