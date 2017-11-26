'use strict';
app.factory('produtosService', ['$http', function ($http) {

    var serviceBase = 'http://localhost:55164/';
    var produtosServiceFactory = {};

    var _getProdutos = function () {

        return $http.get(serviceBase + 'api/produtos').then(function (results) {
            return results;
        });
    };

    var _deleteProduto = function (id) {
        return $http.delete(serviceBase + 'api/produtos/' + id).then(function (results) {
            return results;
        });
    };

    var _criarProduto = function (c) {
        return $http.post(serviceBase + 'api/produtos', c, { headers: { 'Content-Type': 'application/json' } });
    };

    var _alterarProduto = function (c) {
        return $http.patch(serviceBase + 'api/produtos', c, { headers: { 'Content-Type': 'application/json' } });
    };

    produtosServiceFactory.getProdutos = _getProdutos;
    produtosServiceFactory.deleteProduto = _deleteProduto;
    produtosServiceFactory.criarProduto = _criarProduto;
    produtosServiceFactory.alterarProduto = _alterarProduto;

    return produtosServiceFactory;

}]);