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

            this.fullDataSet.DOCUMENT_TYPE_ATTRIBUTES.DOCUMENT_TYPE_ATTRIBUTESRowChanged -= FullDataSet_DocTypeAttributesRowChanged;
            this.fullDataSet.DOCUMENT_TYPE_ATTRIBUTES.DOCUMENT_TYPE_ATTRIBUTESRowDeleted -= FullDataSet_DocTypeAttributesRowChanged;

            this.documentTypesTableAdapter.Fill(this.fullDataSet.DOCUMENT_TYPES);
            this.attributesTableAdapter.Fill(this.fullDataSet.ATTRIBUTES);
            this.docTypeAttributesTableAdapter.Fill(this.fullDataSet.DOCUMENT_TYPE_ATTRIBUTES);

            this.fullDataSet.DOCUMENT_TYPE_ATTRIBUTES.DOCUMENT_TYPE_ATTRIBUTESRowChanged += FullDataSet_DocTypeAttributesRowChanged;
            this.fullDataSet.DOCUMENT_TYPE_ATTRIBUTES.DOCUMENT_TYPE_ATTRIBUTESRowDeleted += FullDataSet_DocTypeAttributesRowChanged;

            this.fullDataSet.DOCUMENT_TYPES.DOCUMENT_TYPESRowChanged += FullDataSet_DocumentTypesRowChanged;
            this.fullDataSet.DOCUMENT_TYPES.DOCUMENT_TYPESRowDeleted += FullDataSet_DocumentTypesRowChanged;
        }

        void FullDataSet_DocumentTypesRowChanged(object sender, FullDataSet.DOCUMENT_TYPESRowChangeEvent e)
        {
            this.documentTypesTableAdapter.Update(this.fullDataSet.DOCUMENT_TYPES);
        }

        void FullDataSet_DocTypeAttributesRowChanged(object sender, FullDataSet.DOCUMENT_TYPE_ATTRIBUTESRowChangeEvent e)
        {
            this.docTypeAttributesTableAdapter.Update(this.fullDataSet.DOCUMENT_TYPE_ATTRIBUTES);
        }

        private void masterGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            masterGridView.GetDataRow(e.RowHandle)["ID"] = DataHelper.GET_DOCUMENT_TYPES_ID();
        }

        private void attributesGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            attributesGridView.GetDataRow(e.RowHandle)["ID"] = DataHelper.GET_DOCUMENT_TYPE_ATTRIBUTES_ID();
        }
    }
}
