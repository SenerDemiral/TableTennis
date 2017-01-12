namespace TableTennis
{
    partial class EventTeamMatchesXF
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
            this.etmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etmTableAdapter = new TableTennis.DataSetTableAdapters.ETMTableAdapter();
            this.etmGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.createTeamMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTeamMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.etmGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTTID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colETID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGRP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPTI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLGI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRGI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLPTID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ptRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.ptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colLPTID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRPTID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRPTID2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colS1N = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NSrepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colS2N = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colS3N = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colS4N = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colS5N = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SSrepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colLRNM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ptTableAdapter = new TableTennis.DataSetTableAdapters.PTTableAdapter();
            this.queriesTableAdapter = new TableTennis.DataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etmGridControl)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.etmGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSrepositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSrepositoryItemTextEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet
            // 
            this.dataSet.CaseSensitive = true;
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // etmBindingSource
            // 
            this.etmBindingSource.DataMember = "ETM";
            this.etmBindingSource.DataSource = this.dataSet;
            // 
            // etmTableAdapter
            // 
            this.etmTableAdapter.ClearBeforeFill = true;
            // 
            // etmGridControl
            // 
            this.etmGridControl.ContextMenuStrip = this.contextMenuStrip;
            this.etmGridControl.DataSource = this.etmBindingSource;
            this.etmGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.etmGridControl.Location = new System.Drawing.Point(0, 0);
            this.etmGridControl.MainView = this.etmGridView;
            this.etmGridControl.Name = "etmGridControl";
            this.etmGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ptRepositoryItemLookUpEdit,
            this.NSrepositoryItemTextEdit,
            this.SSrepositoryItemTextEdit});
            this.etmGridControl.Size = new System.Drawing.Size(883, 307);
            this.etmGridControl.TabIndex = 2;
            this.etmGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.etmGridView});
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.createTeamMatchesToolStripMenuItem,
            this.deleteTeamMatchesToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(189, 76);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // createTeamMatchesToolStripMenuItem
            // 
            this.createTeamMatchesToolStripMenuItem.Name = "createTeamMatchesToolStripMenuItem";
            this.createTeamMatchesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.createTeamMatchesToolStripMenuItem.Text = "Create Team Matches";
            this.createTeamMatchesToolStripMenuItem.Click += new System.EventHandler(this.createTeamMatchesToolStripMenuItem_Click);
            // 
            // deleteTeamMatchesToolStripMenuItem
            // 
            this.deleteTeamMatchesToolStripMenuItem.Name = "deleteTeamMatchesToolStripMenuItem";
            this.deleteTeamMatchesToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.deleteTeamMatchesToolStripMenuItem.Text = "Delete Team Matches";
            this.deleteTeamMatchesToolStripMenuItem.Click += new System.EventHandler(this.deleteTeamMatchesToolStripMenuItem_Click);
            // 
            // etmGridView
            // 
            this.etmGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTTID,
            this.colETID,
            this.colCS,
            this.colLAP,
            this.colGRP,
            this.colGI,
            this.colPTI,
            this.colLGI,
            this.colRGI,
            this.colLPTID1,
            this.colLPTID2,
            this.colRPTID1,
            this.colRPTID2,
            this.colS1N,
            this.colS2N,
            this.colS3N,
            this.colS4N,
            this.colS5N,
            this.colSS,
            this.colLRNM});
            this.etmGridView.GridControl = this.etmGridControl;
            this.etmGridView.GroupCount = 1;
            this.etmGridView.GroupFormat = " [#image]{1} {2}";
            this.etmGridView.Name = "etmGridView";
            this.etmGridView.OptionsPrint.PrintHeader = false;
            this.etmGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLRNM, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colTTID
            // 
            this.colTTID.FieldName = "TTID";
            this.colTTID.Name = "colTTID";
            this.colTTID.OptionsColumn.AllowEdit = false;
            this.colTTID.OptionsColumn.AllowFocus = false;
            this.colTTID.OptionsColumn.ReadOnly = true;
            // 
            // colETID
            // 
            this.colETID.FieldName = "ETID";
            this.colETID.Name = "colETID";
            this.colETID.OptionsColumn.AllowEdit = false;
            this.colETID.OptionsColumn.AllowFocus = false;
            this.colETID.OptionsColumn.ReadOnly = true;
            // 
            // colCS
            // 
            this.colCS.FieldName = "CS";
            this.colCS.Name = "colCS";
            this.colCS.OptionsColumn.AllowEdit = false;
            this.colCS.OptionsColumn.AllowFocus = false;
            this.colCS.OptionsColumn.ReadOnly = true;
            // 
            // colLAP
            // 
            this.colLAP.FieldName = "LAP";
            this.colLAP.Name = "colLAP";
            this.colLAP.OptionsColumn.AllowEdit = false;
            this.colLAP.OptionsColumn.AllowFocus = false;
            this.colLAP.OptionsColumn.ReadOnly = true;
            // 
            // colGRP
            // 
            this.colGRP.FieldName = "GRP";
            this.colGRP.Name = "colGRP";
            this.colGRP.OptionsColumn.AllowEdit = false;
            this.colGRP.OptionsColumn.AllowFocus = false;
            this.colGRP.OptionsColumn.ReadOnly = true;
            // 
            // colGI
            // 
            this.colGI.FieldName = "GI";
            this.colGI.Name = "colGI";
            this.colGI.OptionsColumn.AllowEdit = false;
            this.colGI.OptionsColumn.AllowFocus = false;
            this.colGI.OptionsColumn.ReadOnly = true;
            // 
            // colPTI
            // 
            this.colPTI.Caption = "PtI";
            this.colPTI.FieldName = "PTI";
            this.colPTI.Name = "colPTI";
            this.colPTI.OptionsColumn.AllowEdit = false;
            this.colPTI.OptionsColumn.AllowFocus = false;
            this.colPTI.OptionsColumn.ReadOnly = true;
            // 
            // colLGI
            // 
            this.colLGI.FieldName = "LGI";
            this.colLGI.Name = "colLGI";
            this.colLGI.OptionsColumn.AllowEdit = false;
            this.colLGI.OptionsColumn.AllowFocus = false;
            this.colLGI.OptionsColumn.ReadOnly = true;
            // 
            // colRGI
            // 
            this.colRGI.FieldName = "RGI";
            this.colRGI.Name = "colRGI";
            this.colRGI.OptionsColumn.AllowEdit = false;
            this.colRGI.OptionsColumn.AllowFocus = false;
            this.colRGI.OptionsColumn.ReadOnly = true;
            // 
            // colLPTID1
            // 
            this.colLPTID1.Caption = "«- Participant";
            this.colLPTID1.ColumnEdit = this.ptRepositoryItemLookUpEdit;
            this.colLPTID1.FieldName = "LPTID1";
            this.colLPTID1.Name = "colLPTID1";
            this.colLPTID1.Visible = true;
            this.colLPTID1.VisibleIndex = 0;
            this.colLPTID1.Width = 162;
            // 
            // ptRepositoryItemLookUpEdit
            // 
            this.ptRepositoryItemLookUpEdit.AutoHeight = false;
            this.ptRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ptRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FULLNAME", "Name", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PTID", "PTID", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.ptRepositoryItemLookUpEdit.DataSource = this.ptBindingSource;
            this.ptRepositoryItemLookUpEdit.DisplayMember = "FULLNAME";
            this.ptRepositoryItemLookUpEdit.Name = "ptRepositoryItemLookUpEdit";
            this.ptRepositoryItemLookUpEdit.NullText = "";
            this.ptRepositoryItemLookUpEdit.ValueMember = "PTID";
            // 
            // ptBindingSource
            // 
            this.ptBindingSource.DataMember = "PT";
            this.ptBindingSource.DataSource = this.dataSet;
            // 
            // colLPTID2
            // 
            this.colLPTID2.ColumnEdit = this.ptRepositoryItemLookUpEdit;
            this.colLPTID2.FieldName = "LPTID2";
            this.colLPTID2.Name = "colLPTID2";
            // 
            // colRPTID1
            // 
            this.colRPTID1.Caption = "-» Participant";
            this.colRPTID1.ColumnEdit = this.ptRepositoryItemLookUpEdit;
            this.colRPTID1.FieldName = "RPTID1";
            this.colRPTID1.Name = "colRPTID1";
            this.colRPTID1.Visible = true;
            this.colRPTID1.VisibleIndex = 1;
            this.colRPTID1.Width = 162;
            // 
            // colRPTID2
            // 
            this.colRPTID2.ColumnEdit = this.ptRepositoryItemLookUpEdit;
            this.colRPTID2.FieldName = "RPTID2";
            this.colRPTID2.Name = "colRPTID2";
            // 
            // colS1N
            // 
            this.colS1N.AppearanceCell.Options.UseTextOptions = true;
            this.colS1N.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colS1N.AppearanceHeader.Options.UseTextOptions = true;
            this.colS1N.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colS1N.ColumnEdit = this.NSrepositoryItemTextEdit;
            this.colS1N.FieldName = "S1N";
            this.colS1N.Name = "colS1N";
            this.colS1N.Visible = true;
            this.colS1N.VisibleIndex = 2;
            this.colS1N.Width = 50;
            // 
            // NSrepositoryItemTextEdit
            // 
            this.NSrepositoryItemTextEdit.AutoHeight = false;
            this.NSrepositoryItemTextEdit.Mask.EditMask = "\\d{1,2}--\\d{1,2}";
            this.NSrepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.NSrepositoryItemTextEdit.Name = "NSrepositoryItemTextEdit";
            // 
            // colS2N
            // 
            this.colS2N.AppearanceCell.Options.UseTextOptions = true;
            this.colS2N.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colS2N.AppearanceHeader.Options.UseTextOptions = true;
            this.colS2N.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colS2N.ColumnEdit = this.NSrepositoryItemTextEdit;
            this.colS2N.FieldName = "S2N";
            this.colS2N.Name = "colS2N";
            this.colS2N.Visible = true;
            this.colS2N.VisibleIndex = 3;
            this.colS2N.Width = 50;
            // 
            // colS3N
            // 
            this.colS3N.AppearanceCell.Options.UseTextOptions = true;
            this.colS3N.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colS3N.AppearanceHeader.Options.UseTextOptions = true;
            this.colS3N.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colS3N.ColumnEdit = this.NSrepositoryItemTextEdit;
            this.colS3N.FieldName = "S3N";
            this.colS3N.Name = "colS3N";
            this.colS3N.Visible = true;
            this.colS3N.VisibleIndex = 4;
            this.colS3N.Width = 50;
            // 
            // colS4N
            // 
            this.colS4N.AppearanceCell.Options.UseTextOptions = true;
            this.colS4N.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colS4N.AppearanceHeader.Options.UseTextOptions = true;
            this.colS4N.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colS4N.ColumnEdit = this.NSrepositoryItemTextEdit;
            this.colS4N.FieldName = "S4N";
            this.colS4N.Name = "colS4N";
            this.colS4N.Visible = true;
            this.colS4N.VisibleIndex = 5;
            this.colS4N.Width = 50;
            // 
            // colS5N
            // 
            this.colS5N.AppearanceCell.Options.UseTextOptions = true;
            this.colS5N.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colS5N.AppearanceHeader.Options.UseTextOptions = true;
            this.colS5N.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colS5N.ColumnEdit = this.NSrepositoryItemTextEdit;
            this.colS5N.FieldName = "S5N";
            this.colS5N.Name = "colS5N";
            this.colS5N.Visible = true;
            this.colS5N.VisibleIndex = 6;
            this.colS5N.Width = 50;
            // 
            // colSS
            // 
            this.colSS.AppearanceCell.Options.UseTextOptions = true;
            this.colSS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSS.AppearanceHeader.Options.UseTextOptions = true;
            this.colSS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSS.ColumnEdit = this.SSrepositoryItemTextEdit;
            this.colSS.FieldName = "SS";
            this.colSS.Name = "colSS";
            this.colSS.Visible = true;
            this.colSS.VisibleIndex = 7;
            this.colSS.Width = 50;
            // 
            // SSrepositoryItemTextEdit
            // 
            this.SSrepositoryItemTextEdit.AutoHeight = false;
            this.SSrepositoryItemTextEdit.Mask.BeepOnError = true;
            this.SSrepositoryItemTextEdit.Mask.EditMask = "[0-5]--[0-5]";
            this.SSrepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.SSrepositoryItemTextEdit.Name = "SSrepositoryItemTextEdit";
            // 
            // colLRNM
            // 
            this.colLRNM.Caption = " Teams";
            this.colLRNM.FieldName = "LRNM";
            this.colLRNM.Name = "colLRNM";
            this.colLRNM.Visible = true;
            this.colLRNM.VisibleIndex = 19;
            // 
            // ptTableAdapter
            // 
            this.ptTableAdapter.ClearBeforeFill = true;
            // 
            // EventTeamMatchesXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 307);
            this.Controls.Add(this.etmGridControl);
            this.Name = "EventTeamMatchesXF";
            this.Text = "EventTeamMatchesXF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventTeamMatchesXF_FormClosing);
            this.Load += new System.EventHandler(this.EventTeamMatchesXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etmBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etmGridControl)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.etmGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NSrepositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSrepositoryItemTextEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource etmBindingSource;
        private DataSetTableAdapters.ETMTableAdapter etmTableAdapter;
        private DevExpress.XtraGrid.GridControl etmGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView etmGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTTID;
        private DevExpress.XtraGrid.Columns.GridColumn colETID;
        private DevExpress.XtraGrid.Columns.GridColumn colCS;
        private DevExpress.XtraGrid.Columns.GridColumn colLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colGRP;
        private DevExpress.XtraGrid.Columns.GridColumn colGI;
        private DevExpress.XtraGrid.Columns.GridColumn colPTI;
        private DevExpress.XtraGrid.Columns.GridColumn colLGI;
        private DevExpress.XtraGrid.Columns.GridColumn colRGI;
        private DevExpress.XtraGrid.Columns.GridColumn colLPTID1;
        private DevExpress.XtraGrid.Columns.GridColumn colLPTID2;
        private DevExpress.XtraGrid.Columns.GridColumn colRPTID1;
        private DevExpress.XtraGrid.Columns.GridColumn colRPTID2;
        private DevExpress.XtraGrid.Columns.GridColumn colS1N;
        private DevExpress.XtraGrid.Columns.GridColumn colS2N;
        private DevExpress.XtraGrid.Columns.GridColumn colS3N;
        private DevExpress.XtraGrid.Columns.GridColumn colS4N;
        private DevExpress.XtraGrid.Columns.GridColumn colS5N;
        private DevExpress.XtraGrid.Columns.GridColumn colSS;
        private DevExpress.XtraGrid.Columns.GridColumn colLRNM;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ptRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource ptBindingSource;
        private DataSetTableAdapters.PTTableAdapter ptTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit NSrepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit SSrepositoryItemTextEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem createTeamMatchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTeamMatchesToolStripMenuItem;
        private DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
    }
}