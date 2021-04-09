"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();

connection.start().then(function () {
    document.getElementById("finalizeOrderForm").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("finalizeOrderForm").addEventListener("submit", function (event) {
    var user = "System";
    var message = "An order has been created!";

    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
});