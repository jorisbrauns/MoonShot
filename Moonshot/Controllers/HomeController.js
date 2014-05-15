(function HomeController(ng, mOS) {
    'use strict';
    mOS.controller('HomeController', ['$rootScope', '$scope', '$log', function ($rootScope, $scope, $log) {
        $scope.headers = [
            { Title: "Id", Value: "id" },
            { Title: "Firstname", Value: "firstname" },
            { Title: "Lastname", Value: "lastname" },
            { Title: "Age", Value: "age" }
        ];

        $scope.availablePageSizes = [10, 25, 50, 75, 100];

        $scope.totalItems = 25;

        $scope.filterCriteria = {
            PageSize : 10,
            Page: 1
        };

        $scope.persons = [
            { Id:2,Firstname:"Joris", Lastname:"Brauns", Age:26}
        ];

        $scope.fetchResult = function() {
            $log.info('Feth results: ' + new Date());
        };

    }]); 

})(angular, MoonShotOs);