namespace TableTennis
{
    partial class EventKnockoutLapXF
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
			DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
			this.dataSet = new TableTennis.DataSet();
			this.elBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.elTableAdapter = new TableTennis.DataSetTableAdapters.ELTableAdapter();
			this.elkGridControl = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.teamMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.editParticipantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.elkGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTTID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colETID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.etRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.etBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.colCS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.csRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colLAP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.lapRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colGRP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grpRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colGI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.giRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colPTID1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ptRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.ptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.colPTID2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGR = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grRepositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
			this.colPC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCPC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPCNM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.grRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.etTableAdapter = new TableTennis.DataSetTableAdapters.ETTableAdapter();
			this.ptTableAdapter = new TableTennis.DataSetTableAdapters.PTTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.elBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.elkGridControl)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.elkGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.etRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.csRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.lapRepositoryItemTextEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grpRepositoryItemTextEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.giRepositoryItemTextEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grRepositoryItemTextEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grRepositoryItemImageComboBox)).BeginInit();
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
			// elkGridControl
			// 
			this.elkGridControl.ContextMenuStrip = this.contextMenuStrip;
			this.elkGridControl.DataSource = this.elBindingSource;
			this.elkGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.elkGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.elpGridControl_EmbeddedNavigator_ButtonClick);
			this.elkGridControl.Location = new System.Drawing.Point(0, 0);
			this.elkGridControl.MainView = this.elkGridView;
			this.elkGridControl.Name = "elkGridControl";
			this.elkGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.etRepositoryItemLookUpEdit,
            this.ptRepositoryItemLookUpEdit,
            this.grRepositoryItemImageComboBox,
            this.grRepositoryItemTextEdit,
            this.giRepositoryItemTextEdit,
            this.lapRepositoryItemTextEdit,
            this.grpRepositoryItemTextEdit,
            this.csRepositoryItemImageComboBox});
			this.elkGridControl.ShowOnlyPredefinedDetails = true;
			this.elkGridControl.Size = new System.Drawing.Size(701, 314);
			this.elkGridControl.TabIndex = 2;
			this.elkGridControl.UseEmbeddedNavigator = true;
			this.elkGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.elkGridView});
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.resultsToolStripMenuItem,
            this.teamMatchesToolStripMenuItem,
            this.toolStripSeparator1,
            this.editParticipantToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(245, 98);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// resultsToolStripMenuItem
			// 
			this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
			this.resultsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.resultsToolStripMenuItem.Text = "Results";
			this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
			// 
			// teamMatchesToolStripMenuItem
			// 
			this.teamMatchesToolStripMenuItem.Name = "teamMatchesToolStripMenuItem";
			this.teamMatchesToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.teamMatchesToolStripMenuItem.Text = "Team Matches";
			this.teamMatchesToolStripMenuItem.Click += new System.EventHandler(this.teamMatchesToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(241, 6);
			// 
			// editParticipantToolStripMenuItem
			// 
			this.editParticipantToolStripMenuItem.Name = "editParticipantToolStripMenuItem";
			this.editParticipantToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.editParticipantToolStripMenuItem.Text = "Show Participant Entry Columns";
			this.editParticipantToolStripMenuItem.Click += new System.EventHandler(this.editParticipantToolStripMenuItem_Click);
			// 
			// elkGridView
			// 
			this.elkGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.elkGridView.Appearance.GroupRow.Options.UseFont = true;
			this.elkGridView.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.elkGridView.AppearancePrint.GroupRow.Options.UseFont = true;
			this.elkGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
			gridFormatRule1.ApplyToRow = true;
			gridFormatRule1.Name = "Format0";
			formatConditionRuleExpression1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			formatConditionRuleExpression1.Appearance.Options.UseFont = true;
			formatConditionRuleExpression1.Expression = "[CS] = \' \' And [GR] = \'W\'";
			gridFormatRule1.Rule = formatConditionRuleExpression1;
			gridFormatRule2.ApplyToRow = true;
			gridFormatRule2.Name = "Format1";
			formatConditionRuleExpression2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			formatConditionRuleExpression2.Appearance.Options.UseFont = true;
			formatConditionRuleExpression2.Expression = "[CS] = \'-\'";
			gridFormatRule2.Rule = formatConditionRuleExpression2;
			gridFormatRule3.ApplyToRow = true;
			gridFormatRule3.Name = "Format2";
			formatConditionRuleExpression3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			formatConditionRuleExpression3.Appearance.Options.UseFont = true;
			formatConditionRuleExpression3.Expression = "[CS] = \'-\' And [GR] = \'W\'";
			gridFormatRule3.Rule = formatConditionRuleExpression3;
			this.elkGridView.FormatRules.Add(gridFormatRule1);
			this.elkGridView.FormatRules.Add(gridFormatRule2);
			this.elkGridView.FormatRules.Add(gridFormatRule3);
			this.elkGridView.GridControl = this.elkGridControl;
			this.elkGridView.GroupCount = 3;
			this.elkGridView.GroupFormat = "{0} -> [#image]{1} {2}";
			this.elkGridView.GroupRowHeight = 30;
			this.elkGridView.Name = "elkGridView";
			this.elkGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.elkGridView.OptionsBehavior.AutoExpandAllGroups = true;
			this.elkGridView.OptionsEditForm.EditFormColumnCount = 1;
			this.elkGridView.OptionsEditForm.PopupEditFormWidth = 600;
			this.elkGridView.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
			this.elkGridView.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
			this.elkGridView.OptionsPrint.PrintHeader = false;
			this.elkGridView.OptionsView.AllowCellMerge = true;
			this.elkGridView.OptionsView.ColumnAutoWidth = false;
			this.elkGridView.OptionsView.EnableAppearanceEvenRow = true;
			this.elkGridView.OptionsView.ShowChildrenInGroupPanel = true;
			this.elkGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colETID, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCS, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLAP, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.elkGridView.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.elkGridView_ShowingEditor);
			this.elkGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.elpGridView_InitNewRow);
			this.elkGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.elkGridView_FocusedRowChanged);
			this.elkGridView.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.elpGridView_RowDeleted);
			this.elkGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.elpGridView_KeyUp);
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
			this.colCS.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colCS.AppearanceCell.Options.UseFont = true;
			this.colCS.Caption = "C/C";
			this.colCS.ColumnEdit = this.csRepositoryItemImageComboBox;
			this.colCS.FieldName = "CS";
			this.colCS.Name = "colCS";
			this.colCS.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colCS.Visible = true;
			this.colCS.VisibleIndex = 0;
			// 
			// csRepositoryItemImageComboBox
			// 
			this.csRepositoryItemImageComboBox.AutoHeight = false;
			this.csRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.csRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Competition", " ", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Consolation [-]", "-", -1)});
			this.csRepositoryItemImageComboBox.Name = "csRepositoryItemImageComboBox";
			// 
			// colLAP
			// 
			this.colLAP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colLAP.AppearanceCell.Options.UseFont = true;
			this.colLAP.AppearanceCell.Options.UseTextOptions = true;
			this.colLAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLAP.AppearanceHeader.Options.UseTextOptions = true;
			this.colLAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLAP.Caption = "Lap";
			this.colLAP.ColumnEdit = this.lapRepositoryItemTextEdit;
			this.colLAP.FieldName = "LAP";
			this.colLAP.Name = "colLAP";
			this.colLAP.OptionsColumn.FixedWidth = true;
			this.colLAP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colLAP.Visible = true;
			this.colLAP.VisibleIndex = 0;
			this.colLAP.Width = 57;
			// 
			// lapRepositoryItemTextEdit
			// 
			this.lapRepositoryItemTextEdit.AutoHeight = false;
			this.lapRepositoryItemTextEdit.Mask.BeepOnError = true;
			this.lapRepositoryItemTextEdit.Mask.EditMask = "[1-5]";
			this.lapRepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.lapRepositoryItemTextEdit.Name = "lapRepositoryItemTextEdit";
			// 
			// colGRP
			// 
			this.colGRP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
			this.colGRP.Width = 57;
			// 
			// grpRepositoryItemTextEdit
			// 
			this.grpRepositoryItemTextEdit.AutoHeight = false;
			this.grpRepositoryItemTextEdit.Mask.BeepOnError = true;
			this.grpRepositoryItemTextEdit.Mask.EditMask = "[a-zA-Z0-9]";
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
			this.giRepositoryItemTextEdit.Mask.EditMask = "1|2";
			this.giRepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.giRepositoryItemTextEdit.Name = "giRepositoryItemTextEdit";
			// 
			// colPTID1
			// 
			this.colPTID1.Caption = "Participant 1";
			this.colPTID1.ColumnEdit = this.ptRepositoryItemLookUpEdit;
			this.colPTID1.FieldName = "PTID1";
			this.colPTID1.Name = "colPTID1";
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
			this.colPTID2.Width = 120;
			// 
			// colGR
			// 
			this.colGR.AppearanceCell.Options.UseTextOptions = true;
			this.colGR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGR.AppearanceHeader.Options.UseTextOptions = true;
			this.colGR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGR.ColumnEdit = this.grRepositoryItemTextEdit;
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
			// grRepositoryItemTextEdit
			// 
			this.grRepositoryItemTextEdit.AutoHeight = false;
			this.grRepositoryItemTextEdit.Mask.BeepOnError = true;
			this.grRepositoryItemTextEdit.Mask.EditMask = "W|L| ";
			this.grRepositoryItemTextEdit.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
			this.grRepositoryItemTextEdit.Name = "grRepositoryItemTextEdit";
			this.grRepositoryItemTextEdit.EditValueChanged += new System.EventHandler(this.grRepositoryItemTextEdit_EditValueChanged);
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
			this.colPC.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colPC.ToolTip = "Participant(s) Code";
			this.colPC.Visible = true;
			this.colPC.VisibleIndex = 2;
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
			this.colCPC.OptionsColumn.ReadOnly = true;
			this.colCPC.Visible = true;
			this.colCPC.VisibleIndex = 5;
			this.colCPC.Width = 50;
			// 
			// colPCNM
			// 
			this.colPCNM.Caption = "Participant(s) Name";
			this.colPCNM.FieldName = "PCNM";
			this.colPCNM.Name = "colPCNM";
			this.colPCNM.OptionsColumn.AllowEdit = false;
			this.colPCNM.OptionsColumn.AllowFocus = false;
			this.colPCNM.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colPCNM.ToolTip = "Participant(s) Name";
			this.colPCNM.Visible = true;
			this.colPCNM.VisibleIndex = 3;
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
			// etTableAdapter
			// 
			this.etTableAdapter.ClearBeforeFill = true;
			// 
			// ptTableAdapter
			// 
			this.ptTableAdapter.ClearBeforeFill = true;
			// 
			// EventKnockoutLapXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(701, 314);
			this.Controls.Add(this.elkGridControl);
			this.Name = "EventKnockoutLapXF";
			this.Text = "EventKnockoutLapXF";
			this.Load += new System.EventHandler(this.EventPreliminaryLapXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.elBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.elkGridControl)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.elkGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.etRepositoryItemLookUpEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.csRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.lapRepositoryItemTextEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grpRepositoryItemTextEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.giRepositoryItemTextEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptRepositoryItemLookUpEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grRepositoryItemTextEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grRepositoryItemImageComboBox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource elBindingSource;
        private DataSetTableAdapters.ELTableAdapter elTableAdapter;
        private DevExpress.XtraGrid.GridControl elkGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView elkGridView;
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
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit lapRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit grpRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit giRepositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit grRepositoryItemTextEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colCS;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox csRepositoryItemImageComboBox;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamMatchesToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem editParticipantToolStripMenuItem;
	}
}