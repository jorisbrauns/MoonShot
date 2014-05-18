(function (angular) {
    'use strict';
    angular.module('onEnterBlur', []).directive('onEnterBlur', function () {
        return function (scope, element, attrs) {
            element.bind("keydown keypress", function (event) {
                if (event.which === 13) {
                    angular.element(element).triggerHandler('change');
                    angular.element(element).triggerHandler('blur');
                    event.preventDefault();
                }
            });
        };
    });
}(angular));