using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraPrinting;

namespace TableTennis
{
	public partial class KnockoutResultsXF : DevExpress.XtraEditors.XtraForm
	{
		public int ttID = 0;
		public string ttNM = "";
		public string etID = "";
		public string etNM = "";
		public int NOK = 0;

		public KnockoutResultsXF()
		{
			InitializeComponent();
		}

		private void KnockoutResultsXF_Load(object sender, EventArgs e)
		{
			this.Text = string.Format("{0}->{1}->{2}", ttID, etID, "KnockoutResults");

			if(NOK == 0)
				return;
			
			if(NOK < 64) {
				colL7.Visible = false;
				colL7P.Visible = false;
			}
			if(NOK < 32) {
				colL6.Visible = false;
				colL6P.Visible = false;
			}
			if(NOK < 16) {
				colL5.Visible = false;
				colL5P.Visible = false;
			}
			if(NOK < 8) {
				colL4.Visible = false;
				colL4P.Visible = false;
			}

			this.kRTableAdapter.Fill(this.dataSet.KR, ttID, etID);

			gridView1.BestFitColumns();
		}

		private void hideR7ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colL7.Visible = false;
			colL7P.Visible = false;
		}

		private void hideR6ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colL7.Visible = false;
			colL7P.Visible = false;
			colL6.Visible = false;
			colL6P.Visible = false;

		}

		private void hideR5ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colL7.Visible = false;
			colL7P.Visible = false;
			colL6.Visible = false;
			colL6P.Visible = false;
			colL5.Visible = false;
			colL5P.Visible = false;

		}

		private void hideRoudCodesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			colL7.Visible = hideRoudCodesToolStripMenuItem.Checked;
			colL6.Visible = hideRoudCodesToolStripMenuItem.Checked;
			colL5.Visible = hideRoudCodesToolStripMenuItem.Checked;
			colL4.Visible = hideRoudCodesToolStripMenuItem.Checked;
			colL3.Visible = hideRoudCodesToolStripMenuItem.Checked;
			colL2.Visible = hideRoudCodesToolStripMenuItem.Checked;
			colL1.Visible = hideRoudCodesToolStripMenuItem.Checked;
			//hideRoudCodesToolStripMenuItem.Checked = !hideRoudCodesToolStripMenuItem.Checked;

		}

		private void exportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			PrintingSystem ps = new PrintingSystem();
			PrintableComponentLink link = new PrintableComponentLink(ps);
			link.Component = kRGridControl;

            string info = string.Format("{0}->{1}->KnockoutResults", ttNM, etNM);


			// https://documentation.devexpress.com/#WindowsForms/CustomDocument3435
			// Create an image and add it to the collection.
			// link.Images.Add(Image.FromFile("..\\..\\omela.png"));

			// Create PageHeaderArea object and specify its content.
			// The third (rightmost) section of the page header will contain
			// the time when the report is printed and the first image from 
			// the image collection of this link.

			//phf.Header.Content.AddRange(new string[] { "", "", "[Time Printed][Image 0]" });


			link.PaperKind = System.Drawing.Printing.PaperKind.A4;
			link.Landscape = false;
			link.Margins.Left = 50;
			link.Margins.Right = 50;
			link.Margins.Top = 40;
			link.Margins.Bottom = 50;

			PageHeaderFooter phf = link.PageHeaderFooter as PageHeaderFooter;

			var antetRow = Program.MF.getAntet(ttID);
			if(!antetRow.IsHEADERNull())
				link.RtfReportHeader = antetRow.HEADER;
			if(!antetRow.IsFOOTERNull())
				link.RtfReportFooter = antetRow.FOOTER;

			var Font = new Font("Tahoma", 12, FontStyle.Bold);

			phf.Header.Content.AddRange(new string[] { "", "", info });
			phf.Header.LineAlignment = BrickAlignment.Far;
			phf.Header.Font = Font;

			phf.Footer.Content.AddRange(new string[] { "[Date Printed] [Time Printed]", info, "© Şener Demiral" });
			phf.Footer.LineAlignment = BrickAlignment.Near;

			link.CreateDocument();
			link.ShowPreview();

		}
	}
}
