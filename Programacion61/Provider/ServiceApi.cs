using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Programacion61
{
    public class ServiceApi
    {
        private readonly HttpClient client;

        public ServiceApi(HttpClient client)
        {
            this.client = client;
        }
        #region Usuario

        public async Task<UsuarioEntity> UsuarioLogin(UsuarioEntity entity)
        {

            var result = await client.ServicioPostAsync<UsuarioEntity>("api/Usuarios/Login",entity);

            return result;
        }

        #endregion
    }
}
