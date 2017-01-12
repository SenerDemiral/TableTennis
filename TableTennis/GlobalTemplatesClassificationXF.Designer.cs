namespace TableTennis
{
    partial class GlobalTemplatesClassificationXF
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
			this.gtcGridControl = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.preliminaryLapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.knockoutLapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gtcBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gtcGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colGTID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colIDX = new DevExpress.XtraGrid.Columns.GridColumn();
			this.typRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.gtlBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gtlTableAdapter = new TableTennis.DataSetTableAdapters.GTLTableAdapter();
			this.gtcTableAdapter = new TableTennis.DataSetTableAdapters.GTCTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gtcGridControl)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gtcBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gtcGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.typRepositoryItemImageComboBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gtlBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet
			// 
			this.dataSet.CaseSensitive = true;
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gtcGridControl
			// 
			this.gtcGridControl.DataSource = this.gtcBindingSource;
			this.gtcGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gtcGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.etGridControl_EmbeddedNavigator_ButtonClick);
			this.gtcGridControl.Location = new System.Drawing.Point(0, 0);
			this.gtcGridControl.MainView = this.gtcGridView;
			this.gtcGridControl.Name = "gtcGridControl";
			this.gtcGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.typRepositoryItemImageComboBox});
			this.gtcGridControl.ShowOnlyPredefinedDetails = true;
			this.gtcGridControl.Size = new System.Drawing.Size(556, 281);
			this.gtcGridControl.TabIndex = 2;
			this.gtcGridControl.Tag = "Events";
			this.gtcGridControl.UseEmbeddedNavigator = true;
			this.gtcGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gtcGridView});
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Enabled = false;
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preliminaryLapToolStripMenuItem,
            this.knockoutLapsToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(157, 48);
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
			// gtcBindingSource
			// 
			this.gtcBindingSource.DataMember = "GTC";
			this.gtcBindingSource.DataSource = this.dataSet;
			// 
			// gtcGridView
			// 
			this.gtcGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGTID,
            this.colPC,
            this.colIDX});
			this.gtcGridView.GridControl = this.gtcGridControl;
			this.gtcGridView.Name = "gtcGridView";
			this.gtcGridView.OptionsBehavior.AutoExpandAllGroups = true;
			this.gtcGridView.OptionsView.ColumnAutoWidth = false;
			this.gtcGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.etGridView_InitNewRow);
			this.gtcGridView.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.etGridView_RowDeleted);
			this.gtcGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.etGridView_KeyUp);
			// 
			// colGTID
			// 
			this.colGTID.FieldName = "GTID";
			this.colGTID.Name = "colGTID";
			this.colGTID.OptionsColumn.AllowEdit = false;
			this.colGTID.OptionsColumn.AllowFocus = false;
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
			this.colPC.VisibleIndex = 0;
			// 
			// colIDX
			// 
			this.colIDX.AppearanceCell.Options.UseTextOptions = true;
			this.colIDX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colIDX.AppearanceHeader.Options.UseTextOptions = true;
			this.colIDX.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colIDX.FieldName = "IDX";
			this.colIDX.Name = "colIDX";
			this.colIDX.OptionsColumn.FixedWidth = true;
			this.colIDX.ToolTip = "Index";
			this.colIDX.Visible = true;
			this.colIDX.VisibleIndex = 1;
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
			// gtlBindingSource
			// 
			this.gtlBindingSource.DataMember = "GTL";
			this.gtlBindingSource.DataSource = this.dataSet;
			// 
			// gtlTableAdapter
			// 
			this.gtlTableAdapter.ClearBeforeFill = true;
			// 
			// gtcTableAdapter
			// 
			this.gtcTableAdapter.ClearBeforeFill = true;
			// 
			// GlobalTemplatesClassificationXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 281);
			this.Controls.Add(this.gtcGridControl);
			this.Name = "GlobalTemplatesClassificationXF";
			this.Text = "GlobalTemplatesXF";
			this.Load += new System.EventHandler(this.EventsXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gtcGridControl)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gtcBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gtcGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.typRepositoryItemImageComboBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gtlBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private DevExpress.XtraGrid.GridControl gtcGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gtcGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem preliminaryLapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knockoutLapsToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox typRepositoryItemImageComboBox;
        private System.Windows.Forms.BindingSource gtlBindingSource;
        private DataSetTableAdapters.GTLTableAdapter gtlTableAdapter;
        private System.Windows.Forms.BindingSource gtcBindingSource;
        private DataSetTableAdapters.GTCTableAdapter gtcTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colGTID;
        private DevExpress.XtraGrid.Columns.GridColumn colPC;
        private DevExpress.XtraGrid.Columns.GridColumn colIDX;
    }
}