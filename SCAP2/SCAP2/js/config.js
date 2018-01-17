app.config(function ($routeProvider) {

    $routeProvider
        .when('/', {
            templateUrl: '../../views/index.html',
            controller: 'mainCtrl'
        })
        .otherwise({
            redirectTo: '../../views/index.html',
            controller: 'mainCtrl'
		});

});