"use strict";
var App;
(function (App) {
    var AxiosProvider;
    (function (AxiosProvider) {
        //export const GuardarEmpleado = () => axios.get<Entity.DBEntity>("aplicacion").then(({data})=>data );
        AxiosProvider.UsuarioEliminar = function (id) { return axios.delete("Usuario/Grid?handler=Eliminar&id=" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.UsuarioGuardar = function (entity) { return axios.post("Usuario/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        /*Cliente*/
        AxiosProvider.ClienteEliminar = function (id) { return axios.delete("Cliente/Grid?handler=Delete&id=" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ClienteGuardar = function (entity) { return axios.post("Cliente/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        /*Categoria*/
        AxiosProvider.CategoriaEliminar = function (id) { return axios.delete("Categoria/Grid?handler=Delete&id=" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CategoriaGuardar = function (entity) { return axios.post("Categoria/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        /*Producto*/
        AxiosProvider.ProductoEliminar = function (id) { return axios.delete("Producto/Grid?handler=Delete&id=" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoGuardar = function (entity) { return axios.post("Producto/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        /*Pedido*/
        AxiosProvider.PedidoEliminar = function (id) { return axios.delete("Pedido/Grid?handler=Delete&id=" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.PedidoGuardar = function (entity) { return axios.post("Pedido/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
    })(AxiosProvider = App.AxiosProvider || (App.AxiosProvider = {}));
})(App || (App = {}));
//# sourceMappingURL=AxiosProvider.js.map