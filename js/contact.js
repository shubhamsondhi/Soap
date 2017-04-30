$(function () {

    $('#contact-form').validator();
    
});

$(document).ready(function () {
    var id = GetParameterValues('id');
        if (id == 0) {
        document.getElementById("message").innerHTML = "Sorry, please send message again";
        } else if (id == null) {
            document.getElementById("message").innerHTML = "";
        }

        else {
            document.getElementById("message").style.color = "green";
        document.getElementById("message").innerHTML = "Thank you For Your Feedback";

    }
    function GetParameterValues(param) {
        var url = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
        for (var i = 0; i < url.length; i++) {
            var urlparam = url[i].split('=');
            if (urlparam[0] == param) {
                return urlparam[1];
            }
        }
    }
});