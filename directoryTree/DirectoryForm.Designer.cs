namespace UniArchive.directoryTree
{
    partial class DirectoryForm
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
            this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.okSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.fullAccessCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.directoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UniArchive.FullDataSet();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.directoriesTableAdapter = new UniArchive.FullDataSetTableAdapters.DIRECTORIESTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.fullAccessCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelSimpleButton
            // 
            this.cancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelSimpleButton.Location = new System.Drawing.Point(228, 47);
            this.cancelSimpleButton.Name = "cancelSimpleButton";
            this.cancelSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSimpleButton.TabIndex = 3;
            this.cancelSimpleButton.Text = "İmtina";
            // 
            // okSimpleButton
            // 
            this.okSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okSimpleButton.Location = new System.Drawing.Point(147, 47);
            this.okSimpleButton.Name = "okSimpleButton";
            this.okSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.okSimpleButton.TabIndex = 2;
            this.okSimpleButton.Text = "Saxla";
            this.okSimpleButton.Click += new System.EventHandler(this.okSimpleButton_Click);
            // 
            // fullAccessCheckEdit
            // 
            this.fullAccessCheckEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fullAccessCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.directoriesBindingSource, "FULL_ACCESS", true));
            this.fullAccessCheckEdit.Location = new System.Drawing.Point(105, 46);
            this.fullAccessCheckEdit.Name = "fullAccessCheckEdit";
            this.fullAccessCheckEdit.Properties.Caption = "";
            this.fullAccessCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive;
            this.fullAccessCheckEdit.Properties.ValueChecked = ((short)(1));
            this.fullAccessCheckEdit.Properties.ValueUnchecked = ((short)(0));
            this.fullAccessCheckEdit.Size = new System.Drawing.Size(21, 19);
            this.fullAccessCheckEdit.TabIndex = 15;
            // 
            // directoriesBindingSource
            // 
            this.directoriesBindingSource.DataMember = "DIRECTORIES";
            this.directoriesBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl6.Location = new System.Drawing.Point(12, 47);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Hamıya görünsün:";
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.directoriesBindingSource, "DOCUMENT_NUMBER", true));
            this.nameTextEdit.Location = new System.Drawing.Point(107, 9);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.nameTextEdit.Properties.NullValuePrompt = "Mütləq xanadır!";
            this.nameTextEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.nameTextEdit.Size = new System.Drawing.Size(196, 20);
            this.nameTextEdit.TabIndex = 18;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 12);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(67, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Qovluğun adı:";
            // 
            // directoriesTableAdapter
            // 
            this.directoriesTableAdapter.ClearBeforeFill = true;
            // 
            // DirectoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 82);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.fullAccessCheckEdit);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cancelSimpleButton);
            this.Controls.Add(this.okSimpleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DirectoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DirectoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.fullAccessCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton cancelSimpleButton;
        private DevExpress.XtraEditors.SimpleButton okSimpleButton;
        private DevExpress.XtraEditors.CheckEdit fullAccessCheckEdit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource directoriesBindingSource;
        private FullDataSetTableAdapters.DIRECTORIESTableAdapter directoriesTableAdapter;
    }
}