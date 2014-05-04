using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using Oracle.DataAccess.Client;

namespace UniArchive
{
    public partial class ImportForm : DevExpress.XtraEditors.XtraForm
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void importSimpleButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                using (OracleConnection conn = new OracleConnection())
                {
                    conn.ConnectionString = Properties.Settings.Default.archConnectionString;
                    conn.Open();
                    OracleTransaction tran = conn.BeginTransaction();

                    directoriesTableAdapter.Connection = conn;
                    directoriesTableAdapter.Transaction = tran;
                    documentsTableAdapter.Connection = conn;
                    documentsTableAdapter.Transaction = tran;
                    copiesTableAdapter.Connection = conn;
                    copiesTableAdapter.Transaction = tran;
                    filesTableAdapter.Connection = conn;
                    filesTableAdapter.Transaction = tran;
                    try
                    {
                        directoriesTableAdapter.Fill(fullDataSet.DIRECTORIES);
                        documentsTableAdapter.Fill(fullDataSet.DOCUMENTS);
                        copiesTableAdapter.Fill(fullDataSet.COPIES);

                        processDirectory(folderBrowserDialog.SelectedPath, null);

                        directoriesTableAdapter.Update(fullDataSet.DIRECTORIES);
                        documentsTableAdapter.Update(fullDataSet.DOCUMENTS);
                        copiesTableAdapter.Update(fullDataSet.COPIES);
                        filesTableAdapter.Update(fullDataSet.FILES);

                        tran.Commit();

                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        Close();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void processDirectory(string path, decimal? parentId)
        {
            foreach (string dir in Directory.GetDirectories(path))
            {
                if (Directory.GetFiles(dir).Length > 0 && parentId != null)
                {
                    decimal docId = createDocument(new DirectoryInfo(dir).Name, parentId ?? 0);
                    decimal copyId = createCopy("qoşma", docId);
                    foreach (String file in Directory.GetFiles(dir))
                    {
                        infoLabelControl.Text = file;
                        Application.DoEvents();
                        decimal fileId = createFile(file, copyId);
                        filesTableAdapter.Update(fullDataSet.FILES);
                        fullDataSet.FILES.Clear();
                    }


                }
                else
                {
                    decimal dirId = createDirectory(new DirectoryInfo(dir).Name, parentId);
                    processDirectory(dir, dirId);
                }
            }
        }

        private decimal createDirectory(string name, decimal? parentId)
        {
            FullDataSet.DIRECTORIESRow[] rows = (FullDataSet.DIRECTORIESRow[])fullDataSet.DIRECTORIES.Select("DOCUMENT_NUMBER ='" + name.Replace("'","\'")+ "' and " + (parentId == null ? "PARENT_ID is null" : "PARENT_ID=" + parentId.ToString()));
            decimal id;
            if (rows.Length == 0)
            {
                DataRow newRow = ((DataRowView)directoriesBindingSource.AddNew()).Row;
                id = DataHelper.GET_DOCUMENTS_ID();
                newRow["ID"] = id;
                newRow["FULL_ACCESS"] = 1;
                newRow["IS_DIRECTORY"] = 1;
                newRow["PARENT_ID"] = parentId == null ? (object)DBNull.Value : (object)parentId;
                newRow["DOCUMENT_NUMBER"] = name;
                directoriesBindingSource.EndEdit();
                directoriesTableAdapter.Update(fullDataSet.DIRECTORIES);
            }
            else
            {
                id = rows[0].ID;
            }
            return id;
        }

        private decimal createDocument(string name, decimal parentId)
        {
            FullDataSet.DOCUMENTSRow[] rows = (FullDataSet.DOCUMENTSRow[])fullDataSet.DOCUMENTS.Select("DOCUMENT_NUMBER='" + name.Replace("'", "\'") + "' and PARENT_ID=" + parentId.ToString());
            decimal id;
            if (rows.Length == 0)
            {
                DataRow newRow = ((DataRowView)documentsBindingSource.AddNew()).Row;
                id = DataHelper.GET_DOCUMENTS_ID();
                newRow["ID"] = id;
                newRow["FULL_ACCESS"] = 1;
                newRow["PARENT_ID"] = parentId;
                newRow["DOCUMENT_NUMBER"] = name;
                newRow["DOCUMENT_DATE"] = DateTime.Now;
                newRow["CLIENT_ID"] = 0;
                newRow["DOCUMENT_TYPE_ID"] = 2;
                documentsBindingSource.EndEdit();
                documentsTableAdapter.Update(fullDataSet.DOCUMENTS);
            }
            else
            {
                id = rows[0].ID;
            }
            return id;
        }

        private decimal createCopy(string name, decimal parentId)
        {
            DataRow newRow = ((DataRowView)copiesBindingSource.AddNew()).Row;
            decimal id = DataHelper.GET_COPIES_ID();
            newRow["ID"] = id;
            newRow["FULL_ACCESS"] = 1;
            newRow["DOCUMENT_ID"] = parentId;
            newRow["NAME"] = name;
            newRow["PAGES_COUNT"] = 1;
            newRow["COPY_TYPE_ID"] = 0;
            copiesBindingSource.EndEdit();
            copiesTableAdapter.Update(fullDataSet.COPIES);
            return id;
        }

        private decimal createFile(string fileName, decimal parentId)
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
            decimal id = DataHelper.GET_FILES_ID();
            newRow["ID"] = id;
            newRow["COPY_ID"] = parentId;
            newRow["FILE_BODY"] = file;
            newRow["FILE_SIZE"] = file.LongLength;
            newRow["FILE_NAME"] = Path.GetFileNameWithoutExtension(fileName);
            newRow["FILE_EXTENTION"] = Path.GetExtension(fileName);
            filesBindingSource.EndEdit();
            return id;
        }
    }
}