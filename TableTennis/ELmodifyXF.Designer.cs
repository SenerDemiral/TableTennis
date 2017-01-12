namespace TableTennis
{
    partial class ELmodifyXF
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
            this.queriesTableAdapter = new TableTennis.DataSetTableAdapters.QueriesTableAdapter();
            this.dataSet = new TableTennis.DataSet();
            this.etBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etTableAdapter = new TableTennis.DataSetTableAdapters.ETTableAdapter();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.actionRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.ETlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForetID = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.GTlookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gtBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gtTableAdapter = new TableTennis.DataSetTableAdapters.GTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actionRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForetID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTlookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtBindingSource)).BeginInit();
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
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.GTlookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.actionRadioGroup);
            this.dataLayoutControl1.Controls.Add(this.simpleButton1);
            this.dataLayoutControl1.Controls.Add(this.ETlookUpEdit);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(469, 123, 250, 350);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(284, 201);
            this.dataLayoutControl1.TabIndex = 3;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // actionRadioGroup
            // 
            this.actionRadioGroup.EditValue = "C";
            this.actionRadioGroup.Location = new System.Drawing.Point(12, 108);
            this.actionRadioGroup.Name = "actionRadioGroup";
            this.actionRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("D", "Delete"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Create")});
            this.actionRadioGroup.Size = new System.Drawing.Size(260, 51);
            this.actionRadioGroup.StyleController = this.dataLayoutControl1;
            this.actionRadioGroup.TabIndex = 1;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 163);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(260, 22);
            this.simpleButton1.StyleController = this.dataLayoutControl1;
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "EXECUTE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ETlookUpEdit
            // 
            this.ETlookUpEdit.Location = new System.Drawing.Point(12, 68);
            this.ETlookUpEdit.Name = "ETlookUpEdit";
            this.ETlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ETlookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FULLNAME", "FULLNAME", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ETID", "ETID", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.ETlookUpEdit.Properties.DataSource = this.etBindingSource;
            this.ETlookUpEdit.Properties.DisplayMember = "FULLNAME";
            this.ETlookUpEdit.Properties.NullText = "";
            this.ETlookUpEdit.Properties.ValueMember = "ETID";
            this.ETlookUpEdit.Size = new System.Drawing.Size(260, 20);
            this.ETlookUpEdit.StyleController = this.dataLayoutControl1;
            this.ETlookUpEdit.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(284, 201);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForetID,
            this.layoutControlItem2});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(264, 80);
            // 
            // ItemForetID
            // 
            this.ItemForetID.Control = this.ETlookUpEdit;
            this.ItemForetID.Location = new System.Drawing.Point(0, 40);
            this.ItemForetID.Name = "ItemForetID";
            this.ItemForetID.Size = new System.Drawing.Size(264, 40);
            this.ItemForetID.Text = "Event";
            this.ItemForetID.TextLocation = DevExpress.Utils.Locations.Top;
            this.ItemForetID.TextSize = new System.Drawing.Size(44, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.simpleButton1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 151);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(264, 30);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.actionRadioGroup;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 80);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 71);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(54, 71);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(264, 71);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "Action";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(44, 13);
            // 
            // GTlookUpEdit
            // 
            this.GTlookUpEdit.Location = new System.Drawing.Point(12, 28);
            this.GTlookUpEdit.Name = "GTlookUpEdit";
            this.GTlookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.GTlookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NAME", "NAME", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TYP", "TYP", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("NOP", "NOP", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PPG", "PPG", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("GTID", "GTID", 20, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far)});
            this.GTlookUpEdit.Properties.DataSource = this.gtBindingSource;
            this.GTlookUpEdit.Properties.DisplayMember = "NAME";
            this.GTlookUpEdit.Properties.NullText = "";
            this.GTlookUpEdit.Properties.ValueMember = "GTID";
            this.GTlookUpEdit.Size = new System.Drawing.Size(260, 20);
            this.GTlookUpEdit.StyleController = this.dataLayoutControl1;
            this.GTlookUpEdit.TabIndex = 6;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.GTlookUpEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(264, 40);
            this.layoutControlItem2.Text = "Template";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(44, 13);
            // 
            // gtBindingSource
            // 
            this.gtBindingSource.DataMember = "GT";
            this.gtBindingSource.DataSource = this.dataSet;
            // 
            // gtTableAdapter
            // 
            this.gtTableAdapter.ClearBeforeFill = true;
            // 
            // ELmodifyXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "ELmodifyXF";
            this.Text = "Create/Remove Laps";
            this.Load += new System.EventHandler(this.ELmodifyXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.actionRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ETlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForetID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTlookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gtBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource etBindingSource;
        private DataSetTableAdapters.ETTableAdapter etTableAdapter;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.RadioGroup actionRadioGroup;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit ETlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForetID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.LookUpEdit GTlookUpEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.BindingSource gtBindingSource;
        private DataSetTableAdapters.GTTableAdapter gtTableAdapter;
    }
}