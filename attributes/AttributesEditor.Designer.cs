namespace UniArchive.attributes
{
    partial class AttributesEditor
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
            this.termValueGridControl = new DevExpress.XtraGrid.GridControl();
            this.termValueGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTermName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceType = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.termValueGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termValueGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // termValueGridControl
            // 
            this.termValueGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.termValueGridControl.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.termValueGridControl.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.termValueGridControl.Location = new System.Drawing.Point(0, 0);
            this.termValueGridControl.MainView = this.termValueGridView;
            this.termValueGridControl.Name = "termValueGridControl";
            this.termValueGridControl.Size = new System.Drawing.Size(394, 336);
            this.termValueGridControl.TabIndex = 4;
            this.termValueGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.termValueGridView});
            // 
            // termValueGridView
            // 
            this.termValueGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTermName,
            this.colValue,
            this.colReferenceType,
            this.colType,
            this.ID});
            this.termValueGridView.GridControl = this.termValueGridControl;
            this.termValueGridView.Name = "termValueGridView";
            this.termValueGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colTermName
            // 
            this.colTermName.Caption = "Xassə";
            this.colTermName.FieldName = "Attribute.Name";
            this.colTermName.MaxWidth = 100;
            this.colTermName.MinWidth = 100;
            this.colTermName.Name = "colTermName";
            this.colTermName.OptionsColumn.AllowEdit = false;
            this.colTermName.OptionsColumn.FixedWidth = true;
            this.colTermName.Visible = true;
            this.colTermName.VisibleIndex = 0;
            this.colTermName.Width = 100;
            // 
            // colValue
            // 
            this.colValue.Caption = "Qiymət";
            this.colValue.FieldName = "Value";
            this.colValue.Name = "colValue";
            this.colValue.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colValue.Visible = true;
            this.colValue.VisibleIndex = 1;
            // 
            // colType
            // 
            this.colType.Caption = "Type";
            this.colType.FieldName = "Attribute.ValueType";
            this.colType.Name = "colType";
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // colReferenceType
            // 
            this.colReferenceType.Caption = "ReferenceType";
            this.colReferenceType.FieldName = "Attribute.ReferenceType";
            this.colReferenceType.Name = "colReferenceType";
            // 
            // AttributesEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.termValueGridControl);
            this.Name = "AttributesEditor";
            this.Size = new System.Drawing.Size(394, 336);
            ((System.ComponentModel.ISupportInitialize)(this.termValueGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termValueGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl termValueGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView termValueGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colTermName;
        private DevExpress.XtraGrid.Columns.GridColumn colValue;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceType;
    }
}
