using System.Data;
using System.Data.SqlClient;

namespace RichEditMasterDetailMailMerge {
    public static class NorthwindDataProvider {
        private static string connectionString = @"Data Source=.\SQLExpress;Initial Catalog=Northwind;Integrated Security=SSPI";

        static NorthwindDataProvider() {
            using (SqlConnection connection = new SqlConnection(connectionString)) {
                SqlCommand selectCommand = new SqlCommand("SELECT * FROM Categories", connection);
                SqlDataAdapter da = new SqlDataAdapter(selectCommand);

                categories = new DataTable("Categories");
                products = new DataTable("Products");

                da.Fill(categories);
                selectCommand.CommandText = "SELECT * FROM Products";
                da.Fill(products);

                categories.Constraints.Add("IDPK", categories.Columns["CategoryID"], true);
                products.Constraints.Add("IDPK", products.Columns["ProductID"], true);
 
                selectCommand.Dispose();
            }
        }

        private static DataTable categories;

        public static DataTable Categories {
            get {
                return categories;
            }
        }

        private static DataTable products;

        public static DataTable Products {
            get {
                return products;
            }
        }

        public static DataTable GetProductsByCategoryId(int categoryId) {
            DataView dataView = new DataView(Products, string.Format("CategoryID = {0}", categoryId), string.Empty, DataViewRowState.CurrentRows);

            return dataView.ToTable("ProductsOfCategory");
        }
    }
}