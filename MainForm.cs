using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using System.Collections;
using DevExpress.XtraBars.Helpers;
using DevExpress.UserSkins;


namespace UniArchive
{
    public partial class MainForm : XtraForm
    {
        public MainForm()
        {
            InitializeComponent();
            barManager.ForceInitialize();
            SkinHelper.InitSkinPopupMenu(mPaintStyle);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Users_ItemClick(object sender, ItemClickEventArgs e)
        {
            users.Users users = new UniArchive.users.Users();
            users.Tag = e.Item.Caption;
            tabbedView.AddDocument(users);            
        }

        private void tabbedView_DocumentAdded(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            e.Document.Caption = e.Document.Control.Tag.ToString();
        }

    }
}