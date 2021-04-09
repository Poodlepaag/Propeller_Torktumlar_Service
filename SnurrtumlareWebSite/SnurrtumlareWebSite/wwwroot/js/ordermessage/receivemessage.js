"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();

connection.start().then(function () {
    document.getElementById("finalizeOrderButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});


connection.on("ReceiveMessage", function (user, message) {
    toastr.options = {
        "closeButton": true,
        "positionClass": "toast-bottom-right"
    }
    toastr.info(message, user);
});