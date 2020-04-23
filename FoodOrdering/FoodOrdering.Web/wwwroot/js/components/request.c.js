import { vars } from './variable.c.js';

const getMenu = () => {
    return new Promise(resolve => {
        $.get("/menu/get", res => {
            if (typeof res != 'undefined' && res != null) {
                console.log(res);
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
            console.log(res);
            if (typeof res != 'undefined' && res != null) {

            }
        })
        .done(() => {
            resolve(true);
        });
    })
}

const getDefaultCustomer = () => {
    return new Promise(resolve => {
        $.get("/customer/get-default", res => {
            console.log(res);
            if (typeof res != 'undefined' && res != null) {

            }
        })
        .done(() => {
            resolve(true);
        });
    });
}

export default {
    getMenu,
    getCoupon,
    getDefaultCustomer,
}