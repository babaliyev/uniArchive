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
        public StandaloneCopyManager(decimal? documentId, decimal id)
            : base()
        {
            InitializeComponent();
            loadReferences();
            this.copiesTableAdapter.FillByID(this.fullDataSet.COPIES, id);
            FullDataSet.COPIESRow row = this.fullDataSet.COPIES.FindByID((int)id);
            this.setData(fullDataSet, row.DOCUMENT_ID);
            this.edit(id);
            this.OnSave += SaveEvent;
        }

        public StandaloneCopyManager(decimal documentId)
            : base()
        {
            InitializeComponent();
            loadReferences();
            this.setData(fullDataSet, documentId);
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
            this.filesTableAdapter.Update(fullDataSet.FILES);
        }
    }
}
