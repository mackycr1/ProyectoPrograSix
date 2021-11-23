using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBL
{
    public interface IRegistrarUsuarioService
    {
        Task<DBEntity> Insert(RegistrarNuevoUsuarioEntity entity);
        Task<DBEntity> Update(RegistrarNuevoUsuarioEntity entity);
        Task<DBEntity> Delete(RegistrarNuevoUsuarioEntity entity);
    }

    public class RegistrarUsuarioService : IRegistrarUsuarioService
    {
        public Task<DBEntity> Delete(RegistrarNuevoUsuarioEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DBEntity> Insert(RegistrarNuevoUsuarioEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DBEntity> Update(RegistrarNuevoUsuarioEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
