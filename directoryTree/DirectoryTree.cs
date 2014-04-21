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
        public event EventHandler OnDocumentClick;
        public event EventHandler OnCopyClick;

        public DirectoryTree()
        {
            InitializeComponent();
            load();
        }

        public void load()
        {
            this.directoriesTableAdapter.Fill(this.fullDataSet.DIRECTORIES);
            this.documentsTableAdapter.Fill(this.fullDataSet.DOCUMENTS);
            this.copiesTableAdapter.Fill(this.fullDataSet.COPIES);

            directoryTreeView.Nodes.Clear();

            drawDirectoryTree(directoryTreeView.Nodes, (FullDataSet.DIRECTORIESRow[])this.fullDataSet.DIRECTORIES.Select("PARENT_ID is null"));
        }

        private void drawDirectoryTree(TreeNodeCollection tns, FullDataSet.DIRECTORIESRow[] rows)
        {
            foreach (FullDataSet.DIRECTORIESRow row in rows)
            {
                TreeNode directoryNode = tns.Add(row.DOCUMENT_NUMBER);
                directoryNode.Tag = row.ID;
                drawDirectoryTree(directoryNode.Nodes, (FullDataSet.DIRECTORIESRow[])this.fullDataSet.DIRECTORIES.Select("PARENT_ID=" + row.ID.ToString()));
                drawDocsForDirectory(directoryNode, row);
                if (directoryNode.Level == 0) directoryNode.Expand();
            }
        }

        private void drawDocsForDirectory(TreeNode tn, FullDataSet.DIRECTORIESRow directoryRow)
        {
            int _image = 0;

            foreach (FullDataSet.DOCUMENTSRow docRow in directoryRow.GetDOCUMENTSRows())
            {
                drawDoc(tn, docRow);
                _image = 1;
            }
            tn.ImageIndex = _image;
            tn.SelectedImageIndex = _image;
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

        private void deleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TreeNode selectedNode = directoryTreeView.SelectedNode;
            if (selectedNode != null && (selectedNode.ImageIndex == 0 || selectedNode.ImageIndex == 1))
            {
                DialogResult res = MessageBox.Show("Seçdiyiniz qovluq silinsin ? ", "Əminsiniz?", MessageBoxButtons.YesNo);

                if (res == DialogResult.Yes)
                {
                    fullDataSet.DIRECTORIES.FindByID(Convert.ToInt32(selectedNode.Tag)).Delete();
                    this.directoriesTableAdapter.Update(fullDataSet.DIRECTORIES);
                    load();
                }
            }
            else
                MessageBox.Show("Silmək istədiyiniz qovluğu əvvəlcədən seçin! ", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void editBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            TreeNode selectedNode = directoryTreeView.SelectedNode;
            if (selectedNode != null && (selectedNode.ImageIndex == 0 || selectedNode.ImageIndex == 1))
            {
                
                    DirectoryForm directoryForm = new DirectoryForm(Convert.ToInt32(selectedNode.Tag));
                    if (directoryForm.ShowDialog() == DialogResult.OK)
                    {
                        load();
                    }
            }
            else
                MessageBox.Show("Redakte etmek istədiyiniz qovluğu əvvəlcədən seçin! ", "Səhv", MessageBoxButtons.OK, MessageBoxIcon.Warning);

          
        }

        private void addBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            decimal? parentId = null;

            TreeNode selectedNode = directoryTreeView.SelectedNode;
            if (selectedNode != null && (selectedNode.ImageIndex == 0 || selectedNode.ImageIndex == 1))
            {
                parentId = Convert.ToInt32(selectedNode.Tag);
            }

            DirectoryForm directoryForm = new DirectoryForm(parentId);
            if (directoryForm.ShowDialog() == DialogResult.OK)
            {
                load();
            }
        }

        

        private void dictionaryTreeView_AfterSelect(object sender, TreeViewEventArgs e)
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
