using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UniArchive.copy
{
    public partial class StandaloneCopyManager : UniArchive.copy.CopyManager
    {
        public StandaloneCopyManager(decimal documentId, decimal id)
            : base(documentId)
        {
            InitializeComponent();
            loadReferences();
            this.copiesTableAdapter.FillByID(this.fullDataSet.COPIES, id);
            this.setDataSet(fullDataSet);
            this.edit(id);
            this.OnSave += SaveEvent;
        }

        public StandaloneCopyManager(decimal documentId)
            : base(documentId)
        {
            InitializeComponent();
            loadReferences();            
            this.setDataSet(fullDataSet);
            this.addNew();
            this.OnSave += SaveEvent;
        }

        public void loadReferences()
        {
            this.documentsTableAdapter.FillByID(this.fullDataSet.DOCUMENTS, this.documentId);
            this.copyTypesTableAdapter.Fill(this.fullDataSet.COPY_TYPES);
        }

        public void SaveEvent(object sender, EventArgs args)
        {
            this.copiesTableAdapter.Update(this.fullDataSet.COPIES);
        }
    }
}
