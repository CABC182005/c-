using Entity.DTO;
using Entity.Model.Security;

namespace Business.Interface
{
    public interface IRoleBusiness
    {
        Task Delete(int id);
        Task<IEnumerable<RoleDto>> GetAll();
        Task<RoleDto> GetById(int id);
        Task<Role> Save(RoleDto entity);
        Task Update(RoleDto entity);
    }
}
