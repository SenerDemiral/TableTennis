namespace TableTennis
{
    partial class GlobalTemplatesLapXF
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
			this.gtlGridControl = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.preliminaryLapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.knockoutLapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.gtlBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gtlGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colCS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.csRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colGTID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLAP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGRP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.typRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.gtlTableAdapter = new TableTennis.DataSetTableAdapters.GTLTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gtlGridControl)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gtlBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gtlGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.csRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.typRepositoryItemImageComboBox)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet
			// 
			this.dataSet.CaseSensitive = true;
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gtlGridControl
			// 
			this.gtlGridControl.DataSource = this.gtlBindingSource;
			this.gtlGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gtlGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.etGridControl_EmbeddedNavigator_ButtonClick);
			this.gtlGridControl.Location = new System.Drawing.Point(0, 0);
			this.gtlGridControl.MainView = this.gtlGridView;
			this.gtlGridControl.Name = "gtlGridControl";
			this.gtlGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.typRepositoryItemImageComboBox,
            this.csRepositoryItemImageComboBox});
			this.gtlGridControl.ShowOnlyPredefinedDetails = true;
			this.gtlGridControl.Size = new System.Drawing.Size(556, 281);
			this.gtlGridControl.TabIndex = 2;
			this.gtlGridControl.Tag = "Events";
			this.gtlGridControl.UseEmbeddedNavigator = true;
			this.gtlGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gtlGridView});
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Enabled = false;
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preliminaryLapToolStripMenuItem,
            this.knockoutLapsToolStripMenuItem,
            this.toolStripSeparator1});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(157, 54);
			// 
			// preliminaryLapToolStripMenuItem
			// 
			this.preliminaryLapToolStripMenuItem.Enabled = false;
			this.preliminaryLapToolStripMenuItem.Name = "preliminaryLapToolStripMenuItem";
			this.preliminaryLapToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.preliminaryLapToolStripMenuItem.Text = "Preliminary Lap";
			this.preliminaryLapToolStripMenuItem.Click += new System.EventHandler(this.preliminaryLapToolStripMenuItem_Click);
			// 
			// knockoutLapsToolStripMenuItem
			// 
			this.knockoutLapsToolStripMenuItem.Enabled = false;
			this.knockoutLapsToolStripMenuItem.Name = "knockoutLapsToolStripMenuItem";
			this.knockoutLapsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
			this.knockoutLapsToolStripMenuItem.Text = "Knockout Laps";
			this.knockoutLapsToolStripMenuItem.Click += new System.EventHandler(this.knockoutLapsToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
			// 
			// gtlBindingSource
			// 
			this.gtlBindingSource.DataMember = "GTL";
			this.gtlBindingSource.DataSource = this.dataSet;
			// 
			// gtlGridView
			// 
			this.gtlGridView.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.gtlGridView.Appearance.GroupRow.Options.UseFont = true;
			this.gtlGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCS,
            this.colGTID,
            this.colLAP,
            this.colGRP,
            this.colGI,
            this.colPC});
			this.gtlGridView.GridControl = this.gtlGridControl;
			this.gtlGridView.GroupCount = 1;
			this.gtlGridView.GroupFormat = "{0} -> [#image]{1} {2}";
			this.gtlGridView.Name = "gtlGridView";
			this.gtlGridView.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
			this.gtlGridView.OptionsBehavior.AutoExpandAllGroups = true;
			this.gtlGridView.OptionsView.AllowCellMerge = true;
			this.gtlGridView.OptionsView.ColumnAutoWidth = false;
			this.gtlGridView.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
			this.gtlGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
			this.gtlGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCS, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.gtlGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.etGridView_InitNewRow);
			this.gtlGridView.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.etGridView_RowDeleted);
			this.gtlGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.etGridView_KeyUp);
			// 
			// colCS
			// 
			this.colCS.Caption = "C/C";
			this.colCS.ColumnEdit = this.csRepositoryItemImageComboBox;
			this.colCS.FieldName = "CS";
			this.colCS.Name = "colCS";
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
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Consolation", "-", -1)});
			this.csRepositoryItemImageComboBox.Name = "csRepositoryItemImageComboBox";
			// 
			// colGTID
			// 
			this.colGTID.FieldName = "GTID";
			this.colGTID.Name = "colGTID";
			this.colGTID.OptionsColumn.AllowEdit = false;
			this.colGTID.OptionsColumn.AllowFocus = false;
			this.colGTID.OptionsColumn.FixedWidth = true;
			// 
			// colLAP
			// 
			this.colLAP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colLAP.AppearanceCell.Options.UseFont = true;
			this.colLAP.AppearanceCell.Options.UseTextOptions = true;
			this.colLAP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLAP.AppearanceHeader.Options.UseTextOptions = true;
			this.colLAP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLAP.Caption = "Lap";
			this.colLAP.FieldName = "LAP";
			this.colLAP.Name = "colLAP";
			this.colLAP.OptionsColumn.FixedWidth = true;
			this.colLAP.Visible = true;
			this.colLAP.VisibleIndex = 0;
			// 
			// colGRP
			// 
			this.colGRP.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colGRP.AppearanceCell.Options.UseFont = true;
			this.colGRP.AppearanceCell.Options.UseTextOptions = true;
			this.colGRP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGRP.AppearanceHeader.Options.UseTextOptions = true;
			this.colGRP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGRP.Caption = "Grp";
			this.colGRP.FieldName = "GRP";
			this.colGRP.Name = "colGRP";
			this.colGRP.OptionsColumn.FixedWidth = true;
			this.colGRP.Visible = true;
			this.colGRP.VisibleIndex = 1;
			// 
			// colGI
			// 
			this.colGI.AppearanceCell.Options.UseTextOptions = true;
			this.colGI.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGI.AppearanceHeader.Options.UseTextOptions = true;
			this.colGI.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGI.FieldName = "GI";
			this.colGI.Name = "colGI";
			this.colGI.OptionsColumn.FixedWidth = true;
			this.colGI.ToolTip = "Grup Index";
			this.colGI.Visible = true;
			this.colGI.VisibleIndex = 2;
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
			this.colPC.ToolTip = "Participant Code";
			this.colPC.Visible = true;
			this.colPC.VisibleIndex = 3;
			// 
			// typRepositoryItemImageComboBox
			// 
			this.typRepositoryItemImageComboBox.AutoHeight = false;
			this.typRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.typRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Preliminary", "P", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Knockuot", "K", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Classification", "C", -1)});
			this.typRepositoryItemImageComboBox.Name = "typRepositoryItemImageComboBox";
			// 
			// gtlTableAdapter
			// 
			this.gtlTableAdapter.ClearBeforeFill = true;
			// 
			// GlobalTemplatesLapXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 281);
			this.Controls.Add(this.gtlGridControl);
			this.Name = "GlobalTemplatesLapXF";
			this.Text = "GlobalTemplatesXF";
			this.Load += new System.EventHandler(this.EventsXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gtlGridControl)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gtlBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gtlGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.csRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.typRepositoryItemImageComboBox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private DevExpress.XtraGrid.GridControl gtlGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gtlGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem preliminaryLapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knockoutLapsToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox typRepositoryItemImageComboBox;
        private System.Windows.Forms.BindingSource gtlBindingSource;
        private DataSetTableAdapters.GTLTableAdapter gtlTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colGTID;
        private DevExpress.XtraGrid.Columns.GridColumn colLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colGRP;
        private DevExpress.XtraGrid.Columns.GridColumn colGI;
        private DevExpress.XtraGrid.Columns.GridColumn colPC;
        private DevExpress.XtraGrid.Columns.GridColumn colCS;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox csRepositoryItemImageComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}