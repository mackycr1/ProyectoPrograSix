using DB;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WBL
{
    public interface IUsuarioService
    {
        Task<DBEntity> Login(UsuarioEntity entity);
        Task<DBEntity> Create(UsuarioEntity entity);
        Task<DBEntity> Update(UsuarioEntity entity);
        Task<DBEntity> Delete(UsuarioEntity entity);
        Task<IEnumerable<UsuarioEntity>> Get();
        Task<ProductoEntity> GetById(UsuarioEntity entity);

        Task<IEnumerable<UsuarioEntity >> GetLista();
    }

    public class UsuarioService : IUsuarioService
    {
        private readonly IDataAccess sql;

        public UsuarioService(IDataAccess _sql)
        {
            sql = _sql;
        }

        #region MetodosCrud
        public async Task<DBEntity> Create(UsuarioEntity entity)
        {
            try
            {
                var result = sql.ExecuteAsync("UsuarioInsertar", new
                {
                    entity.Usuario,
                    entity.Nombre,
                    entity.Clave,
                    entity.Estado,
                    entity.Rol_id
                });

                return await result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        Task<DBEntity> IUsuarioService.Delete(UsuarioEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<UsuarioEntity>> IUsuarioService.Get()
        {
            throw new NotImplementedException();
        }

        Task<ProductoEntity> IUsuarioService.GetById(UsuarioEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<UsuarioEntity>> IUsuarioService.GetLista()
        {
            throw new NotImplementedException();
        }

        Task<DBEntity> IUsuarioService.Login(UsuarioEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<DBEntity> IUsuarioService.Update(UsuarioEntity entity)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
