using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;

namespace UniArchive.copy
{
    public partial class CopyManager : DevExpress.XtraEditors.XtraUserControl
    {
        protected decimal id;
        protected decimal documentId;

        public CopyManager(decimal documentId)
        {
            InitializeComponent();            
            this.documentId = documentId;            
        }
        
        public void setDataSet(FullDataSet fds)
        {
            documentsBindingSource.DataSource = fds;
            copyTypesBindingSource.DataSource = fds;
            copiesBindingSource.DataSource = fds;

            documentsBindingSource.ResetBindings(true);
            copyTypesBindingSource.ResetBindings(true);
            copiesBindingSource.ResetBindings(true);
        }

        public void edit(decimal id)
        {
            this.id = id;
            copiesBindingSource.Position = copiesBindingSource.Find("ID", id);
        }

        public void addNew()
        {
            DataRow newRow = ((DataRowView)copiesBindingSource.AddNew()).Row;
            id = DataHelper.GET_COPIES_ID();
            newRow["ID"] = id;
            newRow["FULL_ACCESS"] = 1;
            newRow["DOCUMENT_ID"] = this.documentId;   
        }
              
        private void saveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    this.copiesBindingSource.EndEdit();

                    if(OnSave!=null)
                        OnSave(this, EventArgs.Empty);                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void setBodyBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                fileBodyPictureEdit.Image = Image.FromFile(openFile.FileName);
                DataRow row = ((DataRowView)copiesBindingSource.Current).Row;
                row["FILE_NAME"] = Path.GetFileNameWithoutExtension(openFile.FileName);
                row["FILE_EXTENTION"] = Path.GetExtension(openFile.FileName);
                row["PAGES_COUNT"] = 1;
            }
        }

        private void deleteBodyBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fileBodyPictureEdit.Image = null;
        }

        public event EventHandler OnSave;
    }
}
