Namespace DxSample
	Partial Public Class MainForm
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.PhonesSource = New System.Windows.Forms.BindingSource()
			Me.CountriesSource = New System.Windows.Forms.BindingSource()
			Me.CitiesSource = New System.Windows.Forms.BindingSource()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountryCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.CountryEditor = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.colCityCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.CityEditor = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			DirectCast(Me.PhonesSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.CountriesSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.CitiesSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.CountryEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.CityEditor, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' PhonesSource
			' 
			Me.PhonesSource.DataSource = GetType(DxSample.Models.Phone)
			' 
			' CountriesSource
			' 
			Me.CountriesSource.DataSource = GetType(DxSample.Models.Country)
			' 
			' CitiesSource
			' 
			Me.CitiesSource.DataSource = GetType(DxSample.Models.City)
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.PhonesSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.GridView
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.CountryEditor, Me.CityEditor})
			Me.gridControl1.Size = New System.Drawing.Size(422, 253)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.GridView})
			' 
			' GridView
			' 
			Me.GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colCountryCode, Me.colCityCode})
			Me.GridView.GridControl = Me.gridControl1
			Me.GridView.Name = "GridView"
'			Me.GridView.ShownEditor += New System.EventHandler(Me.GridView_ShownEditor)
			' 
			' colName
			' 
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' colCountryCode
			' 
			Me.colCountryCode.ColumnEdit = Me.CountryEditor
			Me.colCountryCode.FieldName = "CountryCode"
			Me.colCountryCode.Name = "colCountryCode"
			Me.colCountryCode.Visible = True
			Me.colCountryCode.VisibleIndex = 1
			' 
			' CountryEditor
			' 
			Me.CountryEditor.AutoHeight = False
			Me.CountryEditor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.CountryEditor.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
			Me.CountryEditor.DataSource = Me.CountriesSource
			Me.CountryEditor.DisplayMember = "Name"
			Me.CountryEditor.Name = "CountryEditor"
			Me.CountryEditor.ValueMember = "CountryCode"
'			Me.CountryEditor.EditValueChanged += New System.EventHandler(Me.CountryEditor_EditValueChanged)
			' 
			' colCityCode
			' 
			Me.colCityCode.ColumnEdit = Me.CityEditor
			Me.colCityCode.FieldName = "CityCode"
			Me.colCityCode.Name = "colCityCode"
			Me.colCityCode.Visible = True
			Me.colCityCode.VisibleIndex = 2
			' 
			' CityEditor
			' 
			Me.CityEditor.AutoHeight = False
			Me.CityEditor.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.CityEditor.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 43, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
			Me.CityEditor.DataSource = Me.CitiesSource
			Me.CityEditor.DisplayMember = "Name"
			Me.CityEditor.Name = "CityEditor"
			Me.CityEditor.ValueMember = "CityCode"
			' 
			' MainForm
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(422, 253)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "MainForm"
			Me.Text = "Dx Sample"
'			Me.Load += New System.EventHandler(Me.MainForm_Load)
			DirectCast(Me.PhonesSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.CountriesSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.CitiesSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.CountryEditor, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.CityEditor, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private PhonesSource As System.Windows.Forms.BindingSource
		Private CountriesSource As System.Windows.Forms.BindingSource
		Private CitiesSource As System.Windows.Forms.BindingSource
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountryCode As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents CountryEditor As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private colCityCode As DevExpress.XtraGrid.Columns.GridColumn
		Private CityEditor As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
	End Class
End Namespace

