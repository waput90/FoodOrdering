import { vars } from "./variable.c.js";

const selectMenu = (value) => {
    vars.isMenuSelected(value.id);
    console.log(value);
    vars.productList(value.products());
    vars.productList.valueHasMutated();
}

const selectSubMenu = (value) => {
    console.log(value);
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

const clearMenu = () => vars.isMenuSelected(null);

export default {
    selectMenu,
    clearMenu,
    selectSubMenu,
    menuHelper,
    subMenuHelper,
}