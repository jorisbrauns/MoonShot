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
    //$routeProvider.when('/view2', { templateUrl: 'partials/partial2.html', controller: 'MyCtrl2' });
    $routeProvider.otherwise({ redirectTo: '/Home' });
}]);
