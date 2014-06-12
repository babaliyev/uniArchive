namespace UniArchive.search
{
    partial class SearchManager
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.searchAreaRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.searchGridControl = new DevExpress.XtraGrid.GridControl();
            this.searchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UniArchive.FullDataSet();
            this.searchGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDOCUMENT_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOCUMENT_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOCUMENT_DATE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOPY_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATTRIBUTE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATTRIBUTE_VALUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOCUMENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOPY_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.copyTypesLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.fromDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.toDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new UniArchive.FullDataSetTableAdapters.CLIENTSTableAdapter();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientSearchLookUpEdit = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchTextTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.searchSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.searchTableAdapter = new UniArchive.FullDataSetTableAdapters.SEARCHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.searchAreaRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientSearchLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // searchAreaRadioGroup
            // 
            this.searchAreaRadioGroup.EditValue = ((short)(3));
            this.searchAreaRadioGroup.Location = new System.Drawing.Point(111, 13);
            this.searchAreaRadioGroup.Name = "searchAreaRadioGroup";
            this.searchAreaRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.searchAreaRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.searchAreaRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.searchAreaRadioGroup.Properties.Columns = 3;
            this.searchAreaRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "Ancaq sənədlərdə"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "Ancaq qoşmalarda"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(3)), "Bütün obyektlərdə")});
            this.searchAreaRadioGroup.Size = new System.Drawing.Size(488, 32);
            this.searchAreaRadioGroup.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Axtarış sahələri:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Axtarış sözü:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarix aralığı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Müştəri:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.searchGridControl);
            this.groupControl1.Location = new System.Drawing.Point(17, 142);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(667, 316);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Axtarışın nəticəsi";
            // 
            // searchGridControl
            // 
            this.searchGridControl.DataSource = this.searchBindingSource;
            this.searchGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchGridControl.Location = new System.Drawing.Point(2, 21);
            this.searchGridControl.MainView = this.searchGridView;
            this.searchGridControl.Name = "searchGridControl";
            this.searchGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.copyTypesLookUpEdit});
            this.searchGridControl.Size = new System.Drawing.Size(663, 293);
            this.searchGridControl.TabIndex = 7;
            this.searchGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.searchGridView});
            this.searchGridControl.Click += new System.EventHandler(this.searchGridControl_Click);
            // 
            // searchBindingSource
            // 
            this.searchBindingSource.DataMember = "SEARCH";
            this.searchBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchGridView
            // 
            this.searchGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDOCUMENT_TYPE,
            this.colCLIENT,
            this.colDOCUMENT_NUMBER,
            this.colDOCUMENT_DATE,
            this.colCOPY_TYPE,
            this.colATTRIBUTE_NAME,
            this.colATTRIBUTE_VALUE,
            this.colDOCUMENT_ID,
            this.colCOPY_ID});
            this.searchGridView.GridControl = this.searchGridControl;
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.OptionsBehavior.Editable = false;
            this.searchGridView.OptionsCustomization.AllowGroup = false;
            this.searchGridView.OptionsDetail.EnableMasterViewMode = false;
            this.searchGridView.OptionsDetail.ShowDetailTabs = false;
            this.searchGridView.OptionsDetail.SmartDetailExpand = false;
            this.searchGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.searchGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colDOCUMENT_TYPE
            // 
            this.colDOCUMENT_TYPE.Caption = "Sənədin tipi";
            this.colDOCUMENT_TYPE.FieldName = "DOCUMENT_TYPE";
            this.colDOCUMENT_TYPE.Name = "colDOCUMENT_TYPE";
            this.colDOCUMENT_TYPE.OptionsColumn.ReadOnly = true;
            this.colDOCUMENT_TYPE.Visible = true;
            this.colDOCUMENT_TYPE.VisibleIndex = 0;
            // 
            // colCLIENT
            // 
            this.colCLIENT.Caption = "Müştəri";
            this.colCLIENT.FieldName = "CLIENT";
            this.colCLIENT.Name = "colCLIENT";
            this.colCLIENT.OptionsColumn.ReadOnly = true;
            this.colCLIENT.Visible = true;
            this.colCLIENT.VisibleIndex = 1;
            // 
            // colDOCUMENT_NUMBER
            // 
            this.colDOCUMENT_NUMBER.Caption = "Sənədin nömrəsi";
            this.colDOCUMENT_NUMBER.FieldName = "DOCUMENT_NUMBER";
            this.colDOCUMENT_NUMBER.Name = "colDOCUMENT_NUMBER";
            this.colDOCUMENT_NUMBER.OptionsColumn.ReadOnly = true;
            this.colDOCUMENT_NUMBER.Visible = true;
            this.colDOCUMENT_NUMBER.VisibleIndex = 2;
            // 
            // colDOCUMENT_DATE
            // 
            this.colDOCUMENT_DATE.Caption = "Sənədin tarixi";
            this.colDOCUMENT_DATE.FieldName = "DOCUMENT_DATE";
            this.colDOCUMENT_DATE.Name = "colDOCUMENT_DATE";
            this.colDOCUMENT_DATE.OptionsColumn.ReadOnly = true;
            this.colDOCUMENT_DATE.Visible = true;
            this.colDOCUMENT_DATE.VisibleIndex = 3;
            // 
            // colCOPY_TYPE
            // 
            this.colCOPY_TYPE.Caption = "Qoşmanın tipi";
            this.colCOPY_TYPE.FieldName = "COPY_TYPE";
            this.colCOPY_TYPE.Name = "colCOPY_TYPE";
            this.colCOPY_TYPE.OptionsColumn.ReadOnly = true;
            this.colCOPY_TYPE.Visible = true;
            this.colCOPY_TYPE.VisibleIndex = 4;
            // 
            // colATTRIBUTE_NAME
            // 
            this.colATTRIBUTE_NAME.Caption = "Xassəsi";
            this.colATTRIBUTE_NAME.FieldName = "ATTRIBUTE_NAME";
            this.colATTRIBUTE_NAME.Name = "colATTRIBUTE_NAME";
            this.colATTRIBUTE_NAME.OptionsColumn.ReadOnly = true;
            this.colATTRIBUTE_NAME.Visible = true;
            this.colATTRIBUTE_NAME.VisibleIndex = 5;
            // 
            // colATTRIBUTE_VALUE
            // 
            this.colATTRIBUTE_VALUE.Caption = "Qiyməti";
            this.colATTRIBUTE_VALUE.FieldName = "ATTRIBUTE_VALUE";
            this.colATTRIBUTE_VALUE.Name = "colATTRIBUTE_VALUE";
            this.colATTRIBUTE_VALUE.OptionsColumn.ReadOnly = true;
            this.colATTRIBUTE_VALUE.Visible = true;
            this.colATTRIBUTE_VALUE.VisibleIndex = 6;
            // 
            // colDOCUMENT_ID
            // 
            this.colDOCUMENT_ID.FieldName = "DOCUMENT_ID";
            this.colDOCUMENT_ID.Name = "colDOCUMENT_ID";
            this.colDOCUMENT_ID.OptionsColumn.ReadOnly = true;
            // 
            // colCOPY_ID
            // 
            this.colCOPY_ID.FieldName = "COPY_ID";
            this.colCOPY_ID.Name = "colCOPY_ID";
            this.colCOPY_ID.OptionsColumn.ReadOnly = true;
            // 
            // copyTypesLookUpEdit
            // 
            this.copyTypesLookUpEdit.AutoHeight = false;
            this.copyTypesLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.copyTypesLookUpEdit.DisplayMember = "NAME";
            this.copyTypesLookUpEdit.Name = "copyTypesLookUpEdit";
            this.copyTypesLookUpEdit.ValueMember = "ID";
            // 
            // fromDateEdit
            // 
            this.fromDateEdit.EditValue = null;
            this.fromDateEdit.Location = new System.Drawing.Point(115, 47);
            this.fromDateEdit.Name = "fromDateEdit";
            this.fromDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fromDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.fromDateEdit.Size = new System.Drawing.Size(100, 20);
            this.fromDateEdit.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "-dən";
            // 
            // toDateEdit
            // 
            this.toDateEdit.EditValue = null;
            this.toDateEdit.Location = new System.Drawing.Point(274, 47);
            this.toDateEdit.Name = "toDateEdit";
            this.toDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.toDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.toDateEdit.Size = new System.Drawing.Size(100, 20);
            this.toDateEdit.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "-dək";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "CLIENTS";
            this.clientsBindingSource.DataSource = this.fullDataSet;
            // 
            // clientSearchLookUpEdit
            // 
            this.clientSearchLookUpEdit.Location = new System.Drawing.Point(115, 75);
            this.clientSearchLookUpEdit.Name = "clientSearchLookUpEdit";
            this.clientSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.clientSearchLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.clientSearchLookUpEdit.Properties.DataSource = this.clientsBindingSource;
            this.clientSearchLookUpEdit.Properties.DisplayMember = "FULL_NAME";
            this.clientSearchLookUpEdit.Properties.NullText = "Seçilməyib";
            this.clientSearchLookUpEdit.Properties.ValueMember = "ID";
            this.clientSearchLookUpEdit.Properties.View = this.gridView3;
            this.clientSearchLookUpEdit.Size = new System.Drawing.Size(293, 20);
            this.clientSearchLookUpEdit.TabIndex = 13;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // searchTextTextEdit
            // 
            this.searchTextTextEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextTextEdit.Location = new System.Drawing.Point(115, 103);
            this.searchTextTextEdit.Name = "searchTextTextEdit";
            this.searchTextTextEdit.Size = new System.Drawing.Size(461, 20);
            this.searchTextTextEdit.TabIndex = 14;
            // 
            // searchSimpleButton
            // 
            this.searchSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchSimpleButton.Location = new System.Drawing.Point(601, 101);
            this.searchSimpleButton.Name = "searchSimpleButton";
            this.searchSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.searchSimpleButton.TabIndex = 15;
            this.searchSimpleButton.Text = "Axtar";
            this.searchSimpleButton.Click += new System.EventHandler(this.searchSimpleButton_Click);
            // 
            // searchTableAdapter
            // 
            this.searchTableAdapter.ClearBeforeFill = true;
            // 
            // SearchManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchSimpleButton);
            this.Controls.Add(this.searchTextTextEdit);
            this.Controls.Add(this.clientSearchLookUpEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toDateEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fromDateEdit);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchAreaRadioGroup);
            this.Name = "SearchManager";
            this.Size = new System.Drawing.Size(701, 480);
            ((System.ComponentModel.ISupportInitialize)(this.searchAreaRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fromDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientSearchLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTextTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.RadioGroup searchAreaRadioGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit fromDateEdit;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit toDateEdit;
        private System.Windows.Forms.Label label6;
        private FullDataSet fullDataSet;
        private FullDataSetTableAdapters.CLIENTSTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private DevExpress.XtraEditors.SearchLookUpEdit clientSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.TextEdit searchTextTextEdit;
        private DevExpress.XtraEditors.SimpleButton searchSimpleButton;
        protected DevExpress.XtraGrid.GridControl searchGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView searchGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit copyTypesLookUpEdit;
        private System.Windows.Forms.BindingSource searchBindingSource;
        private FullDataSetTableAdapters.SEARCHTableAdapter searchTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colDOCUMENT_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT;
        private DevExpress.XtraGrid.Columns.GridColumn colDOCUMENT_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colDOCUMENT_DATE;
        private DevExpress.XtraGrid.Columns.GridColumn colCOPY_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colATTRIBUTE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colATTRIBUTE_VALUE;
        private DevExpress.XtraGrid.Columns.GridColumn colDOCUMENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colCOPY_ID;
    }
}
