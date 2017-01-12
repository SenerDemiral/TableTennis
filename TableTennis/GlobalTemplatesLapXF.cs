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
    public partial class GlobalTemplatesLapXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;
        public int gtID = 0;
        public string typ = "";

        public GlobalTemplatesLapXF()
        {
            InitializeComponent();
            Program.MF.GridControlInit(gtlGridControl);
        }

        public void Save()
        {
            try
            {
                this.Validate();
                this.gtlBindingSource.EndEdit();
                this.gtlTableAdapter.Update(this.dataSet.GTL);
                LoadData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadData()
        {
            if (typ == "P")
            {
                this.gtlTableAdapter.FillByGTP(this.dataSet.GTL, gtID); // Preliminary
            }
            else
                this.gtlTableAdapter.FillByGTK(this.dataSet.GTL, gtID); // Knockouts
        }

        private void EventsXF_Load(object sender, EventArgs e)
        {
            if (typ == "P")
            { 
                this.Text = string.Format("{0}->{1}->{2}", ttID, gtID, "PreliminaryTemplate");
                colCS.GroupIndex = -1;
                colCS.Visible = false;
                colLAP.GroupIndex = -1;
                colLAP.Visible = false;
                colPC.Visible = false;
            }
            else
                this.Text = string.Format("{0}->{1}->{2}", ttID, gtID, "KnockoutTemplate");
            LoadData();
        }

        private void etGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as GridView;

            view.SetFocusedRowCellValue("GTID", gtID);
            if (typ == "P")
            {
                view.SetFocusedRowCellValue("CS", " ");
                view.SetFocusedRowCellValue("LAP", " ");
            }
        }

        private void etGridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            Program.MF.GridControl_EmbeddedNavigator_ButtonClick(gtlGridView, e, this);
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
            string etID = gtlGridView.GetFocusedRowCellValue("ETID").ToString();

            //PreliminaryRoundXF frm = new PreliminaryRoundXF();
            EventPreliminaryLapXF frm = new EventPreliminaryLapXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.etID = etID;
            frm.Show();
        }

        private void knockoutLapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string etID = gtlGridView.GetFocusedRowCellValue("ETID").ToString();
            //FinalRoundXF frm = new FinalRoundXF();
            EventKnockoutLapXF frm = new EventKnockoutLapXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.etID = etID;
            frm.Show();
        }

        private void deleteTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void createTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}