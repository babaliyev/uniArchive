namespace UniArchive.copy
{
    partial class StandaloneCopyManager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.fullDataSet = new UniArchive.FullDataSet();
            this.copyTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.copyTypesTableAdapter = new UniArchive.FullDataSetTableAdapters.COPY_TYPESTableAdapter();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.copiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.copiesTableAdapter = new UniArchive.FullDataSetTableAdapters.COPIESTableAdapter();
            this.documentsTableAdapter = new UniArchive.FullDataSetTableAdapters.DOCUMENTSTableAdapter();
            this.filesTableAdapter = new UniArchive.FullDataSetTableAdapters.FILESTableAdapter();
            this.filesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // copyTypesBindingSource
            // 
            this.copyTypesBindingSource.DataMember = "COPY_TYPES";
            this.copyTypesBindingSource.DataSource = this.fullDataSet;
            // 
            // copyTypesTableAdapter
            // 
            this.copyTypesTableAdapter.ClearBeforeFill = true;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "DOCUMENTS";
            this.documentsBindingSource.DataSource = this.fullDataSet;
            // 
            // copiesBindingSource
            // 
            this.copiesBindingSource.DataMember = "COPIES";
            this.copiesBindingSource.DataSource = this.fullDataSet;
            // 
            // copiesTableAdapter
            // 
            this.copiesTableAdapter.ClearBeforeFill = true;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // filesTableAdapter
            // 
            this.filesTableAdapter.ClearBeforeFill = true;
            // 
            // filesBindingSource
            // 
            this.filesBindingSource.DataMember = "FILES";
            this.filesBindingSource.DataSource = this.fullDataSet;
            // 
            // StandaloneCopyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.Name = "StandaloneCopyManager";
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copyTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource copyTypesBindingSource;
        private FullDataSetTableAdapters.COPY_TYPESTableAdapter copyTypesTableAdapter;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private System.Windows.Forms.BindingSource copiesBindingSource;
        private FullDataSetTableAdapters.COPIESTableAdapter copiesTableAdapter;
        private FullDataSetTableAdapters.DOCUMENTSTableAdapter documentsTableAdapter;
        private FullDataSetTableAdapters.FILESTableAdapter filesTableAdapter;
        private System.Windows.Forms.BindingSource filesBindingSource;
    }
}
