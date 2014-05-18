(function HomeController(ng, mOS) {
    'use strict';
    mOS.controller('HomeController', function ($rootScope, $scope, PersonService) {
        
        //Fields
        $scope.Headers = [
            { Title: "Id", Value: "Id" },
            { Title: "First Name", Value: "FirstName" },
            { Title: "Last Name", Value: "LastName" },
            { Title: "Age", Value: "Age" }
        ];
        $scope.AvailablePageSizes = [10, 25, 50, 75, 100];
        $scope.TotalItems = 0;
        $scope.FilterCriteria = {
            PageSize : 10,
            Page: 1,
            OrderBy: false,
            OrderOn: 'FirstName',
        };

        //Methodes
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
            $scope.FilterCriteria.OrderBy = sortDir;
            $scope.FilterCriteria.OrderOn = sortedBy;
            $scope.FetchResult();
        };

        $scope.FetchResult();
    });
})(angular, MoonShotOs);