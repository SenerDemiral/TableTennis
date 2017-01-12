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
using DevExpress.XtraGrid;
using DevExpress.Data;

namespace TableTennis
{
    public partial class ParticipantsXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;
        public string ttNM = "";

        public ParticipantsXF()
        {
            InitializeComponent();
            Program.MF.GridControlInit(ptGridControl);
        }

        public void Save()
        {
            try
            {
                this.Validate();
                this.ptBindingSource.EndEdit();
                this.ptTableAdapter.Update(this.dataSet.PT);

                this.ptTableAdapter.FillByTT(this.dataSet.PT, ttID);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void LoadData()
        {
            this.ptTableAdapter.FillByTT(this.dataSet.PT, ttID);
        }
        
        private void ParticipantsXF_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0}->{1}", ttID, "Participants");
            this.ccTableAdapter.FillByTT(this.dataSet.CC, ttID);
            LoadData();
        }

        private void ptGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as GridView;

            int ptID = Program.MF.GET_PK("PT");
            view.SetFocusedRowCellValue("PTID", ptID);
            view.SetFocusedRowCellValue("TTID", ttID);
        }

        private void ptGridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            Program.MF.GridControl_EmbeddedNavigator_ButtonClick(ptGridView, e, this);
        }

        private void ptGridView_KeyUp(object sender, KeyEventArgs e)
        {
            Program.MF.GridView_KeyUp(sender, e);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = ptGridControl;

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
            
            phf.Header.Content.AddRange(new string[] { "", "", "Participants" });
            phf.Header.LineAlignment = BrickAlignment.Far;
            phf.Header.Font = Font;

            phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", "Participants", "© Şener Demiral" });
            phf.Footer.LineAlignment = BrickAlignment.Near;

            link.CreateDocument();
            link.ShowPreview();
        }

        int discontinuedProductsCount;
        decimal customSum;
        
        private void ptGridView_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e)
        {
            // Get the summary ID. 
            int summaryID = Convert.ToInt32((e.Item as GridSummaryItem).Tag);
            GridView View = sender as GridView;

            // Initialization 
            if (e.SummaryProcess == CustomSummaryProcess.Start)
            {
                discontinuedProductsCount = 0;
                customSum = 0;
            }
            // Calculation 
            if (e.SummaryProcess == CustomSummaryProcess.Calculate)
            {
                bool isDiscontinued = View.GetRowCellValue(e.RowHandle, "PN").ToString() == "" ? true : false;
                switch (summaryID)
                {
                    case 1: // The total summary calculated against the 'UnitPrice' column. 
                        if (!isDiscontinued) customSum += Convert.ToDecimal(e.FieldValue);
                        break;
                    case 2: // The group summary. 
                        if (isDiscontinued) discontinuedProductsCount++;
                        break;
                }
            }
            // Finalization 
            if (e.SummaryProcess == CustomSummaryProcess.Finalize)
            {
                switch (summaryID)
                {
                    case 1:
                        e.TotalValue = customSum;
                        break;
                    case 2:
                        e.TotalValue = discontinuedProductsCount;
                        break;
                }
            }
        }

    }
}