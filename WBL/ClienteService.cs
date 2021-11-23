using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WBL
{
    public interface IClienteService
    {
        Task<DBEntity> Insert(ClienteEntity entity);
        Task<DBEntity> Update(ClienteEntity entity);
        Task<DBEntity> Delete(ClienteEntity entity);
        Task<IEnumerable<ClienteEntity>> Get();
        Task<ClienteEntity> GetById(ClienteEntity entity);
    }

    public class ClienteService : IClienteService
    {
        public Task<DBEntity> Delete(ClienteEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ClienteEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<ClienteEntity> GetById(ClienteEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DBEntity> Insert(ClienteEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DBEntity> Update(ClienteEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
