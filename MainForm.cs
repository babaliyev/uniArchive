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

            directoryTree1.OnOpenDocument += OpenDocument;
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

        private void showAbout()
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void showChangePassword()
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }

        #region namagers

        users.UsersManager usersManager;
        roles.RolesManager rolesManager;
        search.SearchManager searchManager;
        references.ReferencesManager referencesManager;
        docTypes.DocTypesManager docTypesManager;
        copyTypes.CopyTypesManager copyTypesManager;
        clients.ClientsManager clientsManager;
        attributes.AttributesManager attributesManager;
        addressDictionary.AddressDictionaryManager addressDictionaryManager;

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

        private void showReferencesManager(string caption)
        {
            if (referencesManager == null || referencesManager.IsDisposed)
            {
                referencesManager = new UniArchive.references.ReferencesManager();
                referencesManager.Tag = caption;
            }

            referencesManager.loadData();
            openDocument(referencesManager);
        }

        private void showDocTypesManager(string caption)
        {
            if (docTypesManager == null || docTypesManager.IsDisposed)
            {
                docTypesManager = new UniArchive.docTypes.DocTypesManager();
                docTypesManager.Tag = caption;
            }

            docTypesManager.loadData();
            openDocument(docTypesManager);
        }

        private void showCopyTypesManager(string caption)
        {
            if (copyTypesManager == null || copyTypesManager.IsDisposed)
            {
                copyTypesManager = new UniArchive.copyTypes.CopyTypesManager();
                copyTypesManager.Tag = caption;
            }

            copyTypesManager.loadData();
            openDocument(copyTypesManager);
        }

        private void showClientsManager(string caption)
        {
            if (clientsManager == null || clientsManager.IsDisposed)
            {
                clientsManager = new UniArchive.clients.ClientsManager();
                clientsManager.Tag = caption;
            }

            clientsManager.loadData();
            openDocument(clientsManager);
        }

        private void showAttributesManager(string caption)
        {
            if (attributesManager == null || attributesManager.IsDisposed)
            {
                attributesManager = new UniArchive.attributes.AttributesManager();
                attributesManager.Tag = caption;
            }

            attributesManager.loadData();
            openDocument(attributesManager);
        }

        private void showAddressDictionaryManager(string caption)
        {
            if (addressDictionaryManager == null || addressDictionaryManager.IsDisposed)
            {
                addressDictionaryManager = new UniArchive.addressDictionary.AddressDictionaryManager();
                addressDictionaryManager.Tag = caption;
            }

            addressDictionaryManager.loadData();
            openDocument(addressDictionaryManager);
        }

        private void showDocument(decimal id, string num)
        {
            document.DocumentManager document = new UniArchive.document.DocumentManager(id);
            document.Tag = num;
            openDocument(document);
        }

        private void newDocument()
        {
            document.DocumentManager document = new UniArchive.document.DocumentManager();
            document.Tag = "Yeni sənəd";
            openDocument(document);
        }

        private void showCopy(decimal id, string num)
        {
            copy.StandaloneCopyManager copy = new UniArchive.copy.StandaloneCopyManager(null,id);
            copy.Tag = num;
            openDocument(copy);
        }

        private void newClient()
        {
            clients.ClientForm clientForm = new clients.ClientForm();
            clientForm.ShowDialog();
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
            showClientsManager(e.Item.Caption);
        }

        private void AddressDictionary_ItemClick(object sender, ItemClickEventArgs e)
        {
            showAddressDictionaryManager(e.Item.Caption);
        }

        private void Reference_ItemClick(object sender, ItemClickEventArgs e)
        {
            showReferencesManager(e.Item.Caption);
        }

        private void Attributes_ItemClick(object sender, ItemClickEventArgs e)
        {
            showAttributesManager(e.Item.Caption);
        }

        private void DocTypes_ItemClick(object sender, ItemClickEventArgs e)
        {
            showDocTypesManager(e.Item.Caption);
        }

        private void CopyTypes_ItemClick(object sender, ItemClickEventArgs e)
        {
            showCopyTypesManager(e.Item.Caption);
        }

        private void Search_ItemClick(object sender, ItemClickEventArgs e)
        {
            showSearchManager(e.Item.Caption);
        }
        
        private void aboutBarButtonItem_ItemClick(object sender, ItemClickEventArgs e)
        {
            showAbout();
        }

        private void ChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            showChangePassword();
        }

        private void addDocument_ItemClick(object sender, ItemClickEventArgs e)
        {
            newDocument();
        }

        private void addClient_ItemClick(object sender, ItemClickEventArgs e)
        {
            newClient();
        }

        public void OpenDocument(object sender, EventArgs args)
        {
            showDocument((decimal)sender, sender.ToString());
        }
    }
}