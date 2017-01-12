namespace TableTennis
{
    partial class EventClassificationXF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataSet = new TableTennis.DataSet();
            this.ecBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ecTableAdapter = new TableTennis.DataSetTableAdapters.ECTableAdapter();
            this.ecGridControl = new DevExpress.XtraGrid.GridControl();
            this.ecGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.etRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.etBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colIDX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.etTableAdapter = new TableTennis.DataSetTableAdapters.ETTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.CaseSensitive = true;
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ecBindingSource
            // 
            this.ecBindingSource.DataMember = "EC";
            this.ecBindingSource.DataSource = this.dataSet;
            // 
            // ecTableAdapter
            // 
            this.ecTableAdapter.ClearBeforeFill = true;
            // 
            // ecGridControl
            // 
            this.ecGridControl.DataSource = this.ecBindingSource;
            this.ecGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ecGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.ecGridControl_EmbeddedNavigator_ButtonClick);
            this.ecGridControl.Location = new System.Drawing.Point(0, 0);
            this.ecGridControl.MainView = this.ecGridView;
            this.ecGridControl.Name = "ecGridControl";
            this.ecGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.etRepositoryItemLookUpEdit});
            this.ecGridControl.Size = new System.Drawing.Size(663, 297);
            this.ecGridControl.TabIndex = 2;
            this.ecGridControl.Tag = "EventClassification";
            this.ecGridControl.UseEmbeddedNavigator = true;
            this.ecGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ecGridView});
            // 
            // ecGridView
            // 
            this.ecGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ecGridView.Appearance.GroupRow.Options.UseFont = true;
            this.ecGridView.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ecGridView.AppearancePrint.GroupRow.Options.UseFont = true;
            this.ecGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTTID,
            this.colETID,
            this.colIDX,
            this.colPC,
            this.colPNAME});
            this.ecGridView.GridControl = this.ecGridControl;
            this.ecGridView.GroupCount = 1;
            this.ecGridView.GroupFormat = "{0} -> [#image]{1} {2}";
            this.ecGridView.GroupRowHeight = 30;
            this.ecGridView.Name = "ecGridView";
            this.ecGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.ecGridView.OptionsView.AllowCellMerge = true;
            this.ecGridView.OptionsView.ColumnAutoWidth = false;
            this.ecGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colETID, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colIDX, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.ecGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ecGridView_InitNewRow);
            this.ecGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ecGridView_KeyUp);
            // 
            // colTTID
            // 
            this.colTTID.FieldName = "TTID";
            this.colTTID.Name = "colTTID";
            this.colTTID.OptionsColumn.AllowEdit = false;
            this.colTTID.OptionsColumn.AllowFocus = false;
            this.colTTID.Width = 83;
            // 
            // colETID
            // 
            this.colETID.Caption = "Event";
            this.colETID.ColumnEdit = this.etRepositoryItemLookUpEdit;
            this.colETID.FieldName = "ETID";
            this.colETID.Name = "colETID";
            this.colETID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            this.colETID.Visible = true;
            this.colETID.VisibleIndex = 0;
            this.colETID.Width = 83;
            // 
            // etRepositoryItemLookUpEdit
            // 
            this.etRepositoryItemLookUpEdit.AutoHeight = false;
            this.etRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.etRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FULLNAME", "FULLNAME", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ETID", "ETID", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.etRepositoryItemLookUpEdit.DataSource = this.etBindingSource;
            this.etRepositoryItemLookUpEdit.DisplayMember = "FULLNAME";
            this.etRepositoryItemLookUpEdit.Name = "etRepositoryItemLookUpEdit";
            this.etRepositoryItemLookUpEdit.ValueMember = "ETID";
            // 
            // etBindingSource
            // 
            this.etBindingSource.DataMember = "ET";
            this.etBindingSource.DataSource = this.dataSet;
            // 
            // colIDX
            // 
            this.colIDX.AppearanceCell.Options.UseTextOptions = true;
            this.colIDX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIDX.AppearanceHeader.Options.UseTextOptions = true;
            this.colIDX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colIDX.Caption = "Idx";
            this.colIDX.FieldName = "IDX";
            this.colIDX.Name = "colIDX";
            this.colIDX.OptionsColumn.FixedWidth = true;
            this.colIDX.Visible = true;
            this.colIDX.VisibleIndex = 0;
            this.colIDX.Width = 67;
            // 
            // colPC
            // 
            this.colPC.AppearanceCell.Options.UseTextOptions = true;
            this.colPC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPC.AppearanceHeader.Options.UseTextOptions = true;
            this.colPC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPC.FieldName = "PC";
            this.colPC.Name = "colPC";
            this.colPC.OptionsColumn.FixedWidth = true;
            this.colPC.Visible = true;
            this.colPC.VisibleIndex = 1;
            this.colPC.Width = 55;
            // 
            // colPNAME
            // 
            this.colPNAME.Caption = "Participants";
            this.colPNAME.FieldName = "PCNM";
            this.colPNAME.Name = "colPNAME";
            this.colPNAME.Visible = true;
            this.colPNAME.VisibleIndex = 2;
            this.colPNAME.Width = 200;
            // 
            // etTableAdapter
            // 
            this.etTableAdapter.ClearBeforeFill = true;
            // 
            // EventClassificationXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 297);
            this.Controls.Add(this.ecGridControl);
            this.Name = "EventClassificationXF";
            this.Text = "EventClassificationXF";
            this.Load += new System.EventHandler(this.EventClassificationXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ecGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource ecBindingSource;
        private DataSetTableAdapters.ECTableAdapter ecTableAdapter;
        private DevExpress.XtraGrid.GridControl ecGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ecGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTTID;
        private DevExpress.XtraGrid.Columns.GridColumn colETID;
        private DevExpress.XtraGrid.Columns.GridColumn colPC;
        private DevExpress.XtraGrid.Columns.GridColumn colIDX;
        private DevExpress.XtraGrid.Columns.GridColumn colPNAME;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit etRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource etBindingSource;
        private DataSetTableAdapters.ETTableAdapter etTableAdapter;
    }
}