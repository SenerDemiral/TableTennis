namespace TableTennis.Report
{
    partial class RprELXF
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
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.rprELBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportDataSet = new TableTennis.Report.ReportDataSet();
            this.fieldETID = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldCS = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldLAP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldGRP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNOP = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNOM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPCNMS = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldNOG = new DevExpress.XtraPivotGrid.PivotGridField();
            this.rprELTableAdapter = new TableTennis.Report.ReportDataSetTableAdapters.RPR_ELTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rprELBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.DataSource = this.rprELBindingSource;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.fieldETID,
            this.fieldCS,
            this.fieldLAP,
            this.fieldGRP,
            this.fieldNOP,
            this.fieldNOM,
            this.fieldPCNMS,
            this.fieldNOG});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.Size = new System.Drawing.Size(392, 319);
            this.pivotGridControl1.TabIndex = 0;
            // 
            // rprELBindingSource
            // 
            this.rprELBindingSource.DataMember = "RPR_EL";
            this.rprELBindingSource.DataSource = this.reportDataSet;
            // 
            // reportDataSet
            // 
            this.reportDataSet.DataSetName = "ReportDataSet";
            this.reportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldETID
            // 
            this.fieldETID.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldETID.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldETID.AreaIndex = 0;
            this.fieldETID.Caption = "Event";
            this.fieldETID.FieldName = "ETID";
            this.fieldETID.Name = "fieldETID";
            this.fieldETID.Width = 161;
            // 
            // fieldCS
            // 
            this.fieldCS.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldCS.AreaIndex = 0;
            this.fieldCS.Caption = "Cmp/Cns";
            this.fieldCS.FieldName = "CS";
            this.fieldCS.Name = "fieldCS";
            // 
            // fieldLAP
            // 
            this.fieldLAP.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldLAP.AreaIndex = 1;
            this.fieldLAP.Caption = "Lap";
            this.fieldLAP.FieldName = "LAP";
            this.fieldLAP.Name = "fieldLAP";
            // 
            // fieldGRP
            // 
            this.fieldGRP.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)(((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.ColumnArea) 
            | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea)));
            this.fieldGRP.AreaIndex = 2;
            this.fieldGRP.Caption = "Grp";
            this.fieldGRP.FieldName = "GRP";
            this.fieldGRP.Name = "fieldGRP";
            // 
            // fieldNOP
            // 
            this.fieldNOP.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldNOP.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNOP.AreaIndex = 1;
            this.fieldNOP.FieldName = "NOP";
            this.fieldNOP.Name = "fieldNOP";
            this.fieldNOP.ToolTips.HeaderText = "Number of Party / Oynayan Taraf Sayısı";
            this.fieldNOP.Width = 50;
            // 
            // fieldNOM
            // 
            this.fieldNOM.AllowedAreas = ((DevExpress.XtraPivotGrid.PivotGridAllowedAreas)((DevExpress.XtraPivotGrid.PivotGridAllowedAreas.FilterArea | DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea)));
            this.fieldNOM.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNOM.AreaIndex = 0;
            this.fieldNOM.FieldName = "NOM";
            this.fieldNOM.Name = "fieldNOM";
            this.fieldNOM.ToolTips.HeaderText = "Number of Matchs / Maç Sayısı";
            this.fieldNOM.Width = 50;
            // 
            // fieldPCNMS
            // 
            this.fieldPCNMS.AreaIndex = 3;
            this.fieldPCNMS.Caption = "pNames";
            this.fieldPCNMS.FieldName = "PCNMS";
            this.fieldPCNMS.Name = "fieldPCNMS";
            // 
            // fieldNOG
            // 
            this.fieldNOG.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldNOG.AreaIndex = 2;
            this.fieldNOG.FieldName = "NOG";
            this.fieldNOG.Name = "fieldNOG";
            this.fieldNOG.ToolTips.HeaderText = "Number of Groups / Grup Sayısı";
            this.fieldNOG.Width = 50;
            // 
            // rprELTableAdapter
            // 
            this.rprELTableAdapter.ClearBeforeFill = true;
            // 
            // RprELXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 319);
            this.Controls.Add(this.pivotGridControl1);
            this.Name = "RprELXF";
            this.Text = "RprELXF";
            this.Load += new System.EventHandler(this.RprELXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rprELBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReportDataSet reportDataSet;
        private System.Windows.Forms.BindingSource rprELBindingSource;
        private ReportDataSetTableAdapters.RPR_ELTableAdapter rprELTableAdapter;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField fieldETID;
        private DevExpress.XtraPivotGrid.PivotGridField fieldCS;
        private DevExpress.XtraPivotGrid.PivotGridField fieldLAP;
        private DevExpress.XtraPivotGrid.PivotGridField fieldGRP;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNOP;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNOM;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPCNMS;
        private DevExpress.XtraPivotGrid.PivotGridField fieldNOG;
    }
}