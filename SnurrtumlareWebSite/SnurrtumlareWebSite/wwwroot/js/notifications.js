"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();

connection.start().then(function () {
    document.getElementById("finalizeOrderButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});


connection.on("ReceiveNotification", function (name, message) {
    toastr.info(message + name);
});

document.getElementById("finalizeOrderButton").addEventListener("click", function (event) {
    var name = document.getElementById("name").value;
    var message = "An order has been created by ";

    connection.invoke("SendMessage", name, message).catch(function (err) {
        return console.error(err.toString());
    });

    event.preventDefault();

});