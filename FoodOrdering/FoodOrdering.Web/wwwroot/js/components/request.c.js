import { vars } from './variable.c.js';

const getMenu = () => {
    return new Promise(resolve => {
        $.get("/home/get-menu", res => {
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

export default {
    getMenu,
}