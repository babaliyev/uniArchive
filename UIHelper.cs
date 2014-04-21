using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniArchive
{
    static public class UIHelper
    {
        static public bool requiredField_Validating(DevExpress.XtraEditors.BaseEdit control)
        {
            if (control.EditValue == null || control.EditValue == DBNull.Value)
            {
                control.ErrorText = "Mütləq xanadır!";
                return false;
            }
            else
                return true;
        }
    }
}
