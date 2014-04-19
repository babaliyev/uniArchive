using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniArchive.addressDictionary
{
    public partial class AddressDictionaryManager : DevExpress.XtraEditors.XtraUserControl
    {
        public AddressDictionaryManager()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.fullDataSet.ADDRESS_DICTIONARY.ADDRESS_DICTIONARYRowChanged -= FullDataSet_AddressDictionaryRowChanged;
            this.fullDataSet.ADDRESS_DICTIONARY.ADDRESS_DICTIONARYRowDeleted -= FullDataSet_AddressDictionaryRowChanged;
            this.addressDictionaryTableAdapter.Fill(this.fullDataSet.ADDRESS_DICTIONARY);
            this.fullDataSet.ADDRESS_DICTIONARY.ADDRESS_DICTIONARYRowChanged += FullDataSet_AddressDictionaryRowChanged;
            this.fullDataSet.ADDRESS_DICTIONARY.ADDRESS_DICTIONARYRowDeleted += FullDataSet_AddressDictionaryRowChanged;
        }

        void FullDataSet_AddressDictionaryRowChanged(object sender, FullDataSet.ADDRESS_DICTIONARYRowChangeEvent e)
        {
            this.addressDictionaryTableAdapter.Update(this.fullDataSet.ADDRESS_DICTIONARY);
        }

        private void treeList1_ValidateNode(object sender, DevExpress.XtraTreeList.ValidateNodeEventArgs e)
        {
            if (e.Node["ID"] == DBNull.Value)
            {
                e.Node["ID"] = DataHelper.GET_ADDRESS_DICTIONARY_ID();
            }
        }


    }
}
