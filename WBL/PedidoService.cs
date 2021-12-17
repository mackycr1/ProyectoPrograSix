﻿using Entity;
using DB;
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
        private readonly IDataAccess sql;

        public PedidoService(IDataAccess sql)
        {
            this.sql = sql;
        }

    
        public async Task<DBEntity> Insert(PedidoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PedidoInsertar", new
                {
                    entity.IdCliente,
                    entity.Codigo,
                    entity.Fecha,
                    entity.Envio,
                    entity.SubTotal,
                    entity.IVA,
                    entity.Total
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DBEntity> Update(PedidoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PedidoActualizar", new
                {
                    entity.IdPedido,
                    entity.IdCliente,
                    entity.Codigo,
                    entity.Fecha,
                    entity.Envio,
                    entity.SubTotal,
                    entity.IVA,
                    entity.Total
                });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<DBEntity> Delete(PedidoEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("PedidoEliminar", new { entity.IdPedido });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<PedidoEntity>> Get()
        {
            try
            {
                var result = sql.QueryAsync<PedidoEntity, ClienteEntity>("PedidoObtener", "IdPedido,IdCliente");
                return await result;

            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<PedidoEntity> GetById(PedidoEntity entity)
        {
            try
            {
                var result = sql.QueryFirstAsync<PedidoEntity>("PedidoObtener", new { entity.IdPedido });
                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
  


}


