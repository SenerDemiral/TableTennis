namespace TableTennis
{
    partial class ParticipantsXF
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
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
			this.colTYP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.typRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.dataSet = new TableTennis.DataSet();
			this.ptBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ptTableAdapter = new TableTennis.DataSetTableAdapters.PTTableAdapter();
			this.ptGridControl = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ptGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colPTID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTTID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCCID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ccRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.ccBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.colPN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colJND = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colETIDS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ccTableAdapter = new TableTennis.DataSetTableAdapters.CCTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.typRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ptGridControl)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ptGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ccRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ccBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// colTYP
			// 
			this.colTYP.Caption = "Typ";
			this.colTYP.ColumnEdit = this.typRepositoryItemImageComboBox;
			this.colTYP.FieldName = "TYP";
			this.colTYP.Name = "colTYP";
			this.colTYP.OptionsColumn.FixedWidth = true;
			this.colTYP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colTYP.Visible = true;
			this.colTYP.VisibleIndex = 1;
			this.colTYP.Width = 50;
			// 
			// typRepositoryItemImageComboBox
			// 
			this.typRepositoryItemImageComboBox.AutoHeight = false;
			this.typRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.typRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Men", "M", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Women", "W", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Team", "T", -1)});
			this.typRepositoryItemImageComboBox.Name = "typRepositoryItemImageComboBox";
			// 
			// dataSet
			// 
			this.dataSet.CaseSensitive = true;
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ptBindingSource
			// 
			this.ptBindingSource.DataMember = "PT";
			this.ptBindingSource.DataSource = this.dataSet;
			this.ptBindingSource.Filter = "PTID > 0";
			// 
			// ptTableAdapter
			// 
			this.ptTableAdapter.ClearBeforeFill = true;
			// 
			// ptGridControl
			// 
			this.ptGridControl.ContextMenuStrip = this.contextMenuStrip;
			this.ptGridControl.DataSource = this.ptBindingSource;
			this.ptGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ptGridControl.EmbeddedNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ptGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.ptGridControl_EmbeddedNavigator_ButtonClick);
			this.ptGridControl.Location = new System.Drawing.Point(0, 0);
			this.ptGridControl.MainView = this.ptGridView;
			this.ptGridControl.Name = "ptGridControl";
			this.ptGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.typRepositoryItemImageComboBox,
            this.ccRepositoryItemLookUpEdit});
			this.ptGridControl.Size = new System.Drawing.Size(632, 306);
			this.ptGridControl.TabIndex = 2;
			this.ptGridControl.Tag = "Participants";
			this.ptGridControl.UseEmbeddedNavigator = true;
			this.ptGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ptGridView});
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(108, 26);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// ptGridView
			// 
			this.ptGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ptGridView.Appearance.GroupRow.Options.UseFont = true;
			this.ptGridView.AppearancePrint.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.ptGridView.AppearancePrint.GroupRow.Options.UseFont = true;
			this.ptGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPTID,
            this.colTTID,
            this.colTYP,
            this.colNAME,
            this.colCCID,
            this.colPN,
            this.colJND,
            this.colETIDS});
			gridFormatRule1.ApplyToRow = true;
			gridFormatRule1.Column = this.colTYP;
			gridFormatRule1.Name = "Format0";
			formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.Blue;
			formatConditionRuleValue1.Appearance.Options.UseForeColor = true;
			formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
			formatConditionRuleValue1.Value1 = "M";
			gridFormatRule1.Rule = formatConditionRuleValue1;
			gridFormatRule1.StopIfTrue = true;
			gridFormatRule2.ApplyToRow = true;
			gridFormatRule2.Column = this.colTYP;
			gridFormatRule2.Name = "Format1";
			formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			formatConditionRuleValue2.Appearance.Options.UseForeColor = true;
			formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
			formatConditionRuleValue2.Value1 = "W";
			gridFormatRule2.Rule = formatConditionRuleValue2;
			gridFormatRule2.StopIfTrue = true;
			gridFormatRule3.ApplyToRow = true;
			gridFormatRule3.Column = this.colTYP;
			gridFormatRule3.Name = "Format2";
			formatConditionRuleValue3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			formatConditionRuleValue3.Appearance.Options.UseFont = true;
			formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Equal;
			formatConditionRuleValue3.Value1 = "T";
			gridFormatRule3.Rule = formatConditionRuleValue3;
			gridFormatRule3.StopIfTrue = true;
			this.ptGridView.FormatRules.Add(gridFormatRule1);
			this.ptGridView.FormatRules.Add(gridFormatRule2);
			this.ptGridView.FormatRules.Add(gridFormatRule3);
			this.ptGridView.GridControl = this.ptGridControl;
			this.ptGridView.GroupCount = 1;
			this.ptGridView.GroupFormat = "{0} -> [#image]{1} {2}";
			this.ptGridView.GroupRowHeight = 30;
			this.ptGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "PN", null, "  Total: {0}", ((short)(2))),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JND", null, "Joined: {0}")});
			this.ptGridView.Name = "ptGridView";
			this.ptGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.ptGridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
			this.ptGridView.OptionsBehavior.SummariesIgnoreNullValues = true;
			this.ptGridView.OptionsPrint.PrintHeader = false;
			this.ptGridView.OptionsView.AllowCellMerge = true;
			this.ptGridView.OptionsView.ColumnAutoWidth = false;
			this.ptGridView.OptionsView.ShowFooter = true;
			this.ptGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTYP, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.ptGridView.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.ptGridView_CustomSummaryCalculate);
			this.ptGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ptGridView_InitNewRow);
			this.ptGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ptGridView_KeyUp);
			// 
			// colPTID
			// 
			this.colPTID.AppearanceCell.BackColor = System.Drawing.Color.Silver;
			this.colPTID.AppearanceCell.ForeColor = System.Drawing.Color.White;
			this.colPTID.AppearanceCell.Options.UseBackColor = true;
			this.colPTID.AppearanceCell.Options.UseForeColor = true;
			this.colPTID.FieldName = "PTID";
			this.colPTID.Name = "colPTID";
			this.colPTID.OptionsColumn.AllowEdit = false;
			this.colPTID.OptionsColumn.AllowFocus = false;
			this.colPTID.OptionsColumn.FixedWidth = true;
			this.colPTID.OptionsColumn.ReadOnly = true;
			this.colPTID.Visible = true;
			this.colPTID.VisibleIndex = 0;
			// 
			// colTTID
			// 
			this.colTTID.FieldName = "TTID";
			this.colTTID.Name = "colTTID";
			this.colTTID.OptionsColumn.AllowEdit = false;
			this.colTTID.OptionsColumn.AllowFocus = false;
			this.colTTID.OptionsColumn.FixedWidth = true;
			// 
			// colNAME
			// 
			this.colNAME.Caption = "Name";
			this.colNAME.FieldName = "NAME";
			this.colNAME.Name = "colNAME";
			this.colNAME.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "PTID", "Total: {0}"),
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "JND", "Joined: {0:0.##}")});
			this.colNAME.Visible = true;
			this.colNAME.VisibleIndex = 1;
			this.colNAME.Width = 218;
			// 
			// colCCID
			// 
			this.colCCID.Caption = "Country";
			this.colCCID.ColumnEdit = this.ccRepositoryItemLookUpEdit;
			this.colCCID.FieldName = "CCID";
			this.colCCID.Name = "colCCID";
			this.colCCID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colCCID.Visible = true;
			this.colCCID.VisibleIndex = 2;
			this.colCCID.Width = 221;
			// 
			// ccRepositoryItemLookUpEdit
			// 
			this.ccRepositoryItemLookUpEdit.AutoHeight = false;
			this.ccRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ccRepositoryItemLookUpEdit.DataSource = this.ccBindingSource;
			this.ccRepositoryItemLookUpEdit.DisplayMember = "NAME";
			this.ccRepositoryItemLookUpEdit.Name = "ccRepositoryItemLookUpEdit";
			this.ccRepositoryItemLookUpEdit.ValueMember = "CCID";
			// 
			// ccBindingSource
			// 
			this.ccBindingSource.DataMember = "CC";
			this.ccBindingSource.DataSource = this.dataSet;
			// 
			// colPN
			// 
			this.colPN.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colPN.AppearanceCell.Options.UseFont = true;
			this.colPN.AppearanceCell.Options.UseTextOptions = true;
			this.colPN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPN.AppearanceHeader.Options.UseTextOptions = true;
			this.colPN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPN.FieldName = "PN";
			this.colPN.Name = "colPN";
			this.colPN.OptionsColumn.FixedWidth = true;
			this.colPN.Visible = true;
			this.colPN.VisibleIndex = 3;
			this.colPN.Width = 50;
			// 
			// colJND
			// 
			this.colJND.Caption = "Joined";
			this.colJND.FieldName = "JND";
			this.colJND.Name = "colJND";
			this.colJND.OptionsColumn.ReadOnly = true;
			// 
			// colETIDS
			// 
			this.colETIDS.Caption = "Events";
			this.colETIDS.FieldName = "ETIDS";
			this.colETIDS.Name = "colETIDS";
			this.colETIDS.OptionsColumn.ReadOnly = true;
			this.colETIDS.Visible = true;
			this.colETIDS.VisibleIndex = 4;
			// 
			// ccTableAdapter
			// 
			this.ccTableAdapter.ClearBeforeFill = true;
			// 
			// ParticipantsXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 306);
			this.Controls.Add(this.ptGridControl);
			this.Name = "ParticipantsXF";
			this.Text = "ParticipantsXF";
			this.Load += new System.EventHandler(this.ParticipantsXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.typRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ptGridControl)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ptGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ccRepositoryItemLookUpEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ccBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource ptBindingSource;
        private DataSetTableAdapters.PTTableAdapter ptTableAdapter;
        private DevExpress.XtraGrid.GridControl ptGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ptGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colPTID;
        private DevExpress.XtraGrid.Columns.GridColumn colTTID;
        private DevExpress.XtraGrid.Columns.GridColumn colTYP;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colCCID;
        private DevExpress.XtraGrid.Columns.GridColumn colPN;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox typRepositoryItemImageComboBox;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ccRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource ccBindingSource;
        private DataSetTableAdapters.CCTableAdapter ccTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colJND;
        private DevExpress.XtraGrid.Columns.GridColumn colETIDS;
    }
}