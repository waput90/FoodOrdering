import request from './components/request.c.js';
import event from './components/event.c.js';
import { vars } from './components/variable.c.js';

app.vm = (() => {
    "use strict";

    const init = () => {
        request.getMenu();
        request.getDefaultCustomer();
        request.getHistory();
    }

    const vm = { 
        init: init,
        vars: vars,
        event: event,
    }

    return vm;
})();

$(() => {
    "use strict";
    app.vm.init();
    ko.applyBindings(app.vm);
});