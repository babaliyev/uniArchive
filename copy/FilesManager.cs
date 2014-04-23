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
    public partial class FilesManager : DevExpress.XtraEditors.XtraUserControl
    {
        private decimal copyId;
        public int filesCount;

        public FilesManager()
        {
            InitializeComponent();
        }

        public void setCopyId(FullDataSet fds, decimal copyId)
        {
            this.copyId = copyId;
            fullDataSet = fds;
            filesBindingSource.DataSource = fullDataSet;
            filesBindingSource.ResetBindings(true);
            this.filesTableAdapter.FillByCopyId(fullDataSet.FILES, copyId);
            filesCount = fullDataSet.FILES.Rows.Count;
        }


        private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {         
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Select Files";
            dlg.Filter = "All files (*.*)|*.*";
            dlg.Multiselect = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (string fileName in dlg.FileNames)
                    {
                        byte[] file;
                        using (var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                        {
                            using (var reader = new BinaryReader(stream))
                            {
                                file = reader.ReadBytes((int)stream.Length);
                            }
                        }

                        DataRow newRow = ((DataRowView)filesBindingSource.AddNew()).Row;
                        newRow["ID"] = DataHelper.GET_FILES_ID();
                        newRow["COPY_ID"] = copyId;
                        newRow["FILE_BODY"] = file;
                        newRow["FILE_SIZE"] = file.LongLength;
                        newRow["FILE_NAME"] = Path.GetFileNameWithoutExtension(fileName);
                        newRow["FILE_EXTENTION"] = Path.GetExtension(fileName);
                        filesBindingSource.EndEdit();
                        filesCount++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to load file: " + ex.Message);
                }
            }

            dlg.Dispose();           
        }

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.filesBindingSource.Current != null)
            {
                DialogResult res = MessageBox.Show("Seçdiyiniz faylı silinsin ? ", "Əminsiniz?", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    this.filesBindingSource.RemoveCurrent();
                    this.filesBindingSource.EndEdit();
                    filesCount--;
                }
            }
        }

        private void downloadBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.filesBindingSource.Current != null)
            {
                FullDataSet.FILESRow fileRow = (FullDataSet.FILESRow)((DataRowView)filesBindingSource.Current).Row;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Files (*."+fileRow.FILE_EXTENTION+")|*."+fileRow.FILE_EXTENTION+"";
                sfd.FileName = fileRow.FILE_NAME + "." + fileRow.FILE_EXTENTION;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                        fs.Write(fileRow.FILE_BODY, 0, fileRow.FILE_BODY.Length);
                }
            }
        }

        private void showBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.filesBindingSource.Current != null)
            {
                FullDataSet.FILESRow fileRow = (FullDataSet.FILESRow)((DataRowView)filesBindingSource.Current).Row;

                PreviewFilesForm previewForm = new PreviewFilesForm();
                previewForm.loadByCopy(fileRow.COPY_ID);
                previewForm.setCurrentFile(fileRow.ID);
                previewForm.ShowDialog();
            }
        }

        private void filesGridControl_DoubleClick(object sender, EventArgs e)
        {
            showBarButtonItem_ItemClick(null, null);
        }
    }
}
