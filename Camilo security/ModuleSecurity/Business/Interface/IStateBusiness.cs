﻿using Entity.DTO;
using Entity.Model.Security;

namespace Business.Interface
{
    public interface IStateBusiness
    {
        Task<IEnumerable<StateDto>> GetAll();
        Task<StateDto> GetById(int id);
        Task<State> Save(StateDto entity);
        Task Update(StateDto entity);
        Task Delete(int id);
    }
}
