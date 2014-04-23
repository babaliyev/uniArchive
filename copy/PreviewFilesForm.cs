using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Drawing.Printing;

namespace UniArchive.copy
{
    public partial class PreviewFilesForm : DevExpress.XtraEditors.XtraForm
    {
        public PreviewFilesForm()
        {
            InitializeComponent();
        }

        public void setDataSet(FullDataSet fds)
        {
            fullDataSet = fds;
            filesBindingSource.ResetBindings(true);
        }

        public void loadByDocument(decimal docId)
        {
            filesTableAdapter.FillByDocId(fullDataSet.FILES, docId);
        }

        public void loadByCopy(decimal copyId)
        {
            filesTableAdapter.FillByCopyId(fullDataSet.FILES, copyId);
        }

        public void setCurrentFile(decimal fileId)
        {
            filesBindingSource.Position = filesBindingSource.Find("ID", fileId);
        }


        private void prevBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            filesBindingSource.MovePrevious();
        }

        private void firstBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            filesBindingSource.MoveFirst();
        }

        private void lastBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            filesBindingSource.MoveLast();
        }

        private void nextBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            filesBindingSource.MoveNext();
        }

        private void filesBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            copyNameBarStaticItem.Caption = filesBindingSource.Position.ToString() +" (" + fullDataSet.FILES.Rows.Count + ")";
            if (filesBindingSource.Current != null)
            {
                FullDataSet.FILESRow row = (FullDataSet.FILESRow)((DataRowView)filesBindingSource.Current).Row;
                copyNameBarStaticItem.Caption = DataHelper.getCopyNameWithDocNum(row.COPY_ID);
            }
        }

        private void printBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            printAll = false;
            print();
        }

        private void print()
        {
            
            PrintDocument pd = new PrintDocument();

            pd.DefaultPageSettings.Margins = new Margins(0, 0, 0, 0);
            pd.OriginAtMargins = false;

            pd.PrintPage += new PrintPageEventHandler(PrintPage);

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pd.Print();
            }            

        }

        private bool printAll;

        private void PrintPage(object o, PrintPageEventArgs e)
        {            
            e.Graphics.DrawImage(pictureEdit1.Image, 0, 0);

            if (printAll)
            {
                if (filesBindingSource.Position < filesBindingSource.Count - 1)
                {
                    e.HasMorePages = true;
                    filesBindingSource.Position++;
                }

            }
        }

        private void printAllBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            printAll = true;
            filesBindingSource.Position = 0;
            print();
        }

    }
}