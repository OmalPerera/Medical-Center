var stuApp = angular.module('stuApp', []);

stuApp.controller('stuctrl', function ($scope, $http) {
    $scope.stuScope = [];

    //$http.get("student/Getstuinfo").then(function (response) {
        //$scope.stuScope = response;

        
    $http.get("student/Getstuinfo","stuScope").

        success(function (data) {
            $scope.stuScope = data;
        }).

        error(function (data, status, headers, config) {
        
        });


});