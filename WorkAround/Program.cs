using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Business.Concrete;

namespace WorkAround
{
    class Program
    {

        static void Main (string[] args)
        {
            //Degiskenler()

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayse");
            SelamVer();

            int sonuc1 = Topla(3,5);

            int sonuc2 = Topla();

            int sonuc3= Topla(50);

            int sonuc4 = Topla(6, 58);



            //Diziler - Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            Console.WriteLine(ogrenci1);
            Console.WriteLine(ogrenci2);
            Console.WriteLine(ogrenci3);



            /*
            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            */

            // ogrenciler[3] = "İlker";  burada aşım var.

            string [] ogrenciler = new string[4];
            ogrenciler[3] = "İlker";


            //Sadece İlker ekranda yazıldı.
            // New, heapte yeni bir alan tanımlar. (steak-heap yönetimi)
            //garbage collector; en son tanımlanan ve  kullanılmayan [0] [1] [2] membersları atar/siler heapten. 
            // array, class, interface, abstract referans tiplidir. (heapte gerçekleşir)
            // int,double,bool değer türlüdür. (stackte gerçekleşir)

            /* 
            int sayi1 = 10;
            int sayi2 = 20;
            sayi2 = sayi1;
            // burada değer ataması yapılır. sayi2= 10 oldu
            sayi1 = 30;
            // burada sayi2=10 ve sayi1=30 olur.
           */





            for (int i=0; i< ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);

            }


            string[] sehirler1 = new[] { "Ankara", "Istanbul", "Izmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakir" };


            sehirler2 = sehirler1;

            // burada array olduğu için deger ataması değil adres ataması yapıldı.

            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);



            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);

            }

            

            List<string> yeniSehirler1 = new List<string> { "Ankara 1", "Istanbul 1", "Izmir 1" };
            yeniSehirler1.Add("Adana 1");


            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);

            }


            Person person1= new Person();
            person1.FirstName = "ENGIN";
            person1.LastName = "DEMİROG";
            person1.DateofBirthYear = 1985;
            person1.NationalIdentity = 123;




        


            PttManager pttManager = new PttManager (new PersonManager());
            pttManager.GiveMask(person1);

             
            Console.ReadLine();


        }

        // resharper

        static void SelamVer(string isim = "isimsiz")
        {

            Console.WriteLine("Merhaba " + isim);

        }



        static int Topla(int sayi1 = 5, int sayi2= 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Topla "+ sonuc );
            return sonuc ;


        }


        


        private static void Degiskenler()
        {

            string mesaj = "Merhaba";
            double tutar = 100000; // db (database) den gelir
            int sayi = 100;
            bool girisYapmisMi = false;


            string ad = "Engin";
            string soyad = "Demirog";
            int dogumYili = 1985;
            long tcNo = 12345678910;


            Console.WriteLine(tutar * 1.18);

            Console.WriteLine(tutar * 1.18);

        }




    }

    


    // pascal casing : Classlar, methodlar, propertiler PascalCasede ile yazılır
    public class Vatandas
    {

       public string Ad { get; set;}
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }
    }

}
