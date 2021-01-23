using ClassMetotDemo.Entity.Abstract;

namespace ClassMetotDemo.Entity
{
    public class Musteri:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNo { get; set; }
    }
}
