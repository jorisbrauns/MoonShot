(function (angular) {
    'use strict';
    angular.module('sortBy', ["template/sortby.html"]).directive('sortBy', function () {
        return {
            templateUrl: 'template/sortby.html',
            restrict: 'E',
            transclude: true,
            replace: true,
            scope: {
                sortdir: '=',
                sortedby: '=',
                sortvalue: '@',
                onsort: '='
            },
            link: function(scope, element, attrs) {
                scope.sort = function() {
                    if (scope.sortedby == scope.sortvalue)
                        scope.sortdir = !scope.sortdir;
                    else {
                        scope.sortedby = scope.sortvalue;
                        scope.sortdir = true;
                    }
                    scope.onsort(scope.sortedby, scope.sortdir);
                }
            }
        };
    });
    angular.module("template/sortby.html", []).run(["$templateCache", function ($templateCache) {
        $templateCache.put("template/sortby.html",
          "<a ng-click=\"sort(sortvalue)\">" +
          "      <span ng-transclude=\"\"></span>" +
          "      <span ng-show=\"sortedby == sortvalue\">" +
          "          <i ng-class=\"{true: 'glyphicon glyphicon-arrow-down', false: 'glyphicon glyphicon-arrow-up'}[sortdir]\"></i>" +
          "      </span>"+
          "</a>");
    }]);
}(angular));