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
    public partial class MainXF : DevExpress.XtraEditors.XtraForm
    {
        public MainXF()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.F))
            {
                MessageBox.Show("What the Ctrl+F?");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        public void GridView_KeyUp(object sender, KeyEventArgs e)
        {
            // GridView icin ShortCut uretir
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;

            if (e.KeyData == (Keys.Control | Keys.Insert))
                view.GridControl.EmbeddedNavigator.Buttons.DoClick(view.GridControl.EmbeddedNavigator.Buttons.Append);
            if (e.KeyData == (Keys.Control | Keys.Delete))
                view.GridControl.EmbeddedNavigator.Buttons.DoClick(view.GridControl.EmbeddedNavigator.Buttons.Remove);
            if (e.KeyData == (Keys.Alt | Keys.S))
                view.GridControl.EmbeddedNavigator.Buttons.DoClick(view.GridControl.EmbeddedNavigator.Buttons.EndEdit);
        }

        private void MainXF_Load(object sender, EventArgs e)
        {
            TournamentsXF frm = new TournamentsXF();
            frm.MdiParent = this;
            frm.Show();
        }

        public int GET_PK(string tbl)
        {
            return (int)queriesTableAdapter.GET_PK(tbl);
        }

        public void AddRow(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            // GroupRow lari da

            int currentRow;
            currentRow = view.FocusedRowHandle;

            if (currentRow < 0)
                currentRow = view.GetDataRowHandleByGroupRowHandle(currentRow);

            view.AddNewRow();

            if (view.GroupedColumns.Count == 0)
                return;

            // Initialize group values 
            foreach (DevExpress.XtraGrid.Columns.GridColumn groupColumn in view.GroupedColumns)
            {
                object value = view.GetRowCellValue(currentRow, groupColumn);
                view.SetRowCellValue(view.FocusedRowHandle, groupColumn, value);
            }

            view.UpdateCurrentRow();
            view.MakeRowVisible(view.FocusedRowHandle, true);
            view.ShowEditor();
        }

        public DialogResult RemoveRow()
        {
            return MessageBox.Show("Do you want to delete the current row?", "Confirm deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        public void GridControlInit(DevExpress.XtraGrid.GridControl gControl)
        {
            gControl.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            gControl.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            gControl.EmbeddedNavigator.Buttons.Prev.Visible = false;
            gControl.EmbeddedNavigator.Buttons.Next.Visible = false;

            gControl.EmbeddedNavigator.TextStringFormat = gControl.Tag + " {0} / {1} ";

            gControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false; // Save
            gControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;// Revert

            DevExpress.XtraEditors.NavigatorCustomButton buttonBos1;
            buttonBos1 = gControl.EmbeddedNavigator.Buttons.CustomButtons.Add();

            DevExpress.XtraEditors.NavigatorCustomButton buttonSave;
            buttonSave = gControl.EmbeddedNavigator.Buttons.CustomButtons.Add();
            buttonSave.Tag = "save";
            buttonSave.Hint = "Save";
            buttonSave.ImageIndex = 9;

            DevExpress.XtraEditors.NavigatorCustomButton buttonBos2;
            buttonBos2 = gControl.EmbeddedNavigator.Buttons.CustomButtons.Add();

            DevExpress.XtraEditors.NavigatorCustomButton buttonRevert;
            buttonRevert = gControl.EmbeddedNavigator.Buttons.CustomButtons.Add();
            buttonRevert.Tag = "revert";
            buttonRevert.Hint = "Revert";
            buttonRevert.ImageIndex = 10;
        }

        public void GridView_RowChanged(DevExpress.XtraGrid.Views.Grid.GridView view, DataSet dataSet)
        {
            if (dataSet.HasChanges())
            {
                view.GridControl.EmbeddedNavigator.Buttons.EndEdit.Enabled = true;
                view.GridControl.EmbeddedNavigator.Buttons.CancelEdit.Enabled = true;
            }
        }

        public void GridControl_EmbeddedNavigator_ButtonClick(DevExpress.XtraGrid.Views.Grid.GridView view, NavigatorButtonClickEventArgs e, object senderForm)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Append)
            {
                //Program.MF.AddRow(view);
                //dynamic frm = senderForm;
                //frm.DuplicateRow();
                
                view.AddNewRow();
                view.OptionsEditForm.EditFormColumnCount = 1;
                view.OptionsEditForm.PopupEditFormWidth = 300;

                view.OptionsBehavior.EditingMode = GridEditingMode.EditForm;
                view.ShowPopupEditForm();
                //view.ShowEditForm();
                view.OptionsBehavior.EditingMode = GridEditingMode.Default;
                e.Handled = true;

                
                //Program.MF.AddRow(view);
                //view.ShowPopupEditForm();
                //e.Handled = true;
            }
            if (e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (MessageBox.Show("Do you want to delete the current row?", "Confirm deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    e.Handled = true;
                }
            }
            if (e.Button.ButtonType == NavigatorButtonType.Edit)
            {
                view.OptionsView.AllowCellMerge = false;
                e.Handled = true;
            }
            if (e.Button.ButtonType == NavigatorButtonType.EndEdit) // Save
            {
                dynamic frm = senderForm;
                frm.Save();
                e.Handled = true;
            }
            if (e.Button.ButtonType == NavigatorButtonType.CancelEdit) // Revert
            {
                if (MessageBox.Show("Do you want to revert all changes?", "Confirm reverting", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    dynamic frm = senderForm;
                    frm.LoadData();
                }
                e.Handled = true;
            }
            if (e.Button.ButtonType == NavigatorButtonType.Custom && "save".Equals(e.Button.Tag)) // Save
            {
                view.GridControl.EmbeddedNavigator.Buttons.DoClick(view.GridControl.EmbeddedNavigator.Buttons.EndEdit);
            }
            if (e.Button.ButtonType == NavigatorButtonType.Custom && "revert".Equals(e.Button.Tag)) // Revert
            {
                view.GridControl.EmbeddedNavigator.Buttons.DoClick(view.GridControl.EmbeddedNavigator.Buttons.CancelEdit);
            }
        }

        public DataSet.ANTETRow getAntet(int ttID)
        {
            antetTableAdapter.FillByTT(dataSet.ANTET, ttID);
            return (DataSet.ANTETRow)dataSet.ANTET.Rows[0];
        }
    }
}