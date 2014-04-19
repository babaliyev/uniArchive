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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.addressDictionaryTableAdapter = new UniArchive.FullDataSetTableAdapters.ADDRESS_DICTIONARYTableAdapter();
            this.addressDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UniArchive.FullDataSet();
            this.colNAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNAME});
            this.treeList1.DataSource = this.addressDictionaryBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.DragNodes = true;
            this.treeList1.OptionsBehavior.Editable = false;
            this.treeList1.OptionsView.ShowAutoFilterRow = true;
            this.treeList1.OptionsView.ShowColumns = false;
            this.treeList1.ParentFieldName = "PARENT_ID";
            this.treeList1.PreviewFieldName = "NAME";
            this.treeList1.RootValue = null;
            this.treeList1.Size = new System.Drawing.Size(340, 457);
            this.treeList1.TabIndex = 5;
            // 
            // addressDictionaryTableAdapter
            // 
            this.addressDictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // addressDictionaryBindingSource
            // 
            this.addressDictionaryBindingSource.DataMember = "ADDRESS_DICTIONARY";
            this.addressDictionaryBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colNAME
            // 
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 0;
            this.colNAME.Width = 108;
            // 
            // AddressTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.treeList1);
            this.Name = "AddressTree";
            this.Size = new System.Drawing.Size(340, 457);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private FullDataSetTableAdapters.ADDRESS_DICTIONARYTableAdapter addressDictionaryTableAdapter;
        private System.Windows.Forms.BindingSource addressDictionaryBindingSource;
        private FullDataSet fullDataSet;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNAME;

    }
}
