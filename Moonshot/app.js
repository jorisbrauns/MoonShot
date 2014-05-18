var MoonShotOs = angular.module('moonShot', [
    'ngRoute',
    'loadingBar',
    'sortBy',
    'onBlurChange',
    'onEnterBlur',
    'ngAnimate',
    'ui.bootstrap'
]).
config(['$routeProvider', 'cfpLoadingBarProvider', function ($routeProvider, cfpLoadingBarProvider) {
    cfpLoadingBarProvider.includeSpinner = true;
    
    
    $routeProvider
        .when('/Home', { templateUrl: 'Views/Home.html', controller: 'HomeController' })
        .when('/About', { templateUrl: 'Views/About.html', controller: 'AboutController' })
        .when('/Contact', { templateUrl: 'Views/Contact.html', controller: 'ContactsController' })
        .otherwise({ redirectTo: '/Home' });
}]);