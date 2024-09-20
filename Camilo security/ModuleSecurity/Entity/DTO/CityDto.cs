using Entity.Model.Security;

namespace Entity.DTO
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }


    }
}
