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
using DevExpress.XtraBars.Docking2010.Views;


namespace UniArchive
{
    public partial class MainForm : XtraForm
    {


        public MainForm()
        {
            InitializeComponent();
            barManager.ForceInitialize();
        }

        private void openDocument(Control c)
        {
            BaseDocument _doc = documentManager.GetDocument(c);

            if (_doc == null)
            {
                tabbedView.AddDocument(c);
                tabbedView.ActivateDocument(c);
            }
            else
                tabbedView.ActivateDocument(c);
        }

        private void tabbedView_DocumentAdded(object sender, DevExpress.XtraBars.Docking2010.Views.DocumentEventArgs e)
        {
            e.Document.Caption = e.Document.Control.Tag.ToString();
        }

        #region namagers
        users.UsersManager usersManager;
        roles.RolesManager rolesManager;
        search.SearchManager searchManager;

        private void showUsersManager(string caption)
        {
            if (usersManager == null || usersManager.IsDisposed)
            {
                usersManager = new UniArchive.users.UsersManager();
                usersManager.Tag = caption;
            }

            usersManager.loadData();
            openDocument(usersManager);
        }

        private void showRolesManager(string caption)
        {
            if (rolesManager == null || rolesManager.IsDisposed)
            {
                rolesManager = new UniArchive.roles.RolesManager();
                rolesManager.Tag = caption;
            }

            rolesManager.loadData();
            openDocument(rolesManager);
        }

        private void showSearchManager(string caption)
        {
            if (searchManager == null || searchManager.IsDisposed)
            {
                searchManager = new UniArchive.search.SearchManager();
                searchManager.Tag = caption;
            }

            searchManager.loadData();
            openDocument(searchManager);
        }

        #endregion

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void Users_ItemClick(object sender, ItemClickEventArgs e)
        {
            showUsersManager(e.Item.Caption);
        }

        private void Roles_ItemClick(object sender, ItemClickEventArgs e)
        {
            showRolesManager(e.Item.Caption);
        }

        private void Clients_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void AddressDictionary_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void ReferenceTypes_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Reference_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Attributes_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void DocTypes_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void CopyTypes_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void Search_ItemClick(object sender, ItemClickEventArgs e)
        {
            showSearchManager(e.Item.Caption);
        }


    }
}