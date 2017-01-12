namespace TableTennis
{
    partial class GlobalTemplatesXF
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
			this.gtGridControl = new DevExpress.XtraGrid.GridControl();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.templatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createRemoveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.createTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gtBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gtGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colGTID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTYP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.typRepositoryItemImageComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
			this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNOP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPPG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gtTableAdapter = new TableTennis.DataSetTableAdapters.GTTableAdapter();
			this.queriesTableAdapter = new TableTennis.DataSetTableAdapters.QueriesTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gtGridControl)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gtBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gtGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.typRepositoryItemImageComboBox)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSet
			// 
			this.dataSet.CaseSensitive = true;
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gtGridControl
			// 
			this.gtGridControl.ContextMenuStrip = this.contextMenuStrip;
			this.gtGridControl.DataSource = this.gtBindingSource;
			this.gtGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gtGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.etGridControl_EmbeddedNavigator_ButtonClick);
			this.gtGridControl.Location = new System.Drawing.Point(0, 0);
			this.gtGridControl.MainView = this.gtGridView;
			this.gtGridControl.Name = "gtGridControl";
			this.gtGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.typRepositoryItemImageComboBox});
			this.gtGridControl.ShowOnlyPredefinedDetails = true;
			this.gtGridControl.Size = new System.Drawing.Size(556, 281);
			this.gtGridControl.TabIndex = 2;
			this.gtGridControl.Tag = "Events";
			this.gtGridControl.UseEmbeddedNavigator = true;
			this.gtGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gtGridView});
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.templatesToolStripMenuItem,
            this.createRemoveToolStripMenuItem,
            this.toolStripSeparator1,
            this.createTemplatesToolStripMenuItem,
            this.deleteTemplatesToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(216, 98);
			// 
			// templatesToolStripMenuItem
			// 
			this.templatesToolStripMenuItem.Name = "templatesToolStripMenuItem";
			this.templatesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.templatesToolStripMenuItem.Text = "Edit Template";
			this.templatesToolStripMenuItem.Click += new System.EventHandler(this.templatesToolStripMenuItem_Click);
			// 
			// createRemoveToolStripMenuItem
			// 
			this.createRemoveToolStripMenuItem.Name = "createRemoveToolStripMenuItem";
			this.createRemoveToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.createRemoveToolStripMenuItem.Text = "Create/Remove Event Laps";
			this.createRemoveToolStripMenuItem.Click += new System.EventHandler(this.createRemoveToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(212, 6);
			// 
			// createTemplatesToolStripMenuItem
			// 
			this.createTemplatesToolStripMenuItem.Name = "createTemplatesToolStripMenuItem";
			this.createTemplatesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.createTemplatesToolStripMenuItem.Text = "Create Templates";
			this.createTemplatesToolStripMenuItem.Click += new System.EventHandler(this.createTemplatesToolStripMenuItem_Click);
			// 
			// deleteTemplatesToolStripMenuItem
			// 
			this.deleteTemplatesToolStripMenuItem.Name = "deleteTemplatesToolStripMenuItem";
			this.deleteTemplatesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.deleteTemplatesToolStripMenuItem.Text = "Delete Templates";
			this.deleteTemplatesToolStripMenuItem.Click += new System.EventHandler(this.deleteTemplatesToolStripMenuItem_Click);
			// 
			// gtBindingSource
			// 
			this.gtBindingSource.DataMember = "GT";
			this.gtBindingSource.DataSource = this.dataSet;
			// 
			// gtGridView
			// 
			this.gtGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colGTID,
            this.colTYP,
            this.colNAME,
            this.colNOP,
            this.colPPG});
			this.gtGridView.GridControl = this.gtGridControl;
			this.gtGridView.Name = "gtGridView";
			this.gtGridView.OptionsBehavior.AutoExpandAllGroups = true;
			this.gtGridView.OptionsView.ColumnAutoWidth = false;
			this.gtGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.etGridView_InitNewRow);
			this.gtGridView.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.etGridView_RowDeleted);
			this.gtGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gtGridView_ValidateRow);
			this.gtGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.etGridView_KeyUp);
			// 
			// colGTID
			// 
			this.colGTID.AppearanceCell.BackColor = System.Drawing.Color.Gray;
			this.colGTID.AppearanceCell.ForeColor = System.Drawing.Color.White;
			this.colGTID.AppearanceCell.Options.UseBackColor = true;
			this.colGTID.AppearanceCell.Options.UseForeColor = true;
			this.colGTID.FieldName = "GTID";
			this.colGTID.Name = "colGTID";
			this.colGTID.OptionsColumn.AllowEdit = false;
			this.colGTID.OptionsColumn.AllowFocus = false;
			this.colGTID.OptionsColumn.ReadOnly = true;
			this.colGTID.Visible = true;
			this.colGTID.VisibleIndex = 0;
			this.colGTID.Width = 50;
			// 
			// colTYP
			// 
			this.colTYP.Caption = "Type";
			this.colTYP.ColumnEdit = this.typRepositoryItemImageComboBox;
			this.colTYP.FieldName = "TYP";
			this.colTYP.Name = "colTYP";
			this.colTYP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colTYP.Visible = true;
			this.colTYP.VisibleIndex = 1;
			this.colTYP.Width = 81;
			// 
			// typRepositoryItemImageComboBox
			// 
			this.typRepositoryItemImageComboBox.AutoHeight = false;
			this.typRepositoryItemImageComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.typRepositoryItemImageComboBox.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Preliminary/GrupMaçları", "P", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Knockout/Eleme", "K", -1),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Classification/Sıralama", "C", -1)});
			this.typRepositoryItemImageComboBox.Name = "typRepositoryItemImageComboBox";
			// 
			// colNAME
			// 
			this.colNAME.Caption = "Name";
			this.colNAME.FieldName = "NAME";
			this.colNAME.Name = "colNAME";
			this.colNAME.Visible = true;
			this.colNAME.VisibleIndex = 4;
			this.colNAME.Width = 242;
			// 
			// colNOP
			// 
			this.colNOP.AppearanceCell.Options.UseTextOptions = true;
			this.colNOP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colNOP.Caption = "#Prtcpnts";
			this.colNOP.FieldName = "NOP";
			this.colNOP.Name = "colNOP";
			this.colNOP.ToolTip = "Oyuncu Sayısı";
			this.colNOP.Visible = true;
			this.colNOP.VisibleIndex = 2;
			// 
			// colPPG
			// 
			this.colPPG.AppearanceCell.Options.UseTextOptions = true;
			this.colPPG.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colPPG.Caption = "Prtpcnts/Grup";
			this.colPPG.FieldName = "PPG";
			this.colPPG.Name = "colPPG";
			this.colPPG.ToolTip = "Gruptaki Oyuncu Sayısı";
			this.colPPG.Visible = true;
			this.colPPG.VisibleIndex = 3;
			// 
			// gtTableAdapter
			// 
			this.gtTableAdapter.ClearBeforeFill = true;
			// 
			// GlobalTemplatesXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 281);
			this.Controls.Add(this.gtGridControl);
			this.Name = "GlobalTemplatesXF";
			this.Text = "GlobalTemplatesXF";
			this.Load += new System.EventHandler(this.EventsXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gtGridControl)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gtBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gtGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.typRepositoryItemImageComboBox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private DevExpress.XtraGrid.GridControl gtGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gtGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.BindingSource gtBindingSource;
        private DataSetTableAdapters.GTTableAdapter gtTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colGTID;
        private DevExpress.XtraGrid.Columns.GridColumn colTYP;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox typRepositoryItemImageComboBox;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private System.Windows.Forms.ToolStripMenuItem templatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createRemoveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem createTemplatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteTemplatesToolStripMenuItem;
        private DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colNOP;
        private DevExpress.XtraGrid.Columns.GridColumn colPPG;
    }
}