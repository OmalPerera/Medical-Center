var myApp = angular.module('myApp', []);

myApp.controller('stuctrl', function ($scope, $http) {
    $scope.studentsScope = [];

    $http.get("Student/GetStudentInfo").then(function (response) {
        $scope.studentsScope = response;
    /*
    $http.get("Student/GetStudentInfo", "studentsScope").

        success(function (data) {
            $scope.studentsScope = data;
        }).

        error(function (data, status, headers, config) {
        */
        });
});


