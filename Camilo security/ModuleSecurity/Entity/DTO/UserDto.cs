using Entity.Model.Security;

namespace Entity.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }

        public Person person { get; set; }

        public Boolean State { get; set; }
        public int PersonId { get; set; }
    }
}
