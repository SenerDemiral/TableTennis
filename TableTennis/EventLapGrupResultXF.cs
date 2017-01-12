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
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraPrinting;

namespace TableTennis
{
    public partial class EventLapGrupResultXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;
        public string etID = "";
        public string etNM = "";
        public string CS = "";
        public string Lap = "";
        public string Grp = "";

        int nor = 0;
        bool hasChanges = false;

        public EventLapGrupResultXF()
        {
            InitializeComponent();
        }

        private void Save()
        {
            this.Validate();
            this.elrBindingSource.EndEdit();
            this.elrTableAdapter.Update(this.dataSet.ELR);
        }

        public void LoadData()
        {
            nor = this.elrTableAdapter.Fill(this.dataSet.ELR, ttID, etID, CS, Lap, Grp);

            for (int i = 0; i < elrBandedGridView.Bands.Count; i++)
                if (Convert.ToInt16(elrBandedGridView.Bands[i].Tag) > nor)
                    elrBandedGridView.Bands[i].Visible = false;

            if (nor == 2)
                grRepositoryItemTextEdit.Mask.EditMask = "W|L";
            else
            {
                grRepositoryItemTextEdit.Mask.EditMask = string.Format("[ ,1-{0}]", nor);   // blank ve 1-7
                /*
                string m = "";
                for (int i = 1; i <= nor; i++)
                {
                    m += i.ToString();
                    if (i != nor)
                        m += '|';
                }
                grRepositoryItemTextEdit.Mask.EditMask = m;*/
            }

        }

        private void EventLapGrupResultXF_Load(object sender, EventArgs e)
        {
			this.Text = string.Format("{0}->{1}->{2}->Grp {3} Results", etNM, CS == " " ? "Competition" : "Consolation", Lap == " " ? "Preliminary" : "Knockouts " + Lap + ".Round", Grp);

			LoadData();

            string msj = queriesTableAdapter.EL_GR_CHECK(ttID, etID, CS, Lap, Grp).ToString();
            if (msj != "")
            {
                MessageBox.Show(msj);
                colGR.OptionsColumn.ReadOnly = true;
            }

            this.Width -= (7 - nor) * 80;
            this.Height = nor * 22 + 100;
        }

        private void EventLapGrupResultXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.elrBindingSource.EndEdit();

            if (hasChanges || dataSet.HasChanges())
            {
                DialogResult dr = MessageBox.Show("Do you want to Save?", "Confirm Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Save();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void elrBandedGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            var view = sender as BandedGridView;

            int GI = Convert.ToInt16(view.GetFocusedRowCellValue("GI"));
            int band = Convert.ToInt16((view.FocusedColumn as BandedGridColumn).OwnerBand.Tag);
            if (GI == band)
                e.Cancel = true;
        }

        private void grRepositoryItemTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (nor == 2)   // Sadece Knockot icin, 2 oyuncu olur
            {
                int rh = elrBandedGridView.FocusedRowHandle;

                var edt = sender as TextEdit;
                string GR = edt.EditValue.ToString();
                if (!string.IsNullOrWhiteSpace(GR))
                    GR = GR == "W" ? "L" : "W";

                rh = rh == 0 ? 1 : 0;
                elrBandedGridView.SetRowCellValue(rh, "GR", GR);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hasChanges = true;
            Save();
            LoadData();
        }

        private void elrBandedGridView_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            var view = sender as BandedGridView;

            int GI = Convert.ToInt16(view.GetRowCellValue(e.RowHandle, "GI"));
            int band = Convert.ToInt16((e.Column as BandedGridColumn).OwnerBand.Tag);

            if (GI == band)
                e.Appearance.BackColor = Color.Black;

            // https://documentation.devexpress.com/#WindowsForms/CustomDocument763
        }

        private void NSrepositoryItemTextEdit_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void NSrepositoryItemTextEdit_Leave(object sender, EventArgs e)
        {

        }

        private void elrBandedGridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            
        }

        private void NSrepositoryItemTextEdit_Modified(object sender, EventArgs e)
        {/*
            var view = elrBandedGridView;

            string fcn = "NS" + view.GetFocusedRowCellValue("GI").ToString();
            int drh = Convert.ToInt16((view.FocusedColumn as BandedGridColumn).OwnerBand.Tag) - 1;
            //string fcn = "NS" + drh.ToString();//view.FocusedColumn.FieldName;

            string org = (sender as TextEdit).EditValue.ToString();
            view.SetRowCellValue(drh, fcn, swapScore(org));*/
        }

        private string swapScore(string org)
        {
            string dst = "";

            string[] da = org.Split(new string[] { "--" }, StringSplitOptions.None);

            dst = da[1] + "--" + da[0];
            return dst;
        }

        private void NSrepositoryItemTextEdit_Validating(object sender, CancelEventArgs e)
        {
            var view = elrBandedGridView;

            string fcn = "NS" + view.GetFocusedRowCellValue("GI").ToString();
            int drh = Convert.ToInt16((view.FocusedColumn as BandedGridColumn).OwnerBand.Tag) - 1;
            
            string org = (sender as TextEdit).EditValue.ToString();
            view.SetRowCellValue(drh, fcn, swapScore(org));
        }

        private void SSrepositoryItemTextEdit_Validating(object sender, CancelEventArgs e)
        {
            var view = elrBandedGridView;

            string fcn = "SS" + view.GetFocusedRowCellValue("GI").ToString();
            int drh = Convert.ToInt16((view.FocusedColumn as BandedGridColumn).OwnerBand.Tag) - 1;

            string org = (sender as TextEdit).EditValue.ToString();
            view.SetRowCellValue(drh, fcn, swapScore(org));
        }

        private void elrBandedGridView_CustomDrawBandHeader(object sender, BandHeaderCustomDrawEventArgs e)
        {
            if (e.Band == null) return;
            if (e.Band.AppearanceHeader.BackColor != Color.Empty)
            {
                e.Info.AllowColoring = true;
            }
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = elrGridControl;

            // https://documentation.devexpress.com/#WindowsForms/CustomDocument3435
            // Create an image and add it to the collection.
            // link.Images.Add(Image.FromFile("..\\..\\omela.png"));

            // Create PageHeaderArea object and specify its content.
            // The third (rightmost) section of the page header will contain
            // the time when the report is printed and the first image from 
            // the image collection of this link.

            //phf.Header.Content.AddRange(new string[] { "", "", "[Time Printed][Image 0]" });


            link.PaperKind = System.Drawing.Printing.PaperKind.A4;
            link.Landscape = true;
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

            //string h = string.Format("{0}, {1}, {2} Lap, Grup {3}, Team Matches", etID, CS == " " ? "Competition" : "Consolation", Lap == " " ? "Preliminary" : "Knockout: " + Lap, Grp);
            phf.Header.Content.AddRange(new string[] { "", "", this.Text });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", this.Text, "© Şener Demiral" });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }
    }
}