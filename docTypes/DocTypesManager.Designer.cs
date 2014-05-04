namespace UniArchive.docTypes
{
    partial class DocTypesManager
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
            this.documentTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTypesTableAdapter = new UniArchive.FullDataSetTableAdapters.DOCUMENT_TYPESTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPARENT_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_ACCESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.attributesGridControl = new DevExpress.XtraGrid.GridControl();
            this.docTypeAttributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attributesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colATTRIBUTE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attributesSearchLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.attributesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANDATORY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mandatoryCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colDOCUMENT_TYPE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.attributesTableAdapter = new UniArchive.FullDataSetTableAdapters.ATTRIBUTESTableAdapter();
            this.docTypeAttributesTableAdapter = new UniArchive.FullDataSetTableAdapters.DOCUMENT_TYPE_ATTRIBUTESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).BeginInit();
            this.detailsXtraTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attributesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTypeAttributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesSearchLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mandatoryCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // masterGridControl
            // 
            this.masterGridControl.DataSource = this.documentTypesBindingSource;
            this.masterGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            // 
            // detailsXtraTabControl
            // 
            this.detailsXtraTabControl.SelectedTabPage = this.xtraTabPage1;
            this.detailsXtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // masterGridView
            // 
            this.masterGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNAME,
            this.colPARENT_ID,
            this.colDESCRIPTION,
            this.colFULL_ACCESS});
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
            // documentTypesBindingSource
            // 
            this.documentTypesBindingSource.DataMember = "DOCUMENT_TYPES";
            this.documentTypesBindingSource.DataSource = this.fullDataSet;
            // 
            // documentTypesTableAdapter
            // 
            this.documentTypesTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Name";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 0;
            // 
            // colPARENT_ID
            // 
            this.colPARENT_ID.FieldName = "PARENT_ID";
            this.colPARENT_ID.Name = "colPARENT_ID";
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "Description";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 1;
            // 
            // colFULL_ACCESS
            // 
            this.colFULL_ACCESS.Caption = "Full Access";
            this.colFULL_ACCESS.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colFULL_ACCESS.FieldName = "FULL_ACCESS";
            this.colFULL_ACCESS.Name = "colFULL_ACCESS";
            this.colFULL_ACCESS.Visible = true;
            this.colFULL_ACCESS.VisibleIndex = 2;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = ((short)(1));
            this.repositoryItemCheckEdit1.ValueUnchecked = ((short)(0));
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.attributesGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(614, 194);
            this.xtraTabPage1.Text = "Attributes";
            // 
            // attributesGridControl
            // 
            this.attributesGridControl.DataSource = this.docTypeAttributesBindingSource;
            this.attributesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.attributesGridControl.Location = new System.Drawing.Point(0, 0);
            this.attributesGridControl.MainView = this.attributesGridView;
            this.attributesGridControl.Name = "attributesGridControl";
            this.attributesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.attributesSearchLookUpEdit,
            this.mandatoryCheckEdit});
            this.attributesGridControl.Size = new System.Drawing.Size(614, 194);
            this.attributesGridControl.TabIndex = 2;
            this.attributesGridControl.UseEmbeddedNavigator = true;
            this.attributesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.attributesGridView});
            // 
            // docTypeAttributesBindingSource
            // 
            this.docTypeAttributesBindingSource.DataMember = "DOCUMENT_TYPE_ATTRIBUTES_FK1";
            this.docTypeAttributesBindingSource.DataSource = this.documentTypesBindingSource;
            // 
            // attributesGridView
            // 
            this.attributesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colATTRIBUTE_ID,
            this.colMANDATORY,
            this.colDOCUMENT_TYPE_ID});
            this.attributesGridView.GridControl = this.attributesGridControl;
            this.attributesGridView.Name = "attributesGridView";
            this.attributesGridView.OptionsCustomization.AllowGroup = false;
            this.attributesGridView.OptionsDetail.EnableMasterViewMode = false;
            this.attributesGridView.OptionsDetail.ShowDetailTabs = false;
            this.attributesGridView.OptionsDetail.SmartDetailExpand = false;
            this.attributesGridView.OptionsView.ShowAutoFilterRow = true;
            this.attributesGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.attributesGridView.OptionsView.ShowGroupPanel = false;
            this.attributesGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.attributesGridView_InitNewRow);
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            // 
            // colATTRIBUTE_ID
            // 
            this.colATTRIBUTE_ID.Caption = "Attribute";
            this.colATTRIBUTE_ID.ColumnEdit = this.attributesSearchLookUpEdit;
            this.colATTRIBUTE_ID.FieldName = "ATTRIBUTE_ID";
            this.colATTRIBUTE_ID.Name = "colATTRIBUTE_ID";
            this.colATTRIBUTE_ID.Visible = true;
            this.colATTRIBUTE_ID.VisibleIndex = 0;
            // 
            // attributesSearchLookUpEdit
            // 
            this.attributesSearchLookUpEdit.AutoHeight = false;
            this.attributesSearchLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.attributesSearchLookUpEdit.DataSource = this.attributesBindingSource;
            this.attributesSearchLookUpEdit.DisplayMember = "NAME";
            this.attributesSearchLookUpEdit.Name = "attributesSearchLookUpEdit";
            this.attributesSearchLookUpEdit.NullText = "";
            this.attributesSearchLookUpEdit.ValueMember = "ID";
            this.attributesSearchLookUpEdit.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // attributesBindingSource
            // 
            this.attributesBindingSource.DataMember = "ATTRIBUTES";
            this.attributesBindingSource.DataSource = this.fullDataSet;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMANDATORY
            // 
            this.colMANDATORY.Caption = "Mandatory";
            this.colMANDATORY.ColumnEdit = this.mandatoryCheckEdit;
            this.colMANDATORY.FieldName = "MANDATORY";
            this.colMANDATORY.Name = "colMANDATORY";
            this.colMANDATORY.Visible = true;
            this.colMANDATORY.VisibleIndex = 1;
            // 
            // mandatoryCheckEdit
            // 
            this.mandatoryCheckEdit.AutoHeight = false;
            this.mandatoryCheckEdit.Name = "mandatoryCheckEdit";
            this.mandatoryCheckEdit.ValueChecked = ((short)(1));
            this.mandatoryCheckEdit.ValueUnchecked = ((short)(0));
            // 
            // colDOCUMENT_TYPE_ID
            // 
            this.colDOCUMENT_TYPE_ID.FieldName = "DOCUMENT_TYPE_ID";
            this.colDOCUMENT_TYPE_ID.Name = "colDOCUMENT_TYPE_ID";
            // 
            // attributesTableAdapter
            // 
            this.attributesTableAdapter.ClearBeforeFill = true;
            // 
            // docTypeAttributesTableAdapter
            // 
            this.docTypeAttributesTableAdapter.ClearBeforeFill = true;
            // 
            // DocTypesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "DocTypesManager";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).EndInit();
            this.detailsXtraTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.attributesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docTypeAttributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesSearchLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attributesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mandatoryCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource documentTypesBindingSource;
        private FullDataSet fullDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colPARENT_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_ACCESS;
        private FullDataSetTableAdapters.DOCUMENT_TYPESTableAdapter documentTypesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private FullDataSetTableAdapters.ATTRIBUTESTableAdapter attributesTableAdapter;
        private System.Windows.Forms.BindingSource attributesBindingSource;
        protected DevExpress.XtraGrid.GridControl attributesGridControl;
        private System.Windows.Forms.BindingSource docTypeAttributesBindingSource;
        public DevExpress.XtraGrid.Views.Grid.GridView attributesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colATTRIBUTE_ID;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit attributesSearchLookUpEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMANDATORY;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit mandatoryCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colDOCUMENT_TYPE_ID;
        private FullDataSetTableAdapters.DOCUMENT_TYPE_ATTRIBUTESTableAdapter docTypeAttributesTableAdapter;
    }
}
