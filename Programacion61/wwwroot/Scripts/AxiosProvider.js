"use strict";
var App;
(function (App) {
    var AxiosProvider;
    (function (AxiosProvider) {
        /*Usuario*/
        AxiosProvider.UsuarioEliminar = function (id) { return axios.delete("Usuario/Grid?handler=Eliminar&id=" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.UsuarioGuardar = function (entity) { return axios.post("Usuario/Edit", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.UsuarioLogin = function (entity) { return axios.post("Login", entity).then(function (_a) {
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
        //export const CategoriaEliminar = (id) => axios.delete<DBEntity>("Categoria/Grid?handler=Delete&id=" + id).then(({ data }) => data);
        //export const CategoriaGuardar = (entity) => axios.post<DBEntity>("Categoria/Edit", entity).then(({ data }) => data);
        AxiosProvider.CategoriaEliminar = function (id) { return ServiceApi.delete("api/Categoria/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CategoriaGuardar = function (entity) { return ServiceApi.post("api/Categoria", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.CategoriaActualizar = function (entity) { return ServiceApi.put("api/Categoria", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        /*Producto*/
        //export const ProductoEliminar = (id) => axios.delete<DBEntity>("Producto/Grid?handler=Delete&id=" + id).then(({ data }) => data);
        //export const ProductoGuardar = (entity) => axios.post<DBEntity>("Producto/Edit", entity).then(({ data }) => data);
        AxiosProvider.ProductoEliminar = function (id) { return ServiceApi.delete("api/Producto/" + id).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoGuardar = function (entity) { return ServiceApi.post("api/Producto", entity).then(function (_a) {
            var data = _a.data;
            return data;
        }); };
        AxiosProvider.ProductoActualizar = function (entity) { return ServiceApi.put("api/Producto", entity).then(function (_a) {
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