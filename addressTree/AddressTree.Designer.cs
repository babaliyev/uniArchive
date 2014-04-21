namespace UniArchive.addressTree
{
    partial class AddressTree
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressTree));
            this.addressImageList = new System.Windows.Forms.ImageList(this.components);
            this.addressTreeView = new System.Windows.Forms.TreeView();
            this.fullDataSet = new UniArchive.FullDataSet();
            this.addressDictionaryTableAdapter = new UniArchive.FullDataSetTableAdapters.ADDRESS_DICTIONARYTableAdapter();
            this.documentsTableAdapter = new UniArchive.FullDataSetTableAdapters.DOCUMENTSTableAdapter();
            this.copiesTableAdapter = new UniArchive.FullDataSetTableAdapters.COPIESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // addressImageList
            // 
            this.addressImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("addressImageList.ImageStream")));
            this.addressImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.addressImageList.Images.SetKeyName(0, "office-building.png");
            this.addressImageList.Images.SetKeyName(1, "index.png");
            this.addressImageList.Images.SetKeyName(2, "document.png");
            this.addressImageList.Images.SetKeyName(3, "paperclip.png");
            this.addressImageList.Images.SetKeyName(4, "warning.png");
            this.addressImageList.Images.SetKeyName(5, "index_new.png");
            // 
            // addressTreeView
            // 
            this.addressTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTreeView.HotTracking = true;
            this.addressTreeView.ImageIndex = 0;
            this.addressTreeView.ImageList = this.addressImageList;
            this.addressTreeView.Location = new System.Drawing.Point(0, 0);
            this.addressTreeView.Name = "addressTreeView";
            this.addressTreeView.SelectedImageIndex = 0;
            this.addressTreeView.Size = new System.Drawing.Size(340, 457);
            this.addressTreeView.TabIndex = 0;
            this.addressTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.addressTreeView_AfterSelect);
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressDictionaryTableAdapter
            // 
            this.addressDictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // copiesTableAdapter
            // 
            this.copiesTableAdapter.ClearBeforeFill = true;
            // 
            // AddressTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addressTreeView);
            this.Name = "AddressTree";
            this.Size = new System.Drawing.Size(340, 457);
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FullDataSetTableAdapters.ADDRESS_DICTIONARYTableAdapter addressDictionaryTableAdapter;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.ImageList addressImageList;
        private System.Windows.Forms.TreeView addressTreeView;
        private FullDataSetTableAdapters.DOCUMENTSTableAdapter documentsTableAdapter;
        private FullDataSetTableAdapters.COPIESTableAdapter copiesTableAdapter;

    }
}
