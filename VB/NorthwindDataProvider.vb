Imports System.Data
Imports System.Data.SqlClient

Namespace RichEditMasterDetailMailMerge

    Public Module NorthwindDataProvider

        Private connectionString As String = "Data Source=.\SQLExpress2008;Initial Catalog=Northwind;Integrated Security=SSPI"

        Sub New()
            Using connection As SqlConnection = New SqlConnection(connectionString)
                Dim selectCommand As SqlCommand = New SqlCommand("SELECT * FROM Categories", connection)
                Dim da As SqlDataAdapter = New SqlDataAdapter(selectCommand)
                categoriesField = New DataTable("Categories")
                productsField = New DataTable("Products")
                da.Fill(categoriesField)
                selectCommand.CommandText = "SELECT * FROM Products"
                da.Fill(productsField)
                categoriesField.Constraints.Add("IDPK", categoriesField.Columns("CategoryID"), True)
                productsField.Constraints.Add("IDPK", productsField.Columns("ProductID"), True)
                selectCommand.Dispose()
            End Using
        End Sub

        Private categoriesField As DataTable

        Public ReadOnly Property Categories As DataTable
            Get
                Return categoriesField
            End Get
        End Property

        Private productsField As DataTable

        Public ReadOnly Property Products As DataTable
            Get
                Return productsField
            End Get
        End Property

        Public Function GetProductsByCategoryId(ByVal categoryId As Integer) As DataTable
            Dim dataView As DataView = New DataView(Products, String.Format("CategoryID = {0}", categoryId), String.Empty, DataViewRowState.CurrentRows)
            Return dataView.ToTable("ProductsOfCategory")
        End Function
    End Module
End Namespace
