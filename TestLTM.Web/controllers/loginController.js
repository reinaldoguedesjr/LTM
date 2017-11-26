'use strict';
app.controller('loginController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.message = "";

    $scope.login = function () {

        authService.login($scope.loginData).then(function (response) {
            $location.path('/produtos');
        },
         function (err) {
             $scope.message = "Ocorreu algum erro ao autenticar.";
         });
    };

}]);