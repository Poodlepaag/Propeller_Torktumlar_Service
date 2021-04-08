"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/notificationHub").build();

//Disable send button until connection is established

connection.on("ReceiveMessage", function () {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = "hello, i made it";
    var ul = document.createElement("ul");
    ul.textContent = encodedMsg;
    document.getElementById("notificationToast").val(encodedMsg);
});

connection.start().then(function () {
    document.getElementById("confirmOrderButton").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});


