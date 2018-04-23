Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Base
Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace DxSample
	Partial Public Class MainForm
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.PhonesSource.DataSource = DataContext.GetPhones()
			Me.CountriesSource.DataSource = DataContext.GetCountries()
			Me.CitiesSource.DataSource = DataContext.GetAllCities()
		End Sub

		Private Sub GridView_ShownEditor(ByVal sender As Object, ByVal e As EventArgs) Handles GridView.ShownEditor
			Dim view As ColumnView = DirectCast(sender, ColumnView)
			If view.FocusedColumn.FieldName = "CityCode" Then
				Dim editor As LookUpEdit = CType(view.ActiveEditor, LookUpEdit)
				Dim countryCode As String = Convert.ToString(view.GetFocusedRowCellValue("CountryCode"))
				editor.Properties.DataSource = DataContext.GetCitiesByCountryCode(countryCode)
			End If
		End Sub

		' In certain scenarios you may want to clear the secondary editor's value
		' You can use the RepositoryItem.EditValueChanged event for this purpose
		Private Sub CountryEditor_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles CountryEditor.EditValueChanged
			Me.GridView.PostEditor()
			Me.GridView.SetFocusedRowCellValue("CityCode", Nothing)
		End Sub
	End Class
End Namespace
