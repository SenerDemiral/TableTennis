namespace TableTennis
{
    partial class ECmodifyXF
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
			this.queriesTableAdapter = new TableTennis.DataSetTableAdapters.QueriesTableAdapter();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.actionRadioGroup = new DevExpress.XtraEditors.RadioGroup();
			this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
			this.etIDLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.ItemForetID = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
			this.dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.actionRadioGroup.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.etIDLookUpEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForetID)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
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
			this.dataLayoutControl1.Controls.Add(this.actionRadioGroup);
			this.dataLayoutControl1.Controls.Add(this.simpleButton1);
			this.dataLayoutControl1.Controls.Add(this.etIDLookUpEdit);
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
			this.dataLayoutControl1.Name = "dataLayoutControl1";
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.dataLayoutControl1.Size = new System.Drawing.Size(180, 261);
			this.dataLayoutControl1.TabIndex = 2;
			this.dataLayoutControl1.Text = "dataLayoutControl1";
			// 
			// actionRadioGroup
			// 
			this.actionRadioGroup.EditValue = "C";
			this.actionRadioGroup.Location = new System.Drawing.Point(12, 52);
			this.actionRadioGroup.Name = "actionRadioGroup";
			this.actionRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("D", "Delete"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Create")});
			this.actionRadioGroup.Size = new System.Drawing.Size(156, 51);
			this.actionRadioGroup.StyleController = this.dataLayoutControl1;
			this.actionRadioGroup.TabIndex = 1;
			// 
			// simpleButton1
			// 
			this.simpleButton1.Location = new System.Drawing.Point(12, 107);
			this.simpleButton1.Name = "simpleButton1";
			this.simpleButton1.Size = new System.Drawing.Size(156, 22);
			this.simpleButton1.StyleController = this.dataLayoutControl1;
			this.simpleButton1.TabIndex = 7;
			this.simpleButton1.Text = "EXECUTE";
			this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
			// 
			// etIDLookUpEdit
			// 
			this.etIDLookUpEdit.Location = new System.Drawing.Point(45, 12);
			this.etIDLookUpEdit.Name = "etIDLookUpEdit";
			this.etIDLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.etIDLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FULLNAME", "FULLNAME", 61, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ETID", "ETID", 46, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
			this.etIDLookUpEdit.Properties.DataSource = this.etBindingSource;
			this.etIDLookUpEdit.Properties.DisplayMember = "FULLNAME";
			this.etIDLookUpEdit.Properties.NullText = "";
			this.etIDLookUpEdit.Properties.ValueMember = "ETID";
			this.etIDLookUpEdit.Size = new System.Drawing.Size(123, 20);
			this.etIDLookUpEdit.StyleController = this.dataLayoutControl1;
			this.etIDLookUpEdit.TabIndex = 5;
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
			this.layoutControlGroup1.Name = "layoutControlGroup1";
			this.layoutControlGroup1.Size = new System.Drawing.Size(180, 261);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.AllowDrawBackground = false;
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForetID});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
			this.layoutControlGroup2.Name = "autoGeneratedGroup0";
			this.layoutControlGroup2.Size = new System.Drawing.Size(160, 24);
			// 
			// ItemForetID
			// 
			this.ItemForetID.Control = this.etIDLookUpEdit;
			this.ItemForetID.Location = new System.Drawing.Point(0, 0);
			this.ItemForetID.Name = "ItemForetID";
			this.ItemForetID.Size = new System.Drawing.Size(160, 24);
			this.ItemForetID.Text = "Event";
			this.ItemForetID.TextSize = new System.Drawing.Size(30, 13);
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.simpleButton1;
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 95);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(160, 146);
			this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
			this.layoutControlItem1.TextVisible = false;
			// 
			// layoutControlItem3
			// 
			this.layoutControlItem3.Control = this.actionRadioGroup;
			this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
			this.layoutControlItem3.MaxSize = new System.Drawing.Size(0, 71);
			this.layoutControlItem3.MinSize = new System.Drawing.Size(54, 71);
			this.layoutControlItem3.Name = "layoutControlItem3";
			this.layoutControlItem3.Size = new System.Drawing.Size(160, 71);
			this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
			this.layoutControlItem3.Text = "Action";
			this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
			this.layoutControlItem3.TextSize = new System.Drawing.Size(30, 13);
			// 
			// ECmodifyXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.dataLayoutControl1);
			this.Name = "ECmodifyXF";
			this.Text = "Create/Remove Classification";
			this.Load += new System.EventHandler(this.ECmodifyXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.etBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
			this.dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.actionRadioGroup.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.etIDLookUpEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForetID)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DataSet dataSet;
        private System.Windows.Forms.BindingSource etBindingSource;
        private DataSetTableAdapters.ETTableAdapter etTableAdapter;
        private DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.RadioGroup actionRadioGroup;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LookUpEdit etIDLookUpEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForetID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}