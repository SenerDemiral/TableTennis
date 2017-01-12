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
    public partial class EventClassificationXF : DevExpress.XtraEditors.XtraForm
    {
        public int ttID = 0;
        public string etID = "";

        public EventClassificationXF()
        {
            InitializeComponent();
            Program.MF.GridControlInit(ecGridControl);
        }

        public void Save()
        {
            try
            {
                this.Validate();
                this.ecBindingSource.EndEdit();
                this.ecTableAdapter.Update(this.dataSet.EC);

                this.ecTableAdapter.FillByTT(this.dataSet.EC, ttID);
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
                this.Text = string.Format("{0}->{1}", ttID, "Classification / Sıralama");
                this.ecTableAdapter.FillByTT(this.dataSet.EC, ttID);
            }
            else
            {
                this.Text = string.Format("{0}->{1}->{2}", ttID, etID, "Classification / Sıralama");
                this.ecTableAdapter.FillByET(this.dataSet.EC, ttID, etID);
            }
        }
        
        private void EventClassificationXF_Load(object sender, EventArgs e)
        {
            this.etTableAdapter.FillByTT(this.dataSet.ET, ttID);
            LoadData();
        }

        private void ecGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            var view = sender as GridView;

            view.SetFocusedRowCellValue("TTID", ttID);
        }

        private void ecGridControl_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            Program.MF.GridControl_EmbeddedNavigator_ButtonClick(ecGridView, e, this);
        }

        private void ecGridView_KeyUp(object sender, KeyEventArgs e)
        {
            Program.MF.GridView_KeyUp(sender, e);
        }

    }
}