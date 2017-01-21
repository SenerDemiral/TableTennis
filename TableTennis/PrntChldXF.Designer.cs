namespace TableTennis
{
	partial class PrntChldXF
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
			if(disposing && (components != null)) {
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
			DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrntChldXF));
			this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colPID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.pRNTGridControl = new DevExpress.XtraGrid.GridControl();
			this.pRNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataSet = new TableTennis.DataSet();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
			this.prntTableAdapter = new TableTennis.DataSetTableAdapters.PRNTTableAdapter();
			this.pRNTBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
			this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
			this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
			this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.pRNTBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.chldTableAdapter = new TableTennis.DataSetTableAdapters.CHLDTableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pRNTGridControl)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pRNTBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pRNTBindingNavigator)).BeginInit();
			this.pRNTBindingNavigator.SuspendLayout();
			this.SuspendLayout();
			// 
			// gridView2
			// 
			this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colPID,
            this.colNAME1});
			this.gridView2.GridControl = this.pRNTGridControl;
			this.gridView2.Name = "gridView2";
			// 
			// colID1
			// 
			this.colID1.FieldName = "ID";
			this.colID1.Name = "colID1";
			this.colID1.Visible = true;
			this.colID1.VisibleIndex = 0;
			// 
			// colPID
			// 
			this.colPID.FieldName = "PID";
			this.colPID.Name = "colPID";
			this.colPID.Visible = true;
			this.colPID.VisibleIndex = 1;
			// 
			// colNAME1
			// 
			this.colNAME1.FieldName = "NAME";
			this.colNAME1.Name = "colNAME1";
			this.colNAME1.Visible = true;
			this.colNAME1.VisibleIndex = 2;
			// 
			// pRNTGridControl
			// 
			this.pRNTGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			gridLevelNode1.LevelTemplate = this.gridView2;
			gridLevelNode1.RelationName = "FK_CHLD_PRNT";
			this.pRNTGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
			this.pRNTGridControl.Location = new System.Drawing.Point(0, 25);
			this.pRNTGridControl.MainView = this.gridView1;
			this.pRNTGridControl.Name = "pRNTGridControl";
			this.pRNTGridControl.Size = new System.Drawing.Size(672, 236);
			this.pRNTGridControl.TabIndex = 1;
			this.pRNTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.gridView2});
			// 
			// pRNTBindingSource
			// 
			this.pRNTBindingSource.DataMember = "PRNT";
			this.pRNTBindingSource.DataSource = this.dataSet;
			// 
			// dataSet
			// 
			this.dataSet.CaseSensitive = true;
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNAME});
			this.gridView1.GridControl = this.pRNTGridControl;
			this.gridView1.Name = "gridView1";
			// 
			// colID
			// 
			this.colID.FieldName = "ID";
			this.colID.Name = "colID";
			this.colID.Visible = true;
			this.colID.VisibleIndex = 0;
			// 
			// colNAME
			// 
			this.colNAME.FieldName = "NAME";
			this.colNAME.Name = "colNAME";
			this.colNAME.Visible = true;
			this.colNAME.VisibleIndex = 1;
			// 
			// prntTableAdapter
			// 
			this.prntTableAdapter.ClearBeforeFill = true;
			// 
			// pRNTBindingNavigator
			// 
			this.pRNTBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.pRNTBindingNavigator.BindingSource = this.pRNTBindingSource;
			this.pRNTBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.pRNTBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.pRNTBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pRNTBindingNavigatorSaveItem});
			this.pRNTBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.pRNTBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.pRNTBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.pRNTBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.pRNTBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.pRNTBindingNavigator.Name = "pRNTBindingNavigator";
			this.pRNTBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.pRNTBindingNavigator.Size = new System.Drawing.Size(672, 25);
			this.pRNTBindingNavigator.TabIndex = 0;
			this.pRNTBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// pRNTBindingNavigatorSaveItem
			// 
			this.pRNTBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.pRNTBindingNavigatorSaveItem.Enabled = false;
			this.pRNTBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pRNTBindingNavigatorSaveItem.Image")));
			this.pRNTBindingNavigatorSaveItem.Name = "pRNTBindingNavigatorSaveItem";
			this.pRNTBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
			this.pRNTBindingNavigatorSaveItem.Text = "Save Data";
			// 
			// chldTableAdapter
			// 
			this.chldTableAdapter.ClearBeforeFill = true;
			// 
			// PrntChldXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(672, 261);
			this.Controls.Add(this.pRNTGridControl);
			this.Controls.Add(this.pRNTBindingNavigator);
			this.Name = "PrntChldXF";
			this.Text = "PrntChldXF";
			this.Load += new System.EventHandler(this.PrntChldXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pRNTGridControl)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pRNTBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pRNTBindingNavigator)).EndInit();
			this.pRNTBindingNavigator.ResumeLayout(false);
			this.pRNTBindingNavigator.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataSet dataSet;
		private System.Windows.Forms.BindingSource pRNTBindingSource;
		private DataSetTableAdapters.PRNTTableAdapter prntTableAdapter;
		private System.Windows.Forms.BindingNavigator pRNTBindingNavigator;
		private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
		private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
		private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
		private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
		private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
		private System.Windows.Forms.ToolStripButton pRNTBindingNavigatorSaveItem;
		private DevExpress.XtraGrid.GridControl pRNTGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
		private DevExpress.XtraGrid.Columns.GridColumn colID1;
		private DevExpress.XtraGrid.Columns.GridColumn colPID;
		private DevExpress.XtraGrid.Columns.GridColumn colNAME1;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colID;
		private DevExpress.XtraGrid.Columns.GridColumn colNAME;
		private DataSetTableAdapters.CHLDTableAdapter chldTableAdapter;
	}
}