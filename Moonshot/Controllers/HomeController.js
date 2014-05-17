(function HomeController(ng, mOS) {
    'use strict';
    mOS.controller('HomeController', function ($rootScope, $scope, PersonService) {
        
        $scope.Headers = [
            { Title: "Id", Value: "id" },
            { Title: "First Name", Value: "FirstName" },
            { Title: "Last Name", Value: "LastName" },
            { Title: "Age", Value: "age" }
        ];

        $scope.AvailablePageSizes = [10, 25, 50, 75, 100];

        $scope.TotalItems = 25;

        $scope.FilterCriteria = {
            PageSize : 10,
            Page: 1,
            sortDir: false,
            Sorting: 'FirstName',
        };

        $scope.FetchResult = function () {
            return PersonService.Persons($scope.FilterCriteria).then(function (data) {
                $scope.Persons = data.Records;
                $scope.TotalItems = data.TotalItems;
            }, function () {
                $scope.Persons = [];
                $scope.TotalItems = 0;
            });
        };

        $scope.onSort = function (sortedBy, sortDir) {
            console.log(sortedBy + " " + sortDir);
            $scope.FilterCriteria.sortDir = sortDir;
            $scope.FilterCriteria.Sorting = sortedBy;
            $scope.FetchResult();
        };

        $scope.FetchResult();

    });
})(angular, MoonShotOs);