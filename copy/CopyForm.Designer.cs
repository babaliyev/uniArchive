namespace UniArchive.copy
{
    partial class CopyForm
    {
        private decimal documentId;
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
            this.copyManager1 = new UniArchive.copy.CopyManager(documentId);
            this.SuspendLayout();
            // 
            // copyManager1
            // 
            this.copyManager1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.copyManager1.Location = new System.Drawing.Point(0, 0);
            this.copyManager1.Name = "copyManager1";
            this.copyManager1.Size = new System.Drawing.Size(589, 474);
            this.copyManager1.TabIndex = 0;
            // 
            // CopyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 474);
            this.Controls.Add(this.copyManager1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CopyForm";
            this.ShowInTaskbar = false;
            this.Text = "CopyForm";
            this.ResumeLayout(false);

        }

        #endregion

        private CopyManager copyManager1;
    }
}