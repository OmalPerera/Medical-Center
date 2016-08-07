var myApp = angular.module('myApp', []);

myApp.controller('tstctrl', function ($scope, $http) {
    $scope.tstScope = [];

    //$http.get("tb_test/getinfo").then(function (response) {
        //$scope.tstScope = response;

        
    $http.get("tb_test/getinfo","tstScope").

        success(function (data) {
            $scope.tstScope = data;
        }).

        error(function (data, status, headers, config) {
        
        });


});


