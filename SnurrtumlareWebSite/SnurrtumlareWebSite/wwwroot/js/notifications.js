"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();

connection.start().then(function () {
    document.getElementById("confirmOrderButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});


connection.on("ReceiveNotification", function (orderId, firstName, lastName, message) {
    toastr.info(orderId + message + firstName + " " + lastName);
});

document.getElementById("confirmOrderButton").addEventListener("click", function (event) {
    var orderId = document.getElementById("orderId").value;
    var firstName = document.getElementById("firstName").value;
    var lastName = document.getElementById("lastName").value;
    var message = " has been created by ";

    connection.invoke("SendMessage", orderId, firstName, lastName, message).catch(function (err) {
        return console.error(err.toString());
    });

    event.preventDefault();

});