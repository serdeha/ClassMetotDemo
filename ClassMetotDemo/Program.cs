using System;
using ClassMetotDemo.Concrete;
using ClassMetotDemo.Entity;

namespace ClassMetotDemo
{
    class Program
    {
        static MusteriManager _musteriManager = new MusteriManager();
        static void Main(string[] args)
        {
            baslangic:
            Console.WriteLine("\n1 - ) Müşterileri Listele");
            Console.WriteLine("2 - ) Müşteri Ekle");
            Console.WriteLine("3 - ) Müşteri Güncelle");
            Console.WriteLine("4 - ) Müşteri Sil");
            Console.Write("\nLütfen bir işlem seçiniz : ");

            int islem = Convert.ToInt16(Console.ReadLine());

            switch (islem)
            {
                case 1:
                    foreach (Musteri item in _musteriManager.GetAll())
                        Console.WriteLine($"ID : {item.Id}, İsim : {item.FirstName}, Soyisim : {item.LastName}, Tel NO : {item.TelNo}");
                    goto baslangic;
                case 2:
                    Console.Write("\nID giriniz : ");
                    int id = Convert.ToInt16(Console.ReadLine());
                    Console.Write("İsim giriniz : ");
                    string name = Console.ReadLine();
                    Console.Write("Soyisim giriniz : ");
                    string lastName = Console.ReadLine();
                    Console.Write("Tel NO giriniz : ");
                    string telNo = Console.ReadLine();
                    Musteri newMusteri = new Musteri() { Id = id, FirstName = name, LastName = lastName, TelNo = telNo };
                    Console.WriteLine(_musteriManager.Add(newMusteri));
                    goto baslangic;
                case 3:
                    Console.Write("\nID giriniz : ");
                    int updateId = Convert.ToInt16(Console.ReadLine());
                    Console.Write("İsim giriniz : ");
                    string updateName = Console.ReadLine();
                    Console.Write("Soyisim giriniz : ");
                    string updateLastName = Console.ReadLine();
                    Console.Write("Tel NO giriniz : ");
                    string updateTelNo = Console.ReadLine();

                    Musteri updateMusteri = new Musteri()
                    { Id = updateId, FirstName = updateName, LastName = updateLastName, TelNo = updateTelNo };
                    Console.WriteLine(_musteriManager.Update(updateMusteri));
                    goto baslangic;
                case 4:
                    Console.Write("\nID giriniz : ");
                    int selectedId = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine(_musteriManager.Delete(selectedId));
                    goto baslangic;
                default:
                    Console.WriteLine("Yanlış seçim yapıldı.");    
                    goto baslangic;
            }


        }
    }
}
