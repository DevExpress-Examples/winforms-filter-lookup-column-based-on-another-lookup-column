namespace DxSample {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.PhonesSource = new System.Windows.Forms.BindingSource();
            this.CountriesSource = new System.Windows.Forms.BindingSource();
            this.CitiesSource = new System.Windows.Forms.BindingSource();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.GridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountryCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CountryEditor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colCityCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CityEditor = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.PhonesSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountriesSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CitiesSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryEditor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // PhonesSource
            // 
            this.PhonesSource.DataSource = typeof(DxSample.Models.Phone);
            // 
            // CountriesSource
            // 
            this.CountriesSource.DataSource = typeof(DxSample.Models.Country);
            // 
            // CitiesSource
            // 
            this.CitiesSource.DataSource = typeof(DxSample.Models.City);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.PhonesSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.GridView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.CountryEditor,
            this.CityEditor});
            this.gridControl1.Size = new System.Drawing.Size(422, 253);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GridView});
            // 
            // GridView
            // 
            this.GridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colCountryCode,
            this.colCityCode});
            this.GridView.GridControl = this.gridControl1;
            this.GridView.Name = "GridView";
            this.GridView.ShownEditor += new System.EventHandler(this.GridView_ShownEditor);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colCountryCode
            // 
            this.colCountryCode.ColumnEdit = this.CountryEditor;
            this.colCountryCode.FieldName = "CountryCode";
            this.colCountryCode.Name = "colCountryCode";
            this.colCountryCode.Visible = true;
            this.colCountryCode.VisibleIndex = 1;
            // 
            // CountryEditor
            // 
            this.CountryEditor.AutoHeight = false;
            this.CountryEditor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CountryEditor.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 43, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.CountryEditor.DataSource = this.CountriesSource;
            this.CountryEditor.DisplayMember = "Name";
            this.CountryEditor.Name = "CountryEditor";
            this.CountryEditor.ValueMember = "CountryCode";
            this.CountryEditor.EditValueChanged += new System.EventHandler(this.CountryEditor_EditValueChanged);
            // 
            // colCityCode
            // 
            this.colCityCode.ColumnEdit = this.CityEditor;
            this.colCityCode.FieldName = "CityCode";
            this.colCityCode.Name = "colCityCode";
            this.colCityCode.Visible = true;
            this.colCityCode.VisibleIndex = 2;
            // 
            // CityEditor
            // 
            this.CityEditor.AutoHeight = false;
            this.CityEditor.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CityEditor.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 43, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.CityEditor.DataSource = this.CitiesSource;
            this.CityEditor.DisplayMember = "Name";
            this.CityEditor.Name = "CityEditor";
            this.CityEditor.ValueMember = "CityCode";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 253);
            this.Controls.Add(this.gridControl1);
            this.Name = "MainForm";
            this.Text = "Dx Sample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PhonesSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountriesSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CitiesSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountryEditor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityEditor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource PhonesSource;
        private System.Windows.Forms.BindingSource CountriesSource;
        private System.Windows.Forms.BindingSource CitiesSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView GridView;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCountryCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit CountryEditor;
        private DevExpress.XtraGrid.Columns.GridColumn colCityCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit CityEditor;
    }
}

