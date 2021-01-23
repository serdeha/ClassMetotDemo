using ClassMetotDemo.Abstract;
using ClassMetotDemo.Entity;
using System;
using System.Collections.Generic;

namespace ClassMetotDemo.Concrete
{
    public class MusteriManager : IMusteriManager
    {
        List<Musteri> _musteriler;
        public MusteriManager()
        {
            _musteriler = new List<Musteri>()
            {
                new Musteri {Id = 1, FirstName = "Serdeha", LastName = "Mutluay", TelNo = "053333333333"},
                new Musteri {Id = 2, FirstName = "Deneme", LastName = "Test", TelNo = "053333333333"}
            };
        }

        public string Add(Musteri musteri)
        {
            Console.WriteLine("------------------------------------");
            _musteriler.Add(musteri);
            return $"{musteri.FirstName + " " + musteri.LastName} isimli müşteri eklendi.";
        }

        public string Delete(int id)
        {
            Console.WriteLine("------------------------------------");
            foreach (Musteri musteri in _musteriler)
            {
                if (id == musteri.Id)
                {
                    _musteriler.Remove(musteri);
                    return $"{musteri.FirstName + " " + musteri.LastName} isimli müşteri eklendi.";
                }
            }

            return "Müşteri bulunamadı.";
        }

        public List<Musteri> GetAll()
        {
            Console.WriteLine("------------------------------------");
            return _musteriler;
        }

        public string Update(Musteri musteri)
        {
            Console.WriteLine("------------------------------------");
            foreach (Musteri item in _musteriler)
            {
                if(musteri.Id == item.Id)
                {
                    item.FirstName = musteri.FirstName;
                    item.LastName = musteri.LastName;
                    item.TelNo = musteri.TelNo;

                    return $"{musteri.FirstName + " " + musteri.LastName} isimli müşteri güncellendi.";
                }
            }

            return "Müşteri bulunamadı.";
        }
    }
}
