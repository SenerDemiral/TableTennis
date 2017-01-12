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
using DevExpress.XtraPrinting;

namespace TableTennis
{
    public partial class EventTeamMatchesXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;
        public string etID = "";
        public string etNM = "";
        public string CS = "";
        public string Lap = "";
        public string Grp = "";
        
        public EventTeamMatchesXF()
        {
            InitializeComponent();
        }

        private void Save()
        {
            this.Validate();
            this.etmBindingSource.EndEdit();
            this.etmTableAdapter.Update(this.dataSet.ETM);
        }

        private void LoadData()
        {
            this.etmTableAdapter.Fill(this.dataSet.ETM, ttID, etID, CS, Lap, Grp);
        }

        private void EventTeamMatchesXF_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0}->{1}->{2}->Grp {3} Results", etNM, CS == " " ? "Competition" : "Consolation", Lap == " " ? "Preliminary" : "Knockouts " + Lap + ".Round", Grp);
            
            LoadData();
            this.ptTableAdapter.FillByTT(this.dataSet.PT, ttID);
        }

        private void EventTeamMatchesXF_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Validate();
            this.etmBindingSource.EndEdit();

            if (dataSet.HasChanges())
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

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintingSystem ps = new PrintingSystem();
            PrintableComponentLink link = new PrintableComponentLink(ps);
            link.Component = etmGridControl;

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

        private void createTeamMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msj = queriesTableAdapter.ETM_MODIFY(ttID, etID, CS, Lap, Grp, "C").ToString();
            if (msj != "")
                MessageBox.Show(msj);
            LoadData();
        }

        private void deleteTeamMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the current Team Matches?", "Confirm deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string msj = queriesTableAdapter.ETM_MODIFY(ttID, etID, CS, Lap, Grp, "D").ToString();
                if (msj != "")
                    MessageBox.Show(msj);
                LoadData();
            }
        }
    }
}