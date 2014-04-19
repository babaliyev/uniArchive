namespace UniArchive.clients
{
    partial class ClientsManager
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
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.refreshBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.fullDataSet = new UniArchive.FullDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new UniArchive.FullDataSetTableAdapters.CLIENTSTableAdapter();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCLIENT_TYPE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDENTIFICATION_NUMBER = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colADDRESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCONTACTS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_ACCESS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fullAccessCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullAccessCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 29);
            this.splitContainerControl1.Size = new System.Drawing.Size(620, 459);
            this.splitContainerControl1.SplitterPosition = 191;
            // 
            // masterGridControl
            // 
            this.masterGridControl.DataSource = this.clientsBindingSource;
            this.masterGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.fullAccessCheckEdit});
            this.masterGridControl.Size = new System.Drawing.Size(620, 263);
            this.masterGridControl.UseEmbeddedNavigator = false;
            // 
            // detailsXtraTabControl
            // 
            this.detailsXtraTabControl.Size = new System.Drawing.Size(620, 191);
            // 
            // masterGridView
            // 
            this.masterGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colCLIENT_TYPE,
            this.colFULL_NAME,
            this.colIDENTIFICATION_NUMBER,
            this.colADDRESS,
            this.colCONTACTS,
            this.colFULL_ACCESS});
            this.masterGridView.OptionsCustomization.AllowGroup = false;
            this.masterGridView.OptionsDetail.EnableMasterViewMode = false;
            this.masterGridView.OptionsDetail.ShowDetailTabs = false;
            this.masterGridView.OptionsDetail.SmartDetailExpand = false;
            this.masterGridView.OptionsView.ShowAutoFilterRow = true;
            this.masterGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.masterGridView.OptionsView.ShowGroupPanel = false;
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
            this.refreshBarButtonItem});
            this.barManager1.MaxItemId = 4;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.refreshBarButtonItem, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // addBarButtonItem
            // 
            this.addBarButtonItem.Caption = "Yəni müştəri";
            this.addBarButtonItem.Id = 0;
            this.addBarButtonItem.Name = "addBarButtonItem";
            this.addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBarButtonItem_ItemClick);
            // 
            // editBarButtonItem
            // 
            this.editBarButtonItem.Caption = "Redaktə etmək";
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
            // refreshBarButtonItem
            // 
            this.refreshBarButtonItem.Caption = "Siyahını yənilə";
            this.refreshBarButtonItem.Id = 3;
            this.refreshBarButtonItem.Name = "refreshBarButtonItem";
            this.refreshBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshBarButtonItem_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(620, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 488);
            this.barDockControlBottom.Size = new System.Drawing.Size(620, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 459);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(620, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 459);
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "CLIENTS";
            this.clientsBindingSource.DataSource = this.fullDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colFULL_NAME
            // 
            this.colFULL_NAME.Caption = "Tam adı";
            this.colFULL_NAME.FieldName = "FULL_NAME";
            this.colFULL_NAME.Name = "colFULL_NAME";
            this.colFULL_NAME.Visible = true;
            this.colFULL_NAME.VisibleIndex = 0;
            // 
            // colCLIENT_TYPE
            // 
            this.colCLIENT_TYPE.Caption = "Müştəri Tipi";
            this.colCLIENT_TYPE.FieldName = "CLIENT_TYPE";
            this.colCLIENT_TYPE.Name = "colCLIENT_TYPE";
            // 
            // colIDENTIFICATION_NUMBER
            // 
            this.colIDENTIFICATION_NUMBER.Caption = "VÖEN/PIN";
            this.colIDENTIFICATION_NUMBER.FieldName = "IDENTIFICATION_NUMBER";
            this.colIDENTIFICATION_NUMBER.Name = "colIDENTIFICATION_NUMBER";
            this.colIDENTIFICATION_NUMBER.Visible = true;
            this.colIDENTIFICATION_NUMBER.VisibleIndex = 1;
            // 
            // colADDRESS
            // 
            this.colADDRESS.Caption = "Ünvan";
            this.colADDRESS.FieldName = "ADDRESS";
            this.colADDRESS.Name = "colADDRESS";
            this.colADDRESS.Visible = true;
            this.colADDRESS.VisibleIndex = 2;
            // 
            // colCONTACTS
            // 
            this.colCONTACTS.Caption = "Əlaqə vasitəsi";
            this.colCONTACTS.FieldName = "CONTACTS";
            this.colCONTACTS.Name = "colCONTACTS";
            this.colCONTACTS.Visible = true;
            this.colCONTACTS.VisibleIndex = 3;
            // 
            // colFULL_ACCESS
            // 
            this.colFULL_ACCESS.Caption = "Hamıya görünsün";
            this.colFULL_ACCESS.ColumnEdit = this.fullAccessCheckEdit;
            this.colFULL_ACCESS.FieldName = "FULL_ACCESS";
            this.colFULL_ACCESS.Name = "colFULL_ACCESS";
            this.colFULL_ACCESS.Visible = true;
            this.colFULL_ACCESS.VisibleIndex = 4;
            // 
            // fullAccessCheckEdit
            // 
            this.fullAccessCheckEdit.AutoHeight = false;
            this.fullAccessCheckEdit.Name = "fullAccessCheckEdit";
            this.fullAccessCheckEdit.ValueChecked = ((short)(1));
            this.fullAccessCheckEdit.ValueUnchecked = ((short)(0));
            // 
            // ClientsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ClientsManager";
            this.Controls.SetChildIndex(this.barDockControlTop, 0);
            this.Controls.SetChildIndex(this.barDockControlBottom, 0);
            this.Controls.SetChildIndex(this.barDockControlRight, 0);
            this.Controls.SetChildIndex(this.barDockControlLeft, 0);
            this.Controls.SetChildIndex(this.splitContainerControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullAccessCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem addBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem editBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private FullDataSet fullDataSet;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit fullAccessCheckEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colCLIENT_TYPE;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colIDENTIFICATION_NUMBER;
        private DevExpress.XtraGrid.Columns.GridColumn colADDRESS;
        private DevExpress.XtraGrid.Columns.GridColumn colCONTACTS;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_ACCESS;
        private FullDataSetTableAdapters.CLIENTSTableAdapter clientsTableAdapter;
        private DevExpress.XtraBars.BarButtonItem refreshBarButtonItem;
    }
}
