namespace UniArchive.copy
{
    partial class PreviewFilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewFilesForm));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.printBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.printAllBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.firstBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.prevBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.nextBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.lastBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.copyNameBarStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.countBarStaticItem = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.filesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UniArchive.FullDataSet();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.filesTableAdapter = new UniArchive.FullDataSetTableAdapters.FILESTableAdapter();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.countBarStaticItem,
            this.barStaticItem1,
            this.printBarButtonItem,
            this.printAllBarButtonItem,
            this.firstBarButtonItem,
            this.prevBarButtonItem,
            this.nextBarButtonItem,
            this.lastBarButtonItem,
            this.barButtonItem1,
            this.copyNameBarStaticItem});
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.printBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.printAllBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.firstBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.prevBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.nextBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.lastBarButtonItem)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.RotateWhenVertical = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // printBarButtonItem
            // 
            this.printBarButtonItem.Caption = "Çap etmək";
            this.printBarButtonItem.Id = 2;
            this.printBarButtonItem.Name = "printBarButtonItem";
            this.printBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printBarButtonItem_ItemClick);
            // 
            // printAllBarButtonItem
            // 
            this.printAllBarButtonItem.Caption = "Bütün faylları çap etmək";
            this.printAllBarButtonItem.Id = 3;
            this.printAllBarButtonItem.Name = "printAllBarButtonItem";
            this.printAllBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.printAllBarButtonItem_ItemClick);
            // 
            // firstBarButtonItem
            // 
            this.firstBarButtonItem.Caption = "əvvəlki";
            this.firstBarButtonItem.Id = 4;
            this.firstBarButtonItem.Name = "firstBarButtonItem";
            this.firstBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.firstBarButtonItem_ItemClick);
            // 
            // prevBarButtonItem
            // 
            this.prevBarButtonItem.Caption = "əvvəlki";
            this.prevBarButtonItem.Id = 5;
            this.prevBarButtonItem.Name = "prevBarButtonItem";
            this.prevBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.prevBarButtonItem_ItemClick);
            // 
            // nextBarButtonItem
            // 
            this.nextBarButtonItem.Caption = "sonrakı";
            this.nextBarButtonItem.Id = 6;
            this.nextBarButtonItem.Name = "nextBarButtonItem";
            this.nextBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.nextBarButtonItem_ItemClick);
            // 
            // lastBarButtonItem
            // 
            this.lastBarButtonItem.Caption = "sonuncu";
            this.lastBarButtonItem.Id = 7;
            this.lastBarButtonItem.Name = "lastBarButtonItem";
            this.lastBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.lastBarButtonItem_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.copyNameBarStaticItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.barStaticItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.countBarStaticItem)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Sənəd";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // copyNameBarStaticItem
            // 
            this.copyNameBarStaticItem.Caption = "001/23";
            this.copyNameBarStaticItem.Id = 9;
            this.copyNameBarStaticItem.Name = "copyNameBarStaticItem";
            this.copyNameBarStaticItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.AllowRightClickInMenu = false;
            this.barStaticItem1.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.barStaticItem1.Caption = "Fayllar";
            this.barStaticItem1.Id = 1;
            this.barStaticItem1.Name = "barStaticItem1";
            this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Far;
            this.barStaticItem1.Width = 32;
            // 
            // countBarStaticItem
            // 
            this.countBarStaticItem.Caption = "0 (0)";
            this.countBarStaticItem.Id = 0;
            this.countBarStaticItem.Name = "countBarStaticItem";
            this.countBarStaticItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(543, 29);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 513);
            this.barDockControlBottom.Size = new System.Drawing.Size(543, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 29);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 484);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(543, 29);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 484);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.filesBindingSource, "FILE_BODY", true));
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 29);
            this.pictureEdit1.MenuManager = this.barManager1;
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(543, 484);
            this.pictureEdit1.TabIndex = 4;
            // 
            // filesBindingSource
            // 
            this.filesBindingSource.DataMember = "FILES";
            this.filesBindingSource.DataSource = this.fullDataSet;
            this.filesBindingSource.CurrentChanged += new System.EventHandler(this.filesBindingSource_CurrentChanged);
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // filesTableAdapter
            // 
            this.filesTableAdapter.ClearBeforeFill = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PreviewFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 538);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MinimizeBox = false;
            this.Name = "PreviewFilesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PreviewFilesForm";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarStaticItem countBarStaticItem;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarButtonItem printBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem printAllBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem firstBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem prevBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem nextBarButtonItem;
        private DevExpress.XtraBars.BarButtonItem lastBarButtonItem;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource filesBindingSource;
        private FullDataSetTableAdapters.FILESTableAdapter filesTableAdapter;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarStaticItem copyNameBarStaticItem;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}