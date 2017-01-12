namespace TableTennis
{
    partial class EventsXF
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
			this.etBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.etTableAdapter = new TableTennis.DataSetTableAdapters.ETTableAdapter();
			this.etGridControl = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.preliminaryLapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.knockoutLapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.classificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.knockoutResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.etGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colETID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTTID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNOP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.TFrepositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.colKL = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTYP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.typRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colSD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.sdRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colCNOP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNOK = new DevExpress.XtraGrid.Columns.GridColumn();
			this.NOKrepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.SDrepositoryItemRadioGroup = new DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.etGridControl)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.etGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TFrepositoryItemCheckEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.typRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sdRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NOKrepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SDrepositoryItemRadioGroup)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet
			// 
			this.dataSet.CaseSensitive = true;
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// etBindingSource
			// 
			this.etBindingSource.DataMember = "ET";
			this.etBindingSource.DataSource = this.dataSet;
			// 
			// etTableAdapter
			// 
			this.etTableAdapter.ClearBeforeFill = true;
			// 
			// etGridControl
			// 
			this.etGridControl.ContextMenuStrip = this.contextMenuStrip;
			this.etGridControl.DataSource = this.etBindingSource;
			this.etGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.etGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.etGridControl_EmbeddedNavigator_ButtonClick);
			this.etGridControl.Location = new System.Drawing.Point(0, 0);
			this.etGridControl.MainView = this.etGridView;
			this.etGridControl.Name = "etGridControl";
			this.etGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TFrepositoryItemCheckEdit,
            this.typRepositoryItemImageComboBox,
            this.SDrepositoryItemRadioGroup,
            this.sdRepositoryItemImageComboBox,
            this.NOKrepositoryItemImageComboBox});
			this.etGridControl.ShowOnlyPredefinedDetails = true;
			this.etGridControl.Size = new System.Drawing.Size(706, 281);
			this.etGridControl.TabIndex = 2;
			this.etGridControl.Tag = "Events";
			this.etGridControl.UseEmbeddedNavigator = true;
			this.etGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.etGridView});
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preliminaryLapToolStripMenuItem,
            this.knockoutLapsToolStripMenuItem,
            this.classificationToolStripMenuItem,
            this.knockoutResultsToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(255, 92);
			// 
			// preliminaryLapToolStripMenuItem
			// 
			this.preliminaryLapToolStripMenuItem.Name = "preliminaryLapToolStripMenuItem";
			this.preliminaryLapToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.preliminaryLapToolStripMenuItem.Text = "PreliminaryPlan / ÖnElemeler";
			this.preliminaryLapToolStripMenuItem.Click += new System.EventHandler(this.preliminaryLapToolStripMenuItem_Click);
			// 
			// knockoutLapsToolStripMenuItem
			// 
			this.knockoutLapsToolStripMenuItem.Name = "knockoutLapsToolStripMenuItem";
			this.knockoutLapsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.knockoutLapsToolStripMenuItem.Text = "KnockoutPlan / Elemeler";
			this.knockoutLapsToolStripMenuItem.Click += new System.EventHandler(this.knockoutLapsToolStripMenuItem_Click);
			// 
			// classificationToolStripMenuItem
			// 
			this.classificationToolStripMenuItem.Name = "classificationToolStripMenuItem";
			this.classificationToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.classificationToolStripMenuItem.Text = "Classification / Sıralama";
			this.classificationToolStripMenuItem.Click += new System.EventHandler(this.classificationToolStripMenuItem_Click);
			// 
			// knockoutResultsToolStripMenuItem
			// 
			this.knockoutResultsToolStripMenuItem.Name = "knockoutResultsToolStripMenuItem";
			this.knockoutResultsToolStripMenuItem.Size = new System.Drawing.Size(254, 22);
			this.knockoutResultsToolStripMenuItem.Text = "KnockoutResults / ElemeSonuçları";
			this.knockoutResultsToolStripMenuItem.Click += new System.EventHandler(this.knockoutResultsToolStripMenuItem_Click);
			// 
			// etGridView
			// 
			this.etGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colETID,
            this.colTTID,
            this.colNAME,
            this.colNOP,
            this.colPL,
            this.colKL,
            this.colTYP,
            this.colSD,
            this.colCNOP,
            this.colNOK});
			this.etGridView.GridControl = this.etGridControl;
			this.etGridView.Name = "etGridView";
			this.etGridView.OptionsBehavior.AutoExpandAllGroups = true;
			this.etGridView.OptionsView.ColumnAutoWidth = false;
			this.etGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.etGridView_InitNewRow);
			this.etGridView.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.etGridView_RowDeleted);
			this.etGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.etGridView_KeyUp);
			// 
			// colETID
			// 
			this.colETID.AppearanceCell.Options.UseTextOptions = true;
			this.colETID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colETID.AppearanceHeader.Options.UseTextOptions = true;
			this.colETID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colETID.Caption = "Event";
			this.colETID.FieldName = "ETID";
			this.colETID.Name = "colETID";
			this.colETID.OptionsColumn.FixedWidth = true;
			this.colETID.Visible = true;
			this.colETID.VisibleIndex = 0;
			this.colETID.Width = 58;
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
			this.colNAME.Visible = true;
			this.colNAME.VisibleIndex = 1;
			this.colNAME.Width = 138;
			// 
			// colNOP
			// 
			this.colNOP.AppearanceCell.Options.UseTextOptions = true;
			this.colNOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNOP.AppearanceHeader.Options.UseTextOptions = true;
			this.colNOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNOP.Caption = "ExpPrt";
			this.colNOP.FieldName = "NOP";
			this.colNOP.Name = "colNOP";
			this.colNOP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colNOP.ToolTip = "Expected Participants";
			this.colNOP.Visible = true;
			this.colNOP.VisibleIndex = 4;
			this.colNOP.Width = 43;
			// 
			// colPL
			// 
			this.colPL.AppearanceHeader.Options.UseTextOptions = true;
			this.colPL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPL.Caption = "P";
			this.colPL.ColumnEdit = this.TFrepositoryItemCheckEdit;
			this.colPL.FieldName = "PL";
			this.colPL.Name = "colPL";
			this.colPL.OptionsColumn.FixedWidth = true;
			this.colPL.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colPL.ToolTip = "Has Preliminary Roud";
			this.colPL.Visible = true;
			this.colPL.VisibleIndex = 5;
			this.colPL.Width = 40;
			// 
			// TFrepositoryItemCheckEdit
			// 
			this.TFrepositoryItemCheckEdit.AutoHeight = false;
			this.TFrepositoryItemCheckEdit.Name = "TFrepositoryItemCheckEdit";
			this.TFrepositoryItemCheckEdit.ValueChecked = "T";
			this.TFrepositoryItemCheckEdit.ValueUnchecked = "F";
			// 
			// colKL
			// 
			this.colKL.AppearanceHeader.Options.UseTextOptions = true;
			this.colKL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colKL.Caption = "K";
			this.colKL.ColumnEdit = this.TFrepositoryItemCheckEdit;
			this.colKL.FieldName = "KL";
			this.colKL.Name = "colKL";
			this.colKL.OptionsColumn.FixedWidth = true;
			this.colKL.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colKL.ToolTip = "Has Knockout Rounds";
			this.colKL.Visible = true;
			this.colKL.VisibleIndex = 6;
			this.colKL.Width = 40;
			// 
			// colTYP
			// 
			this.colTYP.Caption = "Type";
			this.colTYP.ColumnEdit = this.typRepositoryItemImageComboBox;
			this.colTYP.FieldName = "TYP";
			this.colTYP.Name = "colTYP";
			this.colTYP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colTYP.Visible = true;
			this.colTYP.VisibleIndex = 3;
			this.colTYP.Width = 67;
			// 
			// typRepositoryItemImageComboBox
			// 
			this.typRepositoryItemImageComboBox.AutoHeight = false;
			this.typRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.typRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Men", "M", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Women", "W", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Team", "T", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Mix", "X", -1)});
			this.typRepositoryItemImageComboBox.Name = "typRepositoryItemImageComboBox";
			// 
			// colSD
			// 
			this.colSD.Caption = "Single/Double";
			this.colSD.ColumnEdit = this.sdRepositoryItemImageComboBox;
			this.colSD.FieldName = "SD";
			this.colSD.Name = "colSD";
			this.colSD.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colSD.Visible = true;
			this.colSD.VisibleIndex = 2;
			this.colSD.Width = 88;
			// 
			// sdRepositoryItemImageComboBox
			// 
			this.sdRepositoryItemImageComboBox.AutoHeight = false;
			this.sdRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.sdRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Single", "S", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Double", "D", -1)});
			this.sdRepositoryItemImageComboBox.Name = "sdRepositoryItemImageComboBox";
			// 
			// colCNOP
			// 
			this.colCNOP.AppearanceCell.Options.UseTextOptions = true;
			this.colCNOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCNOP.AppearanceHeader.Options.UseTextOptions = true;
			this.colCNOP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colCNOP.Caption = "RegPrt";
			this.colCNOP.FieldName = "CNOP";
			this.colCNOP.Name = "colCNOP";
			this.colCNOP.OptionsColumn.ReadOnly = true;
			this.colCNOP.ToolTip = "Regıstered Participants";
			this.colCNOP.Visible = true;
			this.colCNOP.VisibleIndex = 7;
			this.colCNOP.Width = 54;
			// 
			// colNOK
			// 
			this.colNOK.AppearanceCell.Options.UseTextOptions = true;
			this.colNOK.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNOK.ColumnEdit = this.NOKrepositoryItemImageComboBox;
			this.colNOK.FieldName = "NOK";
			this.colNOK.Name = "colNOK";
			this.colNOK.ToolTip = "Number of Knockout Participants";
			this.colNOK.Visible = true;
			this.colNOK.VisibleIndex = 8;
			this.colNOK.Width = 39;
			// 
			// NOKrepositoryItemImageComboBox
			// 
			this.NOKrepositoryItemImageComboBox.AutoHeight = false;
			this.NOKrepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.NOKrepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("4", 4, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("8", 8, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("16", 16, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("32", 32, -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("64", 64, -1)});
			this.NOKrepositoryItemImageComboBox.Name = "NOKrepositoryItemImageComboBox";
			// 
			// SDrepositoryItemRadioGroup
			// 
			this.SDrepositoryItemRadioGroup.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Single"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("D", "Double")});
			this.SDrepositoryItemRadioGroup.Name = "SDrepositoryItemRadioGroup";
			// 
			// EventsXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(706, 281);
			this.Controls.Add(this.etGridControl);
			this.Name = "EventsXF";
			this.Text = "EventsXF";
			this.Load += new System.EventHandler(this.EventsXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.etGridControl)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.etGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TFrepositoryItemCheckEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.typRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sdRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NOKrepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SDrepositoryItemRadioGroup)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource etBindingSource;
        private DataSetTableAdapters.ETTableAdapter etTableAdapter;
        private DevExpress.XtraGrid.GridControl etGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView etGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colETID;
        private DevExpress.XtraGrid.Columns.GridColumn colTTID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem preliminaryLapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knockoutLapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classificationToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn colNOP;
        private DevExpress.XtraGrid.Columns.GridColumn colPL;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit TFrepositoryItemCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colKL;
        private DevExpress.XtraGrid.Columns.GridColumn colTYP;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox typRepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colSD;
        private DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup SDrepositoryItemRadioGroup;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox sdRepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colCNOP;
		private System.Windows.Forms.ToolStripMenuItem knockoutResultsToolStripMenuItem;
		private DevExpress.XtraGrid.Columns.GridColumn colNOK;
		private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox NOKrepositoryItemImageComboBox;
	}
}