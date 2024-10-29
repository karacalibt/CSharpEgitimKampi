using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaeCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            //Console.WriteLine("***** Menü Sipariş İşlem Paneli ******");
            //Console.WriteLine("");

            //Console.WriteLine("-------------------------------");
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DELLBTPC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Category (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();

            //Console.WriteLine("Kategori başarıyla eklendi!");

            //connection.Close();
            //SqlCommand cm1 = new SqlCommand("select * from Category", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cm1);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow item in dataTable.Rows)
            //{
            //    Console.WriteLine(string.Join(", " ,item.ItemArray));
            //}


            //Console.Write("Ürün Adı: ");
            //string productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı: ");
            //decimal productPrice = Convert.ToDecimal(Console.ReadLine());
            //Console.Write("Ürün Aktif mi? (true/false): ");
            //bool productStatus = Convert.ToBoolean(Console.ReadLine());

            //string connectionString = "Data Source=DELLBTPC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True";
            //SqlConnection connection = new SqlConnection(connectionString);


            //connection.Open();
            //    SqlCommand command = new SqlCommand("insert into Product (ProductName, ProductPrice, ProductStatus) values (@p1, @p2, @p3)", connection);
            //    command.Parameters.AddWithValue("@p1", productName);
            //    command.Parameters.AddWithValue("@p2", productPrice);
            //    command.Parameters.AddWithValue("@p3", productStatus);
            //    command.ExecuteNonQuery();
            //    Console.WriteLine("Ürün başarıyla eklendi!");

            //    SqlCommand cmd = new SqlCommand("select * from Product", connection);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataTable dataTable = new DataTable();
            //    da.Fill(dataTable);

            //    foreach (DataRow row in dataTable.Rows)
            //    {
            //        Console.WriteLine($"{row["ProductName"]}, {row["ProductPrice"]}, {row["ProductStatus"]}");
            //    }

            //Console.Write("Silinecek Ürün Id: ");
            //int productId = Convert.ToInt32(Console.ReadLine());



            //SqlConnection connection = new SqlConnection("Data Source=DELLBTPC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From Product Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //Console.WriteLine("Ürün başarıyla silindi!");
            //connection.Close();

            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            Console.Write("Ürün Aktif mi? (true/false): ");
            bool productStatus = bool.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DELLBTPC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();

            SqlCommand command = new SqlCommand("Update Product Set ProductName = @productName, ProductPrice = @productPrice, ProductStatus = @productStatus Where ProductId = @productId", connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productStatus", productStatus);
            command.ExecuteNonQuery();

            Console.WriteLine("Ürün başarıyla güncellendi!");
            connection.Close();

            



            Console.Read();

        }
    }
}
