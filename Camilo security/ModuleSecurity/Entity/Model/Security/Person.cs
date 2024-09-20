namespace Entity.Model.Security
{
    public class Person
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Email { get; set; }
        public string Addres { get; set; }
        public string Type_document { get; set; }
        public string Document { get; set; }
        public DateTime Birth_of_date { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public string Phone { get; set; }
        public State State { get; set; }
        public int  CityId { get; set; }

        public  City City { get; set; }
       

    }
}
