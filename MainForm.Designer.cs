namespace UniArchive
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.navbarImageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.navbarImageList = new System.Windows.Forms.ImageList(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.addDocument = new DevExpress.XtraBars.BarButtonItem();
            this.addClient = new DevExpress.XtraBars.BarButtonItem();
            this.Search = new DevExpress.XtraBars.BarButtonItem();
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.mFile = new DevExpress.XtraBars.BarSubItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.ChangePassword = new DevExpress.XtraBars.BarButtonItem();
            this.actionsBarSubItem = new DevExpress.XtraBars.BarSubItem();
            this.importBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.executeBarSubItem = new DevExpress.XtraBars.BarSubItem();
            this.Clients = new DevExpress.XtraBars.BarButtonItem();
            this.Users = new DevExpress.XtraBars.BarButtonItem();
            this.Roles = new DevExpress.XtraBars.BarButtonItem();
            this.AddressDictionary = new DevExpress.XtraBars.BarButtonItem();
            this.Reference = new DevExpress.XtraBars.BarButtonItem();
            this.Attributes = new DevExpress.XtraBars.BarButtonItem();
            this.DocTypes = new DevExpress.XtraBars.BarButtonItem();
            this.CopyTypes = new DevExpress.XtraBars.BarButtonItem();
            this.aboutBarButtonItem = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.sItem = new DevExpress.XtraBars.BarStaticItem();
            this.sSecItem = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.hideContainerLeft = new DevExpress.XtraBars.Docking.AutoHideContainer();
            this.addressDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.addressTree1 = new UniArchive.addressTree.AddressTree();
            this.directoryDockPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.directoryTree1 = new UniArchive.directoryTree.DirectoryTree();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.iAbout = new DevExpress.XtraBars.BarButtonItem();
            this.addDirectory = new DevExpress.XtraBars.BarButtonItem();
            this.editDirectory = new DevExpress.XtraBars.BarButtonItem();
            this.delDirectory = new DevExpress.XtraBars.BarButtonItem();
            this.editDocument = new DevExpress.XtraBars.BarButtonItem();
            this.delDocument = new DevExpress.XtraBars.BarButtonItem();
            this.addCopy = new DevExpress.XtraBars.BarButtonItem();
            this.editCopy = new DevExpress.XtraBars.BarButtonItem();
            this.delCopy = new DevExpress.XtraBars.BarButtonItem();
            this.editClient = new DevExpress.XtraBars.BarButtonItem();
            this.delClient = new DevExpress.XtraBars.BarButtonItem();
            this.giveDocument = new DevExpress.XtraBars.BarButtonItem();
            this.returnDocument = new DevExpress.XtraBars.BarButtonItem();
            this.giveCopy = new DevExpress.XtraBars.BarButtonItem();
            this.returnCopy = new DevExpress.XtraBars.BarButtonItem();
            this.documentManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).BeginInit();
            this.hideContainerLeft.SuspendLayout();
            this.addressDockPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.directoryDockPanel.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            this.SuspendLayout();
            // 
            // navbarImageListLarge
            // 
            this.navbarImageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageListLarge.ImageStream")));
            this.navbarImageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageListLarge.Images.SetKeyName(0, "Mail_32x32.png");
            this.navbarImageListLarge.Images.SetKeyName(1, "Organizer_32x32.png");
            // 
            // navbarImageList
            // 
            this.navbarImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("navbarImageList.ImageStream")));
            this.navbarImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.navbarImageList.Images.SetKeyName(0, "Inbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(1, "Outbox_16x16.png");
            this.navbarImageList.Images.SetKeyName(2, "Drafts_16x16.png");
            this.navbarImageList.Images.SetKeyName(3, "Trash_16x16.png");
            this.navbarImageList.Images.SetKeyName(4, "Calendar_16x16.png");
            this.navbarImageList.Images.SetKeyName(5, "Tasks_16x16.png");
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar1,
            this.bar3});
            this.barManager.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("Managers", new System.Guid("aa9c8294-2188-411a-8877-3795a1136ba2")),
            new DevExpress.XtraBars.BarManagerCategory("DirectoryActions", new System.Guid("1f6e3277-0f80-4730-8e94-a3079fc52200")),
            new DevExpress.XtraBars.BarManagerCategory("DocumentActions", new System.Guid("6c82e277-637f-4052-bc27-3ba2af92f37f")),
            new DevExpress.XtraBars.BarManagerCategory("CopyActions", new System.Guid("2fbaff10-351d-481e-82c7-04e454b52f62")),
            new DevExpress.XtraBars.BarManagerCategory("ClientActions", new System.Guid("300076e1-b79e-4079-aca2-defe9e638042"))});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.DockManager = this.dockManager;
            this.barManager.Form = this;
            this.barManager.Images = this.imageList;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.mFile,
            this.iExit,
            this.iAbout,
            this.sItem,
            this.sSecItem,
            this.Clients,
            this.Users,
            this.Roles,
            this.AddressDictionary,
            this.Reference,
            this.Attributes,
            this.DocTypes,
            this.CopyTypes,
            this.Search,
            this.addDirectory,
            this.editDirectory,
            this.delDirectory,
            this.addDocument,
            this.editDocument,
            this.delDocument,
            this.addCopy,
            this.editCopy,
            this.delCopy,
            this.addClient,
            this.editClient,
            this.delClient,
            this.ChangePassword,
            this.giveDocument,
            this.returnDocument,
            this.giveCopy,
            this.returnCopy,
            this.executeBarSubItem,
            this.aboutBarButtonItem,
            this.actionsBarSubItem,
            this.importBarButtonItem});
            this.barManager.MainMenu = this.bar1;
            this.barManager.MaxItemId = 65;
            this.barManager.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(49, 157);
            this.bar2.FloatSize = new System.Drawing.Size(46, 29);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addDocument, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.addClient, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Search, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.Text = "Tools";
            // 
            // addDocument
            // 
            this.addDocument.Caption = "Yeni sənəd";
            this.addDocument.CategoryGuid = new System.Guid("6c82e277-637f-4052-bc27-3ba2af92f37f");
            this.addDocument.Id = 46;
            this.addDocument.Name = "addDocument";
            this.addDocument.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addDocument_ItemClick);
            // 
            // addClient
            // 
            this.addClient.Caption = "Yeni müştəri";
            this.addClient.CategoryGuid = new System.Guid("300076e1-b79e-4079-aca2-defe9e638042");
            this.addClient.Id = 53;
            this.addClient.Name = "addClient";
            this.addClient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addClient_ItemClick);
            // 
            // Search
            // 
            this.Search.Caption = "Axtarış";
            this.Search.CategoryGuid = new System.Guid("aa9c8294-2188-411a-8877-3795a1136ba2");
            this.Search.Id = 41;
            this.Search.Name = "Search";
            this.Search.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Search_ItemClick);
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.mFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.actionsBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.executeBarSubItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.aboutBarButtonItem)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
            // 
            // mFile
            // 
            this.mFile.Caption = "&Fayl";
            this.mFile.Id = 0;
            this.mFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iExit),
            new DevExpress.XtraBars.LinkPersistInfo(this.ChangePassword)});
            this.mFile.Name = "mFile";
            // 
            // iExit
            // 
            this.iExit.Caption = "E&xit";
            this.iExit.Id = 7;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick);
            // 
            // ChangePassword
            // 
            this.ChangePassword.Caption = "Şifrəni dəyişmək";
            this.ChangePassword.Id = 56;
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ChangePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ChangePassword_ItemClick);
            // 
            // actionsBarSubItem
            // 
            this.actionsBarSubItem.Caption = "Əsas əməliyyatlar";
            this.actionsBarSubItem.Id = 63;
            this.actionsBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.addClient),
            new DevExpress.XtraBars.LinkPersistInfo(this.addDocument),
            new DevExpress.XtraBars.LinkPersistInfo(this.importBarButtonItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.Search, true)});
            this.actionsBarSubItem.Name = "actionsBarSubItem";
            // 
            // importBarButtonItem
            // 
            this.importBarButtonItem.Caption = "Import";
            this.importBarButtonItem.CategoryGuid = new System.Guid("6c82e277-637f-4052-bc27-3ba2af92f37f");
            this.importBarButtonItem.Id = 64;
            this.importBarButtonItem.Name = "importBarButtonItem";
            this.importBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.importBarButtonItem_ItemClick);
            // 
            // executeBarSubItem
            // 
            this.executeBarSubItem.Caption = "Əsas obyektlər";
            this.executeBarSubItem.Id = 61;
            this.executeBarSubItem.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.Clients),
            new DevExpress.XtraBars.LinkPersistInfo(this.Users),
            new DevExpress.XtraBars.LinkPersistInfo(this.Roles),
            new DevExpress.XtraBars.LinkPersistInfo(this.AddressDictionary),
            new DevExpress.XtraBars.LinkPersistInfo(this.Reference),
            new DevExpress.XtraBars.LinkPersistInfo(this.Attributes),
            new DevExpress.XtraBars.LinkPersistInfo(this.DocTypes),
            new DevExpress.XtraBars.LinkPersistInfo(this.CopyTypes),
            new DevExpress.XtraBars.LinkPersistInfo(this.Search)});
            this.executeBarSubItem.Name = "executeBarSubItem";
            // 
            // Clients
            // 
            this.Clients.Caption = "Müştərilər";
            this.Clients.CategoryGuid = new System.Guid("aa9c8294-2188-411a-8877-3795a1136ba2");
            this.Clients.Id = 31;
            this.Clients.Name = "Clients";
            this.Clients.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Clients_ItemClick);
            // 
            // Users
            // 
            this.Users.Caption = "İstifadəçilər";
            this.Users.CategoryGuid = new System.Guid("aa9c8294-2188-411a-8877-3795a1136ba2");
            this.Users.Id = 32;
            this.Users.Name = "Users";
            this.Users.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Users_ItemClick);
            // 
            // Roles
            // 
            this.Roles.Caption = "Rollar";
            this.Roles.CategoryGuid = new System.Guid("aa9c8294-2188-411a-8877-3795a1136ba2");
            this.Roles.Id = 33;
            this.Roles.Name = "Roles";
            this.Roles.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Roles_ItemClick);
            // 
            // AddressDictionary
            // 
            this.AddressDictionary.Caption = "Arxivin strukturu";
            this.AddressDictionary.CategoryGuid = new System.Guid("aa9c8294-2188-411a-8877-3795a1136ba2");
            this.AddressDictionary.Id = 34;
            this.AddressDictionary.Name = "AddressDictionary";
            this.AddressDictionary.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddressDictionary_ItemClick);
            // 
            // Reference
            // 
            this.Reference.Caption = "Soraq kitabçası";
            this.Reference.CategoryGuid = new System.Guid("aa9c8294-2188-411a-8877-3795a1136ba2");
            this.Reference.Id = 37;
            this.Reference.Name = "Reference";
            this.Reference.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Reference_ItemClick);
            // 
            // Attributes
            // 
            this.Attributes.Caption = "Xassələr";
            this.Attributes.CategoryGuid = new System.Guid("aa9c8294-2188-411a-8877-3795a1136ba2");
            this.Attributes.Id = 38;
            this.Attributes.Name = "Attributes";
            this.Attributes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Attributes_ItemClick);
            // 
            // DocTypes
            // 
            this.DocTypes.Caption = "Sənəd tipləri";
            this.DocTypes.CategoryGuid = new System.Guid("aa9c8294-2188-411a-8877-3795a1136ba2");
            this.DocTypes.Id = 39;
            this.DocTypes.Name = "DocTypes";
            this.DocTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DocTypes_ItemClick);
            // 
            // CopyTypes
            // 
            this.CopyTypes.Caption = "Qoşma tipləri";
            this.CopyTypes.CategoryGuid = new System.Guid("aa9c8294-2188-411a-8877-3795a1136ba2");
            this.CopyTypes.Id = 40;
            this.CopyTypes.Name = "CopyTypes";
            this.CopyTypes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CopyTypes_ItemClick);
            // 
            // aboutBarButtonItem
            // 
            this.aboutBarButtonItem.Caption = "Haqqında";
            this.aboutBarButtonItem.Id = 62;
            this.aboutBarButtonItem.Name = "aboutBarButtonItem";
            this.aboutBarButtonItem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.aboutBarButtonItem_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.sItem),
            new DevExpress.XtraBars.LinkPersistInfo(this.sSecItem)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // sItem
            // 
            this.sItem.Caption = "Some Info";
            this.sItem.Id = 9;
            this.sItem.Name = "sItem";
            this.sItem.TextAlignment = System.Drawing.StringAlignment.Near;
            // 
            // sSecItem
            // 
            this.sSecItem.AutoSize = DevExpress.XtraBars.BarStaticItemSize.Spring;
            this.sSecItem.Caption = "Some Info";
            this.sSecItem.Id = 10;
            this.sSecItem.Name = "sSecItem";
            this.sSecItem.TextAlignment = System.Drawing.StringAlignment.Near;
            this.sSecItem.Width = 32;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(809, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 384);
            this.barDockControlBottom.Size = new System.Drawing.Size(809, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 333);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(809, 51);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 333);
            // 
            // dockManager
            // 
            this.dockManager.AutoHideContainers.AddRange(new DevExpress.XtraBars.Docking.AutoHideContainer[] {
            this.hideContainerLeft});
            this.dockManager.Form = this;
            this.dockManager.MenuManager = this.barManager;
            this.dockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.directoryDockPanel});
            this.dockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // hideContainerLeft
            // 
            this.hideContainerLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.hideContainerLeft.Controls.Add(this.addressDockPanel);
            this.hideContainerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.hideContainerLeft.Location = new System.Drawing.Point(0, 51);
            this.hideContainerLeft.Name = "hideContainerLeft";
            this.hideContainerLeft.Size = new System.Drawing.Size(19, 333);
            // 
            // addressDockPanel
            // 
            this.addressDockPanel.Controls.Add(this.dockPanel1_Container);
            this.addressDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.addressDockPanel.ID = new System.Guid("c49d9910-8eb8-4d86-b07b-82cd4413957b");
            this.addressDockPanel.Location = new System.Drawing.Point(0, 0);
            this.addressDockPanel.Name = "addressDockPanel";
            this.addressDockPanel.OriginalSize = new System.Drawing.Size(233, 200);
            this.addressDockPanel.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.addressDockPanel.SavedIndex = 0;
            this.addressDockPanel.Size = new System.Drawing.Size(233, 333);
            this.addressDockPanel.Text = "Ünvan";
            this.addressDockPanel.Visibility = DevExpress.XtraBars.Docking.DockVisibility.AutoHide;
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.addressTree1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(225, 306);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // addressTree1
            // 
            this.addressTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTree1.Location = new System.Drawing.Point(0, 0);
            this.addressTree1.Name = "addressTree1";
            this.addressTree1.Size = new System.Drawing.Size(225, 306);
            this.addressTree1.TabIndex = 0;
            // 
            // directoryDockPanel
            // 
            this.directoryDockPanel.Controls.Add(this.dockPanel2_Container);
            this.directoryDockPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.directoryDockPanel.ID = new System.Guid("42f1c68e-c4f3-4a65-b1a4-e62c7c221a3b");
            this.directoryDockPanel.Location = new System.Drawing.Point(19, 51);
            this.directoryDockPanel.Name = "directoryDockPanel";
            this.directoryDockPanel.OriginalSize = new System.Drawing.Size(233, 200);
            this.directoryDockPanel.Size = new System.Drawing.Size(233, 333);
            this.directoryDockPanel.Text = "Qovluqlar";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.directoryTree1);
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(225, 306);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // directoryTree1
            // 
            this.directoryTree1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryTree1.Location = new System.Drawing.Point(0, 0);
            this.directoryTree1.Name = "directoryTree1";
            this.directoryTree1.Size = new System.Drawing.Size(225, 306);
            this.directoryTree1.TabIndex = 0;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.White;
            this.imageList.Images.SetKeyName(0, "New_16x16.png");
            this.imageList.Images.SetKeyName(1, "Open_16x16.png");
            this.imageList.Images.SetKeyName(2, "Save_16x16.png");
            this.imageList.Images.SetKeyName(3, "SaveAs_16x16.png");
            // 
            // iAbout
            // 
            this.iAbout.Caption = "&About";
            this.iAbout.Id = 8;
            this.iAbout.Name = "iAbout";
            // 
            // addDirectory
            // 
            this.addDirectory.Caption = "Yeni qovluq";
            this.addDirectory.CategoryGuid = new System.Guid("1f6e3277-0f80-4730-8e94-a3079fc52200");
            this.addDirectory.Id = 43;
            this.addDirectory.Name = "addDirectory";
            // 
            // editDirectory
            // 
            this.editDirectory.Caption = "Redakte";
            this.editDirectory.CategoryGuid = new System.Guid("1f6e3277-0f80-4730-8e94-a3079fc52200");
            this.editDirectory.Id = 44;
            this.editDirectory.Name = "editDirectory";
            // 
            // delDirectory
            // 
            this.delDirectory.Caption = "Silmək";
            this.delDirectory.CategoryGuid = new System.Guid("1f6e3277-0f80-4730-8e94-a3079fc52200");
            this.delDirectory.Id = 45;
            this.delDirectory.Name = "delDirectory";
            // 
            // editDocument
            // 
            this.editDocument.Caption = "Redaktə";
            this.editDocument.CategoryGuid = new System.Guid("6c82e277-637f-4052-bc27-3ba2af92f37f");
            this.editDocument.Id = 47;
            this.editDocument.Name = "editDocument";
            // 
            // delDocument
            // 
            this.delDocument.Caption = "Silmək";
            this.delDocument.CategoryGuid = new System.Guid("6c82e277-637f-4052-bc27-3ba2af92f37f");
            this.delDocument.Id = 48;
            this.delDocument.Name = "delDocument";
            // 
            // addCopy
            // 
            this.addCopy.Caption = "Yeni qoşma";
            this.addCopy.CategoryGuid = new System.Guid("2fbaff10-351d-481e-82c7-04e454b52f62");
            this.addCopy.Id = 50;
            this.addCopy.Name = "addCopy";
            // 
            // editCopy
            // 
            this.editCopy.Caption = "Redaktə";
            this.editCopy.CategoryGuid = new System.Guid("2fbaff10-351d-481e-82c7-04e454b52f62");
            this.editCopy.Id = 51;
            this.editCopy.Name = "editCopy";
            // 
            // delCopy
            // 
            this.delCopy.Caption = "Silmək";
            this.delCopy.CategoryGuid = new System.Guid("2fbaff10-351d-481e-82c7-04e454b52f62");
            this.delCopy.Id = 52;
            this.delCopy.Name = "delCopy";
            // 
            // editClient
            // 
            this.editClient.Caption = "Redaktə";
            this.editClient.CategoryGuid = new System.Guid("300076e1-b79e-4079-aca2-defe9e638042");
            this.editClient.Id = 54;
            this.editClient.Name = "editClient";
            // 
            // delClient
            // 
            this.delClient.Caption = "Silmək";
            this.delClient.CategoryGuid = new System.Guid("300076e1-b79e-4079-aca2-defe9e638042");
            this.delClient.Id = 55;
            this.delClient.Name = "delClient";
            // 
            // giveDocument
            // 
            this.giveDocument.Caption = "Başqa adama vermək";
            this.giveDocument.CategoryGuid = new System.Guid("6c82e277-637f-4052-bc27-3ba2af92f37f");
            this.giveDocument.Id = 57;
            this.giveDocument.Name = "giveDocument";
            // 
            // returnDocument
            // 
            this.returnDocument.Caption = "Geri qaytarmaq";
            this.returnDocument.CategoryGuid = new System.Guid("6c82e277-637f-4052-bc27-3ba2af92f37f");
            this.returnDocument.Id = 58;
            this.returnDocument.Name = "returnDocument";
            // 
            // giveCopy
            // 
            this.giveCopy.Caption = "Başqa adama vermək";
            this.giveCopy.CategoryGuid = new System.Guid("2fbaff10-351d-481e-82c7-04e454b52f62");
            this.giveCopy.Id = 59;
            this.giveCopy.Name = "giveCopy";
            // 
            // returnCopy
            // 
            this.returnCopy.Caption = "Geri qaytarmaq";
            this.returnCopy.CategoryGuid = new System.Guid("2fbaff10-351d-481e-82c7-04e454b52f62");
            this.returnCopy.Id = 60;
            this.returnCopy.Name = "returnCopy";
            // 
            // documentManager
            // 
            this.documentManager.ContainerControl = this;
            this.documentManager.MenuManager = this.barManager;
            this.documentManager.View = this.tabbedView;
            this.documentManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView});
            // 
            // tabbedView
            // 
            this.tabbedView.OptionsLayout.PropertiesRestoreMode = DevExpress.XtraBars.Docking2010.Views.PropertiesRestoreMode.UI;
            this.tabbedView.UseDocumentSelector = DevExpress.Utils.DefaultBoolean.True;
            this.tabbedView.DocumentAdded += new DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(this.tabbedView_DocumentAdded);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 409);
            this.Controls.Add(this.directoryDockPanel);
            this.Controls.Add(this.hideContainerLeft);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UniArchive";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager)).EndInit();
            this.hideContainerLeft.ResumeLayout(false);
            this.addressDockPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.directoryDockPanel.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.documentManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem mFile;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iAbout;
        private DevExpress.XtraBars.BarStaticItem sItem;
        private DevExpress.XtraBars.BarStaticItem sSecItem;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ImageList navbarImageList;
        private System.Windows.Forms.ImageList navbarImageListLarge;
        private DevExpress.XtraBars.Docking.DockManager dockManager;
        private DevExpress.XtraBars.Docking.DockPanel directoryDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel addressDockPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Docking.AutoHideContainer hideContainerLeft;
        private DevExpress.XtraBars.BarButtonItem Clients;
        private DevExpress.XtraBars.BarButtonItem Users;
        private DevExpress.XtraBars.BarButtonItem Roles;
        private DevExpress.XtraBars.BarButtonItem AddressDictionary;
        private DevExpress.XtraBars.BarButtonItem Reference;
        private DevExpress.XtraBars.BarButtonItem Attributes;
        private DevExpress.XtraBars.BarButtonItem DocTypes;
        private DevExpress.XtraBars.BarButtonItem CopyTypes;
        private DevExpress.XtraBars.BarButtonItem Search;
        private DevExpress.XtraBars.BarButtonItem ChangePassword;
        private DevExpress.XtraBars.BarButtonItem addDirectory;
        private DevExpress.XtraBars.BarButtonItem editDirectory;
        private DevExpress.XtraBars.BarButtonItem delDirectory;
        private DevExpress.XtraBars.BarButtonItem addDocument;
        private DevExpress.XtraBars.BarButtonItem editDocument;
        private DevExpress.XtraBars.BarButtonItem delDocument;
        private DevExpress.XtraBars.BarButtonItem addCopy;
        private DevExpress.XtraBars.BarButtonItem editCopy;
        private DevExpress.XtraBars.BarButtonItem delCopy;
        private DevExpress.XtraBars.BarButtonItem addClient;
        private DevExpress.XtraBars.BarButtonItem editClient;
        private DevExpress.XtraBars.BarButtonItem delClient;
        private DevExpress.XtraBars.BarButtonItem giveDocument;
        private DevExpress.XtraBars.BarButtonItem returnDocument;
        private DevExpress.XtraBars.BarButtonItem giveCopy;
        private DevExpress.XtraBars.BarButtonItem returnCopy;
        private DevExpress.XtraBars.BarSubItem executeBarSubItem;
        private addressTree.AddressTree addressTree1;
        private directoryTree.DirectoryTree directoryTree1;
        private DevExpress.XtraBars.BarButtonItem aboutBarButtonItem;
        private DevExpress.XtraBars.BarSubItem actionsBarSubItem;
        private DevExpress.XtraBars.BarButtonItem importBarButtonItem;

    }
}
