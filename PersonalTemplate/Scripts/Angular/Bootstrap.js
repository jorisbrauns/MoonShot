'use strict';
var module = angular.module('Eagle', ['ui.bootstrap','ngLoadingBar', 'ngAnimate']);
module.config(function(cfpLoadingBarProvider) {
    cfpLoadingBarProvider.includeSpinner = true;
});
