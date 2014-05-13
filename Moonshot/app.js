'use strict';
angular.module('moonShot', [
  'ngRoute',
  //'moonshot.filters',
  //'moonshot.services',
  //'moonshot.directives',
  'moonShot.controllers'
]).
config(['$routeProvider', function ($routeProvider) {
    $routeProvider.when('/view1', { templateUrl: 'Views/partial1.html', controller: 'HomeController' });
    //$routeProvider.when('/view2', { templateUrl: 'partials/partial2.html', controller: 'MyCtrl2' });
    $routeProvider.otherwise({ redirectTo: '/view1' });
}]);
