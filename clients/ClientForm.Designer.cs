namespace UniArchive.clients
{
    partial class ClientForm
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
            this.okSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelSimpleButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.clientTypeRadioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullDataSet = new UniArchive.FullDataSet();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.identificationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.contactsMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.addressMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.fullAccessCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.clientsTableAdapter = new UniArchive.FullDataSetTableAdapters.CLIENTSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientTypeRadioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.identificationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullAccessCheckEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // okSimpleButton
            // 
            this.okSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okSimpleButton.Location = new System.Drawing.Point(267, 241);
            this.okSimpleButton.Name = "okSimpleButton";
            this.okSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.okSimpleButton.TabIndex = 0;
            this.okSimpleButton.Text = "Saxla";
            this.okSimpleButton.Click += new System.EventHandler(this.okSimpleButton_Click);
            // 
            // cancelSimpleButton
            // 
            this.cancelSimpleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelSimpleButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelSimpleButton.Location = new System.Drawing.Point(348, 241);
            this.cancelSimpleButton.Name = "cancelSimpleButton";
            this.cancelSimpleButton.Size = new System.Drawing.Size(75, 23);
            this.cancelSimpleButton.TabIndex = 1;
            this.cancelSimpleButton.Text = "İmtina";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Müştəri tipi:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tam adı:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(14, 70);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "VÖEN/PIN";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Əlaqə vasitəsi";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 162);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Ünvan:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(310, 17);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Hamıya görünsün:";
            // 
            // clientTypeRadioGroup
            // 
            this.clientTypeRadioGroup.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "CLIENT_TYPE", true));
            this.clientTypeRadioGroup.Location = new System.Drawing.Point(106, 12);
            this.clientTypeRadioGroup.Name = "clientTypeRadioGroup";
            this.clientTypeRadioGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.clientTypeRadioGroup.Properties.Appearance.Options.UseBackColor = true;
            this.clientTypeRadioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clientTypeRadioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(new decimal(new int[] {
                            0,
                            0,
                            0,
                            0}), "Fiziki şəxs"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(new decimal(new int[] {
                            1,
                            0,
                            0,
                            0}), "Hüquqi şəxs")});
            this.clientTypeRadioGroup.Size = new System.Drawing.Size(169, 23);
            this.clientTypeRadioGroup.TabIndex = 8;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "CLIENTS";
            this.clientsBindingSource.DataSource = this.fullDataSet;
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "FULL_NAME", true));
            this.nameTextEdit.Location = new System.Drawing.Point(106, 41);
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.nameTextEdit.Properties.NullValuePrompt = "Mütləq xanadır!";
            this.nameTextEdit.Properties.NullValuePromptShowForEmptyValue = true;
            this.nameTextEdit.Size = new System.Drawing.Size(318, 20);
            this.nameTextEdit.TabIndex = 9;
            // 
            // identificationTextEdit
            // 
            this.identificationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "IDENTIFICATION_NUMBER", true));
            this.identificationTextEdit.Location = new System.Drawing.Point(106, 67);
            this.identificationTextEdit.Name = "identificationTextEdit";
            this.identificationTextEdit.Size = new System.Drawing.Size(169, 20);
            this.identificationTextEdit.TabIndex = 10;
            // 
            // contactsMemoEdit
            // 
            this.contactsMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "CONTACTS", true));
            this.contactsMemoEdit.Location = new System.Drawing.Point(106, 93);
            this.contactsMemoEdit.Name = "contactsMemoEdit";
            this.contactsMemoEdit.Size = new System.Drawing.Size(318, 60);
            this.contactsMemoEdit.TabIndex = 11;
            // 
            // addressMemoEdit
            // 
            this.addressMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "ADDRESS", true));
            this.addressMemoEdit.Location = new System.Drawing.Point(106, 159);
            this.addressMemoEdit.Name = "addressMemoEdit";
            this.addressMemoEdit.Size = new System.Drawing.Size(318, 66);
            this.addressMemoEdit.TabIndex = 12;
            // 
            // fullAccessCheckEdit
            // 
            this.fullAccessCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.clientsBindingSource, "FULL_ACCESS", true));
            this.fullAccessCheckEdit.Location = new System.Drawing.Point(403, 16);
            this.fullAccessCheckEdit.Name = "fullAccessCheckEdit";
            this.fullAccessCheckEdit.Properties.Caption = "";
            this.fullAccessCheckEdit.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive;
            this.fullAccessCheckEdit.Properties.ValueChecked = ((short)(1));
            this.fullAccessCheckEdit.Properties.ValueUnchecked = ((short)(0));
            this.fullAccessCheckEdit.Size = new System.Drawing.Size(21, 19);
            this.fullAccessCheckEdit.TabIndex = 13;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 276);
            this.Controls.Add(this.fullAccessCheckEdit);
            this.Controls.Add(this.addressMemoEdit);
            this.Controls.Add(this.contactsMemoEdit);
            this.Controls.Add(this.identificationTextEdit);
            this.Controls.Add(this.nameTextEdit);
            this.Controls.Add(this.clientTypeRadioGroup);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cancelSimpleButton);
            this.Controls.Add(this.okSimpleButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müştəri";
            ((System.ComponentModel.ISupportInitialize)(this.clientTypeRadioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.identificationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactsMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullAccessCheckEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton okSimpleButton;
        private DevExpress.XtraEditors.SimpleButton cancelSimpleButton;
        private FullDataSetTableAdapters.CLIENTSTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private FullDataSet fullDataSet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.RadioGroup clientTypeRadioGroup;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraEditors.TextEdit identificationTextEdit;
        private DevExpress.XtraEditors.MemoEdit contactsMemoEdit;
        private DevExpress.XtraEditors.MemoEdit addressMemoEdit;
        private DevExpress.XtraEditors.CheckEdit fullAccessCheckEdit;
    }
}