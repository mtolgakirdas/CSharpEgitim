using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Konu11DatabaseCRUD
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create - Read - Update - Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("--------------------------");
            #region Kategori Ekleme İşlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source =DESKTOP-0PQGLKB\\SQLEXPRESS;initial catalog=EgitimKampiDB;integrated security = true;");

            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1)",connection);
            //command.Parameters.AddWithValue("@p1",categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Başarılı Şekilde Eklendi");
            #endregion

            #region Ürün Ekleme İşlemi
            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürün Adı :");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fıyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =DESKTOP-0PQGLKB\\SQLEXPRESS;initial catalog=EgitimKampiDB;integrated security = true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün Eklemesi Başarılı");



            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source =DESKTOP-0PQGLKB\\SQLEXPRESS;initial catalog=EgitimKampiDB;integrated security = true;");
            //connection.Open();
            //SqlCommand cmd = new SqlCommand("select * from TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);
            //foreach (DataRow row in dataTable.Rows)
            //{
            //   foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString()+" ");
            //    }
            //   Console.WriteLine();
            //}



            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silinecek ürün Id : ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source =DESKTOP-0PQGLKB\\SQLEXPRESS;initial catalog=EgitimKampiDB;integrated security = true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();



            //connection.Close();
            //Console.WriteLine("Silme İşlemi Başarılı");

            #endregion

            #region Ürün Güncelleme İşlemi
            //Console.Write("Güncellenecek Ürün Id: ");
            
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source =DESKTOP-0PQGLKB\\SQLEXPRESS;initial catalog=EgitimKampiDB;integrated security = true;");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();


            //connection.Close();
            //Console.WriteLine("Güncelleme Başarılı");
            #endregion


            Console.Read();


        }
    }
}
