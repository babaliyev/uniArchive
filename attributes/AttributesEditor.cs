using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Repository;
using System.Data.SqlClient;
using Oracle.DataAccess.Client;

namespace UniArchive.attributes
{
    public partial class AttributesEditor : DevExpress.XtraEditors.XtraUserControl
    {
        public AttributesEditor()
        {
            InitializeComponent();
            attrDAO = new AttributesEditorDAO(Properties.Settings.Default.archConnectionString);
        }

        #region variables

        RepositoryItemMemoExEdit textRitem = new RepositoryItemMemoExEdit();
        RepositoryItemDateEdit dateRitem = new RepositoryItemDateEdit();
        RepositoryItemCheckEdit checkRitem = new RepositoryItemCheckEdit();
        RepositoryItemCalcEdit calcRitem = new RepositoryItemCalcEdit();
        RepositoryItemSpinEdit spinRitem = new RepositoryItemSpinEdit();
        RepositoryItemSearchLookUpEdit lookUpRitem = new RepositoryItemSearchLookUpEdit();

        AttributesEditorDAO attrDAO;
        List<AttributeValue> attributeValueList = null;

        #endregion
    }  
}
