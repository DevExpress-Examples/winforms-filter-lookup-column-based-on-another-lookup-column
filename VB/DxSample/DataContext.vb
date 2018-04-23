Imports DxSample.Models
Imports System.Collections.Generic
Imports System.Linq

Namespace DxSample
	Public NotInheritable Class DataContext

		Private Sub New()
		End Sub

		Private Shared ReadOnly Cities As IEnumerable(Of City)
		Private Shared ReadOnly Countries As IEnumerable(Of Country)
		Private Shared ReadOnly Phones As IEnumerable(Of Phone)

		Shared Sub New()
			DataContext.Cities = New City() {
				New City() With {.ID = 1, .Name = "Washington", .CityCode = "202", .CountryCode = "1"},
				New City() With {.ID = 2, .Name = "Los Angeles", .CityCode = "213", .CountryCode = "1"},
				New City() With {.ID = 3, .Name = "San Francisco", .CityCode = "415", .CountryCode = "1"},
				New City() With {.ID = 4, .Name = "New-York", .CityCode = "718", .CountryCode = "1"},
				New City() With {.ID = 5, .Name = "Berlin", .CityCode = "30", .CountryCode = "49"},
				New City() With {.ID = 6, .Name = "Bonn", .CityCode = "228", .CountryCode = "49"},
				New City() With {.ID = 7, .Name = "Munhen", .CityCode = "89", .CountryCode = "49"},
				New City() With {.ID = 8, .Name = "Paris", .CityCode = "1", .CountryCode = "33"},
				New City() With {.ID = 9, .Name = "Lion", .CityCode = "19", .CountryCode = "33"},
				New City() With {.ID = 10, .Name = "London", .CityCode = "1274", .CountryCode = "44"},
				New City() With {.ID = 11, .Name = "Glasgo", .CityCode = "141", .CountryCode = "44"},
				New City() With {.ID = 12, .Name = "Rome", .CityCode = "6", .CountryCode = "39"},
				New City() With {.ID = 13, .Name = "Milan", .CityCode = "2", .CountryCode = "39"},
				New City() With {.ID = 14, .Name = "Moscow", .CityCode = "495", .CountryCode = "7"}
			}
			DataContext.Countries = New Country() {
				New Country() With {.ID = 1, .Name = "USA", .CountryCode = "1"},
				New Country() With {.ID = 2, .Name = "Germany", .CountryCode = "49"},
				New Country() With {.ID = 3, .Name = "France", .CountryCode = "33"},
				New Country() With {.ID = 4, .Name = "Great Britain", .CountryCode = "44"},
				New Country() With {.ID = 5, .Name = "Italy", .CountryCode = "39"},
				New Country() With {.ID = 6, .Name = "Russia", .CountryCode = "7"}
			}
			DataContext.Phones = New Phone() {
				New Phone() With {.ID = 1, .Name = "xxx", .CountryCode = "39", .CityCode = "6"},
				New Phone() With {.ID = 2, .Name = "yyy", .CountryCode = "33", .CityCode = "19"},
				New Phone() With {.ID = 3, .Name = "zzz", .CountryCode = "1", .CityCode = "202"}
			}
		End Sub

		Public Shared Function GetPhones() As List(Of Phone)
			Return DataContext.Phones.ToList()
		End Function

		Public Shared Function GetCountries() As List(Of Country)
			Return DataContext.Countries.ToList()
		End Function

		Public Shared Function GetAllCities() As List(Of City)
			Return DataContext.Cities.ToList()
		End Function

		Public Shared Function GetCitiesByCountryCode(ByVal countryCode As String) As List(Of City)
			Return DataContext.Cities.Where(Function(c) c.CountryCode = countryCode).ToList()
		End Function
	End Class
End Namespace
