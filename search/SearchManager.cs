using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniArchive.search
{
    public partial class SearchManager : DevExpress.XtraEditors.XtraUserControl
    {
        public event EventHandler OnDocumentClick;
        public event EventHandler OnCopyClick;

        public SearchManager()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            this.clientsTableAdapter.Fill(this.fullDataSet.CLIENTS);
        }
        
        private void searchSimpleButton_Click(object sender, EventArgs e)
        {
            this.searchTableAdapter.Fill(this.fullDataSet.SEARCH,
                "%"+searchTextTextEdit.Text+"%",
                (int?)clientSearchLookUpEdit.EditValue,
                (DateTime?)fromDateEdit.EditValue,
                (DateTime?)toDateEdit.EditValue,
                decimal.Parse(searchAreaRadioGroup.EditValue.ToString()));
        }

        private void searchGridControl_Click(object sender, EventArgs e)
        {
            if (searchGridView.FocusedRowHandle > -1)
            {
                FullDataSet.SEARCHRow row = (FullDataSet.SEARCHRow)searchGridView.GetFocusedDataRow();
                if (row.IsCOPY_IDNull())
                {
                    if (OnDocumentClick != null)
                        OnDocumentClick(row.DOCUMENT_ID, null);
                }
                else
                {
                    if (OnCopyClick != null)
                        OnCopyClick(row.DOCUMENT_ID, null);
                }
            }
            
        }
    }
}
