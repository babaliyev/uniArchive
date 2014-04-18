namespace UniArchive
{
    partial class MasterDetailManager
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
            this.fullDataSet = new UniArchive.FullDataSet();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.masterGridControl = new DevExpress.XtraGrid.GridControl();
            this.masterGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.detailsXtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).BeginInit();
            this.SuspendLayout();
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.masterGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.detailsXtraTabControl);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(620, 488);
            this.splitContainerControl1.SplitterPosition = 222;
            this.splitContainerControl1.TabIndex = 1;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // masterGridControl
            // 
            this.masterGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.masterGridControl.Location = new System.Drawing.Point(0, 0);
            this.masterGridControl.MainView = this.masterGridView;
            this.masterGridControl.Name = "masterGridControl";
            this.masterGridControl.Size = new System.Drawing.Size(620, 261);
            this.masterGridControl.TabIndex = 0;
            this.masterGridControl.UseEmbeddedNavigator = true;
            this.masterGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.masterGridView});
            // 
            // masterGridView
            // 
            this.masterGridView.GridControl = this.masterGridControl;
            this.masterGridView.Name = "masterGridView";
            this.masterGridView.OptionsCustomization.AllowGroup = false;
            this.masterGridView.OptionsDetail.EnableMasterViewMode = false;
            this.masterGridView.OptionsDetail.ShowDetailTabs = false;
            this.masterGridView.OptionsDetail.SmartDetailExpand = false;
            this.masterGridView.OptionsView.ShowAutoFilterRow = true;
            this.masterGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.masterGridView.OptionsView.ShowGroupPanel = false;
            // 
            // detailsXtraTabControl
            // 
            this.detailsXtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsXtraTabControl.Location = new System.Drawing.Point(0, 0);
            this.detailsXtraTabControl.Name = "detailsXtraTabControl";
            this.detailsXtraTabControl.Size = new System.Drawing.Size(620, 222);
            this.detailsXtraTabControl.TabIndex = 0;
            // 
            // MasterDetailManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "MasterDetailManager";
            this.Size = new System.Drawing.Size(620, 488);
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.masterGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detailsXtraTabControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FullDataSet fullDataSet;
        protected DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        protected DevExpress.XtraGrid.GridControl masterGridControl;
        public DevExpress.XtraTab.XtraTabControl detailsXtraTabControl;
        public DevExpress.XtraGrid.Views.Grid.GridView masterGridView;
    }
}
