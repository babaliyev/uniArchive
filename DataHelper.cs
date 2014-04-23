using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniArchive
{
    static class DataHelper
    {
        #region sequences

        private static string _SEQ_ADDRESS_DICTIONARY = "ADDRESS_DICTIONARY_SEQ";
        private static string _SEQ_ATTRIBUTES = "ATTRIBUTES_SEQ";
        private static string _SEQ_ATTRIBUTES_VALUES = "ATTRIBUTES_VALUES_SEQ";
        private static string _SEQ_CLIENTS = "CLIENTS_SEQ";
        private static string _SEQ_COPIES = "COPIES_SEQ";
        private static string _SEQ_COPY_TYPE_ATTRIBUTES = "COPY_TYPE_ATTRIBUTES_SEQ";
        private static string _SEQ_COPY_TYPES = "COPY_TYPES_SEQ";
        private static string _SEQ_DOCUMENT_HISTORY = "DOCUMENT_HISTORY_SEQ";
        private static string _SEQ_DOCUMENT_TYPE_ATTRIBUTES = "DOCUMENT_TYPE_ATTRIBUTES_SEQ";
        private static string _SEQ_DOCUMENT_TYPES = "DOCUMENT_TYPES_SEQ";
        private static string _SEQ_DOCUMENTS = "DOCUMENTS_SEQ";
        private static string _SEQ_MOVEMENT = "MOVEMENT_SEQ";
        private static string _SEQ_REFERENCE_TYPES = "REFERENCE_TYPES_SEQ";
        private static string _SEQ_REFERENCES = "REFERENCES_SEQ";
        private static string _SEQ_ROLE_CLIENT_ACCESS = "ROLE_CLIENT_ACCESS_SEQ";
        private static string _SEQ_ROLE_DOC_TYPE_ACCESS = "ROLE_DOCUMENT_TYPE_ACCESS_SEQ";
        private static string _SEQ_ROLE_DOCUMENT_ACCESS = "ROLE_DOCUMENT_ACCESS_SEQ";
        private static string _SEQ_ROLES = "ROLES_SEQ";
        private static string _SEQ_USER_CLIENT_ACCESS = "USER_CLIENT_ACCESS_SEQ";
        private static string _SEQ_USER_DOC_TYPE_ACCESS = "USER_DOCUMENT_TYPE_ACCESS_SEQ";
        private static string _SEQ_USER_DOCUMENT_ACCESS = "USER_DOCUMENT_ACCESS_SEQ";
        private static string _SEQ_USER_ROLES = "USER_ROLES_SEQ";
        private static string _SEQ_USERS = "USERS_SEQ";
        private static string _SEQ_FILES = "FILES_SEQ";

        public static int GET_ADDRESS_DICTIONARY_ID()
        {
            return GetSequenceValue(_SEQ_ADDRESS_DICTIONARY);
        }

        public static int GET_ATTRIBUTES_ID()
        {
            return GetSequenceValue(_SEQ_ATTRIBUTES);
        }

        public static int GET_ATTRIBUTES_VALUES_ID()
        {
            return GetSequenceValue(_SEQ_ATTRIBUTES_VALUES);
        }

        public static int GET_CLIENTS_ID()
        {
            return GetSequenceValue(_SEQ_CLIENTS);
        }

        public static int GET_COPIES_ID()
        {
            return GetSequenceValue(_SEQ_COPIES);
        }

        public static int GET_COPY_TYPE_ATTRIBUTES_ID()
        {
            return GetSequenceValue(_SEQ_COPY_TYPE_ATTRIBUTES);
        }

        public static int GET_COPY_TYPES_ID()
        {
            return GetSequenceValue(_SEQ_COPY_TYPES);
        }

        public static int GET_DOCUMENT_HISTORY_ID()
        {
            return GetSequenceValue(_SEQ_DOCUMENT_HISTORY);
        }

        public static int GET_DOCUMENT_TYPE_ATTRIBUTES_ID()
        {
            return GetSequenceValue(_SEQ_DOCUMENT_TYPE_ATTRIBUTES);
        }

        public static int GET_DOCUMENT_TYPES_ID()
        {
            return GetSequenceValue(_SEQ_DOCUMENT_TYPES);
        }

        public static int GET_DOCUMENTS_ID()
        {
            return GetSequenceValue(_SEQ_DOCUMENTS);
        }

        public static int GET_MOVEMENT_ID()
        {
            return GetSequenceValue(_SEQ_MOVEMENT);
        }

        public static int GET_REFERENCE_TYPES_ID()
        {
            return GetSequenceValue(_SEQ_REFERENCE_TYPES);
        }

        public static int GET_REFERENCES_ID()
        {
            return GetSequenceValue(_SEQ_REFERENCES);
        }

        public static int GET_ROLE_CLIENT_ACCESS_ID()
        {
            return GetSequenceValue(_SEQ_ROLE_CLIENT_ACCESS);
        }

        public static int GET_ROLE_DOC_TYPE_ACCESS_ID()
        {
            return GetSequenceValue(_SEQ_ROLE_DOC_TYPE_ACCESS);
        }

        public static int GET_ROLE_DOCUMENT_ACCESS_ID()
        {
            return GetSequenceValue(_SEQ_ROLE_DOCUMENT_ACCESS);
        }

        public static int GET_ROLES_ID()
        {
            return GetSequenceValue(_SEQ_ROLES);
        }

        public static int GET_USER_CLIENT_ACCESS_ID()
        {
            return GetSequenceValue(_SEQ_USER_CLIENT_ACCESS);
        }

        public static int GET_USER_DOC_TYPE_ACCESS_ID()
        {
            return GetSequenceValue(_SEQ_USER_DOC_TYPE_ACCESS);
        }

        public static int GET_USER_DOCUMENT_ACCESS_ID()
        {
            return GetSequenceValue(_SEQ_USER_DOCUMENT_ACCESS);
        }

        public static int GET_USER_ROLES_ID()
        {
            return GetSequenceValue(_SEQ_USER_ROLES);
        }

        public static int GET_USERS_ID()
        {
            return GetSequenceValue(_SEQ_USERS);
        }

        public static int GET_FILES_ID()
        {
            return GetSequenceValue(_SEQ_FILES);
        }

        public static int GetSequenceValue(string _SequenceValue)
        {
            OracleCommand _command = new OracleCommand();
            int _ItemValue = -1;
            OracleConnection _con = new OracleConnection(Properties.Settings.Default.archConnectionString);
            try
            {
                _con.Open();
                _command.Connection = _con;
                string _QueryString = "select ARCH." + _SequenceValue + ".NEXTVAL from dual ";
                _command.CommandText = _QueryString;
                _ItemValue = Convert.ToInt32(_command.ExecuteScalar().ToString());
                _con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _con.Close();
            }
            return _ItemValue;
        }

        #endregion

        static public string getDocNum(decimal id)
        {
            OracleCommand _command = new OracleCommand();
            string _value = "";
            OracleConnection _con = new OracleConnection(Properties.Settings.Default.archConnectionString);
            try
            {
                _con.Open();
                _command.Connection = _con;
                string _QueryString = "select DOCUMENT_NUMBER from ARCH.DOCUMENTS where ID=:id";
                _command.CommandText = _QueryString;
                _command.Parameters.Add(":id", id);
                _value = _command.ExecuteScalar().ToString();
                _con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _con.Close();
            }
            return _value;
        }

        static public string getCopyNameWithDocNum(decimal id)
        {
            OracleCommand _command = new OracleCommand();
            string _value = "";
            OracleConnection _con = new OracleConnection(Properties.Settings.Default.archConnectionString);
            try
            {
                _con.Open();
                _command.Connection = _con;
                string _QueryString = @"select ARCH.DOCUMENTS.DOCUMENT_NUMBER||'/'||ARCH.COPIES.NAME from ARCH.DOCUMENTS inner join ARCH.COPIES on 
                                        ARCH.DOCUMENTS.ID = ARCH.COPIES.DOCUMENT_ID
                                        where ARCH.COPIES.ID=:id";
                _command.CommandText = _QueryString;
                _command.Parameters.Add(":id", id);
                _value = _command.ExecuteScalar().ToString();
                _con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _con.Close();
            }
            return _value;
        }
    }
}
