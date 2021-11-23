using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WBL
{
    public interface IUsuarioService
    {
        Task<IEnumerable<ProductoEntity>> Get();

        Task<ProductoEntity> GetById(UsuarioEntity entity);
    }

    public class UsuarioService : IUsuarioService
    {
        public Task<IEnumerable<ProductoEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<ProductoEntity> GetById(UsuarioEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
