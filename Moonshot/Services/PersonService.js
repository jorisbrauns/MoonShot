(function PersonService(ng, mOS) {
    'use strict';
    mOS.factory('PersonService', function ($http) {
        return {
            Persons: function (query) {
                return $http.get('http://localhost/mOsWebApi/api/persons', { params: query }).then(function (result) {
                    return result.data;
                });
            }
        };
    });
}(angular, MoonShotOs));