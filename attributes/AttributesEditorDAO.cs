using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace UniArchive.attributes
{
    public class AttributesEditorDAO
    {
        private string connectionString;
        private DataSet referencesDataSet = new DataSet();

        private OracleCommand delAttributesByDocCmd = new OracleCommand();
        private OracleCommand delAttributesByCopyCmd = new OracleCommand();
        private OracleCommand insertAttributeCmd = new OracleCommand();

        public AttributesEditorDAO(string connectionString)
        {
            this.connectionString = connectionString;
            initCommands();
        }

        private void initCommands()
        {
            delAttributesByDocCmd.CommandText = "DELETE FROM ARCH.ATTRIBUTES_VALUES WHERE DOCUMENT_ID = :DOCUMENT_ID and COPY_ID is null";
            delAttributesByDocCmd.Parameters.Add(":DOCUMENT_ID", OracleDbType.Decimal);

            delAttributesByCopyCmd.CommandText = "DELETE FROM ARCH.ATTRIBUTES_VALUES WHERE COPY_ID = :COPY_ID";
            delAttributesByCopyCmd.Parameters.Add(":COPY_ID", OracleDbType.Decimal);

            insertAttributeCmd.CommandText = "DML_ATTRIBUTES_VALUES.INS_ATTRIBUTES_VALUES";
            insertAttributeCmd.CommandType = CommandType.StoredProcedure;
            insertAttributeCmd.Parameters.Add(":DOCUMENT_ID", OracleDbType.Decimal);
            insertAttributeCmd.Parameters.Add(":COPY_ID", OracleDbType.Decimal);
            insertAttributeCmd.Parameters.Add(":STRING_VALUE", OracleDbType.NVarchar2,2000);
            insertAttributeCmd.Parameters.Add(":DECIMAL_VALUE", OracleDbType.Decimal);
            insertAttributeCmd.Parameters.Add(":INT_VALUE", OracleDbType.Int16);
            insertAttributeCmd.Parameters.Add(":DATE_VALUE", OracleDbType.Date);
            insertAttributeCmd.Parameters.Add(":BOOLEAN_VALUE", OracleDbType.Decimal);
            insertAttributeCmd.Parameters.Add(":REFERENCE_VALUE", OracleDbType.Decimal);
            insertAttributeCmd.Parameters.Add(":ATTRIBUTE_ID", OracleDbType.Decimal);

        }

        private void setAttributeParameters(AttributeValue value)
        {
            insertAttributeCmd.Parameters[":DOCUMENT_ID"].Value = value.DocumentID;
            insertAttributeCmd.Parameters[":COPY_ID"].Value = value.CopyID==null?DBNull.Value:(object)value.CopyID;

            insertAttributeCmd.Parameters[":STRING_VALUE"].Value = DBNull.Value;
            insertAttributeCmd.Parameters[":DECIMAL_VALUE"].Value = DBNull.Value;
            insertAttributeCmd.Parameters[":INT_VALUE"].Value = DBNull.Value;
            insertAttributeCmd.Parameters[":DATE_VALUE"].Value = DBNull.Value;
            insertAttributeCmd.Parameters[":BOOLEAN_VALUE"].Value = DBNull.Value;
            insertAttributeCmd.Parameters[":REFERENCE_VALUE"].Value = DBNull.Value;
            insertAttributeCmd.Parameters[":ATTRIBUTE_ID"].Value = value.Attibute.ID;

            switch (value.Attibute.ValueType)
            {
                case AttributeType.String:
                    insertAttributeCmd.Parameters[":STRING_VALUE"].Value = value.Value;
                    break;
                case AttributeType.Decimal:
                    insertAttributeCmd.Parameters[":DECIMAL_VALUE"].Value = value.Value;
                    break;
                case AttributeType.Integer:
                    insertAttributeCmd.Parameters[":INT_VALUE"].Value = value.Value;
                    break;
                case AttributeType.DateTime:
                    insertAttributeCmd.Parameters[":DATE_VALUE"].Value = value.Value;
                    break;
                case AttributeType.Boolean:
                    insertAttributeCmd.Parameters[":BOOLEAN_VALUE"].Value = value.Value;
                    break;
                case AttributeType.Reference:
                    insertAttributeCmd.Parameters[":REFERENCE_VALUE"].Value = value.Value;
                    break;
            }
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
            fillDocSavedAttributes(ref values, docId);
            if (values.Count == 0)
                fillDocTypeAttributes(ref values, docTypeID);
            return values;
        }

        public List<AttributeValue> getCopyAttributes(decimal copyId, decimal copyTypeID)
        {
            List<AttributeValue> values = new List<AttributeValue>();
            fillCopySavedAttributes(ref values, copyId);
            if (values.Count == 0)
                fillCopyTypeAttributes(ref values, copyTypeID);
            return values;
        }

        private void fillDocSavedAttributes(ref List<AttributeValue> values, decimal docId)
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
                    if (attr.ValueType == AttributeType.Reference)
                        attr.ReferenceType = reader.GetDecimal(14);

                    value.Attibute = attr;
                    value.ID = reader.GetDecimal(0);
                    value.DocumentID = reader.GetDecimal(2);
                    if (reader["COPY_ID"] != DBNull.Value)
                        value.CopyID = reader.GetDecimal(3);

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

        private void fillCopySavedAttributes(ref List<AttributeValue> values, decimal copyId)
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

        public void saveAttributes(List<AttributeValue> values, decimal docId, decimal? copyId)
        {
            using (OracleConnection conn = new OracleConnection(connectionString))
            {
                conn.Open();
                OracleTransaction tran = conn.BeginTransaction();

                try
                {
                    if (copyId != null)
                    {
                        delAttributesByCopyCmd.Parameters[":COPY_ID"].Value = copyId;
                        delAttributesByCopyCmd.ExecuteNonQuery();
                    }
                    else
                    {
                        delAttributesByDocCmd.Parameters[":DOCUMENT_ID"].Value = docId;
                        delAttributesByDocCmd.ExecuteNonQuery();
                    }

                    foreach (AttributeValue value in values)
                    {
                        setAttributeParameters(value);
                        insertAttributeCmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    throw ex;
                }
                finally
                {
                    conn.Close();
                }

            }

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
