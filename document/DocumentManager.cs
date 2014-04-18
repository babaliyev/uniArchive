using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniArchive.document
{
    public partial class DocumentManager : DevExpress.XtraEditors.XtraUserControl
    {
        public DocumentManager(decimal id)
        {
            InitializeComponent();
        }

        public DocumentManager()
        {
            InitializeComponent();
        }
    }
}
