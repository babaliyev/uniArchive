using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniArchive.directoryTree
{
    public partial class DirectoryTree : DevExpress.XtraEditors.XtraUserControl
    {
        public DirectoryTree()
        {
            InitializeComponent();
            this.directoriesTableAdapter.Fill(fullDataSet.DIRECTORIES);
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult res = MessageBox.Show("Seçdiyiniz qovluq silinsin ? ", "Əminsiniz?", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                this.directoriesBindingSource.RemoveCurrent();
                this.directoriesBindingSource.EndEdit();
                this.directoriesTableAdapter.Update(fullDataSet.DIRECTORIES);
            }
        }

        private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (directoriesBindingSource.Count > 0)
            {
                if (directoriesBindingSource.Current != null)
                {
                    int pos = directoriesBindingSource.Position;
                    DataRow row = (DataRow)((DataRowView)directoriesBindingSource.Current).Row;
                    decimal id = Convert.ToDecimal(row["ID"]);
                    DirectoryForm directoryForm = new DirectoryForm(id);
                    if (directoryForm.ShowDialog() == DialogResult.OK)
                    {
                        this.directoriesTableAdapter.Fill(fullDataSet.DIRECTORIES);
                        directoriesBindingSource.Position = pos;
                    }
                }
            }
        }

        private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            decimal? parentId = null;

            if (directoriesBindingSource.Count > 0)
            {
                if (directoriesBindingSource.Current != null)
                {
                    int pos = directoriesBindingSource.Position;
                    DataRow row = (DataRow)((DataRowView)directoriesBindingSource.Current).Row;
                    parentId = Convert.ToDecimal(row["ID"]);                    
                }
            }

            DirectoryForm directoryForm = new DirectoryForm(parentId);
            if (directoryForm.ShowDialog() == DialogResult.OK)
            {
                this.directoriesTableAdapter.Fill(fullDataSet.DIRECTORIES);
            }
        }

        public event EventHandler OnOpenDocument;

        private void treeList1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (directoriesBindingSource.Count > 0)
            {
                if (directoriesBindingSource.Current != null)
                {
                    int pos = directoriesBindingSource.Position;
                    DataRow row = (DataRow)((DataRowView)directoriesBindingSource.Current).Row;

                    decimal isDirectory = Convert.ToDecimal(row["IS_DIRECTORY"]);

                    if (isDirectory == 0)
                    {
                        if (OnOpenDocument != null)
                        {
                            decimal id = Convert.ToDecimal(row["ID"]);
                            OnOpenDocument(id, EventArgs.Empty); 
                        }
                    }
                }
            }
        }
    }
}
