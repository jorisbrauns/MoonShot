"use strict";
module.controller('HomeController', function ($rootScope, $scope) {

    $scope.AvailablePageSizes = [10, 25, 50, 75];
    $scope.totalItems = 50;
    $scope.filterCriteria = {
        PageSize: 25,
        Page: 1
};

});

