using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniArchive.attributes
{
    public partial class AttributesManager : UniArchive.MasterDetailManager
    {
        public AttributesManager()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.fullDataSet.ATTRIBUTES.ATTRIBUTESRowChanged -= FullDataSet_AttributesRowChanged;
            this.attributesTableAdapter.Fill(this.fullDataSet.ATTRIBUTES);
            this.referenceTypesTableAdapter.Fill(this.fullDataSet.REFERENCE_TYPES);
            this.fullDataSet.ATTRIBUTES.ATTRIBUTESRowChanged += FullDataSet_AttributesRowChanged;
        }

        void FullDataSet_AttributesRowChanged(object sender, FullDataSet.ATTRIBUTESRowChangeEvent e)
        {
            this.attributesTableAdapter.Update(this.fullDataSet.ATTRIBUTES);
        }

        private void masterGridView_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e)
        {
            masterGridView.GetDataRow(e.RowHandle)["ID"] = DataHelper.GET_ATTRIBUTES_ID();
        }
    }
}
