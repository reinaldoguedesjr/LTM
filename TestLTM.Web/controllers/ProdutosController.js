'use strict';
app.controller('produtosController', ['$scope', 'produtosService', '$rootScope', '$location', function ($scope, produtosService, $rootScope, $location) {

    $scope.produtos = [];
    $scope.search = "";
    var _setDefaultModel = function () {
        $scope.formData = {
            "IdProduto": "",
            "NomeProduto": ""
        };
    };
    _setDefaultModel();

    var _carregaLista = function ($scope) {
        produtosService.getProdutos().then(function (results) {
            $scope.produtos = results.data;

        }, function (error) {
            bootbox.alert(error.data.message);
        });
    };
    _carregaLista($scope);

    var _delete = function (id) {
        bootbox.confirm("Tem certeza que quer excluir este produto?", function (r) {
            if (r)
                produtosService.deleteProduto(id).then(function () {
                    _carregaLista($scope);
                });
        });
    };

    var _alter = function (c) {
        $scope.formData.IdProduto = c.idProduto;
        $scope.formData.NomeProduto = c.nomeProduto;
        jQuery("#modalProduto").append("body").modal('show');
    };

    var _salvarDados = function () {
        var form = $scope.formData;

        if (form.NomeProduto === "") {
            bootbox.alert("Preencha o nome.");
            return;
        }

        var $req;
        if (form.IdProduto) { //ALTERAÇÃO
            $req = produtosService.alterarProduto(form);
        } else { //NOVO
            $req = produtosService.criarProduto(form);
        }
        $req.success(function () {
            jQuery("#modalProduto").modal('hide');
            _carregaLista($scope);
        })
        .error(function () {
            bootbox.alert("Ocorreu algum erro ao salvar.");
        });
    };

    var _novo = function () {
        _setDefaultModel();
        jQuery("#modalProduto").append("body").modal('show');
    };

    $scope.delete = _delete;
    $scope.alter = _alter;
    $scope.salvarDados = _salvarDados;
    $scope.novo = _novo;

}]);