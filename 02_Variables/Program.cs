using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.85;
            //Console.WriteLine(number);

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine($"Elma : {applePrice} Tl");
            //Console.WriteLine($"Portakal : {orangePrice} Tl");
            //Console.WriteLine($"Çilek : {strawberryPrice} Tl");
            //Console.WriteLine($"Patates : {potatoPrice} Tl");
            //Console.WriteLine($"Domates : {tomatoPrice} Tl");

            #endregion

            #region Char Değişkenler
            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("*** CSharp Hava Yolları Yolcu Bilgisi ***");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity,passengerAge,passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName =Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname =Console.ReadLine();

            //Console.Write("Yolcu İlçe:");
            //passengerDistrict =Console.ReadLine();

            //Console.Write("Yolcu şehir:");
            //passengerCity =Console.ReadLine();

            //Console.Write("Yolcu Yaş:");
            //passengerAge =Console.ReadLine();

            //Console.Write("Yolcu Kimlik No:");
            //passengerIdentityNumber =Console.ReadLine();


            //Console.WriteLine("----------------------------------");

            //Console.WriteLine($"Yolcu : {passengerName} {passengerSurname} {passengerDistrict} {passengerCity} {passengerIdentityNumber}");
            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoePrice, computerPrice, chairPrice, tvPrice;

            //shoePrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Ayakkabı Sayısı: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Bilgisayar Sayısı: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Sandalye Sayısı: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Tv Sayısı: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice=shoesCount*shoePrice+computerCount*computerPrice+chairCount*chairPrice+tvCount*tvPrice;
            //Console.WriteLine("Toplam Tutar : "+totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            // double exam1, exam2, exam3,result;

            // Console.Write("1. Sınav Notu : ");
            // exam1=double.Parse(Console.ReadLine());

            // Console.Write("2. Sınav Notu : ");
            // exam2 = double.Parse(Console.ReadLine());

            // Console.Write("3. Sınav Notu : ");
            // exam3 = double.Parse(Console.ReadLine());

            //result=(exam1+exam2+exam3)/3;

            // Console.WriteLine("Sınav Ortalamanız :"+result);

            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Cinsiyet Giriniz : ");
            //gender =char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : "+gender);


            #endregion
            Console.Read();

        }
    }
}
