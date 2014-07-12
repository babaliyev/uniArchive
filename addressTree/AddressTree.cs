using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniArchive.addressTree
{
    public partial class AddressTree : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler OnDocumentClick;
        public event EventHandler OnCopyClick;

        public AddressTree()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            this.fullDataSet.EnforceConstraints = false;
            this.addressDictionaryTableAdapter.Fill(this.fullDataSet.ADDRESS_DICTIONARY);
            this.documentsTableAdapter.Fill(this.fullDataSet.DOCUMENTS);
            this.copiesTableAdapter.Fill(this.fullDataSet.COPIES);
            this.fullDataSet.EnforceConstraints = true;

            addressTreeView.Nodes.Clear();

            drawAddressTree(addressTreeView.Nodes, (FullDataSet.ADDRESS_DICTIONARYRow[])this.fullDataSet.ADDRESS_DICTIONARY.Select("PARENT_ID is null"));

            TreeNode freeNode = addressTreeView.Nodes.Add("Ünvansız");
            freeNode.ImageIndex = 4;
            freeNode.SelectedImageIndex = 4;
            drawNoAddressDocs(freeNode);
        }

        private void drawAddressTree(TreeNodeCollection tns, FullDataSet.ADDRESS_DICTIONARYRow[] rows)
        {
            foreach (FullDataSet.ADDRESS_DICTIONARYRow row in rows)
            {                
                TreeNode addressNode = tns.Add(row.NAME);
                drawAddressTree(addressNode.Nodes, row.GetADDRESS_DICTIONARYRows());
                drawDocsForAddress(addressNode, row);
            }
        }

        private void drawDocsForAddress(TreeNode tn, FullDataSet.ADDRESS_DICTIONARYRow addressRow)
        {
            int _image = 1;

            if (tn.Level == 0)
                _image = 0;

            foreach (FullDataSet.DOCUMENTSRow docRow in addressRow.GetDOCUMENTSRows())
            {
                drawDoc(tn, docRow);
                _image = 5;
            }
            tn.ImageIndex = _image;
            tn.SelectedImageIndex = _image;
        }

        private void drawNoAddressDocs(TreeNode tn)
        {
            foreach (FullDataSet.DOCUMENTSRow docRow in fullDataSet.DOCUMENTS.Select("ADDRESS_ID is null"))
            {
                drawDoc(tn, docRow);
            }
        }

        private void drawDoc(TreeNode tn, FullDataSet.DOCUMENTSRow row)
        {
            TreeNode docNode = tn.Nodes.Add(row.DOCUMENT_NUMBER);
            docNode.Tag = row.ID;
            docNode.ImageIndex = 2;
            docNode.SelectedImageIndex = 2;
            drawCopiesForDoc(docNode, row);
        }

        private void drawCopiesForDoc(TreeNode tn, FullDataSet.DOCUMENTSRow docRow)
        {
            foreach (FullDataSet.COPIESRow copyRow in docRow.GetCOPIESRows())
            {
                drawCopy(tn, copyRow);
            }
        }

        private void drawCopy(TreeNode tn, FullDataSet.COPIESRow row)
        {
            TreeNode copyNode = tn.Nodes.Add(row.NAME);
            copyNode.Tag = row.ID;
            copyNode.ImageIndex = 3;
            copyNode.SelectedImageIndex = 3;
        }

        private void addressTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.ImageIndex)
            {
                case 2:
                    if (OnDocumentClick != null)
                        OnDocumentClick(e.Node.Tag, null);
                    break;
                case 3:
                    if (OnCopyClick != null)
                        OnCopyClick(e.Node.Tag, null);
                    break;
            }
        }

    }
}
