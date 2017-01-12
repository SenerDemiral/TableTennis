namespace TableTennis
{
    partial class EventPreliminaryLapXF
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
			this.elBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.elTableAdapter = new TableTennis.DataSetTableAdapters.ELTableAdapter();
			this.elpGridControl = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.teamMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.createRemoveEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.elpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTTID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colETID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.etRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.etBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.colCS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.csRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colLAP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGRP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grpRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colGI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.giRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colPTID1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ptRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.ptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.colPTID2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGR = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCPC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPCNM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.giRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.grpRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.etTableAdapter = new TableTennis.DataSetTableAdapters.ETTableAdapter();
			this.ptTableAdapter = new TableTennis.DataSetTableAdapters.PTTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.elBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.elpGridControl)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.elpGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.etRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.csRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpRepositoryItemTextEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.giRepositoryItemTextEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.giRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpRepositoryItemImageComboBox)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet
			// 
			this.dataSet.CaseSensitive = true;
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// elBindingSource
			// 
			this.elBindingSource.DataMember = "EL";
			this.elBindingSource.DataSource = this.dataSet;
			// 
			// elTableAdapter
			// 
			this.elTableAdapter.ClearBeforeFill = true;
			// 
			// elpGridControl
			// 
			this.elpGridControl.ContextMenuStrip = this.contextMenuStrip;
			this.elpGridControl.DataSource = this.elBindingSource;
			this.elpGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.elpGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.elpGridControl_EmbeddedNavigator_ButtonClick);
			this.elpGridControl.Location = new System.Drawing.Point(0, 0);
			this.elpGridControl.MainView = this.elpGridView;
			this.elpGridControl.Name = "elpGridControl";
			this.elpGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.etRepositoryItemLookUpEdit,
            this.ptRepositoryItemLookUpEdit,
            this.grRepositoryItemImageComboBox,
            this.giRepositoryItemImageComboBox,
            this.grpRepositoryItemImageComboBox,
            this.grpRepositoryItemTextEdit,
            this.giRepositoryItemTextEdit,
            this.csRepositoryItemImageComboBox});
			this.elpGridControl.ShowOnlyPredefinedDetails = true;
			this.elpGridControl.Size = new System.Drawing.Size(701, 314);
			this.elpGridControl.TabIndex = 2;
			this.elpGridControl.UseEmbeddedNavigator = true;
			this.elpGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.elpGridView});
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.teamMatchesToolStripMenuItem,
            this.toolStripSeparator1,
            this.createRemoveEventsToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(256, 120);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// resultsToolStripMenuItem
			// 
			this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
			this.resultsToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.resultsToolStripMenuItem.Text = "Results / Sonuçlar";
			this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
			// 
			// teamMatchesToolStripMenuItem
			// 
			this.teamMatchesToolStripMenuItem.Name = "teamMatchesToolStripMenuItem";
			this.teamMatchesToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.teamMatchesToolStripMenuItem.Text = "TeamMatches / TakımMaçları";
			this.teamMatchesToolStripMenuItem.Click += new System.EventHandler(this.teamMatchesToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(252, 6);
			// 
			// createRemoveEventsToolStripMenuItem
			// 
			this.createRemoveEventsToolStripMenuItem.Name = "createRemoveEventsToolStripMenuItem";
			this.createRemoveEventsToolStripMenuItem.Size = new System.Drawing.Size(255, 22);
			this.createRemoveEventsToolStripMenuItem.Text = "Create|RemovePlan / PlanYarat|Sil ";
			this.createRemoveEventsToolStripMenuItem.Click += new System.EventHandler(this.createRemoveEventsToolStripMenuItem_Click);
			// 
			// elpGridView
			// 
			this.elpGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.elpGridView.Appearance.GroupRow.Options.UseFont = true;
			this.elpGridView.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.elpGridView.AppearancePrint.GroupRow.Options.UseFont = true;
			this.elpGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTTID,
            this.colETID,
            this.colCS,
            this.colLAP,
            this.colGRP,
            this.colGI,
            this.colPTID1,
            this.colPTID2,
            this.colGR,
            this.colPC,
            this.colCPC,
            this.colPCNM});
			this.elpGridView.GridControl = this.elpGridControl;
			this.elpGridView.GroupCount = 1;
			this.elpGridView.GroupFormat = "{0} -> [#image]{1} {2}";
			this.elpGridView.GroupRowHeight = 30;
			this.elpGridView.Name = "elpGridView";
			this.elpGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.elpGridView.OptionsBehavior.AutoExpandAllGroups = true;
			this.elpGridView.OptionsPrint.PrintHeader = false;
			this.elpGridView.OptionsView.AllowCellMerge = true;
			this.elpGridView.OptionsView.ColumnAutoWidth = false;
			this.elpGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colETID, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.elpGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.elpGridView_InitNewRow);
			this.elpGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.elpGridView_FocusedRowChanged);
			this.elpGridView.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.elpGridView_RowDeleted);
			this.elpGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.elpGridView_KeyUp);
			// 
			// colTTID
			// 
			this.colTTID.FieldName = "TTID";
			this.colTTID.Name = "colTTID";
			this.colTTID.OptionsColumn.AllowEdit = false;
			this.colTTID.OptionsColumn.AllowFocus = false;
			this.colTTID.OptionsColumn.FixedWidth = true;
			this.colTTID.Width = 50;
			// 
			// colETID
			// 
			this.colETID.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colETID.AppearanceCell.Options.UseFont = true;
			this.colETID.Caption = "Event";
			this.colETID.ColumnEdit = this.etRepositoryItemLookUpEdit;
			this.colETID.FieldName = "ETID";
			this.colETID.Name = "colETID";
			this.colETID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colETID.Visible = true;
			this.colETID.VisibleIndex = 0;
			this.colETID.Width = 114;
			// 
			// etRepositoryItemLookUpEdit
			// 
			this.etRepositoryItemLookUpEdit.AutoHeight = false;
			this.etRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.etRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FULLNAME", "Name", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ETID", "Event", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
			this.etRepositoryItemLookUpEdit.DataSource = this.etBindingSource;
			this.etRepositoryItemLookUpEdit.DisplayMember = "FULLNAME";
			this.etRepositoryItemLookUpEdit.Name = "etRepositoryItemLookUpEdit";
			this.etRepositoryItemLookUpEdit.NullText = "";
			this.etRepositoryItemLookUpEdit.ValueMember = "ETID";
			// 
			// etBindingSource
			// 
			this.etBindingSource.DataMember = "ET";
			this.etBindingSource.DataSource = this.dataSet;
			// 
			// colCS
			// 
			this.colCS.Caption = "Comp/Cons";
			this.colCS.ColumnEdit = this.csRepositoryItemImageComboBox;
			this.colCS.FieldName = "CS";
			this.colCS.Name = "colCS";
			this.colCS.OptionsColumn.AllowEdit = false;
			this.colCS.OptionsColumn.AllowFocus = false;
			// 
			// csRepositoryItemImageComboBox
			// 
			this.csRepositoryItemImageComboBox.AutoHeight = false;
			this.csRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.csRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("-", " ", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Competition", "C", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Consolation", "S", -1)});
			this.csRepositoryItemImageComboBox.Name = "csRepositoryItemImageComboBox";
			// 
			// colLAP
			// 
			this.colLAP.AppearanceCell.Options.UseTextOptions = true;
			this.colLAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLAP.AppearanceHeader.Options.UseTextOptions = true;
			this.colLAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLAP.Caption = "Lap";
			this.colLAP.FieldName = "LAP";
			this.colLAP.Name = "colLAP";
			this.colLAP.OptionsColumn.AllowEdit = false;
			this.colLAP.OptionsColumn.AllowFocus = false;
			this.colLAP.OptionsColumn.FixedWidth = true;
			this.colLAP.Width = 35;
			// 
			// colGRP
			// 
			this.colGRP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colGRP.AppearanceCell.Options.UseFont = true;
			this.colGRP.AppearanceCell.Options.UseTextOptions = true;
			this.colGRP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGRP.AppearanceHeader.Options.UseTextOptions = true;
			this.colGRP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGRP.Caption = "Grp";
			this.colGRP.ColumnEdit = this.grpRepositoryItemTextEdit;
			this.colGRP.FieldName = "GRP";
			this.colGRP.Name = "colGRP";
			this.colGRP.OptionsColumn.FixedWidth = true;
			this.colGRP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colGRP.Visible = true;
			this.colGRP.VisibleIndex = 0;
			this.colGRP.Width = 55;
			// 
			// grpRepositoryItemTextEdit
			// 
			this.grpRepositoryItemTextEdit.AutoHeight = false;
			this.grpRepositoryItemTextEdit.Mask.BeepOnError = true;
			this.grpRepositoryItemTextEdit.Mask.EditMask = "[A-P]";
			this.grpRepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.grpRepositoryItemTextEdit.Name = "grpRepositoryItemTextEdit";
			// 
			// colGI
			// 
			this.colGI.AppearanceCell.Options.UseTextOptions = true;
			this.colGI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGI.AppearanceHeader.Options.UseTextOptions = true;
			this.colGI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGI.ColumnEdit = this.giRepositoryItemTextEdit;
			this.colGI.FieldName = "GI";
			this.colGI.Name = "colGI";
			this.colGI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.colGI.OptionsColumn.FixedWidth = true;
			this.colGI.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colGI.Visible = true;
			this.colGI.VisibleIndex = 1;
			this.colGI.Width = 36;
			// 
			// giRepositoryItemTextEdit
			// 
			this.giRepositoryItemTextEdit.AutoHeight = false;
			this.giRepositoryItemTextEdit.Mask.BeepOnError = true;
			this.giRepositoryItemTextEdit.Mask.EditMask = "[1-7]";
			this.giRepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.giRepositoryItemTextEdit.Name = "giRepositoryItemTextEdit";
			// 
			// colPTID1
			// 
			this.colPTID1.Caption = "Participant 1";
			this.colPTID1.ColumnEdit = this.ptRepositoryItemLookUpEdit;
			this.colPTID1.FieldName = "PTID1";
			this.colPTID1.Name = "colPTID1";
			this.colPTID1.Visible = true;
			this.colPTID1.VisibleIndex = 2;
			this.colPTID1.Width = 120;
			// 
			// ptRepositoryItemLookUpEdit
			// 
			this.ptRepositoryItemLookUpEdit.AutoHeight = false;
			this.ptRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ptRepositoryItemLookUpEdit.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FULLNAME", "FULLNAME", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TYP", "TYP", 28, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "NAME", 38, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PTID", "PTID", 46, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
			this.ptRepositoryItemLookUpEdit.DataSource = this.ptBindingSource;
			this.ptRepositoryItemLookUpEdit.DisplayMember = "FULLNAME";
			this.ptRepositoryItemLookUpEdit.HeaderClickMode = DevExpress.XtraEditors.Controls.HeaderClickMode.AutoSearch;
			this.ptRepositoryItemLookUpEdit.Name = "ptRepositoryItemLookUpEdit";
			this.ptRepositoryItemLookUpEdit.NullText = "";
			this.ptRepositoryItemLookUpEdit.ValueMember = "PTID";
			// 
			// ptBindingSource
			// 
			this.ptBindingSource.DataMember = "PT";
			this.ptBindingSource.DataSource = this.dataSet;
			// 
			// colPTID2
			// 
			this.colPTID2.Caption = "Participant 2 (Double)";
			this.colPTID2.ColumnEdit = this.ptRepositoryItemLookUpEdit;
			this.colPTID2.FieldName = "PTID2";
			this.colPTID2.Name = "colPTID2";
			this.colPTID2.Visible = true;
			this.colPTID2.VisibleIndex = 3;
			this.colPTID2.Width = 120;
			// 
			// colGR
			// 
			this.colGR.AppearanceCell.Options.UseTextOptions = true;
			this.colGR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGR.AppearanceHeader.Options.UseTextOptions = true;
			this.colGR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGR.ColumnEdit = this.giRepositoryItemTextEdit;
			this.colGR.FieldName = "GR";
			this.colGR.Name = "colGR";
			this.colGR.OptionsColumn.AllowEdit = false;
			this.colGR.OptionsColumn.AllowFocus = false;
			this.colGR.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.colGR.OptionsColumn.FixedWidth = true;
			this.colGR.OptionsColumn.ReadOnly = true;
			this.colGR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colGR.ToolTip = "Grup Rank";
			this.colGR.Visible = true;
			this.colGR.VisibleIndex = 4;
			this.colGR.Width = 36;
			// 
			// colPC
			// 
			this.colPC.AppearanceCell.Options.UseTextOptions = true;
			this.colPC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPC.AppearanceHeader.Options.UseTextOptions = true;
			this.colPC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPC.FieldName = "PC";
			this.colPC.Name = "colPC";
			this.colPC.OptionsColumn.AllowEdit = false;
			this.colPC.OptionsColumn.AllowFocus = false;
			this.colPC.OptionsColumn.FixedWidth = true;
			this.colPC.Width = 50;
			// 
			// colCPC
			// 
			this.colCPC.AppearanceCell.Options.UseTextOptions = true;
			this.colCPC.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCPC.AppearanceHeader.Options.UseTextOptions = true;
			this.colCPC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCPC.Caption = "cPC";
			this.colCPC.FieldName = "CPC";
			this.colCPC.Name = "colCPC";
			this.colCPC.OptionsColumn.AllowEdit = false;
			this.colCPC.OptionsColumn.AllowFocus = false;
			this.colCPC.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.colCPC.OptionsColumn.FixedWidth = true;
			this.colCPC.Visible = true;
			this.colCPC.VisibleIndex = 5;
			this.colCPC.Width = 50;
			// 
			// colPCNM
			// 
			this.colPCNM.FieldName = "PCNM";
			this.colPCNM.Name = "colPCNM";
			this.colPCNM.OptionsColumn.AllowEdit = false;
			this.colPCNM.OptionsColumn.AllowFocus = false;
			this.colPCNM.Width = 180;
			// 
			// grRepositoryItemImageComboBox
			// 
			this.grRepositoryItemImageComboBox.AutoHeight = false;
			this.grRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.grRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("-", null, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("1", "1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("2", "2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("3", "3", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("4", "4", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("5", "5", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("6", "6", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("7", "7", -1)});
			this.grRepositoryItemImageComboBox.Name = "grRepositoryItemImageComboBox";
			// 
			// giRepositoryItemImageComboBox
			// 
			this.giRepositoryItemImageComboBox.AutoHeight = false;
			this.giRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.giRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("1", "1", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("2", "2", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("3", "3", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("4", "4", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("5", "5", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("6", "6", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("7", "7", -1)});
			this.giRepositoryItemImageComboBox.Name = "giRepositoryItemImageComboBox";
			// 
			// grpRepositoryItemImageComboBox
			// 
			this.grpRepositoryItemImageComboBox.AutoHeight = false;
			this.grpRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.grpRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("A", "A", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("B", "B", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("C", "C", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("D", "D", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("E", "E", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("F", "F", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("G", "G", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("H", "H", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("I", "I", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("J", "J", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("K", "K", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("L", "L", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("M", "M", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("N", "N", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("O", "O", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("P", "P", -1)});
			this.grpRepositoryItemImageComboBox.Name = "grpRepositoryItemImageComboBox";
			// 
			// etTableAdapter
			// 
			this.etTableAdapter.ClearBeforeFill = true;
			// 
			// ptTableAdapter
			// 
			this.ptTableAdapter.ClearBeforeFill = true;
			// 
			// EventPreliminaryLapXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(701, 314);
			this.Controls.Add(this.elpGridControl);
			this.Name = "EventPreliminaryLapXF";
			this.Text = "EventPreliminaryLapXF";
			this.Load += new System.EventHandler(this.EventPreliminaryLapXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.elBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.elpGridControl)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.elpGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.etRepositoryItemLookUpEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.csRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpRepositoryItemTextEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.giRepositoryItemTextEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptRepositoryItemLookUpEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.giRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpRepositoryItemImageComboBox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource elBindingSource;
        private DataSetTableAdapters.ELTableAdapter elTableAdapter;
        private DevExpress.XtraGrid.GridControl elpGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView elpGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTTID;
        private DevExpress.XtraGrid.Columns.GridColumn colETID;
        private DevExpress.XtraGrid.Columns.GridColumn colLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colGRP;
        private DevExpress.XtraGrid.Columns.GridColumn colGI;
        private DevExpress.XtraGrid.Columns.GridColumn colPTID1;
        private DevExpress.XtraGrid.Columns.GridColumn colPTID2;
        private DevExpress.XtraGrid.Columns.GridColumn colGR;
        private DevExpress.XtraGrid.Columns.GridColumn colPC;
        private DevExpress.XtraGrid.Columns.GridColumn colCPC;
        private DevExpress.XtraGrid.Columns.GridColumn colPCNM;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit etRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource etBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ptRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource ptBindingSource;
        private DataSetTableAdapters.ETTableAdapter etTableAdapter;
        private DataSetTableAdapters.PTTableAdapter ptTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox grRepositoryItemImageComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit grpRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit giRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox giRepositoryItemImageComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox grpRepositoryItemImageComboBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colCS;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox csRepositoryItemImageComboBox;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamMatchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem createRemoveEventsToolStripMenuItem;
    }
}