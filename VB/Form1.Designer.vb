Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
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
			Me.components = New System.ComponentModel.Container()
			Me.bsPhones = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet11 = New WindowsApplication1.DataSet1()
			Me.bsCountries = New System.Windows.Forms.BindingSource(Me.components)
			Me.bsCities = New System.Windows.Forms.BindingSource(Me.components)
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCountryCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.colCityCode = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.bsPhones, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bsCountries, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bsCities, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' bsPhones
			' 
			Me.bsPhones.DataMember = "Phones"
			Me.bsPhones.DataSource = Me.dataSet11
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' bsCountries
			' 
			Me.bsCountries.DataMember = "Countries"
			Me.bsCountries.DataSource = Me.dataSet11
			' 
			' bsCities
			' 
			Me.bsCities.DataMember = "Cities"
			Me.bsCities.DataSource = Me.dataSet11
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.bsPhones
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1, Me.repositoryItemLookUpEdit2})
			Me.gridControl1.Size = New System.Drawing.Size(534, 315)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colCountryCode, Me.colCityCode, Me.colPhone})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.ShownEditor += New System.EventHandler(Me.gridView1_ShownEditor);
'			Me.gridView1.HiddenEditor += New System.EventHandler(Me.gridView1_HiddenEditor);
			' 
			' colID
			' 
			Me.colID.Caption = "ID"
			Me.colID.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.colID.FieldName = "ID"
			Me.colID.Name = "colID"
			Me.colID.Visible = True
			Me.colID.VisibleIndex = 0
			' 
			' colCountryCode
			' 
			Me.colCountryCode.Caption = "CountryCode"
			Me.colCountryCode.ColumnEdit = Me.repositoryItemLookUpEdit1
			Me.colCountryCode.FieldName = "CountryCode"
			Me.colCountryCode.Name = "colCountryCode"
			Me.colCountryCode.Visible = True
			Me.colCountryCode.VisibleIndex = 1
			' 
			' repositoryItemLookUpEdit1
			' 
			Me.repositoryItemLookUpEdit1.AutoHeight = False
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CountryCode", "CountryCode", 91), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 75)})
			Me.repositoryItemLookUpEdit1.DataSource = Me.bsCountries
			Me.repositoryItemLookUpEdit1.DisplayMember = "Country"
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.ValueMember = "CountryCode"
'			Me.repositoryItemLookUpEdit1.EditValueChanged += New System.EventHandler(Me.repositoryItemLookUpEdit1_EditValueChanged);
			' 
			' colCityCode
			' 
			Me.colCityCode.Caption = "CityCode"
			Me.colCityCode.ColumnEdit = Me.repositoryItemLookUpEdit2
			Me.colCityCode.FieldName = "CityCode"
			Me.colCityCode.Name = "colCityCode"
			Me.colCityCode.Visible = True
			Me.colCityCode.VisibleIndex = 2
			' 
			' repositoryItemLookUpEdit2
			' 
			Me.repositoryItemLookUpEdit2.AutoHeight = False
			Me.repositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CityCode", "CityCode", 67), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("City", "City", 51)})
			Me.repositoryItemLookUpEdit2.DataSource = Me.bsCities
			Me.repositoryItemLookUpEdit2.DisplayMember = "City"
			Me.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2"
			Me.repositoryItemLookUpEdit2.ValueMember = "CityCode"
			' 
			' colPhone
			' 
			Me.colPhone.Caption = "Phone"
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			Me.colPhone.Visible = True
			Me.colPhone.VisibleIndex = 3
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(534, 315)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.bsPhones, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bsCountries, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bsCities, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private bsPhones As System.Windows.Forms.BindingSource
		Private dataSet11 As DataSet1
		Private bsCountries As System.Windows.Forms.BindingSource
		Private bsCities As System.Windows.Forms.BindingSource
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCountryCode As DevExpress.XtraGrid.Columns.GridColumn
		Private WithEvents repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private colCityCode As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
	End Class
End Namespace