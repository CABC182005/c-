using Business.Interface;
using Data.Interfaces;
using Entity.DTO;
using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Business.Implements
{
    public class StateBusiness : IStateBusiness
    {
        protected readonly IStateData data;
        private IEnumerable<StateDto> stateDtos;

        public StateBusiness(IStateData data)
        {
            this.data = data;
        }

        // Eliminar un estado por id
        public async Task Delete(int id)
        {
            await this.data.Delete(id);
        }

        // Obtener todos los estados
        public async Task<IEnumerable<StateDto>> GetAll()
        {
            IEnumerable<State> states = await this.data.GetAll();
           // var stateDtos = states.Select(state => new StateDto
            //{
             //   Id = state.Id,
              //  Name = state.Name,
               // CountriesId = state.CountriesId
            //});
            return stateDtos;
        }

        // Obtener todos los estados en formato DataSelectDto
        public async Task<IEnumerable<DataSelectDto>> GetAllSelect()
        {
            return await this.data.GetAllSelect();
        }

        // Obtener estado por id
        public async Task<StateDto> GetById(int id)
        {
            State state = await this.data.GetById(id);
            if (state == null)
            {
                throw new Exception("Registro no encontrado");
            }

            return new StateDto
            {
                Id = state.Id,
                Name = state.Name,
                CountriesId = state.CountriesId
            };
        }

        // Mapeo de datos entre State y StateDto
        public State MapearDatos(State state, StateDto entity)
        {
            state.Name = entity.Name;
            state.CountriesId = entity.CountriesId;
            return state;
        }

        // Guardar un nuevo estado
        public async Task<State> Save(StateDto entity)
        {
            State state = new State
            {
                CreateAt = DateTime.Now.AddHours(-5) // Ajuste de zona horaria
            };

            state = this.MapearDatos(state, entity);
            return await this.data.Save(state);
        }

        // Actualizar un estado existente
        public async Task Update(StateDto entity)
        {
            State state = await this.data.GetById(entity.Id);
            if (state == null)
            {
                throw new Exception("Registro no encontrado");
            }

            state = this.MapearDatos(state, entity);
            await this.data.Update(state);
        }
    }
}
