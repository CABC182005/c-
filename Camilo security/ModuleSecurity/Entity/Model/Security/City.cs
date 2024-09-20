namespace Entity.Model.Security
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string postal_code { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }

    }
}
