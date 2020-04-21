export let vars = {
    menuList: ko.observableArray([]),
    isMenuSelected: ko.observable(null),   
    productList: ko.observable([]),
    orderList: ko.observableArray([]),
    orderTotal: ko.observable(),
    coupon: ko.observable(),
    discount: ko.observable(0),
}