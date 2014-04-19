using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniArchive.docTypes
{
    public partial class DocTypesManager : UniArchive.MasterDetailManager
    {
        public DocTypesManager()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.fullDataSet.DOCUMENT_TYPES.DOCUMENT_TYPESRowChanged -= FullDataSet_DocumentTypesRowChanged;
            this.fullDataSet.DOCUMENT_TYPES.DOCUMENT_TYPESRowDeleted -= FullDataSet_DocumentTypesRowChanged;
            this.documentTypesTableAdapter.Fill(this.fullDataSet.DOCUMENT_TYPES);
            this.fullDataSet.DOCUMENT_TYPES.DOCUMENT_TYPESRowChanged += FullDataSet_DocumentTypesRowChanged;
            this.fullDataSet.DOCUMENT_TYPES.DOCUMENT_TYPESRowDeleted += FullDataSet_DocumentTypesRowChanged;
        }

        void FullDataSet_DocumentTypesRowChanged(object sender, FullDataSet.DOCUMENT_TYPESRowChangeEvent e)
        {
            this.documentTypesTableAdapter.Update(this.fullDataSet.DOCUMENT_TYPES);
        }

        private void masterGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            masterGridView.GetDataRow(e.RowHandle)["ID"] = DataHelper.GET_DOCUMENT_TYPES_ID();
        }
    }
}
