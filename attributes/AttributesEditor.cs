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
        }

        #region variables


        RepositoryItemMemoExEdit textRitem = new RepositoryItemMemoExEdit();
        RepositoryItemDateEdit dateRitem = new RepositoryItemDateEdit();
        RepositoryItemCheckEdit checkRitem = new RepositoryItemCheckEdit();
        RepositoryItemCalcEdit calcRitem = new RepositoryItemCalcEdit();
        RepositoryItemSpinEdit spinRitem = new RepositoryItemSpinEdit();
        RepositoryItemSearchLookUpEdit lookUpRitem = new RepositoryItemSearchLookUpEdit();

        List<AttributeValue> attributeValueList = null;

        #endregion
    }
      

    public enum AttributeType
    {
        String, 
        DateTime, 
        Boolean, 
        Decimal, 
        Integer, 
        Reference
    }


    public class Attribute
    {
        private decimal referenceType;
        private AttributeType valueType;

        public decimal ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal ReferenceType
        {
            get { return referenceType; }
            set
            {
                this.referenceType = value;
            }
        }

        public AttributeType ValueType
        {
            get { return this.valueType; }
            set
            {
                this.valueType = value;
            }
        }

        public string ValueTypeName
        {
            get { return this.valueType.ToString(); }
            set
            {
                this.valueType = GetAttributeType(value);
            }
        }

        public static AttributeType GetAttributeType(string valueType)
        {
            if (valueType.Equals(AttributeType.String.ToString().ToLower()))
                return AttributeType.String;
            else
                if (valueType.Equals(AttributeType.DateTime.ToString().ToLower()))
                    return AttributeType.DateTime;
                else
                    if (valueType.Equals(AttributeType.Decimal.ToString().ToLower()))
                        return AttributeType.Decimal;
                    else
                        if (valueType.Equals(AttributeType.Integer.ToString().ToLower()))
                            return AttributeType.Integer;
                        else
                            if (valueType.Equals(AttributeType.Boolean.ToString().ToLower()))
                                return AttributeType.Boolean;
                            else
                                return AttributeType.Reference;

        }

        public override string ToString()
        {
            return this.Name;
        }
    }

    public class AttributeValue
    {
        public decimal ID { get; set; }
        public decimal DocumentID { get; set; }
        public decimal? CopyID { get; set; }
        public Attribute Attibute { get; set; }
        public object Value { get; set; }

        public bool isNew;

        public override bool Equals(object obj)
        {
            if (obj != null && obj is AttributeValue)
                return this.ID.Equals((obj as AttributeValue).ID);
            else
                return false;
        }
    }

    public class AttributesEditorDAO
    {
        private string connectionString;
        private DataSet referencesDataSet = new DataSet();

        public AttributesEditorDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public DataTable getReferenceTable(decimal referenceId)
        {
            if (referencesDataSet.Tables[referenceId.ToString()] == null)
            {
                fillReferenceTable(referenceId);
            }

            return referencesDataSet.Tables[referenceId.ToString()];
        }

        public List<AttributeValue> getDocumentAttributes(decimal docId, decimal docTypeID)
        {
            List<AttributeValue> values = new List<AttributeValue>();
            fillDocSavedAttributes(ref values, docId, docTypeID);
            if(values.Count==0)
                fillDocTypeAttributes(ref values, docTypeID);
            return values;
        }

        public List<AttributeValue> getCopyAttributes(decimal copyId, decimal copyTypeID)
        {
            List<AttributeValue> values = new List<AttributeValue>();
            fillCopySavedAttributes(ref values, copyId, copyTypeID);
            if(values.Count == 0)
                fillCopyTypeAttributes(ref values, copyTypeID);
            return values;
        }
        
        private void fillDocSavedAttributes(ref List<AttributeValue> values, decimal docId, decimal docTypeID)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(@"SELECT 
                                                            attv.ID as V_ID, att.ID as A_ID, DOCUMENT_ID,
                                                            COPY_ID, STRING_VALUE, DECIMAL_VALUE, INT_VALUE, 
                                                           DATE_VALUE, BOOLEAN_VALUE, REFERENCE_VALUE, 
                                                           ATTRIBUTE_ID, NAME, DESCRIPTION, VALUETYPE
                                                           REFERENCE_TYPE_ID
                                                        FROM ARCH.ATTRIBUTES_VALUES attv inner join ARCH.ATTRIBUTES att 
                                                        on attv.ATTRIBUTE_ID = att.ID
                                                        where DOCUMENT_ID = :DOCUMENT_ID and COPY_ID is null;", conn);
                cmd.Parameters.Add(":DOCUMENT_ID", docId);

                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AttributeValue value = new AttributeValue();

                    Attribute attr = new Attribute();
                    attr.ID = reader.GetDecimal(1);
                    attr.Name = reader.GetString(11);
                    attr.Description = reader.GetString(12);
                    attr.ValueTypeName = reader.GetString(13);
                    if(attr.ValueType == AttributeType.Reference)
                        attr.ReferenceType = reader.GetDecimal(14);

                    value.Attibute = attr;
                    value.ID = reader.GetDecimal(0);
                    value.DocumentID = reader.GetDecimal(2);
                    if (reader["COPY_ID"] != DBNull.Value)
                        value.CopyID = reader.GetDecimal(3);
                    value.isNew = false;

                    switch (attr.ValueType)
                    {
                        case AttributeType.String:
                            value.Value = reader["STRING_VALUE"];
                            break;
                        case AttributeType.Decimal:
                            value.Value = reader["DECIMAL_VALUE"];
                            break;
                        case AttributeType.Integer:
                            value.Value = reader["INT_VALUE"];
                            break;
                        case AttributeType.DateTime:
                            value.Value = reader["DATE_VALUE"];
                            break;
                        case AttributeType.Boolean:
                            value.Value = reader["BOOLEAN_VALUE"];
                            break;
                        case AttributeType.Reference:
                            value.Value = reader["REFERENCE_VALUE"];
                            break;
                    }
                }
                reader.Close();
                conn.Close();
            }
        }

        private void fillCopySavedAttributes(ref List<AttributeValue> values, decimal copyId, decimal copyTypeID)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand(@"SELECT 
                                                            attv.ID as V_ID, att.ID as A_ID, DOCUMENT_ID,
                                                            COPY_ID, STRING_VALUE, DECIMAL_VALUE, INT_VALUE, 
                                                           DATE_VALUE, BOOLEAN_VALUE, REFERENCE_VALUE, 
                                                           ATTRIBUTE_ID, NAME, DESCRIPTION, VALUETYPE
                                                           REFERENCE_TYPE_ID
                                                        FROM ARCH.ATTRIBUTES_VALUES attv inner join ARCH.ATTRIBUTES att 
                                                        on attv.ATTRIBUTE_ID = att.ID
                                                        where COPY_ID = :COPY_ID;", conn);
                cmd.Parameters.Add(":COPY_ID", copyId);

                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    AttributeValue value = new AttributeValue();

                    Attribute attr = new Attribute();
                    attr.ID = reader.GetDecimal(1);
                    attr.Name = reader.GetString(11);
                    attr.Description = reader.GetString(12);
                    attr.ValueTypeName = reader.GetString(13);
                    if (attr.ValueType == AttributeType.Reference)
                        attr.ReferenceType = reader.GetDecimal(14);

                    value.Attibute = attr;
                    value.ID = reader.GetDecimal(0);
                    value.DocumentID = reader.GetDecimal(2);
                    if (reader["COPY_ID"] != DBNull.Value)
                        value.CopyID = reader.GetDecimal(3);
                    value.isNew = false;

                    switch (attr.ValueType)
                    {
                        case AttributeType.String:
                            value.Value = reader["STRING_VALUE"];
                            break;
                        case AttributeType.Decimal:
                            value.Value = reader["DECIMAL_VALUE"];
                            break;
                        case AttributeType.Integer:
                            value.Value = reader["INT_VALUE"];
                            break;
                        case AttributeType.DateTime:
                            value.Value = reader["DATE_VALUE"];
                            break;
                        case AttributeType.Boolean:
                            value.Value = reader["BOOLEAN_VALUE"];
                            break;
                        case AttributeType.Reference:
                            value.Value = reader["REFERENCE_VALUE"];
                            break;
                    }
                }
                reader.Close();
                conn.Close();
            }
        }

        private void fillDocTypeAttributes(ref List<AttributeValue> values, decimal docTypeID)
        {

        }

        private void fillCopyTypeAttributes(ref List<AttributeValue> values, decimal copyTypeID)
        {

        }

        public void saveAttributes(List<AttributeValue> values)
        {
            // udalit vse attributi copi ili documenta

        }


        private void fillReferenceTable(decimal referenceId)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                OracleDataAdapter adapter = new OracleDataAdapter(@"SELECT ID, NAME, DESCRIPTION    
                                                                    FROM ARCH.REFERENCES 
                                                                    where REFENCE_TYPE_ID=:REFENCE_TYPE_ID", conn);
                adapter.SelectCommand.Parameters.Add(":REFENCE_TYPE_ID", referenceId);
                adapter.Fill(referencesDataSet, referenceId.ToString());
                conn.Close();
            }
        }
    }
}
