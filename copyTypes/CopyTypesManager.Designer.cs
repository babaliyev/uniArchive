namespace UniArchive.copyTypes
{
    partial class CopyTypesManager
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
            this.copyTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.copyTypesTableAdapter = new UniArchive.FullDataSetTableAdapters.COPY_TYPESTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_ACCESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDOCUMENT_TYPE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // masterGridControl
            // 
            this.masterGridControl.DataSource = this.copyTypesBindingSource;
            this.masterGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            // 
            // masterGridView
            // 
            this.masterGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNAME,
            this.colDESCRIPTION,
            this.colFULL_ACCESS,
            this.colDOCUMENT_TYPE_ID});
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
            // copyTypesBindingSource
            // 
            this.copyTypesBindingSource.DataMember = "COPY_TYPES";
            this.copyTypesBindingSource.DataSource = this.fullDataSet;
            // 
            // copyTypesTableAdapter
            // 
            this.copyTypesTableAdapter.ClearBeforeFill = true;
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
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "Caption";
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
            // colDOCUMENT_TYPE_ID
            // 
            this.colDOCUMENT_TYPE_ID.FieldName = "DOCUMENT_TYPE_ID";
            this.colDOCUMENT_TYPE_ID.Name = "colDOCUMENT_TYPE_ID";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repositoryItemCheckEdit1.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // CopyTypesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "CopyTypesManager";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource copyTypesBindingSource;
        private FullDataSet fullDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_ACCESS;
        private DevExpress.XtraGrid.Columns.GridColumn colDOCUMENT_TYPE_ID;
        private FullDataSetTableAdapters.COPY_TYPESTableAdapter copyTypesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}
