using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniArchive.roles
{
    public partial class RolesManager : UniArchive.MasterDetailManager
    {
        public RolesManager()
        {
            InitializeComponent();            
        }

        public void loadData()
        {
            this.fullDataSet.ROLES.ROLESRowChanged -= FullDataSet_RolesRowChanged;
            this.fullDataSet.ROLES.ROLESRowDeleted -= FullDataSet_RolesRowChanged;
            this.rolesTableAdapter.Fill(fullDataSet.ROLES);
            this.fullDataSet.ROLES.ROLESRowChanged += FullDataSet_RolesRowChanged;
            this.fullDataSet.ROLES.ROLESRowDeleted += FullDataSet_RolesRowChanged;
        }

        void FullDataSet_RolesRowChanged(object sender, FullDataSet.ROLESRowChangeEvent e)
        {
            this.rolesTableAdapter.Update(this.fullDataSet.ROLES);
        }

        private void masterGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            masterGridView.GetDataRow(e.RowHandle)["ID"] = DataHelper.GET_ROLES_ID();
        }


    }
}
