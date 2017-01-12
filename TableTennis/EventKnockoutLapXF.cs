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
using DevExpress.XtraPrinting;

namespace TableTennis
{
    public partial class EventKnockoutLapXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;
        public string ttNM = "";
        public string etID = "";
        public string etNM = "";

        public EventKnockoutLapXF()
        {
            InitializeComponent();
            Program.MF.GridControlInit(elkGridControl);
        }

        public void Save()
        {
            try
            {
                this.Validate();
                this.elBindingSource.EndEdit();
                this.elTableAdapter.Update(this.dataSet.EL);

                LoadData();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadData()
        {
            if (etID == "")
            {
                this.Text = string.Format("{0}->{1}", ttID, "KnockoutPlan");
                this.elTableAdapter.FillByTTK(this.dataSet.EL, ttID);
            }
            else
            {
                this.Text = string.Format("{0}->{1}->{2}", ttID, etID, "KnockoutPlan");
                colETID.Visible = false;
                this.elTableAdapter.FillByETK(this.dataSet.EL, ttID, etID);
            }
        }

        private void EventPreliminaryLapXF_Load(object sender, EventArgs e)
        {
            this.etTableAdapter.FillByTT(this.dataSet.ET, ttID);
            this.ptTableAdapter.FillByTT(this.dataSet.PT, ttID);
            LoadData();
        }

        private void elkGridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var view = sender as GridView;
            if (e.FocusedRowHandle >= 0)
                view.Tag = e.FocusedRowHandle;
        }

        private void elpGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as GridView;

            view.SetFocusedRowCellValue("TTID", ttID);
            int pfrh = Convert.ToInt32(view.Tag);
            if (pfrh >= 0)
            {
                view.SetFocusedRowCellValue("ETID", view.GetRowCellValue(pfrh, "ETID"));
                view.SetFocusedRowCellValue("CS", view.GetRowCellValue(pfrh, "CS"));
                view.SetFocusedRowCellValue("LAP", view.GetRowCellValue(pfrh, "LAP"));
                view.SetFocusedRowCellValue("GRP", view.GetRowCellValue(pfrh, "GRP"));
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(etID))
                    view.SetFocusedRowCellValue("ETID", etID);

                view.SetFocusedRowCellValue("LAP", "");
                view.SetFocusedRowCellValue("GRP", "");
                view.SetFocusedRowCellValue("GI", "1");
            }
        }

        private void elpGridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            /*
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                Program.MF.AddRow(elkGridView);
                elkGridView.OptionsBehavior.EditingMode = GridEditingMode.EditForm;
                elkGridView.ShowPopupEditForm();
                elkGridView.OptionsBehavior.EditingMode = GridEditingMode.Default;
                e.Handled = true;
            }
            else*/
                Program.MF.GridControl_EmbeddedNavigator_ButtonClick(elkGridView, e, this);
            //elkGridView.OptionsBehavior.EditingMode = GridEditingMode.Default;
        }

        private void elpGridView_KeyUp(object sender, KeyEventArgs e)
        {
			Program.MF.GridView_KeyUp(sender, e);
		}

		private void elpGridView_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            Program.MF.GridView_RowChanged(sender as GridView, this.dataSet);
        }

        private void grRepositoryItemTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            var view = elkGridView;
            string ETID = view.GetFocusedRowCellValue("ETID").ToString();
            string CS = view.GetFocusedRowCellValue("CS").ToString();
            string LAP = view.GetFocusedRowCellValue("LAP").ToString();
            string GRP = view.GetFocusedRowCellValue("GRP").ToString();
            string GI = view.GetFocusedRowCellValue("GI").ToString();
            GI = GI == "1" ? "2" : "1"; // Bir grup icinde 1 ve 2 olur

            var edt = sender as TextEdit;

            string GR = edt.EditValue.ToString();
            if (!string.IsNullOrWhiteSpace(GR))
                GR = GR == "W" ? "L" : "W";

            DataSet.ELRow row = this.dataSet.EL.FindByTTIDETIDCSLAPGRPGI(ttID, ETID, CS, LAP, GRP, GI);
            if (row != null)
                row.GR = GR;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = elkGridControl;

            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = false;
            link.Margins.Left = 50;
            link.Margins.Right = 50;
            link.Margins.Top = 40;
            link.Margins.Bottom = 50;

            PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;
            
            var antetRow = Program.MF.getAntet(ttID);
            if (!antetRow.IsHEADERNull())
                link.RtfReportHeader = antetRow.HEADER;
            if (!antetRow.IsFOOTERNull())
                link.RtfReportFooter = antetRow.FOOTER;

            var Font = new Font("Tahoma", 12, FontStyle.Bold);

            phf.Header.Content.AddRange(new string[] { "", "", "Knockout Events" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "Knockout Events", "© Şener Demiral" });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        private void resultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = elkGridView;
            string etID = view.GetFocusedRowCellValue("ETID").ToString();
            string CS = view.GetFocusedRowCellValue("CS").ToString();
            string Lap = view.GetFocusedRowCellValue("LAP").ToString();
            string Grp = view.GetFocusedRowCellValue("GRP").ToString();

            EventLapGrupResultXF frm = new EventLapGrupResultXF();
            //frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.etID = etID;
            frm.etNM = view.GetFocusedRowCellDisplayText("ETID");
            frm.CS = CS;
            frm.Lap = Lap;
            frm.Grp = Grp;

            DialogResult dr = frm.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                var rowObj = view.GetFocusedRow();

                elTableAdapter.ClearBeforeFill = false;
                //this.elTableAdapter.FillByGRP(this.dataSet.EL, ttID, etID, CS, Lap, Grp);
                this.elTableAdapter.FillByET(this.dataSet.EL, ttID, etID);  // Degisiklik Event deki her seyi degistirebilir.
                elTableAdapter.ClearBeforeFill = true;

                view.FocusedRowHandle = view.FindRow(rowObj);
            }
        }

        private void teamMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var view = elkGridView;
            var rowObj = view.GetFocusedRow();
            string etID = view.GetFocusedRowCellValue("ETID").ToString();
            string CS = view.GetFocusedRowCellValue("CS").ToString();
            string Lap = view.GetFocusedRowCellValue("LAP").ToString();
            string Grp = view.GetFocusedRowCellValue("GRP").ToString();

            EventTeamMatchesXF frm = new EventTeamMatchesXF();
            //frm.MdiParent = Program.MF;
            frm.ttID = ttID;
            frm.etID = etID;
            frm.etNM = view.GetFocusedRowCellDisplayText("ETID");
            frm.CS = CS;
            frm.Lap = Lap;
            frm.Grp = Grp;

            DialogResult dr = frm.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                elTableAdapter.ClearBeforeFill = false;
                //this.elTableAdapter.FillByGRP(this.dataSet.EL, ttID, etID, CS, Lap, Grp);
                this.elTableAdapter.FillByET(this.dataSet.EL, ttID, etID);  // Degisiklik Event deki her seyi degistirebilir.
                elTableAdapter.ClearBeforeFill = true;

                view.FocusedRowHandle = view.FindRow(rowObj);
            }
        }

		private void editParticipantToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//elkGridControl.EmbeddedNavigator.Cl
			//Program.MF.GridControl_EmbeddedNavigator_ButtonClick(elkGridView, e, this);
			colPTID1.Visible = true;
			colPTID2.Visible = true;
			/*
			var view = sender as GridView;
			
			string LAP = view.GetFocusedRowCellValue("LAP").ToString();
			
			if(LAP != "1")
				e.Cancel = true;
		 */
		}

		private void elkGridView_ShowingEditor(object sender, CancelEventArgs e)
		{
			var view = sender as GridView;
			if(!view.IsGroupRow(view.FocusedRowHandle)) {
				string LAP = view.GetFocusedRowCellValue("LAP").ToString();

				if(view.FocusedColumn == colPTID1 || view.FocusedColumn == colPTID2)
					if(LAP != "1")
						e.Cancel = true;
			}
		}
	}
}