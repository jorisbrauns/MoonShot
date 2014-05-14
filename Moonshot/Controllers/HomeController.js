'use strict';
ctr.controller('HomeController', ['$scope', '$log', function ($scope, $log) {

        $scope.AvailablePageSizes = [10, 25, 50, 75, 100];
        $scope.totalItems = 25;
        $scope.filterCriteria = {
            PageSize : 10,
            Page: 1
        };

        $scope.fetchResult = function() {
            $log.info('Feth results: ' + new Date());
        }

    }
]);