namespace TableTennis.Report
{
    partial class RprELRXF
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
			this.reportDataSet = new TableTennis.Report.ReportDataSet();
			this.RprELRBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.RprELRTableAdapter = new TableTennis.Report.ReportDataSetTableAdapters.RPR_ELRTableAdapter();
			this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
			this.fieldETID1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldCS1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldLAP1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldGRP1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldGI1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldGR1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPC1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldPCNM1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldNPS1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldWTN1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldWTS1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldWTM1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldLTN1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldLTS1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldLTM1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldTS1 = new DevExpress.XtraPivotGrid.PivotGridField();
			this.fieldCLG = new DevExpress.XtraPivotGrid.PivotGridField();
			this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
			this.gridControl1 = new DevExpress.XtraGrid.GridControl();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colETID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCLG = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colCS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLAP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGRP = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colGR = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPC = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPCNM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNPS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWTN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWTS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colWTM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLTN = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLTS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colLTM = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colTS = new DevExpress.XtraGrid.Columns.GridColumn();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.RprELRBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
			this.layoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
			this.SuspendLayout();
			// 
			// reportDataSet
			// 
			this.reportDataSet.DataSetName = "ReportDataSet";
			this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// RprELRBindingSource
			// 
			this.RprELRBindingSource.DataMember = "RPR_ELR";
			this.RprELRBindingSource.DataSource = this.reportDataSet;
			// 
			// RprELRTableAdapter
			// 
			this.RprELRTableAdapter.ClearBeforeFill = true;
			// 
			// pivotGridControl1
			// 
			this.pivotGridControl1.DataSource = this.RprELRBindingSource;
			this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldETID1,
            this.fieldCS1,
            this.fieldLAP1,
            this.fieldGRP1,
            this.fieldGI1,
            this.fieldGR1,
            this.fieldPC1,
            this.fieldPCNM1,
            this.fieldNPS1,
            this.fieldWTN1,
            this.fieldWTS1,
            this.fieldWTM1,
            this.fieldLTN1,
            this.fieldLTS1,
            this.fieldLTM1,
            this.fieldTS1,
            this.fieldCLG});
			this.pivotGridControl1.Location = new System.Drawing.Point(24, 46);
			this.pivotGridControl1.Name = "pivotGridControl1";
			this.pivotGridControl1.Size = new System.Drawing.Size(1079, 367);
			this.pivotGridControl1.TabIndex = 0;
			// 
			// fieldETID1
			// 
			this.fieldETID1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldETID1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldETID1.AreaIndex = 0;
			this.fieldETID1.Caption = "Event";
			this.fieldETID1.FieldName = "ETID";
			this.fieldETID1.Name = "fieldETID1";
			this.fieldETID1.Width = 70;
			// 
			// fieldCS1
			// 
			this.fieldCS1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldCS1.AreaIndex = 8;
			this.fieldCS1.Caption = "C/C";
			this.fieldCS1.FieldName = "CS";
			this.fieldCS1.Name = "fieldCS1";
			this.fieldCS1.ToolTips.HeaderText = "Competition/Consolation";
			this.fieldCS1.Width = 60;
			// 
			// fieldLAP1
			// 
			this.fieldLAP1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldLAP1.AreaIndex = 9;
			this.fieldLAP1.Caption = "Lap";
			this.fieldLAP1.FieldName = "LAP";
			this.fieldLAP1.Name = "fieldLAP1";
			this.fieldLAP1.Width = 60;
			// 
			// fieldGRP1
			// 
			this.fieldGRP1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldGRP1.AreaIndex = 10;
			this.fieldGRP1.Caption = "Grp";
			this.fieldGRP1.FieldName = "GRP";
			this.fieldGRP1.Name = "fieldGRP1";
			this.fieldGRP1.Width = 60;
			// 
			// fieldGI1
			// 
			this.fieldGI1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldGI1.AreaIndex = 0;
			this.fieldGI1.FieldName = "GI";
			this.fieldGI1.Name = "fieldGI1";
			this.fieldGI1.ToolTips.HeaderText = "GrupIndex";
			// 
			// fieldGR1
			// 
			this.fieldGR1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldGR1.AreaIndex = 1;
			this.fieldGR1.FieldName = "GR";
			this.fieldGR1.Name = "fieldGR1";
			this.fieldGR1.ToolTips.HeaderText = "GrupRank";
			// 
			// fieldPC1
			// 
			this.fieldPC1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldPC1.AreaIndex = 2;
			this.fieldPC1.FieldName = "PC";
			this.fieldPC1.Name = "fieldPC1";
			this.fieldPC1.ToolTips.HeaderText = "ParticipantCode";
			// 
			// fieldPCNM1
			// 
			this.fieldPCNM1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldPCNM1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldPCNM1.AreaIndex = 2;
			this.fieldPCNM1.Caption = "Participant";
			this.fieldPCNM1.FieldName = "PCNM";
			this.fieldPCNM1.Name = "fieldPCNM1";
			this.fieldPCNM1.ToolTips.HeaderText = "ParticipantName";
			// 
			// fieldNPS1
			// 
			this.fieldNPS1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldNPS1.AreaIndex = 3;
			this.fieldNPS1.Caption = "Results";
			this.fieldNPS1.FieldName = "NPS";
			this.fieldNPS1.Name = "fieldNPS1";
			this.fieldNPS1.ToolTips.HeaderText = "Results vs+Num+Set";
			// 
			// fieldWTN1
			// 
			this.fieldWTN1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
			this.fieldWTN1.AreaIndex = 4;
			this.fieldWTN1.Caption = "WN";
			this.fieldWTN1.CellFormat.FormatString = "#";
			this.fieldWTN1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldWTN1.FieldName = "WTN";
			this.fieldWTN1.Name = "fieldWTN1";
			this.fieldWTN1.ToolTips.HeaderText = "WonNumber";
			this.fieldWTN1.Width = 60;
			// 
			// fieldWTS1
			// 
			this.fieldWTS1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
			this.fieldWTS1.AreaIndex = 5;
			this.fieldWTS1.Caption = "WS";
			this.fieldWTS1.CellFormat.FormatString = "#";
			this.fieldWTS1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldWTS1.FieldName = "WTS";
			this.fieldWTS1.Name = "fieldWTS1";
			this.fieldWTS1.ToolTips.HeaderText = "WonSet";
			this.fieldWTS1.Width = 60;
			// 
			// fieldWTM1
			// 
			this.fieldWTM1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
			this.fieldWTM1.Appearance.Value.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.fieldWTM1.Appearance.Value.Options.UseBackColor = true;
			this.fieldWTM1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldWTM1.AreaIndex = 0;
			this.fieldWTM1.Caption = "WM";
			this.fieldWTM1.CellFormat.FormatString = "#";
			this.fieldWTM1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldWTM1.FieldName = "WTM";
			this.fieldWTM1.Name = "fieldWTM1";
			this.fieldWTM1.ToolTips.HeaderText = "WonMatch";
			this.fieldWTM1.Width = 33;
			// 
			// fieldLTN1
			// 
			this.fieldLTN1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
			this.fieldLTN1.AreaIndex = 6;
			this.fieldLTN1.Caption = "LN";
			this.fieldLTN1.CellFormat.FormatString = "#";
			this.fieldLTN1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldLTN1.FieldName = "LTN";
			this.fieldLTN1.Name = "fieldLTN1";
			this.fieldLTN1.ToolTips.HeaderText = "LostNum";
			this.fieldLTN1.Width = 60;
			// 
			// fieldLTS1
			// 
			this.fieldLTS1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
			this.fieldLTS1.AreaIndex = 7;
			this.fieldLTS1.Caption = "LS";
			this.fieldLTS1.CellFormat.FormatString = "#";
			this.fieldLTS1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldLTS1.FieldName = "LTS";
			this.fieldLTS1.Name = "fieldLTS1";
			this.fieldLTS1.ToolTips.HeaderText = "LostSet";
			this.fieldLTS1.Width = 60;
			// 
			// fieldLTM1
			// 
			this.fieldLTM1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
			this.fieldLTM1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldLTM1.AreaIndex = 1;
			this.fieldLTM1.Caption = "LM";
			this.fieldLTM1.CellFormat.FormatString = "#";
			this.fieldLTM1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldLTM1.FieldName = "LTM";
			this.fieldLTM1.Name = "fieldLTM1";
			this.fieldLTM1.ToolTips.HeaderText = "LostMatch";
			this.fieldLTM1.Width = 33;
			// 
			// fieldTS1
			// 
			this.fieldTS1.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
			this.fieldTS1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
			this.fieldTS1.AreaIndex = 2;
			this.fieldTS1.Caption = "Score";
			this.fieldTS1.CellFormat.FormatString = "#";
			this.fieldTS1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.fieldTS1.FieldName = "TS";
			this.fieldTS1.Name = "fieldTS1";
			this.fieldTS1.ToolTips.HeaderText = "Score";
			this.fieldTS1.Width = 36;
			// 
			// fieldCLG
			// 
			this.fieldCLG.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
			this.fieldCLG.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
			this.fieldCLG.AreaIndex = 1;
			this.fieldCLG.FieldName = "CLG";
			this.fieldCLG.Name = "fieldCLG";
			// 
			// layoutControl1
			// 
			this.layoutControl1.Controls.Add(this.gridControl1);
			this.layoutControl1.Controls.Add(this.pivotGridControl1);
			this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.layoutControl1.Location = new System.Drawing.Point(0, 0);
			this.layoutControl1.Name = "layoutControl1";
			this.layoutControl1.Root = this.layoutControlGroup1;
			this.layoutControl1.Size = new System.Drawing.Size(1127, 437);
			this.layoutControl1.TabIndex = 1;
			this.layoutControl1.Text = "layoutControl1";
			// 
			// gridControl1
			// 
			this.gridControl1.DataSource = this.RprELRBindingSource;
			this.gridControl1.Location = new System.Drawing.Point(24, 46);
			this.gridControl1.MainView = this.gridView1;
			this.gridControl1.Name = "gridControl1";
			this.gridControl1.Size = new System.Drawing.Size(1079, 367);
			this.gridControl1.TabIndex = 4;
			this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colETID,
            this.colCLG,
            this.colCS,
            this.colLAP,
            this.colGRP,
            this.colGI,
            this.colGR,
            this.colPC,
            this.colPCNM,
            this.colNPS,
            this.colWTN,
            this.colWTS,
            this.colWTM,
            this.colLTN,
            this.colLTS,
            this.colLTM,
            this.colTS});
			this.gridView1.GridControl = this.gridControl1;
			this.gridView1.GroupCount = 2;
			this.gridView1.Name = "gridView1";
			this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colETID, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCLG, DevExpress.Data.ColumnSortOrder.Ascending)});
			// 
			// colETID
			// 
			this.colETID.Caption = "Event";
			this.colETID.FieldName = "ETID";
			this.colETID.Name = "colETID";
			this.colETID.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colETID.Visible = true;
			this.colETID.VisibleIndex = 0;
			this.colETID.Width = 101;
			// 
			// colCLG
			// 
			this.colCLG.FieldName = "CLG";
			this.colCLG.Name = "colCLG";
			this.colCLG.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colCLG.Visible = true;
			this.colCLG.VisibleIndex = 14;
			// 
			// colCS
			// 
			this.colCS.Caption = "C/C";
			this.colCS.FieldName = "CS";
			this.colCS.Name = "colCS";
			this.colCS.OptionsColumn.FixedWidth = true;
			this.colCS.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colCS.ToolTip = "Competition/Consolation";
			this.colCS.Width = 50;
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
			this.colLAP.OptionsColumn.FixedWidth = true;
			this.colLAP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colLAP.Width = 30;
			// 
			// colGRP
			// 
			this.colGRP.AppearanceCell.Options.UseTextOptions = true;
			this.colGRP.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGRP.AppearanceHeader.Options.UseTextOptions = true;
			this.colGRP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGRP.Caption = "Grp";
			this.colGRP.FieldName = "GRP";
			this.colGRP.Name = "colGRP";
			this.colGRP.OptionsColumn.FixedWidth = true;
			this.colGRP.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colGRP.Width = 30;
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
			this.colGI.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colGI.ToolTip = "GrupIndex";
			this.colGI.Visible = true;
			this.colGI.VisibleIndex = 1;
			this.colGI.Width = 30;
			// 
			// colGR
			// 
			this.colGR.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colGR.AppearanceCell.Options.UseBackColor = true;
			this.colGR.AppearanceCell.Options.UseTextOptions = true;
			this.colGR.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGR.AppearanceHeader.Options.UseTextOptions = true;
			this.colGR.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colGR.FieldName = "GR";
			this.colGR.Name = "colGR";
			this.colGR.OptionsColumn.FixedWidth = true;
			this.colGR.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
			this.colGR.ToolTip = "GrupRank";
			this.colGR.Visible = true;
			this.colGR.VisibleIndex = 10;
			this.colGR.Width = 40;
			// 
			// colPC
			// 
			this.colPC.FieldName = "PC";
			this.colPC.Name = "colPC";
			this.colPC.ToolTip = "ParticipantCode";
			// 
			// colPCNM
			// 
			this.colPCNM.Caption = "Participant";
			this.colPCNM.FieldName = "PCNM";
			this.colPCNM.Name = "colPCNM";
			this.colPCNM.ToolTip = "ParticipantName";
			this.colPCNM.Visible = true;
			this.colPCNM.VisibleIndex = 0;
			this.colPCNM.Width = 258;
			// 
			// colNPS
			// 
			this.colNPS.Caption = "Results";
			this.colNPS.FieldName = "NPS";
			this.colNPS.Name = "colNPS";
			this.colNPS.ToolTip = "Results vs+Num+Set";
			this.colNPS.Visible = true;
			this.colNPS.VisibleIndex = 2;
			this.colNPS.Width = 363;
			// 
			// colWTN
			// 
			this.colWTN.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.colWTN.AppearanceCell.Options.UseBackColor = true;
			this.colWTN.AppearanceCell.Options.UseTextOptions = true;
			this.colWTN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWTN.AppearanceHeader.Options.UseTextOptions = true;
			this.colWTN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWTN.Caption = "WN";
			this.colWTN.DisplayFormat.FormatString = "#";
			this.colWTN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colWTN.FieldName = "WTN";
			this.colWTN.Name = "colWTN";
			this.colWTN.OptionsColumn.FixedWidth = true;
			this.colWTN.ToolTip = "WonNum";
			this.colWTN.Visible = true;
			this.colWTN.VisibleIndex = 6;
			this.colWTN.Width = 40;
			// 
			// colWTS
			// 
			this.colWTS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.colWTS.AppearanceCell.Options.UseBackColor = true;
			this.colWTS.AppearanceCell.Options.UseTextOptions = true;
			this.colWTS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWTS.AppearanceHeader.Options.UseTextOptions = true;
			this.colWTS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWTS.Caption = "WS";
			this.colWTS.DisplayFormat.FormatString = "#";
			this.colWTS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colWTS.FieldName = "WTS";
			this.colWTS.Name = "colWTS";
			this.colWTS.OptionsColumn.FixedWidth = true;
			this.colWTS.ToolTip = "WonSet";
			this.colWTS.Visible = true;
			this.colWTS.VisibleIndex = 7;
			this.colWTS.Width = 40;
			// 
			// colWTM
			// 
			this.colWTM.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.colWTM.AppearanceCell.Options.UseBackColor = true;
			this.colWTM.AppearanceCell.Options.UseTextOptions = true;
			this.colWTM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWTM.AppearanceHeader.Options.UseTextOptions = true;
			this.colWTM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colWTM.Caption = "WM";
			this.colWTM.DisplayFormat.FormatString = "#";
			this.colWTM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colWTM.FieldName = "WTM";
			this.colWTM.Name = "colWTM";
			this.colWTM.OptionsColumn.FixedWidth = true;
			this.colWTM.ToolTip = "WonMatch";
			this.colWTM.Visible = true;
			this.colWTM.VisibleIndex = 8;
			this.colWTM.Width = 40;
			// 
			// colLTN
			// 
			this.colLTN.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colLTN.AppearanceCell.Options.UseBackColor = true;
			this.colLTN.AppearanceCell.Options.UseTextOptions = true;
			this.colLTN.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLTN.AppearanceHeader.Options.UseTextOptions = true;
			this.colLTN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLTN.Caption = "LN";
			this.colLTN.DisplayFormat.FormatString = "#";
			this.colLTN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colLTN.FieldName = "LTN";
			this.colLTN.Name = "colLTN";
			this.colLTN.OptionsColumn.FixedWidth = true;
			this.colLTN.ToolTip = "LostNum";
			this.colLTN.Visible = true;
			this.colLTN.VisibleIndex = 3;
			this.colLTN.Width = 40;
			// 
			// colLTS
			// 
			this.colLTS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colLTS.AppearanceCell.Options.UseBackColor = true;
			this.colLTS.AppearanceCell.Options.UseTextOptions = true;
			this.colLTS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLTS.AppearanceHeader.Options.UseTextOptions = true;
			this.colLTS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLTS.Caption = "LS";
			this.colLTS.DisplayFormat.FormatString = "#";
			this.colLTS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colLTS.FieldName = "LTS";
			this.colLTS.Name = "colLTS";
			this.colLTS.OptionsColumn.FixedWidth = true;
			this.colLTS.ToolTip = "LostSet";
			this.colLTS.Visible = true;
			this.colLTS.VisibleIndex = 4;
			this.colLTS.Width = 40;
			// 
			// colLTM
			// 
			this.colLTM.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colLTM.AppearanceCell.Options.UseBackColor = true;
			this.colLTM.AppearanceCell.Options.UseTextOptions = true;
			this.colLTM.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLTM.AppearanceHeader.Options.UseTextOptions = true;
			this.colLTM.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colLTM.Caption = "LM";
			this.colLTM.DisplayFormat.FormatString = "#";
			this.colLTM.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colLTM.FieldName = "LTM";
			this.colLTM.Name = "colLTM";
			this.colLTM.OptionsColumn.FixedWidth = true;
			this.colLTM.ToolTip = "LostMatch";
			this.colLTM.Visible = true;
			this.colLTM.VisibleIndex = 5;
			this.colLTM.Width = 40;
			// 
			// colTS
			// 
			this.colTS.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.colTS.AppearanceCell.Options.UseBackColor = true;
			this.colTS.AppearanceCell.Options.UseTextOptions = true;
			this.colTS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colTS.AppearanceHeader.Options.UseTextOptions = true;
			this.colTS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colTS.Caption = "Score";
			this.colTS.DisplayFormat.FormatString = "#";
			this.colTS.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.colTS.FieldName = "TS";
			this.colTS.Name = "colTS";
			this.colTS.OptionsColumn.FixedWidth = true;
			this.colTS.ToolTip = "Score";
			this.colTS.Visible = true;
			this.colTS.VisibleIndex = 9;
			this.colTS.Width = 40;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tabbedControlGroup1});
			this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(1127, 437);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// tabbedControlGroup1
			// 
			this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
			this.tabbedControlGroup1.Name = "tabbedControlGroup1";
			this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup2;
			this.tabbedControlGroup1.SelectedTabPageIndex = 0;
			this.tabbedControlGroup1.Size = new System.Drawing.Size(1107, 417);
			this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "layoutControlGroup2";
			this.layoutControlGroup2.Size = new System.Drawing.Size(1083, 371);
			this.layoutControlGroup2.Text = "Pivot";
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.pivotGridControl1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(1083, 371);
			this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlGroup3
			// 
			this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
			this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup3.Name = "layoutControlGroup3";
			this.layoutControlGroup3.Size = new System.Drawing.Size(1083, 371);
			this.layoutControlGroup3.Text = "Grid";
			// 
			// layoutControlItem2
			// 
			this.layoutControlItem2.Control = this.gridControl1;
			this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlItem2.Name = "layoutControlItem2";
			this.layoutControlItem2.Size = new System.Drawing.Size(1083, 371);
			this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem2.TextVisible = false;
			// 
			// RprELRXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1127, 437);
			this.Controls.Add(this.layoutControl1);
			this.Name = "RprELRXF";
			this.Text = "Results";
			this.Load += new System.EventHandler(this.RprELRXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.RprELRBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
			this.layoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource RprELRBindingSource;
        private ReportDataSetTableAdapters.RPR_ELRTableAdapter RprELRTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldETID1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCS1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLAP1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGRP1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGI1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGR1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPC1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPCNM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNPS1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWTN1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWTS1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldWTM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLTN1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLTS1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLTM1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldTS1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colETID;
        private DevExpress.XtraGrid.Columns.GridColumn colCS;
        private DevExpress.XtraGrid.Columns.GridColumn colLAP;
        private DevExpress.XtraGrid.Columns.GridColumn colGRP;
        private DevExpress.XtraGrid.Columns.GridColumn colGI;
        private DevExpress.XtraGrid.Columns.GridColumn colGR;
        private DevExpress.XtraGrid.Columns.GridColumn colPC;
        private DevExpress.XtraGrid.Columns.GridColumn colPCNM;
        private DevExpress.XtraGrid.Columns.GridColumn colNPS;
        private DevExpress.XtraGrid.Columns.GridColumn colWTN;
        private DevExpress.XtraGrid.Columns.GridColumn colWTS;
        private DevExpress.XtraGrid.Columns.GridColumn colWTM;
        private DevExpress.XtraGrid.Columns.GridColumn colLTN;
        private DevExpress.XtraGrid.Columns.GridColumn colLTS;
        private DevExpress.XtraGrid.Columns.GridColumn colLTM;
        private DevExpress.XtraGrid.Columns.GridColumn colTS;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.Columns.GridColumn colCLG;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCLG;
    }
}