using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WBL
{

    public interface ICategoriaService
    {
        Task<DBEntity> Insert(CategoriaEntity entity);
        Task<DBEntity> Update(CategoriaEntity entity);
        Task<DBEntity> Delete(CategoriaEntity entity);
        Task<IEnumerable<CategoriaEntity>> Get();
        Task<CategoriaEntity> GetById(CategoriaEntity entity);
    }

    public class CategoriaService : ICategoriaService
    {
        public Task<DBEntity> Delete(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriaEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaEntity> GetById(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DBEntity> Insert(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DBEntity> Update(CategoriaEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
