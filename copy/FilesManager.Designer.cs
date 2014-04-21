namespace UniArchive.copy
{
    partial class FilesManager
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
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.showBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.downloadBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.fullDataSet = new UniArchive.FullDataSet();
            this.copyTypesLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.filesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.filesGridControl = new DevExpress.XtraGrid.GridControl();
            this.filesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filesTableAdapter = new UniArchive.FullDataSetTableAdapters.FILESTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFILE_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFILE_EXTENTION = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFILE_SIZE = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 412);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(536, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 412);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 441);
            this.barDockControlBottom.Size = new System.Drawing.Size(536, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(536, 29);
            // 
            // showBarButtonItem
            // 
            this.showBarButtonItem.Caption = "Qoşmaya baxmaq";
            this.showBarButtonItem.Id = 5;
            this.showBarButtonItem.Name = "showBarButtonItem";
            this.showBarButtonItem.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // downloadBarButtonItem
            // 
            this.downloadBarButtonItem.Caption = "Kompyuterə endirmək";
            this.downloadBarButtonItem.Id = 3;
            this.downloadBarButtonItem.Name = "downloadBarButtonItem";
            this.downloadBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.downloadBarButtonItem_ItemClick);
            // 
            // deleteBarButtonItem
            // 
            this.deleteBarButtonItem.Caption = "Silmək";
            this.deleteBarButtonItem.Id = 2;
            this.deleteBarButtonItem.Name = "deleteBarButtonItem";
            this.deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarButtonItem_ItemClick);
            // 
            // addBarButtonItem
            // 
            this.addBarButtonItem.Caption = "Əlavə etmək";
            this.addBarButtonItem.Id = 0;
            this.addBarButtonItem.Name = "addBarButtonItem";
            this.addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBarButtonItem_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.downloadBarButtonItem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.showBarButtonItem)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
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
            this.deleteBarButtonItem,
            this.downloadBarButtonItem,
            this.showBarButtonItem});
            this.barManager1.MaxItemId = 6;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // filesGridView
            // 
            this.filesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFILE_NAME,
            this.colFILE_EXTENTION,
            this.colFILE_SIZE});
            this.filesGridView.GridControl = this.filesGridControl;
            this.filesGridView.Name = "filesGridView";
            this.filesGridView.OptionsCustomization.AllowGroup = false;
            this.filesGridView.OptionsDetail.EnableMasterViewMode = false;
            this.filesGridView.OptionsDetail.ShowDetailTabs = false;
            this.filesGridView.OptionsDetail.SmartDetailExpand = false;
            this.filesGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.filesGridView.OptionsView.ShowGroupPanel = false;
            // 
            // filesGridControl
            // 
            this.filesGridControl.DataSource = this.filesBindingSource;
            this.filesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filesGridControl.Location = new System.Drawing.Point(0, 29);
            this.filesGridControl.MainView = this.filesGridView;
            this.filesGridControl.Name = "filesGridControl";
            this.filesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.copyTypesLookUpEdit});
            this.filesGridControl.Size = new System.Drawing.Size(536, 412);
            this.filesGridControl.TabIndex = 6;
            this.filesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.filesGridView});
            // 
            // filesBindingSource
            // 
            this.filesBindingSource.DataMember = "FILES";
            this.filesBindingSource.DataSource = this.fullDataSet;
            // 
            // filesTableAdapter
            // 
            this.filesTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colFILE_NAME
            // 
            this.colFILE_NAME.Caption = "Faylın adı";
            this.colFILE_NAME.FieldName = "FILE_NAME";
            this.colFILE_NAME.Name = "colFILE_NAME";
            this.colFILE_NAME.Visible = true;
            this.colFILE_NAME.VisibleIndex = 0;
            this.colFILE_NAME.Width = 269;
            // 
            // colFILE_EXTENTION
            // 
            this.colFILE_EXTENTION.Caption = "Tipi";
            this.colFILE_EXTENTION.FieldName = "FILE_EXTENTION";
            this.colFILE_EXTENTION.Name = "colFILE_EXTENTION";
            this.colFILE_EXTENTION.Visible = true;
            this.colFILE_EXTENTION.VisibleIndex = 1;
            this.colFILE_EXTENTION.Width = 122;
            // 
            // colFILE_SIZE
            // 
            this.colFILE_SIZE.Caption = "Ölçüsü";
            this.colFILE_SIZE.FieldName = "FILE_SIZE";
            this.colFILE_SIZE.Name = "colFILE_SIZE";
            this.colFILE_SIZE.Visible = true;
            this.colFILE_SIZE.VisibleIndex = 2;
            this.colFILE_SIZE.Width = 127;
            // 
            // FilesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filesGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FilesManager";
            this.Size = new System.Drawing.Size(536, 441);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarButtonItem showBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem downloadBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem addBarButtonItem;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarManager barManager1;
        protected DevExpress.XtraGrid.GridControl filesGridControl;
        private FullDataSet fullDataSet;
        public DevExpress.XtraGrid.Views.Grid.GridView filesGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit copyTypesLookUpEdit;
        private System.Windows.Forms.BindingSource filesBindingSource;
        private FullDataSetTableAdapters.FILESTableAdapter filesTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFILE_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colFILE_EXTENTION;
        private DevExpress.XtraGrid.Columns.GridColumn colFILE_SIZE;
    }
}
