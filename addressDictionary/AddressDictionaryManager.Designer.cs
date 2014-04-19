namespace UniArchive.addressDictionary
{
    partial class AddressDictionaryManager
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
            this.fullDataSet = new UniArchive.FullDataSet();
            this.addressDictionaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addressDictionaryTableAdapter = new UniArchive.FullDataSetTableAdapters.ADDRESS_DICTIONARYTableAdapter();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colNAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDESCRIPTION = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.dataNavigator1 = new DevExpress.XtraEditors.DataNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDictionaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addressDictionaryBindingSource
            // 
            this.addressDictionaryBindingSource.DataMember = "ADDRESS_DICTIONARY";
            this.addressDictionaryBindingSource.DataSource = this.fullDataSet;
            // 
            // addressDictionaryTableAdapter
            // 
            this.addressDictionaryTableAdapter.ClearBeforeFill = true;
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colNAME,
            this.colDESCRIPTION});
            this.treeList1.DataSource = this.addressDictionaryBindingSource;
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.DragNodes = true;
            this.treeList1.ParentFieldName = "PARENT_ID";
            this.treeList1.RootValue = null;
            this.treeList1.Size = new System.Drawing.Size(583, 470);
            this.treeList1.TabIndex = 2;
            this.treeList1.ValidateNode += new DevExpress.XtraTreeList.ValidateNodeEventHandler(this.treeList1_ValidateNode);
            // 
            // colNAME
            // 
            this.colNAME.Caption = "Name";
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 0;
            this.colNAME.Width = 127;
            // 
            // colDESCRIPTION
            // 
            this.colDESCRIPTION.Caption = "Notes";
            this.colDESCRIPTION.FieldName = "DESCRIPTION";
            this.colDESCRIPTION.Name = "colDESCRIPTION";
            this.colDESCRIPTION.Visible = true;
            this.colDESCRIPTION.VisibleIndex = 1;
            this.colDESCRIPTION.Width = 127;
            // 
            // dataNavigator1
            // 
            this.dataNavigator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataNavigator1.DataSource = this.addressDictionaryBindingSource;
            this.dataNavigator1.Location = new System.Drawing.Point(3, 443);
            this.dataNavigator1.Name = "dataNavigator1";
            this.dataNavigator1.Size = new System.Drawing.Size(172, 24);
            this.dataNavigator1.TabIndex = 3;
            this.dataNavigator1.Text = "dataNavigator1";
            // 
            // AddressDictionaryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataNavigator1);
            this.Controls.Add(this.treeList1);
            this.Name = "AddressDictionaryManager";
            this.Size = new System.Drawing.Size(583, 470);
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressDictionaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource addressDictionaryBindingSource;
        private FullDataSetTableAdapters.ADDRESS_DICTIONARYTableAdapter addressDictionaryTableAdapter;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colNAME;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDESCRIPTION;
        private DevExpress.XtraEditors.DataNavigator dataNavigator1;

    }
}
