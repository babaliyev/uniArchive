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
            Events();
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
        BindingSource attributesValueSource = new BindingSource();

        #endregion

        public virtual bool ReadOnly
        {

            get
            {
                return this.termValueGridView.OptionsBehavior.ReadOnly;
            }

            set
            {
                this.termValueGridView.OptionsBehavior.ReadOnly = value;
            }

        }

        public virtual bool Editable
        {
            get
            {
                return this.termValueGridView.OptionsBehavior.Editable;
            }

            set
            {
                this.termValueGridView.OptionsBehavior.Editable = value;
            }

        }

        public void save(decimal docId)
        {
            attrDAO.saveAttributes(attributeValueList, docId, null);
        }

         public void save(decimal docId, decimal copyId)
        {
            attrDAO.saveAttributes(attributeValueList, docId, copyId);
        }

        public void loadForDoc(decimal docId, decimal docTypeId)
        {
            attributeValueList = attrDAO.getDocumentAttributes(docId, docTypeId);
            RefreshDataSource();
        }

        public void loadForCopy(decimal docId, decimal copyId, decimal copyTypeId)
        {
            attributeValueList = attrDAO.getCopyAttributes(docId, copyId, copyTypeId);
            RefreshDataSource();
        }


        private void Events()
        {
            termValueGridView.CustomRowCellEditForEditing += delegate(object sender, CustomRowCellEditEventArgs e)
            {
                if (e.Column.FieldName == "Value")
                {
                    AttributeType attrType = (AttributeType)termValueGridView.GetRowCellValue(e.RowHandle, "Attribute.ValueType");
                    decimal referenceType = (decimal)termValueGridView.GetRowCellValue(e.RowHandle, "Attribute.ReferenceType");

                    switch (attrType)
                    {
                        case AttributeType.String:
                            e.RepositoryItem = textRitem;
                            break;
                        case AttributeType.Decimal:
                            e.RepositoryItem = calcRitem;
                            break;
                        case AttributeType.Integer:
                            e.RepositoryItem = spinRitem;
                            break;
                        case AttributeType.DateTime:
                            e.RepositoryItem = dateRitem;
                            break;
                        case AttributeType.Boolean:
                            checkRitem.ValueChecked = 1;
                            checkRitem.ValueUnchecked = 0;
                            e.RepositoryItem = checkRitem;
                            break;
                        case AttributeType.Reference:
                            lookUpRitem.BeginInit();
                            lookUpRitem.DataSource = attrDAO.getReferenceTable(referenceType);
                            lookUpRitem.EndInit();
                            lookUpRitem.ValueMember = "ID";
                            lookUpRitem.DisplayMember = "NAME";
                            e.RepositoryItem = lookUpRitem;
                            break;
                    }                   
                }
            };
        }

        private void RefreshDataSource()
        {
            termValueGridControl.BeginInit();
            attributesValueSource.DataSource = attributeValueList;
            termValueGridControl.DataSource = null;
            termValueGridControl.DataSource = attributesValueSource;
            termValueGridControl.EndInit();

            termValueGridView.ExpandAllGroups();
        }
    }  
}
