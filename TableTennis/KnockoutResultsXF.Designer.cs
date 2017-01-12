namespace TableTennis
{
	partial class KnockoutResultsXF
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
			DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression1 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression2 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression3 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule4 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression4 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
			DevExpress.XtraGrid.GridFormatRule gridFormatRule5 = new DevExpress.XtraGrid.GridFormatRule();
			DevExpress.XtraEditors.FormatConditionRuleExpression formatConditionRuleExpression5 = new DevExpress.XtraEditors.FormatConditionRuleExpression();
			this.colL1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL1P = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL2P = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
			this.colL3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL3P = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL4P = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL5P = new DevExpress.XtraGrid.Columns.GridColumn();
			this.dataSet = new TableTennis.DataSet();
			this.kRBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.kRTableAdapter = new TableTennis.DataSetTableAdapters.KRTableAdapter();
			this.kRGridControl = new DevExpress.XtraGrid.GridControl();
			this.contectMenuScript = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.hideRoudCodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideR5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideR6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hideR7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.colIDX = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL6P = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL7 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL7P = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL8 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colL8P = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colF1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colF2 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colF3 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colF4 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colF5 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colF6 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.colF7 = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kRBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.kRGridControl)).BeginInit();
			this.contectMenuScript.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// colL1
			// 
			this.colL1.AppearanceCell.Options.UseTextOptions = true;
			this.colL1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL1.AppearanceHeader.Options.UseTextOptions = true;
			this.colL1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL1.Caption = "R1";
			this.colL1.FieldName = "L1";
			this.colL1.Name = "colL1";
			this.colL1.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
			this.colL1.OptionsColumn.FixedWidth = true;
			this.colL1.Visible = true;
			this.colL1.VisibleIndex = 1;
			this.colL1.Width = 30;
			// 
			// colL1P
			// 
			this.colL1P.Caption = "1. Round Participants";
			this.colL1P.FieldName = "L1P";
			this.colL1P.Name = "colL1P";
			this.colL1P.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
			this.colL1P.Visible = true;
			this.colL1P.VisibleIndex = 2;
			this.colL1P.Width = 123;
			// 
			// colL2
			// 
			this.colL2.AppearanceCell.Options.UseTextOptions = true;
			this.colL2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL2.AppearanceHeader.Options.UseTextOptions = true;
			this.colL2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL2.Caption = "R2";
			this.colL2.FieldName = "L2";
			this.colL2.Name = "colL2";
			this.colL2.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
			this.colL2.OptionsColumn.FixedWidth = true;
			this.colL2.Visible = true;
			this.colL2.VisibleIndex = 3;
			this.colL2.Width = 30;
			// 
			// colL2P
			// 
			this.colL2P.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colL2P.AppearanceCell.Options.UseFont = true;
			this.colL2P.AppearanceCell.Options.UseTextOptions = true;
			this.colL2P.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL2P.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
			this.colL2P.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colL2P.Caption = "2. Round Participants";
			this.colL2P.ColumnEdit = this.repositoryItemMemoEdit1;
			this.colL2P.FieldName = "L2P";
			this.colL2P.Name = "colL2P";
			this.colL2P.Visible = true;
			this.colL2P.VisibleIndex = 4;
			this.colL2P.Width = 123;
			// 
			// repositoryItemMemoEdit1
			// 
			this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
			// 
			// colL3
			// 
			this.colL3.AppearanceCell.Options.UseTextOptions = true;
			this.colL3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL3.AppearanceHeader.Options.UseTextOptions = true;
			this.colL3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL3.Caption = "R3";
			this.colL3.FieldName = "L3";
			this.colL3.Name = "colL3";
			this.colL3.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
			this.colL3.OptionsColumn.FixedWidth = true;
			this.colL3.Visible = true;
			this.colL3.VisibleIndex = 5;
			this.colL3.Width = 30;
			// 
			// colL3P
			// 
			this.colL3P.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colL3P.AppearanceCell.Options.UseFont = true;
			this.colL3P.AppearanceCell.Options.UseTextOptions = true;
			this.colL3P.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL3P.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
			this.colL3P.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colL3P.Caption = "3. Round Participants";
			this.colL3P.ColumnEdit = this.repositoryItemMemoEdit1;
			this.colL3P.FieldName = "L3P";
			this.colL3P.Name = "colL3P";
			this.colL3P.Visible = true;
			this.colL3P.VisibleIndex = 6;
			this.colL3P.Width = 123;
			// 
			// colL4
			// 
			this.colL4.AppearanceCell.Options.UseTextOptions = true;
			this.colL4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL4.AppearanceHeader.Options.UseTextOptions = true;
			this.colL4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL4.Caption = "R4";
			this.colL4.FieldName = "L4";
			this.colL4.Name = "colL4";
			this.colL4.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
			this.colL4.OptionsColumn.FixedWidth = true;
			this.colL4.Visible = true;
			this.colL4.VisibleIndex = 7;
			this.colL4.Width = 30;
			// 
			// colL4P
			// 
			this.colL4P.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colL4P.AppearanceCell.Options.UseFont = true;
			this.colL4P.AppearanceCell.Options.UseTextOptions = true;
			this.colL4P.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL4P.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
			this.colL4P.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colL4P.Caption = "4. Round Participants";
			this.colL4P.ColumnEdit = this.repositoryItemMemoEdit1;
			this.colL4P.FieldName = "L4P";
			this.colL4P.Name = "colL4P";
			this.colL4P.Visible = true;
			this.colL4P.VisibleIndex = 8;
			this.colL4P.Width = 123;
			// 
			// colL5
			// 
			this.colL5.AppearanceCell.Options.UseTextOptions = true;
			this.colL5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL5.AppearanceHeader.Options.UseTextOptions = true;
			this.colL5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL5.Caption = "R5";
			this.colL5.FieldName = "L5";
			this.colL5.Name = "colL5";
			this.colL5.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
			this.colL5.OptionsColumn.FixedWidth = true;
			this.colL5.Visible = true;
			this.colL5.VisibleIndex = 9;
			this.colL5.Width = 30;
			// 
			// colL5P
			// 
			this.colL5P.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colL5P.AppearanceCell.Options.UseFont = true;
			this.colL5P.AppearanceCell.Options.UseTextOptions = true;
			this.colL5P.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL5P.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
			this.colL5P.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colL5P.Caption = "5. Round Participants";
			this.colL5P.ColumnEdit = this.repositoryItemMemoEdit1;
			this.colL5P.FieldName = "L5P";
			this.colL5P.Name = "colL5P";
			this.colL5P.Visible = true;
			this.colL5P.VisibleIndex = 10;
			this.colL5P.Width = 123;
			// 
			// dataSet
			// 
			this.dataSet.CaseSensitive = true;
			this.dataSet.DataSetName = "DataSet";
			this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// kRBindingSource
			// 
			this.kRBindingSource.DataMember = "KR";
			this.kRBindingSource.DataSource = this.dataSet;
			// 
			// kRTableAdapter
			// 
			this.kRTableAdapter.ClearBeforeFill = true;
			// 
			// kRGridControl
			// 
			this.kRGridControl.ContextMenuStrip = this.contectMenuScript;
			this.kRGridControl.DataSource = this.kRBindingSource;
			this.kRGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.kRGridControl.Location = new System.Drawing.Point(0, 0);
			this.kRGridControl.MainView = this.gridView1;
			this.kRGridControl.Name = "kRGridControl";
			this.kRGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
			this.kRGridControl.Size = new System.Drawing.Size(939, 319);
			this.kRGridControl.TabIndex = 1;
			this.kRGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
			// 
			// contectMenuScript
			// 
			this.contectMenuScript.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem,
            this.toolStripSeparator1,
            this.hideRoudCodesToolStripMenuItem,
            this.hideR5ToolStripMenuItem,
            this.hideR6ToolStripMenuItem,
            this.hideR7ToolStripMenuItem});
			this.contectMenuScript.Name = "contectMenuScript";
			this.contectMenuScript.Size = new System.Drawing.Size(167, 120);
			// 
			// exportToolStripMenuItem
			// 
			this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
			this.exportToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.exportToolStripMenuItem.Text = "Export";
			this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
			// 
			// hideRoudCodesToolStripMenuItem
			// 
			this.hideRoudCodesToolStripMenuItem.Name = "hideRoudCodesToolStripMenuItem";
			this.hideRoudCodesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.hideRoudCodesToolStripMenuItem.Text = "Hide Roud Codes";
			this.hideRoudCodesToolStripMenuItem.Click += new System.EventHandler(this.hideRoudCodesToolStripMenuItem_Click);
			// 
			// hideR5ToolStripMenuItem
			// 
			this.hideR5ToolStripMenuItem.Name = "hideR5ToolStripMenuItem";
			this.hideR5ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.hideR5ToolStripMenuItem.Text = "Hide >= R5";
			this.hideR5ToolStripMenuItem.Visible = false;
			this.hideR5ToolStripMenuItem.Click += new System.EventHandler(this.hideR5ToolStripMenuItem_Click);
			// 
			// hideR6ToolStripMenuItem
			// 
			this.hideR6ToolStripMenuItem.Name = "hideR6ToolStripMenuItem";
			this.hideR6ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.hideR6ToolStripMenuItem.Text = "Hide >= R6";
			this.hideR6ToolStripMenuItem.Visible = false;
			this.hideR6ToolStripMenuItem.Click += new System.EventHandler(this.hideR6ToolStripMenuItem_Click);
			// 
			// hideR7ToolStripMenuItem
			// 
			this.hideR7ToolStripMenuItem.Name = "hideR7ToolStripMenuItem";
			this.hideR7ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.hideR7ToolStripMenuItem.Text = "Hide >= R7";
			this.hideR7ToolStripMenuItem.Visible = false;
			this.hideR7ToolStripMenuItem.Click += new System.EventHandler(this.hideR7ToolStripMenuItem_Click);
			// 
			// gridView1
			// 
			this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDX,
            this.colL1,
            this.colL1P,
            this.colL2,
            this.colL2P,
            this.colL3,
            this.colL3P,
            this.colL4,
            this.colL4P,
            this.colL5,
            this.colL5P,
            this.colL6,
            this.colL6P,
            this.colL7,
            this.colL7P,
            this.colL8,
            this.colL8P,
            this.colF1,
            this.colF2,
            this.colF3,
            this.colF4,
            this.colF5,
            this.colF6,
            this.colF7});
			gridFormatRule1.Column = this.colL1;
			gridFormatRule1.ColumnApplyTo = this.colL1P;
			gridFormatRule1.Name = "Format0";
			formatConditionRuleExpression1.Appearance.BackColor = System.Drawing.Color.Cornsilk;
			formatConditionRuleExpression1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			formatConditionRuleExpression1.Appearance.Options.UseBackColor = true;
			formatConditionRuleExpression1.Appearance.Options.UseFont = true;
			formatConditionRuleExpression1.Expression = "[F1] = \'0\'";
			gridFormatRule1.Rule = formatConditionRuleExpression1;
			gridFormatRule2.Column = this.colL2;
			gridFormatRule2.ColumnApplyTo = this.colL2P;
			gridFormatRule2.Name = "Format1";
			formatConditionRuleExpression2.Appearance.BackColor = System.Drawing.Color.Cornsilk;
			formatConditionRuleExpression2.Appearance.Options.UseBackColor = true;
			formatConditionRuleExpression2.Expression = "[F2] = \'0\'";
			gridFormatRule2.Rule = formatConditionRuleExpression2;
			gridFormatRule3.Column = this.colL3;
			gridFormatRule3.ColumnApplyTo = this.colL3P;
			gridFormatRule3.Name = "Format2";
			formatConditionRuleExpression3.Appearance.BackColor = System.Drawing.Color.Cornsilk;
			formatConditionRuleExpression3.Appearance.Options.UseBackColor = true;
			formatConditionRuleExpression3.Expression = "[F3] = \'0\'";
			gridFormatRule3.Rule = formatConditionRuleExpression3;
			gridFormatRule4.Column = this.colL4;
			gridFormatRule4.ColumnApplyTo = this.colL4P;
			gridFormatRule4.Name = "Format3";
			formatConditionRuleExpression4.Appearance.BackColor = System.Drawing.Color.Cornsilk;
			formatConditionRuleExpression4.Appearance.Options.UseBackColor = true;
			formatConditionRuleExpression4.Expression = "[F4] = \'0\'";
			gridFormatRule4.Rule = formatConditionRuleExpression4;
			gridFormatRule5.Column = this.colL5;
			gridFormatRule5.ColumnApplyTo = this.colL5P;
			gridFormatRule5.Name = "Format4";
			formatConditionRuleExpression5.Appearance.BackColor = System.Drawing.Color.Cornsilk;
			formatConditionRuleExpression5.Appearance.Options.UseBackColor = true;
			formatConditionRuleExpression5.Expression = "[F5] = \'0\'";
			gridFormatRule5.Rule = formatConditionRuleExpression5;
			this.gridView1.FormatRules.Add(gridFormatRule1);
			this.gridView1.FormatRules.Add(gridFormatRule2);
			this.gridView1.FormatRules.Add(gridFormatRule3);
			this.gridView1.FormatRules.Add(gridFormatRule4);
			this.gridView1.FormatRules.Add(gridFormatRule5);
			this.gridView1.GridControl = this.kRGridControl;
			this.gridView1.Name = "gridView1";
			this.gridView1.OptionsBehavior.Editable = false;
			this.gridView1.OptionsView.AllowCellMerge = true;
			// 
			// colIDX
			// 
			this.colIDX.AppearanceCell.Options.UseTextOptions = true;
			this.colIDX.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colIDX.Caption = "Idx";
			this.colIDX.FieldName = "IDX";
			this.colIDX.Name = "colIDX";
			this.colIDX.OptionsColumn.FixedWidth = true;
			this.colIDX.Visible = true;
			this.colIDX.VisibleIndex = 0;
			this.colIDX.Width = 30;
			// 
			// colL6
			// 
			this.colL6.AppearanceCell.Options.UseTextOptions = true;
			this.colL6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL6.AppearanceHeader.Options.UseTextOptions = true;
			this.colL6.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL6.Caption = "R6";
			this.colL6.FieldName = "L6";
			this.colL6.Name = "colL6";
			this.colL6.OptionsColumn.FixedWidth = true;
			this.colL6.Visible = true;
			this.colL6.VisibleIndex = 11;
			this.colL6.Width = 30;
			// 
			// colL6P
			// 
			this.colL6P.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colL6P.AppearanceCell.Options.UseFont = true;
			this.colL6P.AppearanceCell.Options.UseTextOptions = true;
			this.colL6P.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL6P.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
			this.colL6P.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colL6P.Caption = "6. Round Participants";
			this.colL6P.ColumnEdit = this.repositoryItemMemoEdit1;
			this.colL6P.FieldName = "L6P";
			this.colL6P.Name = "colL6P";
			this.colL6P.Visible = true;
			this.colL6P.VisibleIndex = 12;
			this.colL6P.Width = 123;
			// 
			// colL7
			// 
			this.colL7.AppearanceCell.Options.UseTextOptions = true;
			this.colL7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL7.AppearanceHeader.Options.UseTextOptions = true;
			this.colL7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL7.Caption = "R7";
			this.colL7.FieldName = "L7";
			this.colL7.Name = "colL7";
			this.colL7.OptionsColumn.FixedWidth = true;
			this.colL7.Visible = true;
			this.colL7.VisibleIndex = 13;
			this.colL7.Width = 30;
			// 
			// colL7P
			// 
			this.colL7P.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.colL7P.AppearanceCell.Options.UseFont = true;
			this.colL7P.AppearanceCell.Options.UseTextOptions = true;
			this.colL7P.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.colL7P.AppearanceCell.TextOptions.Trimming = DevExpress.Utils.Trimming.Word;
			this.colL7P.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.colL7P.Caption = "7. Round Participants";
			this.colL7P.ColumnEdit = this.repositoryItemMemoEdit1;
			this.colL7P.FieldName = "L7P";
			this.colL7P.Name = "colL7P";
			this.colL7P.Visible = true;
			this.colL7P.VisibleIndex = 14;
			this.colL7P.Width = 202;
			// 
			// colL8
			// 
			this.colL8.FieldName = "L8";
			this.colL8.Name = "colL8";
			// 
			// colL8P
			// 
			this.colL8P.FieldName = "L8P";
			this.colL8P.Name = "colL8P";
			// 
			// colF1
			// 
			this.colF1.FieldName = "F1";
			this.colF1.Name = "colF1";
			// 
			// colF2
			// 
			this.colF2.FieldName = "F2";
			this.colF2.Name = "colF2";
			// 
			// colF3
			// 
			this.colF3.FieldName = "F3";
			this.colF3.Name = "colF3";
			// 
			// colF4
			// 
			this.colF4.FieldName = "F4";
			this.colF4.Name = "colF4";
			// 
			// colF5
			// 
			this.colF5.FieldName = "F5";
			this.colF5.Name = "colF5";
			// 
			// colF6
			// 
			this.colF6.FieldName = "F6";
			this.colF6.Name = "colF6";
			// 
			// colF7
			// 
			this.colF7.FieldName = "F7";
			this.colF7.Name = "colF7";
			// 
			// KnockoutResultsXF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(939, 319);
			this.Controls.Add(this.kRGridControl);
			this.Name = "KnockoutResultsXF";
			this.Text = "KnockoutResults";
			this.Load += new System.EventHandler(this.KnockoutResultsXF_Load);
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kRBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.kRGridControl)).EndInit();
			this.contectMenuScript.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DataSet dataSet;
		private System.Windows.Forms.BindingSource kRBindingSource;
		private DataSetTableAdapters.KRTableAdapter kRTableAdapter;
		private DevExpress.XtraGrid.GridControl kRGridControl;
		private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
		private DevExpress.XtraGrid.Columns.GridColumn colIDX;
		private DevExpress.XtraGrid.Columns.GridColumn colL1;
		private DevExpress.XtraGrid.Columns.GridColumn colL1P;
		private DevExpress.XtraGrid.Columns.GridColumn colL2;
		private DevExpress.XtraGrid.Columns.GridColumn colL2P;
		private DevExpress.XtraGrid.Columns.GridColumn colL3;
		private DevExpress.XtraGrid.Columns.GridColumn colL3P;
		private DevExpress.XtraGrid.Columns.GridColumn colL4;
		private DevExpress.XtraGrid.Columns.GridColumn colL4P;
		private DevExpress.XtraGrid.Columns.GridColumn colL5;
		private DevExpress.XtraGrid.Columns.GridColumn colL5P;
		private DevExpress.XtraGrid.Columns.GridColumn colL6;
		private DevExpress.XtraGrid.Columns.GridColumn colL6P;
		private DevExpress.XtraGrid.Columns.GridColumn colL7;
		private DevExpress.XtraGrid.Columns.GridColumn colL7P;
		private DevExpress.XtraGrid.Columns.GridColumn colL8;
		private DevExpress.XtraGrid.Columns.GridColumn colL8P;
		private System.Windows.Forms.ContextMenuStrip contectMenuScript;
		private System.Windows.Forms.ToolStripMenuItem hideR5ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hideR6ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hideR7ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hideRoudCodesToolStripMenuItem;
		private DevExpress.XtraGrid.Columns.GridColumn colF1;
		private DevExpress.XtraGrid.Columns.GridColumn colF2;
		private DevExpress.XtraGrid.Columns.GridColumn colF3;
		private DevExpress.XtraGrid.Columns.GridColumn colF4;
		private DevExpress.XtraGrid.Columns.GridColumn colF5;
		private DevExpress.XtraGrid.Columns.GridColumn colF6;
		private DevExpress.XtraGrid.Columns.GridColumn colF7;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
		private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
	}
}