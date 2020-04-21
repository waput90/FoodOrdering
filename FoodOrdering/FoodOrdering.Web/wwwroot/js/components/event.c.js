import { vars } from "./variable.c.js";

const selectMenu = (value) => {
    vars.isMenuSelected(value.id);
    vars.productList(value.products());
    vars.productList.valueHasMutated();
}

const selectSubMenu = (value) => {
    Swal.fire({
        title: 'Enter quantity',
        input: 'text',
        inputAttributes: {
            autocapitalize: 'off'
        },
        showCancelButton: true,
        confirmButtonText: 'Submit',
    }).then((result) => {
        if (result.value) {
            if (!new RegExp(/^[0-9]{1,}$/).test(result.value)) {
                Swal.fire(
                    'Invalid quantity',
                    'Quantity should be number.',
                    'error'
                );
            }
            else {
                //place order here
                if (vars.orderList == null) {
                    let data = vars.orderList();
                    data.push({
                        id: value.id,
                        name: value.name,
                        qty: ko.observable(result.value),
                        price: value.price,
                        subtotal: ko.observable(value.price * result.value)
                    });
                    vars.orderList.valueHasMutated();
                    calculateSub();
                }
                else {
                    let order = _.find(vars.orderList(), s => s.id == value.id);

                    if (order != null) {
                        order.qty(parseInt(order.qty()) + parseInt(result.value));
                        order.subtotal(order.subtotal() + (order.price * result.value));
                    }
                    else {
                        let data = vars.orderList();
                        data.push({
                            id: value.id,
                            name: value.name,
                            qty: ko.observable(result.value),
                            price: value.price,
                            subtotal: ko.observable(value.price * result.value)
                        });
                    }
                    vars.orderList.valueHasMutated();
                    calculateSub();
                }
            }
        }
    });
}

const menuHelper = (name) => {
    switch (name) {
        case 'Burgers':
            return './img/burgers.jpg'
        case 'Beverages':
            return './img/beverages.jpg'
        case 'Combo Meals':
            return './img/combo-meal.jpg'
        default:
            return './img/default.png'
    }
}

const subMenuHelper = (name) => {
    switch (name) {
        case 'Hotdog':
            return './img/hotdog.jpg'
        case 'CheeseBurger':
            return './img/cheeseburger.jpg'
        case 'French Fries':
            return './img/fries.jpg'
        case 'Coke':
            return './img/coke.jpg'
        case 'Sprite':
            return './img/sprite.jpg'
        case 'Iced Tea':
            return './img/icetea.jpg'
        case 'Chicken Combo Meal':
            return './img/chicken-combo-meal.jpg'
        case 'Pork Combo':
            return './img/pork-combo-meal.jpg'
        case 'Fish Combo':
            return './img/fish-combo-meal.jpg'
        default:
            return './img/default.png'
    }
}

const calculateSub = () => {
    let data = 0;
    _.forEach(vars.orderList(), o => {
        data += o.subtotal();
    });

    vars.orderTotal(data);
}

const reduceItem = (value) => {
    var item = _.find(vars.orderList(), o => o.id == value.id);

    if (item != null) {
        if (item.qty() <= 1) {
            //remove the item 
            vars.orderList.remove(item);
        }
        else {
            item.qty(item.qty() - 1);
            item.subtotal(item.subtotal() - value.price);
        }
        calculateSub();
    }
}

const increaseItem = (value) => {
    var item = _.find(vars.orderList(), o => o.id == value.id);

    if (item != null) {
        item.qty(parseInt(item.qty()) + 1);
        item.subtotal(item.subtotal() + value.price);
        calculateSub();
    }
}

const validateCoupon = () => {
    Swal.fire({
        title: 'Validating Coupon..',
        timerProgressBar: true,
        onBeforeOpen: () => Swal.showLoading()
    });
    setTimeout(() => {
        if (vars.coupon() == "GOSAKTO") {
            vars.discount(10);
            Swal.close();
        }
        else
            Swal.fire(
                'Invalid Coupon',
                'Invalid coupon code. please try again',
                'error'
            );
    }, 3000);
}

const clearMenu = () => vars.isMenuSelected(null);

export default {
    selectMenu,
    clearMenu,
    selectSubMenu,
    menuHelper,
    subMenuHelper,
    calculateSub,
    increaseItem,
    reduceItem,
    validateCoupon,
}