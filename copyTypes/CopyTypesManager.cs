using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniArchive.copyTypes
{
    public partial class CopyTypesManager : UniArchive.MasterDetailManager
    {
        public CopyTypesManager()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.fullDataSet.COPY_TYPES.COPY_TYPESRowChanged -= FullDataSet_CopyTypesRowChanged;
            this.fullDataSet.COPY_TYPES.COPY_TYPESRowDeleted -= FullDataSet_CopyTypesRowChanged;
            this.copyTypesTableAdapter.Fill(this.fullDataSet.COPY_TYPES);
            this.fullDataSet.COPY_TYPES.COPY_TYPESRowChanged += FullDataSet_CopyTypesRowChanged;
            this.fullDataSet.COPY_TYPES.COPY_TYPESRowDeleted += FullDataSet_CopyTypesRowChanged;
        }

        void FullDataSet_CopyTypesRowChanged(object sender, FullDataSet.COPY_TYPESRowChangeEvent e)
        {
            this.copyTypesTableAdapter.Update(this.fullDataSet.COPY_TYPES);
        }

        private void masterGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            masterGridView.GetDataRow(e.RowHandle)["ID"] = DataHelper.GET_COPY_TYPES_ID();
        }
    }
}
