using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniArchive.references
{
    public partial class ReferencesManager : UniArchive.MasterDetailManager
    {
        public ReferencesManager()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.fullDataSet.REFERENCE_TYPES.REFERENCE_TYPESRowChanged -= FullDataSet_ReferenceTypeRowChanged;
            this.fullDataSet.REFERENCE_TYPES.REFERENCE_TYPESRowDeleted -= FullDataSet_ReferenceTypeRowChanged;
            this.fullDataSet.REFERENCES.REFERENCESRowChanged -= FullDataSet_ReferenceRowChanged;
            this.fullDataSet.REFERENCES.REFERENCESRowDeleted -= FullDataSet_ReferenceRowChanged;
            this.referenceTypesTableAdapter.Fill(this.fullDataSet.REFERENCE_TYPES);
            this.referencesTableAdapter.Fill(this.fullDataSet.REFERENCES);
            this.fullDataSet.REFERENCE_TYPES.REFERENCE_TYPESRowChanged += FullDataSet_ReferenceTypeRowChanged;
            this.fullDataSet.REFERENCE_TYPES.REFERENCE_TYPESRowDeleted += FullDataSet_ReferenceTypeRowChanged;
            this.fullDataSet.REFERENCES.REFERENCESRowChanged += FullDataSet_ReferenceRowChanged;
            this.fullDataSet.REFERENCES.REFERENCESRowDeleted += FullDataSet_ReferenceRowChanged;

        }

        private void masterGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            masterGridView.GetDataRow(e.RowHandle)["ID"] = DataHelper.GET_REFERENCE_TYPES_ID();
        }

        private void referencesGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            referencesGridView.GetDataRow(e.RowHandle)["ID"] = DataHelper.GET_REFERENCES_ID();
        }

        void FullDataSet_ReferenceTypeRowChanged(object sender, FullDataSet.REFERENCE_TYPESRowChangeEvent e)
        {
            this.referenceTypesTableAdapter.Update(this.fullDataSet.REFERENCE_TYPES);
        }

        void FullDataSet_ReferenceRowChanged(object sender, FullDataSet.REFERENCESRowChangeEvent e)
        {
            this.referencesTableAdapter.Update(this.fullDataSet.REFERENCES);
        }
    }
}
