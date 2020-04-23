import '../order.m.js';

export let vars = {
    menuList: ko.observableArray([]),
    isMenuSelected: ko.observable(null),   
    productList: ko.observable([]),
    orderList: ko.observableArray([]),
    orderTotal: ko.observable(),
    coupon: ko.observable(),
    discount: ko.observable(0),
    discountId: ko.observable(),
    customerId: ko.observable(),
    order: new app.order(),
    historyList: ko.observableArray([]),
    isHistorySelected: ko.observable(false),
}