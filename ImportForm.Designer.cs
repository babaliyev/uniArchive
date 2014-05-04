﻿namespace UniArchive
{
    partial class ImportForm
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
            this.importSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.infoLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.fullDataSet = new UniArchive.FullDataSet();
            this.documentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentsTableAdapter = new UniArchive.FullDataSetTableAdapters.DOCUMENTSTableAdapter();
            this.copiesTableAdapter = new UniArchive.FullDataSetTableAdapters.COPIESTableAdapter();
            this.copiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filesTableAdapter = new UniArchive.FullDataSetTableAdapters.FILESTableAdapter();
            this.directoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.directoriesTableAdapter = new UniArchive.FullDataSetTableAdapters.DIRECTORIESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // importSimpleButton
            // 
            this.importSimpleButton.Location = new System.Drawing.Point(75, 74);
            this.importSimpleButton.Name = "importSimpleButton";
            this.importSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.importSimpleButton.TabIndex = 0;
            this.importSimpleButton.Text = "Import";
            this.importSimpleButton.Click += new System.EventHandler(this.importSimpleButton_Click);
            // 
            // cancelSimpleButton
            // 
            this.cancelSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelSimpleButton.Location = new System.Drawing.Point(156, 74);
            this.cancelSimpleButton.Name = "cancelSimpleButton";
            this.cancelSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSimpleButton.TabIndex = 1;
            this.cancelSimpleButton.Text = "Cancel";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Cari iş:";
            // 
            // infoLabelControl
            // 
            this.infoLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.infoLabelControl.Location = new System.Drawing.Point(51, 22);
            this.infoLabelControl.Name = "infoLabelControl";
            this.infoLabelControl.Size = new System.Drawing.Size(232, 46);
            this.infoLabelControl.TabIndex = 3;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentsBindingSource
            // 
            this.documentsBindingSource.DataMember = "DOCUMENTS";
            this.documentsBindingSource.DataSource = this.fullDataSet;
            // 
            // documentsTableAdapter
            // 
            this.documentsTableAdapter.ClearBeforeFill = true;
            // 
            // copiesTableAdapter
            // 
            this.copiesTableAdapter.ClearBeforeFill = true;
            // 
            // copiesBindingSource
            // 
            this.copiesBindingSource.DataMember = "COPIES";
            this.copiesBindingSource.DataSource = this.fullDataSet;
            // 
            // filesBindingSource
            // 
            this.filesBindingSource.DataMember = "FILES";
            this.filesBindingSource.DataSource = this.fullDataSet;
            // 
            // filesTableAdapter
            // 
            this.filesTableAdapter.ClearBeforeFill = true;
            // 
            // directoriesBindingSource
            // 
            this.directoriesBindingSource.DataMember = "DIRECTORIES";
            this.directoriesBindingSource.DataSource = this.fullDataSet;
            // 
            // directoriesTableAdapter
            // 
            this.directoriesTableAdapter.ClearBeforeFill = true;
            // 
            // ImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 109);
            this.Controls.Add(this.infoLabelControl);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cancelSimpleButton);
            this.Controls.Add(this.importSimpleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.copiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource documentsBindingSource;
        private FullDataSetTableAdapters.DOCUMENTSTableAdapter documentsTableAdapter;
        private FullDataSetTableAdapters.COPIESTableAdapter copiesTableAdapter;
        private System.Windows.Forms.BindingSource copiesBindingSource;
        private System.Windows.Forms.BindingSource filesBindingSource;
        private FullDataSetTableAdapters.FILESTableAdapter filesTableAdapter;
        private DevExpress.XtraEditors.SimpleButton importSimpleButton;
        private DevExpress.XtraEditors.SimpleButton cancelSimpleButton;
        private System.Windows.Forms.BindingSource directoriesBindingSource;
        private FullDataSetTableAdapters.DIRECTORIESTableAdapter directoriesTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl infoLabelControl;
    }
}