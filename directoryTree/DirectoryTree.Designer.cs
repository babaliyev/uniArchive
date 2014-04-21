namespace UniArchive.directoryTree
{
    partial class DirectoryTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectoryTree));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.addBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.editBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.fullDataSet = new UniArchive.FullDataSet();
            this.directoriesTableAdapter = new UniArchive.FullDataSetTableAdapters.DIRECTORIESTableAdapter();
            this.documentsTableAdapter = new UniArchive.FullDataSetTableAdapters.DOCUMENTSTableAdapter();
            this.copiesTableAdapter = new UniArchive.FullDataSetTableAdapters.COPIESTableAdapter();
            this.directoryImageList = new System.Windows.Forms.ImageList(this.components);
            this.directoryTreeView = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.SuspendLayout();
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
            this.editBarButtonItem});
            this.barManager1.MaxItemId = 3;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.deleteBarButtonItem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawBorder = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // addBarButtonItem
            // 
            this.addBarButtonItem.Caption = "Yeni qovluq";
            this.addBarButtonItem.Id = 0;
            this.addBarButtonItem.Name = "addBarButtonItem";
            this.addBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBarButtonItem_ItemClick);
            // 
            // editBarButtonItem
            // 
            this.editBarButtonItem.Caption = "Redaktə etmək";
            this.editBarButtonItem.Id = 2;
            this.editBarButtonItem.Name = "editBarButtonItem";
            this.editBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editBarButtonItem_ItemClick);
            // 
            // deleteBarButtonItem
            // 
            this.deleteBarButtonItem.Caption = "Silmək";
            this.deleteBarButtonItem.Id = 1;
            this.deleteBarButtonItem.Name = "deleteBarButtonItem";
            this.deleteBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarButtonItem_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(477, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 453);
            this.barDockControlBottom.Size = new System.Drawing.Size(477, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 424);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(477, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 424);
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // directoriesTableAdapter
            // 
            this.directoriesTableAdapter.ClearBeforeFill = true;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // copiesTableAdapter
            // 
            this.copiesTableAdapter.ClearBeforeFill = true;
            // 
            // directoryImageList
            // 
            this.directoryImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("directoryImageList.ImageStream")));
            this.directoryImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.directoryImageList.Images.SetKeyName(0, "folder.png");
            this.directoryImageList.Images.SetKeyName(1, "folder_document.png");
            this.directoryImageList.Images.SetKeyName(2, "document.png");
            this.directoryImageList.Images.SetKeyName(3, "paperclip.png");
            this.directoryImageList.Images.SetKeyName(4, "document_attachment.png");
            this.directoryImageList.Images.SetKeyName(5, "folder_closed.png");
            // 
            // directoryTreeView
            // 
            this.directoryTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryTreeView.HotTracking = true;
            this.directoryTreeView.ImageIndex = 0;
            this.directoryTreeView.ImageList = this.directoryImageList;
            this.directoryTreeView.Location = new System.Drawing.Point(0, 29);
            this.directoryTreeView.Name = "directoryTreeView";
            this.directoryTreeView.SelectedImageIndex = 0;
            this.directoryTreeView.ShowRootLines = false;
            this.directoryTreeView.Size = new System.Drawing.Size(477, 424);
            this.directoryTreeView.TabIndex = 9;
            this.directoryTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.dictionaryTreeView_AfterSelect);
            // 
            // DirectoryTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.directoryTreeView);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DirectoryTree";
            this.Size = new System.Drawing.Size(477, 453);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private FullDataSet fullDataSet;
        private FullDataSetTableAdapters.DIRECTORIESTableAdapter directoriesTableAdapter;
        private DevExpress.XtraBars.BarButtonItem addBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem editBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem deleteBarButtonItem;
        private FullDataSetTableAdapters.DOCUMENTSTableAdapter documentsTableAdapter;
        private FullDataSetTableAdapters.COPIESTableAdapter copiesTableAdapter;
        private System.Windows.Forms.ImageList directoryImageList;
        private System.Windows.Forms.TreeView directoryTreeView;
    }
}
