using Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WBL
{

    public interface IPedidoService
    {
        Task<DBEntity> Insert(PedidoEntity entity);
        Task<DBEntity> Update(PedidoEntity entity);
        Task<DBEntity> Delete(PedidoEntity entity);
        Task<IEnumerable<PedidoEntity>> Get();
        Task<PedidoEntity> GetById(PedidoEntity entity);
    }

    public class PedidoService : IPedidoService
    {
        public Task<DBEntity> Delete(PedidoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PedidoEntity>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<PedidoEntity> GetById(PedidoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DBEntity> Insert(PedidoEntity entity)
        {
            throw new NotImplementedException();
        }

        public Task<DBEntity> Update(PedidoEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
