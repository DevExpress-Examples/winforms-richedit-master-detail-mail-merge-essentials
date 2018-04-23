Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient

Namespace RichEditMasterDetailMailMerge
	Public NotInheritable Class NorthwindDataProvider
		Private Shared connectionString As String = "Data Source=.\SQLExpress2008;Initial Catalog=Northwind;Integrated Security=SSPI"

		Private Sub New()
		End Sub
		Shared Sub New()
			Using connection As New SqlConnection(connectionString)
				Dim selectCommand As New SqlCommand("SELECT * FROM Categories", connection)
				Dim da As New SqlDataAdapter(selectCommand)

				categories_Renamed = New DataTable("Categories")
				products_Renamed = New DataTable("Products")

				da.Fill(categories_Renamed)
				selectCommand.CommandText = "SELECT * FROM Products"
				da.Fill(products_Renamed)

				categories_Renamed.Constraints.Add("IDPK", categories_Renamed.Columns("CategoryID"), True)
				products_Renamed.Constraints.Add("IDPK", products_Renamed.Columns("ProductID"), True)

				selectCommand.Dispose()
			End Using
		End Sub

		Private Shared categories_Renamed As DataTable

		Public Shared ReadOnly Property Categories() As DataTable
			Get
				Return categories_Renamed
			End Get
		End Property

		Private Shared products_Renamed As DataTable

		Public Shared ReadOnly Property Products() As DataTable
			Get
				Return products_Renamed
			End Get
		End Property

		Public Shared Function GetProductsByCategoryId(ByVal categoryId As Integer) As DataTable
			Dim dataView As New DataView(Products, String.Format("CategoryID = {0}", categoryId), String.Empty, DataViewRowState.CurrentRows)

			Return dataView.ToTable("ProductsOfCategory")
		End Function
	End Class
End Namespace