namespace UniArchive.attributes
{
    partial class AttributesManager
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
            this.fullDataSet = new UniArchive.FullDataSet();
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attributesTableAdapter = new UniArchive.FullDataSetTableAdapters.ATTRIBUTESTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVALUETYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.typesComboBox = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.colREFERENCE_TYPE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.refTypeSearchLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.referenceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.referenceTypesTableAdapter = new UniArchive.FullDataSetTableAdapters.REFERENCE_TYPESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesComboBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refTypeSearchLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Size = new System.Drawing.Size(739, 526);
            this.splitContainerControl1.SplitterPosition = 0;
            // 
            // masterGridControl
            // 
            this.masterGridControl.DataSource = this.attributesBindingSource;
            this.masterGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.refTypeSearchLookUpEdit,
            this.typesComboBox});
            this.masterGridControl.Size = new System.Drawing.Size(739, 521);
            // 
            // detailsXtraTabControl
            // 
            this.detailsXtraTabControl.Size = new System.Drawing.Size(0, 0);
            // 
            // masterGridView
            // 
            this.masterGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNAME,
            this.colDESCRIPTION,
            this.colVALUETYPE,
            this.colREFERENCE_TYPE_ID});
            this.masterGridView.OptionsCustomization.AllowGroup = false;
            this.masterGridView.OptionsDetail.EnableMasterViewMode = false;
            this.masterGridView.OptionsDetail.ShowDetailTabs = false;
            this.masterGridView.OptionsDetail.SmartDetailExpand = false;
            this.masterGridView.OptionsView.ShowAutoFilterRow = true;
            this.masterGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.masterGridView.OptionsView.ShowGroupPanel = false;
            this.masterGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.masterGridView_InitNewRow);
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attributesBindingSource
            // 
            this.attributesBindingSource.DataMember = "ATTRIBUTES";
            this.attributesBindingSource.DataSource = this.fullDataSet;
            // 
            // attributesTableAdapter
            // 
            this.attributesTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Adı";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 0;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "Qeyd";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 1;
            // 
            // colVALUETYPE
            // 
            this.colVALUETYPE.Caption = "Tipi";
            this.colVALUETYPE.ColumnEdit = this.typesComboBox;
            this.colVALUETYPE.FieldName = "VALUETYPE";
            this.colVALUETYPE.Name = "colVALUETYPE";
            this.colVALUETYPE.Visible = true;
            this.colVALUETYPE.VisibleIndex = 2;
            // 
            // typesComboBox
            // 
            this.typesComboBox.AutoHeight = false;
            this.typesComboBox.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typesComboBox.Items.AddRange(new object[] {
            "String",
            "Date",
            "Decimal",
            "Integer",
            "Boolean",
            "Reference"});
            this.typesComboBox.Name = "typesComboBox";
            this.typesComboBox.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // colREFERENCE_TYPE_ID
            // 
            this.colREFERENCE_TYPE_ID.Caption = "İstinad";
            this.colREFERENCE_TYPE_ID.ColumnEdit = this.refTypeSearchLookUpEdit;
            this.colREFERENCE_TYPE_ID.FieldName = "REFERENCE_TYPE_ID";
            this.colREFERENCE_TYPE_ID.Name = "colREFERENCE_TYPE_ID";
            this.colREFERENCE_TYPE_ID.Visible = true;
            this.colREFERENCE_TYPE_ID.VisibleIndex = 3;
            // 
            // refTypeSearchLookUpEdit
            // 
            this.refTypeSearchLookUpEdit.AutoHeight = false;
            this.refTypeSearchLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.refTypeSearchLookUpEdit.DataSource = this.referenceTypesBindingSource;
            this.refTypeSearchLookUpEdit.DisplayMember = "NAME";
            this.refTypeSearchLookUpEdit.Name = "refTypeSearchLookUpEdit";
            this.refTypeSearchLookUpEdit.NullText = "";
            this.refTypeSearchLookUpEdit.ValueMember = "ID";
            this.refTypeSearchLookUpEdit.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // referenceTypesBindingSource
            // 
            this.referenceTypesBindingSource.DataMember = "REFERENCE_TYPES";
            this.referenceTypesBindingSource.DataSource = this.fullDataSet;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // referenceTypesTableAdapter
            // 
            this.referenceTypesTableAdapter.ClearBeforeFill = true;
            // 
            // AttributesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "AttributesManager";
            this.Size = new System.Drawing.Size(739, 526);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesComboBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refTypeSearchLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource attributesBindingSource;
        private FullDataSet fullDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colVALUETYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colREFERENCE_TYPE_ID;
        private FullDataSetTableAdapters.ATTRIBUTESTableAdapter attributesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit refTypeSearchLookUpEdit;
        private System.Windows.Forms.BindingSource referenceTypesBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private FullDataSetTableAdapters.REFERENCE_TYPESTableAdapter referenceTypesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox typesComboBox;
    }
}
