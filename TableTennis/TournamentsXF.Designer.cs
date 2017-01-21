namespace TableTennis
{
    partial class TournamentsXF
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
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.participantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.preliminaryEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.knockoutEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eventClassificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.globalTemplatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eventDistirbutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.antetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataSet = new TableTennis.DataSet();
			this.ttBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ttTableAdapter = new TableTennis.DataSetTableAdapters.TTTableAdapter();
			this.ttGridControl = new DevExpress.XtraGrid.GridControl();
			this.ttGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colTTID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ccRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
			this.ccBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.colSOD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colEOD = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ccTableAdapter = new TableTennis.DataSetTableAdapters.CCTableAdapter();
			this.denemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ttBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ttGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ttGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ccRepositoryItemLookUpEdit)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ccBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.participantsToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.preliminaryEventsToolStripMenuItem,
            this.knockoutEventsToolStripMenuItem,
            this.eventClassificationToolStripMenuItem,
            this.globalTemplatesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.antetToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.denemeToolStripMenuItem});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(253, 246);
			// 
			// participantsToolStripMenuItem
			// 
			this.participantsToolStripMenuItem.Name = "participantsToolStripMenuItem";
			this.participantsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.participantsToolStripMenuItem.Text = "Participants / Katılımcılar";
			this.participantsToolStripMenuItem.Click += new System.EventHandler(this.participantsToolStripMenuItem_Click);
			// 
			// eventsToolStripMenuItem
			// 
			this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
			this.eventsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.eventsToolStripMenuItem.Text = "Events / Etkinlikler";
			this.eventsToolStripMenuItem.Click += new System.EventHandler(this.eventsToolStripMenuItem_Click);
			// 
			// preliminaryEventsToolStripMenuItem
			// 
			this.preliminaryEventsToolStripMenuItem.Name = "preliminaryEventsToolStripMenuItem";
			this.preliminaryEventsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.preliminaryEventsToolStripMenuItem.Text = "PreliminaryPlan / ÖnElemeler";
			this.preliminaryEventsToolStripMenuItem.Click += new System.EventHandler(this.preliminaryEventsToolStripMenuItem_Click);
			// 
			// knockoutEventsToolStripMenuItem
			// 
			this.knockoutEventsToolStripMenuItem.Name = "knockoutEventsToolStripMenuItem";
			this.knockoutEventsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.knockoutEventsToolStripMenuItem.Text = "KnockoutPlan / Elemeler";
			this.knockoutEventsToolStripMenuItem.Click += new System.EventHandler(this.knockoutEventsToolStripMenuItem_Click);
			// 
			// eventClassificationToolStripMenuItem
			// 
			this.eventClassificationToolStripMenuItem.Name = "eventClassificationToolStripMenuItem";
			this.eventClassificationToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.eventClassificationToolStripMenuItem.Text = "EventClassification / Sıralama";
			this.eventClassificationToolStripMenuItem.Click += new System.EventHandler(this.eventClassificationToolStripMenuItem_Click);
			// 
			// globalTemplatesToolStripMenuItem
			// 
			this.globalTemplatesToolStripMenuItem.Name = "globalTemplatesToolStripMenuItem";
			this.globalTemplatesToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.globalTemplatesToolStripMenuItem.Text = "GlobalTemplates / GenelŞablonlar";
			this.globalTemplatesToolStripMenuItem.Click += new System.EventHandler(this.globalTemplatesToolStripMenuItem_Click);
			// 
			// reportsToolStripMenuItem
			// 
			this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventDistirbutionToolStripMenuItem,
            this.resultsToolStripMenuItem});
			this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
			this.reportsToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.reportsToolStripMenuItem.Text = "Reports";
			// 
			// eventDistirbutionToolStripMenuItem
			// 
			this.eventDistirbutionToolStripMenuItem.Name = "eventDistirbutionToolStripMenuItem";
			this.eventDistirbutionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.eventDistirbutionToolStripMenuItem.Text = "Event Distirbution";
			this.eventDistirbutionToolStripMenuItem.Click += new System.EventHandler(this.eventDistirbutionToolStripMenuItem_Click);
			// 
			// resultsToolStripMenuItem
			// 
			this.resultsToolStripMenuItem.Name = "resultsToolStripMenuItem";
			this.resultsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.resultsToolStripMenuItem.Text = "Results";
			this.resultsToolStripMenuItem.Click += new System.EventHandler(this.resultsToolStripMenuItem_Click);
			// 
			// antetToolStripMenuItem
			// 
			this.antetToolStripMenuItem.Name = "antetToolStripMenuItem";
			this.antetToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.antetToolStripMenuItem.Text = "Antet";
			this.antetToolStripMenuItem.Click += new System.EventHandler(this.antetToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// dataSet
			// 
			this.dataSet.CaseSensitive = true;
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// ttBindingSource
			// 
			this.ttBindingSource.DataMember = "TT";
			this.ttBindingSource.DataSource = this.dataSet;
			// 
			// ttTableAdapter
			// 
			this.ttTableAdapter.ClearBeforeFill = true;
			// 
			// ttGridControl
			// 
			this.ttGridControl.ContextMenuStrip = this.contextMenuStrip;
			this.ttGridControl.DataSource = this.ttBindingSource;
			this.ttGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ttGridControl.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.ttGridControl_EmbeddedNavigator_ButtonClick);
			this.ttGridControl.Location = new System.Drawing.Point(0, 0);
			this.ttGridControl.MainView = this.ttGridView;
			this.ttGridControl.Name = "ttGridControl";
			this.ttGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ccRepositoryItemLookUpEdit});
			this.ttGridControl.ShowOnlyPredefinedDetails = true;
			this.ttGridControl.Size = new System.Drawing.Size(657, 289);
			this.ttGridControl.TabIndex = 2;
			this.ttGridControl.Tag = "Tournaments";
			this.ttGridControl.UseEmbeddedNavigator = true;
			this.ttGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ttGridView});
			// 
			// ttGridView
			// 
			this.ttGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTTID,
            this.colNAME,
            this.colADDRESS,
            this.colCC,
            this.colSOD,
            this.colEOD});
			this.ttGridView.GridControl = this.ttGridControl;
			this.ttGridView.Name = "ttGridView";
			this.ttGridView.OptionsBehavior.EditorShowMode = DevExpress.Utils.EditorShowMode.MouseDownFocused;
			this.ttGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.ttGridView_InitNewRow);
			this.ttGridView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.ttGridView_FocusedRowChanged);
			this.ttGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ttGridView_KeyUp);
			// 
			// colTTID
			// 
			this.colTTID.AppearanceCell.BackColor = System.Drawing.Color.Gray;
			this.colTTID.AppearanceCell.ForeColor = System.Drawing.Color.White;
			this.colTTID.AppearanceCell.Options.UseBackColor = true;
			this.colTTID.AppearanceCell.Options.UseForeColor = true;
			this.colTTID.FieldName = "TTID";
			this.colTTID.Name = "colTTID";
			this.colTTID.OptionsColumn.AllowEdit = false;
			this.colTTID.OptionsColumn.AllowFocus = false;
			this.colTTID.OptionsColumn.FixedWidth = true;
			this.colTTID.OptionsColumn.ReadOnly = true;
			this.colTTID.Visible = true;
			this.colTTID.VisibleIndex = 0;
			this.colTTID.Width = 49;
			// 
			// colNAME
			// 
			this.colNAME.Caption = "Name";
			this.colNAME.FieldName = "NAME";
			this.colNAME.Name = "colNAME";
			this.colNAME.Visible = true;
			this.colNAME.VisibleIndex = 1;
			this.colNAME.Width = 115;
			// 
			// colADDRESS
			// 
			this.colADDRESS.Caption = "Address";
			this.colADDRESS.FieldName = "ADDRESS";
			this.colADDRESS.Name = "colADDRESS";
			this.colADDRESS.Visible = true;
			this.colADDRESS.VisibleIndex = 2;
			this.colADDRESS.Width = 115;
			// 
			// colCC
			// 
			this.colCC.Caption = "Country";
			this.colCC.ColumnEdit = this.ccRepositoryItemLookUpEdit;
			this.colCC.FieldName = "CCID";
			this.colCC.Name = "colCC";
			this.colCC.Visible = true;
			this.colCC.VisibleIndex = 3;
			this.colCC.Width = 117;
			// 
			// ccRepositoryItemLookUpEdit
			// 
			this.ccRepositoryItemLookUpEdit.AutoHeight = false;
			this.ccRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.ccRepositoryItemLookUpEdit.DataSource = this.ccBindingSource;
			this.ccRepositoryItemLookUpEdit.DisplayMember = "NAME";
			this.ccRepositoryItemLookUpEdit.Name = "ccRepositoryItemLookUpEdit";
			this.ccRepositoryItemLookUpEdit.NullText = "";
			this.ccRepositoryItemLookUpEdit.ValueMember = "CCID";
			// 
			// ccBindingSource
			// 
			this.ccBindingSource.DataMember = "CC";
			this.ccBindingSource.DataSource = this.dataSet;
			// 
			// colSOD
			// 
			this.colSOD.Caption = "StartDate";
			this.colSOD.FieldName = "SOD";
			this.colSOD.Name = "colSOD";
			this.colSOD.OptionsColumn.FixedWidth = true;
			this.colSOD.Visible = true;
			this.colSOD.VisibleIndex = 4;
			this.colSOD.Width = 78;
			// 
			// colEOD
			// 
			this.colEOD.Caption = "EndDate";
			this.colEOD.FieldName = "EOD";
			this.colEOD.Name = "colEOD";
			this.colEOD.OptionsColumn.FixedWidth = true;
			this.colEOD.Visible = true;
			this.colEOD.VisibleIndex = 5;
			this.colEOD.Width = 78;
			// 
			// ccTableAdapter
			// 
			this.ccTableAdapter.ClearBeforeFill = true;
			// 
			// denemeToolStripMenuItem
			// 
			this.denemeToolStripMenuItem.Name = "denemeToolStripMenuItem";
			this.denemeToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
			this.denemeToolStripMenuItem.Text = "Deneme";
			this.denemeToolStripMenuItem.Click += new System.EventHandler(this.denemeToolStripMenuItem_Click);
			// 
			// TournamentsXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(657, 289);
			this.Controls.Add(this.ttGridControl);
			this.Name = "TournamentsXF";
			this.Text = "TournamentsXF";
			this.Load += new System.EventHandler(this.TournamentsXF_Load);
			this.contextMenuStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ttBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ttGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ttGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ccRepositoryItemLookUpEdit)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ccBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource ttBindingSource;
        private DataSetTableAdapters.TTTableAdapter ttTableAdapter;
        private DevExpress.XtraGrid.GridControl ttGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView ttGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTTID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colCC;
        private DevExpress.XtraGrid.Columns.GridColumn colSOD;
        private DevExpress.XtraGrid.Columns.GridColumn colEOD;
        private System.Windows.Forms.ToolStripMenuItem participantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventClassificationToolStripMenuItem;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ccRepositoryItemLookUpEdit;
        private System.Windows.Forms.BindingSource ccBindingSource;
        private DataSetTableAdapters.CCTableAdapter ccTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem preliminaryEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knockoutEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem globalTemplatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventDistirbutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem antetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem denemeToolStripMenuItem;
	}
}