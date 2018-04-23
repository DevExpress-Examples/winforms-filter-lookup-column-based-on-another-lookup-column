Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub FillDataSet()
			dataSet11.Countries.AddCountriesRow("USA", "1", 1)
			dataSet11.Countries.AddCountriesRow("Germany", "49", 2)
			dataSet11.Countries.AddCountriesRow("France", "33", 3)
			dataSet11.Countries.AddCountriesRow("Great Britain", "44", 4)
			dataSet11.Countries.AddCountriesRow("Italy", "39", 5)
			dataSet11.Countries.AddCountriesRow("Russia", "7", 6)

			dataSet11.Cities.AddCitiesRow("Washington", "202", "1", 1)
			dataSet11.Cities.AddCitiesRow("Los Angeles", "213", "1", 2)
			dataSet11.Cities.AddCitiesRow("San Francisco", "415", "1", 3)
			dataSet11.Cities.AddCitiesRow("New-York", "718", "1", 4)
			dataSet11.Cities.AddCitiesRow("Berlin", "30", "49", 5)
			dataSet11.Cities.AddCitiesRow("Bonn", "228", "49", 6)
			dataSet11.Cities.AddCitiesRow("Munhen", "89", "49", 7)
			dataSet11.Cities.AddCitiesRow("Paris", "1", "33", 8)
			dataSet11.Cities.AddCitiesRow("Lion", "19", "33", 9)
			dataSet11.Cities.AddCitiesRow("London", "1274", "44", 10)
			dataSet11.Cities.AddCitiesRow("Glasgo", "141", "44", 11)
			dataSet11.Cities.AddCitiesRow("Rome", "6", "39", 12)
			dataSet11.Cities.AddCitiesRow("Milan", "2", "39", 13)
			dataSet11.Cities.AddCitiesRow("Moscow", "495", "7", 14)

			dataSet11.Phones.AddPhonesRow(1, "39", "6", "xxx")
			dataSet11.Phones.AddPhonesRow(2, "33", "19", "yyy")
			dataSet11.Phones.AddPhonesRow(3, "1", "202", "zzz")
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			FillDataSet()
		End Sub

		Private clone As DataView = Nothing

		Private Sub gridView1_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView1.ShownEditor
			Dim view As DevExpress.XtraGrid.Views.Grid.GridView
			view = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
			If view.FocusedColumn.FieldName = "CityCode" AndAlso TypeOf view.ActiveEditor Is DevExpress.XtraEditors.LookUpEdit Then
				Dim edit As DevExpress.XtraEditors.LookUpEdit
				edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)

				Dim bs As BindingSource = CType(edit.Properties.DataSource, BindingSource)
				Dim table As DataTable = (CType(bs.DataSource, DataSet)).Tables(bs.DataMember)
				clone = New DataView(table)
				Dim row As DataRow = view.GetDataRow(view.FocusedRowHandle)
				clone.RowFilter = "[CountryCode] = " & row("CountryCode").ToString()
				edit.Properties.DataSource = New BindingSource(clone, "")
			End If
		End Sub

		Private Sub gridView1_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridView1.HiddenEditor
			If clone IsNot Nothing Then
				clone.Dispose()
				clone = Nothing
			End If
		End Sub

		Private Sub repositoryItemLookUpEdit1_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles repositoryItemLookUpEdit1.EditValueChanged
			Dim view As DevExpress.XtraGrid.Views.Grid.GridView = gridView1
			view.SetRowCellValue(view.FocusedRowHandle, "CityCode", DBNull.Value)
		End Sub
	End Class
End Namespace