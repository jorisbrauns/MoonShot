var MoonShotOs = angular.module('moonShot', [
    'ngRoute',
    'loadingBar',
    'sortBy',
    'ngAnimate',
    'ui.bootstrap'
]).
config(['$routeProvider', function ($routeProvider) {
    $routeProvider
        .when('/Home', { templateUrl: 'Views/Home.html', controller: 'HomeController' })
        .when('/About', { templateUrl: 'Views/About.html', controller: 'AboutController' })
        .when('/Contact', { templateUrl: 'Views/Contact.html', controller: 'ContactsController' })
        .otherwise({ redirectTo: '/Home' });
}]);