namespace UniArchive.references
{
    partial class ReferencesManager
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
            this.referenceTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.referenceTypesTableAdapter = new UniArchive.FullDataSetTableAdapters.REFERENCE_TYPESTableAdapter();
            this.tableAdapterManager = new UniArchive.FullDataSetTableAdapters.TableAdapterManager();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.referencesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.referencesTableAdapter = new UniArchive.FullDataSetTableAdapters.REFERENCESTableAdapter();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.referencesGridControl = new DevExpress.XtraGrid.GridControl();
            this.referencesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDESCRIPTION1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colREFENCE_TYPE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).BeginInit();
            this.detailsXtraTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencesBindingSource)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.referencesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masterGridControl
            // 
            this.masterGridControl.DataSource = this.referenceTypesBindingSource;
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
            this.colDESCRIPTION});
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
            // referenceTypesBindingSource
            // 
            this.referenceTypesBindingSource.DataMember = "REFERENCE_TYPES";
            this.referenceTypesBindingSource.DataSource = this.fullDataSet;
            // 
            // referenceTypesTableAdapter
            // 
            this.referenceTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ADDRESS_DICTIONARYTableAdapter = null;
            this.tableAdapterManager.ATTRIBUTES_VALUESTableAdapter = null;
            this.tableAdapterManager.ATTRIBUTESTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLIENTSTableAdapter = null;
            this.tableAdapterManager.COPIESTableAdapter = null;
            this.tableAdapterManager.COPY_TYPE_ATTRIBUTESTableAdapter = null;
            this.tableAdapterManager.COPY_TYPESTableAdapter = null;
            this.tableAdapterManager.DIRECTORIESTableAdapter = null;
            this.tableAdapterManager.DOCUMENT_HISTORYTableAdapter = null;
            this.tableAdapterManager.DOCUMENT_TYPE_ATTRIBUTESTableAdapter = null;
            this.tableAdapterManager.DOCUMENT_TYPESTableAdapter = null;
            this.tableAdapterManager.DOCUMENTSTableAdapter = null;
            this.tableAdapterManager.FILESTableAdapter = null;
            this.tableAdapterManager.MOVEMENTTableAdapter = null;
            this.tableAdapterManager.REFERENCE_TYPESTableAdapter = this.referenceTypesTableAdapter;
            this.tableAdapterManager.REFERENCESTableAdapter = this.referencesTableAdapter;
            this.tableAdapterManager.ROLE_CLIENT_ACCESSTableAdapter = null;
            this.tableAdapterManager.ROLE_DOC_TYPE_ACCESSTableAdapter = null;
            this.tableAdapterManager.ROLE_DOCUMENT_ACCESSTableAdapter = null;
            this.tableAdapterManager.ROLESTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = UniArchive.FullDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USER_CLIENT_ACCESSTableAdapter = null;
            this.tableAdapterManager.USER_DOC_TYPE_ACCESSTableAdapter = null;
            this.tableAdapterManager.USER_DOCUMENT_ACCESSTableAdapter = null;
            this.tableAdapterManager.USER_ROLESTableAdapter = null;
            this.tableAdapterManager.USERSTableAdapter = null;
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
            this.colDESCRIPTION.Caption = "Qeydi";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 1;
            // 
            // referencesBindingSource
            // 
            this.referencesBindingSource.DataMember = "REFERENCES_FK1";
            this.referencesBindingSource.DataSource = this.referenceTypesBindingSource;
            // 
            // referencesTableAdapter
            // 
            this.referencesTableAdapter.ClearBeforeFill = true;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.referencesGridControl);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(614, 194);
            this.xtraTabPage1.Text = "Soraq kitabçasının tərkibi";
            // 
            // referencesGridControl
            // 
            this.referencesGridControl.DataSource = this.referencesBindingSource;
            this.referencesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.referencesGridControl.Location = new System.Drawing.Point(0, 0);
            this.referencesGridControl.MainView = this.referencesGridView;
            this.referencesGridControl.Name = "referencesGridControl";
            this.referencesGridControl.Size = new System.Drawing.Size(614, 194);
            this.referencesGridControl.TabIndex = 1;
            this.referencesGridControl.UseEmbeddedNavigator = true;
            this.referencesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.referencesGridView});
            // 
            // referencesGridView
            // 
            this.referencesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colNAME1,
            this.colDESCRIPTION1,
            this.colREFENCE_TYPE_ID});
            this.referencesGridView.GridControl = this.referencesGridControl;
            this.referencesGridView.Name = "referencesGridView";
            this.referencesGridView.OptionsCustomization.AllowGroup = false;
            this.referencesGridView.OptionsDetail.EnableMasterViewMode = false;
            this.referencesGridView.OptionsDetail.ShowDetailTabs = false;
            this.referencesGridView.OptionsDetail.SmartDetailExpand = false;
            this.referencesGridView.OptionsView.ShowAutoFilterRow = true;
            this.referencesGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.referencesGridView.OptionsView.ShowGroupPanel = false;
            this.referencesGridView.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.referencesGridView_InitNewRow);
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            // 
            // colNAME1
            // 
            this.colNAME1.Caption = "Adı";
            this.colNAME1.FieldName = "NAME";
            this.colNAME1.Name = "colNAME1";
            this.colNAME1.Visible = true;
            this.colNAME1.VisibleIndex = 0;
            // 
            // colDESCRIPTION1
            // 
            this.colDESCRIPTION1.Caption = "Qeydi";
            this.colDESCRIPTION1.FieldName = "DESCRIPTION";
            this.colDESCRIPTION1.Name = "colDESCRIPTION1";
            this.colDESCRIPTION1.Visible = true;
            this.colDESCRIPTION1.VisibleIndex = 1;
            // 
            // colREFENCE_TYPE_ID
            // 
            this.colREFENCE_TYPE_ID.FieldName = "REFENCE_TYPE_ID";
            this.colREFENCE_TYPE_ID.Name = "colREFENCE_TYPE_ID";
            // 
            // ReferencesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "ReferencesManager";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).EndInit();
            this.detailsXtraTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referenceTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencesBindingSource)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.referencesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.referencesGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource referenceTypesBindingSource;
        private FullDataSet fullDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION;
        private FullDataSetTableAdapters.REFERENCE_TYPESTableAdapter referenceTypesTableAdapter;
        private FullDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private FullDataSetTableAdapters.REFERENCESTableAdapter referencesTableAdapter;
        private System.Windows.Forms.BindingSource referencesBindingSource;
        protected DevExpress.XtraGrid.GridControl referencesGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView referencesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME1;
        private DevExpress.XtraGrid.Columns.GridColumn colDESCRIPTION1;
        private DevExpress.XtraGrid.Columns.GridColumn colREFENCE_TYPE_ID;
    }
}
