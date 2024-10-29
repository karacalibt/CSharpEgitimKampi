using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.Net
            string tableNumber;
            Console.WriteLine("***** C# Veri Tabanlı ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarısını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("----------------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=DELLBTPC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From Category", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(string.Join(", ", row.ItemArray));
            }


            Console.Read();
        }
    }
}
