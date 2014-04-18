using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniArchive.users
{
    public partial class UsersManager : DevExpress.XtraEditors.XtraUserControl
    {
        public UsersManager()
        {
            InitializeComponent();
        }

        public void loadData()
        {

            this.fullDataSet.USERS.USERSRowChanged -= FullDataSet_UsersRowChanged;
            this.fullDataSet.USERS.USERSRowDeleted -= FullDataSet_UsersRowChanged;

            this.fullDataSet.USER_ROLES.USER_ROLESRowChanged -= FullDataSet_UserRolesRowChanged;
            this.fullDataSet.USER_ROLES.USER_ROLESRowDeleted -= FullDataSet_UserRolesRowChanged;

            this.usersTableAdapter.Fill(this.fullDataSet.USERS);
            this.rolesTableAdapter.Fill(this.fullDataSet.ROLES);
            this.userRolesTableAdapter.Fill(this.fullDataSet.USER_ROLES);

            this.fullDataSet.USERS.USERSRowChanged += FullDataSet_UsersRowChanged;
            this.fullDataSet.USERS.USERSRowDeleted += FullDataSet_UsersRowChanged;

            this.fullDataSet.USER_ROLES.USER_ROLESRowChanged += FullDataSet_UserRolesRowChanged;
            this.fullDataSet.USER_ROLES.USER_ROLESRowDeleted+= FullDataSet_UserRolesRowChanged;
        }
        
        void FullDataSet_UsersRowChanged(object sender, FullDataSet.USERSRowChangeEvent e)
        {
            this.usersTableAdapter.Update(this.fullDataSet.USERS);
        }

        void FullDataSet_UserRolesRowChanged(object sender, FullDataSet.USER_ROLESRowChangeEvent e)
        {
            this.userRolesTableAdapter.Update(this.fullDataSet.USER_ROLES);
        }

        private void usersGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            usersGridView.GetDataRow(e.RowHandle)["ID"] = DataHelper.GET_USERS_ID();
            
        }
    }
}
