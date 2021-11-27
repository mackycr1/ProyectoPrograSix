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
    })(AxiosProvider = App.AxiosProvider || (App.AxiosProvider = {}));
})(App || (App = {}));
//# sourceMappingURL=AxiosProvider.js.map