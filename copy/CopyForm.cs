using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace UniArchive.copy
{
    public partial class CopyForm : DevExpress.XtraEditors.XtraForm
    {
        

        public CopyForm(FullDataSet fds, decimal documentId, decimal id)
        {
            InitializeComponent();
            copyManager1.setData(fds, documentId);
            copyManager1.edit(id);
            copyManager1.OnSave += SaveEvent;
        }

        public CopyForm(FullDataSet fds, decimal documentId)
        {
            InitializeComponent();
            copyManager1.setData(fds, documentId);
            copyManager1.addNew();
            copyManager1.OnSave += SaveEvent;
        }

        public void SaveEvent(object sender, EventArgs args)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}