import { vars } from './variable.c.js';

const getMenu = () => {
    return new Promise(resolve => {
        $.get("/menu/get", res => {
            if (typeof res != 'undefined' && res != null) {
                let data = vars.menuList();
                _.forEach(res, value => {
                    data.push({
                        id: value.id,
                        name: value.name,
                        description: value.description,
                        products: ko.observableArray(value.products)
                    });
                });
                vars.menuList.valueHasMutated();
            }
        })
            .done(() => {
                resolve(true);
            });
    });
}

const getCoupon = () => {
    return new Promise(resolve => {
        $.get(`/coupon/get?code=${vars.coupon()}`, res => {
            if (typeof res != 'undefined' && res != null) {
                if (res.isAvail && res.isValid) {
                    vars.discount(res.discount);
                    vars.discountId(res.id);
                    Swal.close();
                }
                else
                    Swal.fire(
                        'Invalid Coupon',
                        'Coupon used or expired',
                        'error'
                    );
            }
            else
                Swal.fire(
                    'Invalid Coupon',
                    'Coupon not found',
                    'error'
                );
        })
            .done(() => {
                resolve(true);
            });
    })
}

const getDefaultCustomer = () => {
    return new Promise(resolve => {
        $.get("/customer/get-default", res => {
            if (typeof res != 'undefined' && res != null) {
                vars.customerId(res);
            }
        })
            .done(() => {
                resolve(true);
            });
    });
}

const saveOrder = () => {
    const token = $("[name='__RequestVerificationToken'").val();
    vars.order.CustomerId(vars.customerId());
    vars.order.OrderItems(vars.orderList());
    vars.order.DiscountId(vars.discountId());
    vars.order.OrderTotal(vars.orderTotal());
    vars.order.DiscountedTotal(vars.orderTotal() * (vars.discount() / 100));
    return new Promise(resolve => {
        $.ajax({
            url: "/order/save",
            method: "post",
            dataType: "json",
            data: {
                "__RequestVerificationToken": token,
                "save": ko.toJS(vars.order)
            },
            success: res => {
                if (typeof res != 'undefined' && res != null) {
                    if (res.succeeded) {
                        Swal.fire(
                            'Order placed',
                            'Order placed successfully',
                            'success'
                        );
                        vars.coupon(null);
                        vars.discount(0);
                        vars.discountId(null);
                        vars.orderList.removeAll();
                        vars.orderTotal(0);
                    }
                    else {
                        Swal.fire(
                            'Order placed',
                            'Order error please try again',
                            'error'
                        );
                    }
                }
            }
        })
            .done(() => {
                resolve(true);
            });
    });
}

const getHistory = () => {
    return new Promise(resolve => {
        $.get("/order/get", res => {
            if (typeof res != 'undefined' && res != null) {
                console.log(res);
                vars.historyList.removeAll();
                let data = vars.historyList();
                _.forEach(res, (o, key) => {
                    data.push({
                        id: o.id,
                        discountedTotal: o.discountedTotal,
                        overallTotal: o.overallTotal,
                        orderItems: ko.observableArray(res[key].orderItems)
                    });
                });
                vars.historyList.valueHasMutated();
            }
        })
            .done(() => {
                resolve(true);
            });
    })
}

export default {
    getMenu,
    getCoupon,
    getDefaultCustomer,
    saveOrder,
    getHistory,
}