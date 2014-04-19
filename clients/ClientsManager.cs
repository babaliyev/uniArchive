using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniArchive.clients
{
    public partial class ClientsManager : UniArchive.MasterDetailManager
    {
        public ClientsManager()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.clientsTableAdapter.Fill(fullDataSet.CLIENTS);
        }

        private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            clients.ClientForm clientForm = new clients.ClientForm();
            if (clientForm.ShowDialog() == DialogResult.OK)
            {
                this.clientsTableAdapter.Fill(fullDataSet.CLIENTS);
                clientsBindingSource.MoveLast();
            }
        }

        private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (clientsBindingSource.Count > 0)
            {
                if (clientsBindingSource.Current != null)
                {
                    int pos = clientsBindingSource.Position;
                    DataRow row = (DataRow)((DataRowView)clientsBindingSource.Current).Row;
                    decimal id = Convert.ToDecimal(row["ID"]);
                    clients.ClientForm clientForm = new clients.ClientForm(id);
                    if (clientForm.ShowDialog() == DialogResult.OK)
                    {
                        this.clientsTableAdapter.Fill(fullDataSet.CLIENTS);
                        clientsBindingSource.Position = pos;
                    }
                }
            }
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
             DialogResult res = MessageBox.Show("Seçdiyiniz müştəri silinsin ? ","Əminsiniz?", MessageBoxButtons.YesNo);

             if (res == DialogResult.Yes)
             {
                 this.clientsBindingSource.RemoveCurrent();
                 this.clientsBindingSource.EndEdit();
                 this.clientsTableAdapter.Update(fullDataSet.CLIENTS);
             }
        }

        private void refreshBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.clientsTableAdapter.Fill(fullDataSet.CLIENTS);
        }
    }
}
