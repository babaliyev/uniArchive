namespace UniArchive.users
{
    partial class Users
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
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new UniArchive.FullDataSetTableAdapters.USERSTableAdapter();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.usersGridControl = new DevExpress.XtraGrid.GridControl();
            this.usersGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFULL_NAME = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBLOCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.blockCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.rolesTabPage = new DevExpress.XtraTab.XtraTabPage();
            this.userRolesGridControl = new DevExpress.XtraGrid.GridControl();
            this.userRolesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROLE_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUSER_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.userRolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userRolesTableAdapter = new UniArchive.FullDataSetTableAdapters.USER_ROLESTableAdapter();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new UniArchive.FullDataSetTableAdapters.ROLESTableAdapter();
            this.rolesSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockCheckEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.rolesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesSearchLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // fullDataSet
            // 
            this.fullDataSet.DataSetName = "FullDataSet";
            this.fullDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "USERS";
            this.usersBindingSource.DataSource = this.fullDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.usersGridControl);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(546, 419);
            this.splitContainerControl1.SplitterPosition = 222;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // usersGridControl
            // 
            this.usersGridControl.DataSource = this.usersBindingSource;
            this.usersGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGridControl.Location = new System.Drawing.Point(0, 0);
            this.usersGridControl.MainView = this.usersGridView;
            this.usersGridControl.Name = "usersGridControl";
            this.usersGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.blockCheckEdit});
            this.usersGridControl.Size = new System.Drawing.Size(546, 222);
            this.usersGridControl.TabIndex = 0;
            this.usersGridControl.UseEmbeddedNavigator = true;
            this.usersGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.usersGridView});
            // 
            // usersGridView
            // 
            this.usersGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colNAME,
            this.colFULL_NAME,
            this.colBLOCK});
            this.usersGridView.GridControl = this.usersGridControl;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.OptionsCustomization.AllowGroup = false;
            this.usersGridView.OptionsDetail.EnableMasterViewMode = false;
            this.usersGridView.OptionsDetail.ShowDetailTabs = false;
            this.usersGridView.OptionsDetail.SmartDetailExpand = false;
            this.usersGridView.OptionsView.ShowAutoFilterRow = true;
            this.usersGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.usersGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colNAME
            // 
            this.colNAME.FieldName = "NAME";
            this.colNAME.Name = "colNAME";
            this.colNAME.Visible = true;
            this.colNAME.VisibleIndex = 0;
            // 
            // colFULL_NAME
            // 
            this.colFULL_NAME.FieldName = "FULL_NAME";
            this.colFULL_NAME.Name = "colFULL_NAME";
            this.colFULL_NAME.Visible = true;
            this.colFULL_NAME.VisibleIndex = 1;
            // 
            // colBLOCK
            // 
            this.colBLOCK.ColumnEdit = this.blockCheckEdit;
            this.colBLOCK.FieldName = "BLOCK";
            this.colBLOCK.Name = "colBLOCK";
            this.colBLOCK.Visible = true;
            this.colBLOCK.VisibleIndex = 2;
            // 
            // blockCheckEdit
            // 
            this.blockCheckEdit.AutoHeight = false;
            this.blockCheckEdit.Name = "blockCheckEdit";
            this.blockCheckEdit.ValueChecked = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.blockCheckEdit.ValueUnchecked = new decimal(new int[] {
            0,
            0,
            0,
            0});
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.rolesTabPage;
            this.xtraTabControl1.Size = new System.Drawing.Size(546, 192);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.rolesTabPage});
            // 
            // rolesTabPage
            // 
            this.rolesTabPage.Controls.Add(this.userRolesGridControl);
            this.rolesTabPage.Name = "rolesTabPage";
            this.rolesTabPage.Size = new System.Drawing.Size(540, 164);
            this.rolesTabPage.Text = "Roles";
            // 
            // userRolesGridControl
            // 
            this.userRolesGridControl.DataMember = "USER_ROLES_FK2";
            this.userRolesGridControl.DataSource = this.usersBindingSource;
            this.userRolesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userRolesGridControl.Location = new System.Drawing.Point(0, 0);
            this.userRolesGridControl.MainView = this.userRolesGridView;
            this.userRolesGridControl.Name = "userRolesGridControl";
            this.userRolesGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.rolesSearchLookUpEdit1});
            this.userRolesGridControl.Size = new System.Drawing.Size(540, 164);
            this.userRolesGridControl.TabIndex = 1;
            this.userRolesGridControl.UseEmbeddedNavigator = true;
            this.userRolesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.userRolesGridView});
            // 
            // userRolesGridView
            // 
            this.userRolesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colROLE_ID,
            this.colUSER_ID});
            this.userRolesGridView.GridControl = this.userRolesGridControl;
            this.userRolesGridView.Name = "userRolesGridView";
            this.userRolesGridView.OptionsCustomization.AllowGroup = false;
            this.userRolesGridView.OptionsDetail.EnableMasterViewMode = false;
            this.userRolesGridView.OptionsDetail.ShowDetailTabs = false;
            this.userRolesGridView.OptionsDetail.SmartDetailExpand = false;
            this.userRolesGridView.OptionsView.ShowAutoFilterRow = true;
            this.userRolesGridView.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.userRolesGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            // 
            // colROLE_ID
            // 
            this.colROLE_ID.Caption = "Role";
            this.colROLE_ID.ColumnEdit = this.rolesSearchLookUpEdit1;
            this.colROLE_ID.FieldName = "ROLE_ID";
            this.colROLE_ID.Name = "colROLE_ID";
            this.colROLE_ID.Visible = true;
            this.colROLE_ID.VisibleIndex = 0;
            // 
            // colUSER_ID
            // 
            this.colUSER_ID.FieldName = "USER_ID";
            this.colUSER_ID.Name = "colUSER_ID";
            // 
            // userRolesBindingSource
            // 
            this.userRolesBindingSource.DataMember = "USER_ROLES_FK2";
            this.userRolesBindingSource.DataSource = this.usersBindingSource;
            // 
            // userRolesTableAdapter
            // 
            this.userRolesTableAdapter.ClearBeforeFill = true;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "ROLES";
            this.rolesBindingSource.DataSource = this.fullDataSet;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // rolesSearchLookUpEdit1
            // 
            this.rolesSearchLookUpEdit1.AutoHeight = false;
            this.rolesSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rolesSearchLookUpEdit1.DataSource = this.rolesBindingSource;
            this.rolesSearchLookUpEdit1.DisplayMember = "NAME";
            this.rolesSearchLookUpEdit1.Name = "rolesSearchLookUpEdit1";
            this.rolesSearchLookUpEdit1.NullText = "";
            this.rolesSearchLookUpEdit1.ValueMember = "ID";
            this.rolesSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "Users";
            this.Size = new System.Drawing.Size(546, 419);
            ((System.ComponentModel.ISupportInitialize)(this.fullDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blockCheckEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.rolesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userRolesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userRolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesSearchLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FullDataSet fullDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private FullDataSetTableAdapters.USERSTableAdapter usersTableAdapter;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl usersGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView usersGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colNAME;
        private DevExpress.XtraGrid.Columns.GridColumn colFULL_NAME;
        private DevExpress.XtraGrid.Columns.GridColumn colBLOCK;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit blockCheckEdit;
        private DevExpress.XtraTab.XtraTabPage rolesTabPage;
        private DevExpress.XtraGrid.GridControl userRolesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView userRolesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colROLE_ID;
        private DevExpress.XtraGrid.Columns.GridColumn colUSER_ID;
        private System.Windows.Forms.BindingSource userRolesBindingSource;
        private FullDataSetTableAdapters.USER_ROLESTableAdapter userRolesTableAdapter;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private FullDataSetTableAdapters.ROLESTableAdapter rolesTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit rolesSearchLookUpEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
    }
}
