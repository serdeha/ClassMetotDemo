using System.Collections.Generic;
using ClassMetotDemo.Entity;
using ClassMetotDemo.Entity.Abstract;

namespace ClassMetotDemo.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<Musteri> GetAll();
        string Add(Musteri musteri);
        string Update(Musteri musteri);
        string Delete(int id);
    }
}
