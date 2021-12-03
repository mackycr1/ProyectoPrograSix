
namespace App.AxiosProvider   {

    //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );
    export const UsuarioEliminar = (id) => axios.delete<DBEntity>("Usuario/Grid?handler=Eliminar&id=" + id).then(({ data }) => data);
    export const UsuarioGuardar = (entity) => axios.post<DBEntity>("Usuario/Edit", entity).then(({ data }) => data);

    /*Cliente*/
    export const ClienteEliminar = (id) => axios.delete<DBEntity>("Cliente/Grid?handler=Delete&id=" + id).then(({ data }) => data);
    export const ClienteGuardar = (entity) => axios.post<DBEntity>("Cliente/Edit", entity).then(({ data }) => data);

}




