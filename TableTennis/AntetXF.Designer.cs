namespace TableTennis
{
    partial class AntetXF
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
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.antetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new TableTennis.DataSet();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.antetTableAdapter = new TableTennis.DataSetTableAdapters.ANTETTableAdapter();
            this.richEditControl2 = new DevExpress.XtraRichEdit.RichEditControl();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.antetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl1.DataBindings.Add(new System.Windows.Forms.Binding("RtfText", this.antetBindingSource, "HEADER", true));
            this.richEditControl1.EnableToolTips = true;
            this.richEditControl1.Location = new System.Drawing.Point(12, 28);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Options.Bookmarks.AllowNameResolution = false;
            this.richEditControl1.Size = new System.Drawing.Size(1059, 242);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "HEADER";
            // 
            // antetBindingSource
            // 
            this.antetBindingSource.DataMember = "ANTET";
            this.antetBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.CaseSensitive = true;
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.richEditControl2);
            this.layoutControl1.Controls.Add(this.richEditControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1234, 169, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1083, 539);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1083, 539);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.richEditControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1063, 262);
            this.layoutControlItem1.Text = "Header";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(35, 13);
            // 
            // antetTableAdapter
            // 
            this.antetTableAdapter.ClearBeforeFill = true;
            // 
            // richEditControl2
            // 
            this.richEditControl2.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl2.DataBindings.Add(new System.Windows.Forms.Binding("RtfText", this.antetBindingSource, "FOOTER", true));
            this.richEditControl2.EnableToolTips = true;
            this.richEditControl2.Location = new System.Drawing.Point(12, 295);
            this.richEditControl2.Name = "richEditControl2";
            this.richEditControl2.Options.Bookmarks.AllowNameResolution = false;
            this.richEditControl2.Size = new System.Drawing.Size(1059, 232);
            this.richEditControl2.TabIndex = 4;
            this.richEditControl2.Text = "FOOTER";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.richEditControl2;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 267);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1063, 252);
            this.layoutControlItem2.Text = "Footer";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(35, 13);
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            this.splitterItem1.Location = new System.Drawing.Point(0, 262);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(1063, 5);
            // 
            // AntetXF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 539);
            this.Controls.Add(this.layoutControl1);
            this.Name = "AntetXF";
            this.Text = "AntetXF";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AntetXF_FormClosing);
            this.Load += new System.EventHandler(this.AntetXF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.antetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource antetBindingSource;
        private DataSetTableAdapters.ANTETTableAdapter antetTableAdapter;
        private DevExpress.XtraRichEdit.RichEditControl richEditControl2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
    }
}