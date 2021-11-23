using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WBL
{
    public interface IUsuario
    {
        Task<DBEntity> Insert(Usuario entity);
        Task<DBEntity> Update(ProductoEntity entity);
        Task<DBEntity> Delete(ProductoEntity entity);
        Task<IEnumerable<ProductoEntity>> Get();
        Task<ProductoEntity> GetById(ProductoEntity entity);
    }

    public class Usuario : IUsuario
    {
        public Task<DBEntity> Delete(ProductoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductoEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<ProductoEntity> GetById(ProductoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DBEntity> Insert(ProductoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DBEntity> Update(ProductoEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
