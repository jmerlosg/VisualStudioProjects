
    var app = angular.module('scapApp', []);

    app.controller('mainCtrl', ['$scope', function($scope) {

        $scope.menu = 'views/templates/menu.html';
        $scope.login = 'views/login/login.html';

        $scope.usrnm = '';
        $scope.pass = '';

        $scope.login = function () {
            alert('User name: ' + $scope.usrnm + ' passcode: ' + $scope.pass);
        }

    }]);