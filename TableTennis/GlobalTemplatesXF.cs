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
    public partial class GlobalTemplatesXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;

        public GlobalTemplatesXF()
        {
            InitializeComponent();
            Program.MF.GridControlInit(gtGridControl);
           
        }

        public void Save()
        {
            try
            {
                this.Validate();
                this.gtBindingSource.EndEdit();
                this.gtTableAdapter.Update(this.dataSet.GT);

                LoadData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadData()
        {
            this.gtTableAdapter.Fill(this.dataSet.GT);
        }

        private void EventsXF_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0}->{1}", ttID, "Global Templates");
            LoadData();
        }

        private void etGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as GridView;

            view.SetFocusedRowCellValue("GTID", Program.MF.GET_PK("GT"));
        }

        private void etGridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            Program.MF.GridControl_EmbeddedNavigator_ButtonClick(gtGridView, e, this);
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
            string etID = gtGridView.GetFocusedRowCellValue("ETID").ToString();

            //PreliminaryRoundXF frm = new PreliminaryRoundXF();
            EventPreliminaryLapXF frm = new EventPreliminaryLapXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.etID = etID;
            frm.Show();
        }

        private void knockoutLapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string etID = gtGridView.GetFocusedRowCellValue("ETID").ToString();
            //FinalRoundXF frm = new FinalRoundXF();
            EventKnockoutLapXF frm = new EventKnockoutLapXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.etID = etID;
            frm.Show();
        }

        private void templatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gtID = (int)gtGridView.GetFocusedRowCellValue("GTID");
            string typ = gtGridView.GetFocusedRowCellValue("TYP").ToString();
            if (typ == "C")
            {
                GlobalTemplatesClassificationXF frm = new GlobalTemplatesClassificationXF();
                frm.MdiParent = Program.MF;
                frm.ttID = ttID;
                frm.gtID = gtID;
                frm.Show();
            }
            else
            {
                GlobalTemplatesLapXF frm = new GlobalTemplatesLapXF();
                frm.MdiParent = Program.MF;
                frm.ttID = ttID;
                frm.gtID = gtID;
                frm.typ = typ;
                frm.Show();
            }
        }

        private void createRemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gtID = (int)gtGridView.GetFocusedRowCellValue("GTID");
            string gtTYP = gtGridView.GetFocusedRowCellValue("TYP").ToString();
            string gtNAME = gtGridView.GetFocusedRowCellValue("NAME").ToString();
            if (gtTYP == "C")
            {
                ECmodifyXF frm = new ECmodifyXF();
                frm.MdiParent = Program.MF;
                frm.ttID = ttID;
                frm.gtID = gtID;
                frm.gtNAME = gtNAME;
                frm.Show();
            }
            else
            {
                ELmodifyXF frm = new ELmodifyXF();
                frm.MdiParent = Program.MF;
                frm.ttID = ttID;
                frm.gtID = gtID;
                frm.gtNAME = gtNAME;
                frm.Show();
            }
        }

        private void createTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gtID = (int)gtGridView.GetFocusedRowCellValue("GTID");
            string msj = queriesTableAdapter.GT_MODIFY(gtID, "C").ToString();
            if (!string.IsNullOrWhiteSpace(msj))
                MessageBox.Show(msj, "Create Templates");
        }

        private void deleteTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int gtID = (int)gtGridView.GetFocusedRowCellValue("GTID");
            string msj = queriesTableAdapter.GT_MODIFY(gtID, "D").ToString();
            if (!string.IsNullOrWhiteSpace(msj))
                MessageBox.Show(msj, "Delete Templates");
        }

        private void gtGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var view = sender as GridView;
            if (view.GetRowCellValue(e.RowHandle, "TYP").ToString() == "K")     // Knockout sisteminde bir grupta 2 oyuncu olur.
                view.SetRowCellValue(e.RowHandle, "PPG", 2);
           
        }
    }
}