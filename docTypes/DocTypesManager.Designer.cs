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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // masterGridControl
            // 
            this.masterGridControl.DataSource = this.documentTypesBindingSource;
            this.masterGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
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
            // DocTypesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "DocTypesManager";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
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
    }
}
