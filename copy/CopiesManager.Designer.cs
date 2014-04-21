namespace UniArchive.copy
{
    partial class CopiesManager
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
            this.copiesGridControl = new DevExpress.XtraGrid.GridControl();
            this.copiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UniArchive.FullDataSet();
            this.copiesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOPY_TYPE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.copyTypesLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.copyTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPAGES_COUNT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_ACCESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fullAccessCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.downloadBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.showBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.copyTypesTableAdapter = new UniArchive.FullDataSetTableAdapters.COPY_TYPESTableAdapter();
            this.copiesTableAdapter = new UniArchive.FullDataSetTableAdapters.COPIESTableAdapter();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentsTableAdapter = new UniArchive.FullDataSetTableAdapters.DOCUMENTSTableAdapter();
            this.filesTableAdapter = new UniArchive.FullDataSetTableAdapters.FILESTableAdapter();
            this.filesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.copiesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullAccessCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // copiesGridControl
            // 
            this.copiesGridControl.DataSource = this.copiesBindingSource;
            this.copiesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copiesGridControl.Location = new System.Drawing.Point(0, 29);
            this.copiesGridControl.MainView = this.copiesGridView;
            this.copiesGridControl.Name = "copiesGridControl";
            this.copiesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.copyTypesLookUpEdit,
            this.fullAccessCheckEdit});
            this.copiesGridControl.Size = new System.Drawing.Size(619, 483);
            this.copiesGridControl.TabIndex = 5;
            this.copiesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.copiesGridView});
            this.copiesGridControl.DoubleClick += new System.EventHandler(this.copiesGridControl_DoubleClick);
            // 
            // copiesBindingSource
            // 
            this.copiesBindingSource.DataMember = "COPIES";
            this.copiesBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // copiesGridView
            // 
            this.copiesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCOPY_TYPE_ID,
            this.colNAME,
            this.colPAGES_COUNT,
            this.colFULL_ACCESS});
            this.copiesGridView.GridControl = this.copiesGridControl;
            this.copiesGridView.Name = "copiesGridView";
            this.copiesGridView.OptionsBehavior.Editable = false;
            this.copiesGridView.OptionsCustomization.AllowGroup = false;
            this.copiesGridView.OptionsDetail.EnableMasterViewMode = false;
            this.copiesGridView.OptionsDetail.ShowDetailTabs = false;
            this.copiesGridView.OptionsDetail.SmartDetailExpand = false;
            this.copiesGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.copiesGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colCOPY_TYPE_ID
            // 
            this.colCOPY_TYPE_ID.Caption = "Qoşmanın tipi";
            this.colCOPY_TYPE_ID.ColumnEdit = this.copyTypesLookUpEdit;
            this.colCOPY_TYPE_ID.FieldName = "COPY_TYPE_ID";
            this.colCOPY_TYPE_ID.Name = "colCOPY_TYPE_ID";
            this.colCOPY_TYPE_ID.Visible = true;
            this.colCOPY_TYPE_ID.VisibleIndex = 0;
            this.colCOPY_TYPE_ID.Width = 226;
            // 
            // copyTypesLookUpEdit
            // 
            this.copyTypesLookUpEdit.AutoHeight = false;
            this.copyTypesLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.copyTypesLookUpEdit.DataSource = this.copyTypesBindingSource;
            this.copyTypesLookUpEdit.DisplayMember = "NAME";
            this.copyTypesLookUpEdit.Name = "copyTypesLookUpEdit";
            this.copyTypesLookUpEdit.ValueMember = "ID";
            // 
            // copyTypesBindingSource
            // 
            this.copyTypesBindingSource.DataMember = "COPY_TYPES";
            this.copyTypesBindingSource.DataSource = this.fullDataSet;
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Açıqlama";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 1;
            this.colNAME.Width = 375;
            // 
            // colPAGES_COUNT
            // 
            this.colPAGES_COUNT.Caption = "Səhifə sayı";
            this.colPAGES_COUNT.FieldName = "PAGES_COUNT";
            this.colPAGES_COUNT.Name = "colPAGES_COUNT";
            this.colPAGES_COUNT.Visible = true;
            this.colPAGES_COUNT.VisibleIndex = 2;
            // 
            // colFULL_ACCESS
            // 
            this.colFULL_ACCESS.Caption = "Hamıya görünsün";
            this.colFULL_ACCESS.ColumnEdit = this.fullAccessCheckEdit;
            this.colFULL_ACCESS.FieldName = "FULL_ACCESS";
            this.colFULL_ACCESS.Name = "colFULL_ACCESS";
            this.colFULL_ACCESS.Visible = true;
            this.colFULL_ACCESS.VisibleIndex = 3;
            // 
            // fullAccessCheckEdit
            // 
            this.fullAccessCheckEdit.AutoHeight = false;
            this.fullAccessCheckEdit.Name = "fullAccessCheckEdit";
            this.fullAccessCheckEdit.ValueChecked = ((short)(1));
            this.fullAccessCheckEdit.ValueUnchecked = ((short)(0));
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.addBarButtonItem,
            this.editBarButtonItem,
            this.deleteBarButtonItem,
            this.downloadBarButtonItem,
            this.showBarButtonItem});
            this.barManager1.MaxItemId = 6;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.editBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.showBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.downloadBarButtonItem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // addBarButtonItem
            // 
            this.addBarButtonItem.Caption = "Əlavə etmək";
            this.addBarButtonItem.Id = 0;
            this.addBarButtonItem.Name = "addBarButtonItem";
            this.addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBarButtonItem_ItemClick);
            // 
            // editBarButtonItem
            // 
            this.editBarButtonItem.Caption = "Dəyişmək";
            this.editBarButtonItem.Id = 1;
            this.editBarButtonItem.Name = "editBarButtonItem";
            this.editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBarButtonItem_ItemClick);
            // 
            // deleteBarButtonItem
            // 
            this.deleteBarButtonItem.Caption = "Silmək";
            this.deleteBarButtonItem.Id = 2;
            this.deleteBarButtonItem.Name = "deleteBarButtonItem";
            this.deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarButtonItem_ItemClick);
            // 
            // downloadBarButtonItem
            // 
            this.downloadBarButtonItem.Caption = "Kompyuterə endirmək";
            this.downloadBarButtonItem.Id = 3;
            this.downloadBarButtonItem.Name = "downloadBarButtonItem";
            this.downloadBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // showBarButtonItem
            // 
            this.showBarButtonItem.Caption = "Baxmaq";
            this.showBarButtonItem.Id = 5;
            this.showBarButtonItem.Name = "showBarButtonItem";
            this.showBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(619, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 512);
            this.barDockControlBottom.Size = new System.Drawing.Size(619, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 483);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(619, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 483);
            // 
            // copyTypesTableAdapter
            // 
            this.copyTypesTableAdapter.ClearBeforeFill = true;
            // 
            // copiesTableAdapter
            // 
            this.copiesTableAdapter.ClearBeforeFill = true;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "DOCUMENTS";
            this.documentsBindingSource.DataSource = this.fullDataSet;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // filesTableAdapter
            // 
            this.filesTableAdapter.ClearBeforeFill = true;
            // 
            // filesBindingSource
            // 
            this.filesBindingSource.DataMember = "FILES";
            this.filesBindingSource.DataSource = this.fullDataSet;
            // 
            // CopiesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.copiesGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CopiesManager";
            this.Size = new System.Drawing.Size(619, 512);
            ((System.ComponentModel.ISupportInitialize)(this.copiesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullAccessCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected DevExpress.XtraGrid.GridControl copiesGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView copiesGridView;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem addBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem editBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem downloadBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem showBarButtonItem;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private FullDataSetTableAdapters.COPY_TYPESTableAdapter copyTypesTableAdapter;
        private System.Windows.Forms.BindingSource copyTypesBindingSource;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource copiesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCOPY_TYPE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private FullDataSetTableAdapters.COPIESTableAdapter copiesTableAdapter;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private FullDataSetTableAdapters.DOCUMENTSTableAdapter documentsTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit copyTypesLookUpEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colPAGES_COUNT;
        private FullDataSetTableAdapters.FILESTableAdapter filesTableAdapter;
        private System.Windows.Forms.BindingSource filesBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_ACCESS;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit fullAccessCheckEdit;
    }
}
