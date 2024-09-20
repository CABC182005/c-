using Entity.DTO;
using Entity.Model.Security;

namespace Business.Interface
{
    public interface IPersonBusiness
    {
        Task Delete(int id);
        Task<IEnumerable<PersonDto>> GetAll();
        Task<PersonDto> GetById(int id);
        Task<Person> Save(PersonDto entity);
        Task Update(PersonDto entity);
    }
}
