(function () {
    'use strict';
    angular.module('moonShot', [
      'ngRoute',
      'loadingBar',
      'ngAnimate',
      //'moonshot.filters',
      //'moonshot.services',
      //'moonshot.directives',
      'moonShot.controllers'
    ]).
    config(['$routeProvider', function ($routeProvider) {
        $routeProvider.when('/Home', { templateUrl: 'Views/Home.html', controller: 'HomeController' });
        $routeProvider.when('/About', { templateUrl: 'Views/About.html', controller: 'AboutController' });
        $routeProvider.when('/Contact', { templateUrl: 'Views/Contact.html', controller: 'ContactsController' });
        $routeProvider.otherwise({ redirectTo: '/Home' });
    }]);
})();