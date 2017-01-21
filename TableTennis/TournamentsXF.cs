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
    public partial class TournamentsXF : DevExpress.XtraEditors.XtraForm
    {
        public TournamentsXF()
        {
            InitializeComponent();

            //ttGridControl.EmbeddedNavigator.Buttons.EndEdit.Hint = "Save";
            //ttGridControl.EmbeddedNavigator.Buttons.CancelEdit.Hint = "Revert";
            Program.MF.GridControlInit(ttGridControl);
        }

        public void Save()
        {
            try
            {
                this.Validate();
                this.ttBindingSource.EndEdit();
                this.ttTableAdapter.Update(this.dataSet.TT);

                this.ttTableAdapter.Fill(this.dataSet.TT);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadData()
        {
            this.ttTableAdapter.Fill(this.dataSet.TT);
        }

        private void TournamentsXF_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0}", "Tournaments");
            this.ccTableAdapter.FillByTT(this.dataSet.CC, 0);   // Globe
            LoadData();
        }

        private void ttGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as GridView;

            int ttID = Program.MF.GET_PK("TT");
            view.SetFocusedRowCellValue("TTID", ttID);
        }

        private void preliminaryRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void finalRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void finalRoundTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ttGridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            Program.MF.GridControl_EmbeddedNavigator_ButtonClick(ttGridView, e, this);

            /*
            var view = ttGridView;
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                Program.MF.AddRow(view);
                e.Handled = true;
            }
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (Program.MF.RemoveRow() != DialogResult.Yes)
                    e.Handled = true;
            }
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit)
            {
                Save();
                e.Handled = true;
            }
            if (e.Button.ButtonType == NavigatorButtonType.Edit)
            {
                view.OptionsView.AllowCellMerge = false;
                e.Handled = true;
            }*/
        }

        private void ttGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // Program.MF.GridView_RowChanged(sender as GridView, this.dataSet);
            
            /*
            var gControl = (sender as GridView).GridControl;

            Program.MF.GridControlEmbedded_RowChanged(gControl, this.dataSet);
            
            if (this.dataSet.HasChanges())
            {
                gControl.EmbeddedNavigator.Buttons.EndEdit.Enabled = true;
                gControl.EmbeddedNavigator.Buttons.CancelEdit.Enabled = true;
            }*/
        }

        private void ttGridView_KeyUp(object sender, KeyEventArgs e)
        {
            Program.MF.GridView_KeyUp(sender, e);
        }

        private void preliminaryRoudPivotToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void createFinalRoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void createEventClassificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void preliminaryEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ttID = (int)ttGridView.GetFocusedRowCellValue("TTID");
            EventPreliminaryLapXF frm = new EventPreliminaryLapXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.ttNM = ttGridView.GetFocusedRowCellDisplayText("NAME");
            frm.Show();
        }

        private void knockoutEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ttID = (int)ttGridView.GetFocusedRowCellValue("TTID");
            EventKnockoutLapXF frm = new EventKnockoutLapXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.ttNM = ttGridView.GetFocusedRowCellDisplayText("NAME");
            frm.Show();
        }

        private void globalTemplatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ttID = (int)ttGridView.GetFocusedRowCellValue("TTID");
            GlobalTemplatesXF frm = new GlobalTemplatesXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.Show();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ttID = (int)ttGridView.GetFocusedRowCellValue("TTID");
            EventsXF frm = new EventsXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
			frm.ttNM = ttGridView.GetFocusedRowCellDisplayText("NAME");
			frm.Show();
        }

        private void participantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ttID = (int)ttGridView.GetFocusedRowCellValue("TTID");
            ParticipantsXF frm = new ParticipantsXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.ttNM = ttGridView.GetFocusedRowCellDisplayText("NAME");
            frm.Show();
        }

        private void eventClassificationTemplateToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void eventClassificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ttID = (int)ttGridView.GetFocusedRowCellValue("TTID");
            EventClassificationXF frm = new EventClassificationXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.Show();
        }

        private void eventDistirbutionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ttID = (int)ttGridView.GetFocusedRowCellValue("TTID");
            Report.RprELXF frm = new Report.RprELXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.Show();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ttID = (int)ttGridView.GetFocusedRowCellValue("TTID");
            Report.RprELRXF frm = new Report.RprELRXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.Show();
        }

        private void antetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ttID = (int)ttGridView.GetFocusedRowCellValue("TTID");
            AntetXF frm = new AntetXF();
            frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.Show();
        }

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			HelpXF frm = new HelpXF();
			frm.MdiParent = Program.MF;
			frm.Show();
		}

		private void denemeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PrntChldXF frm = new PrntChldXF();
			frm.MdiParent = Program.MF;
			frm.Show();
		}
	}
}