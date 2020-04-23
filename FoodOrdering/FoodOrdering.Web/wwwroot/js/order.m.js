app.order = function() {
    let self = this;
    self.CustomerId = ko.observable();
    self.OrderItems = ko.observableArray();
    self.OrderTotal = ko.observable();
    self.DiscountId = ko.observable();
    self.DiscountedTotal = ko.observable();
    return self;
}