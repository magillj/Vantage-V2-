/* Common functions used by multiple javascript pages */

function showCommonModal(title, body) {
    $("#commonModalTitle").html(title);
    $("#commonModalBody").html(body);
    $("#commonModal").modal("show");
}

function setCookie(name, value, exdays) {
    var d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    var expires = "expires=" + d.toUTCString();
    document.cookie = name + "=" + value + "; " + expires;
};

function getCookie(cname) {
    var name = cname + "=";
    var ca = document.cookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') c = c.substring(1);
        if (c.indexOf(name) == 0) return c.substring(name.length, c.length);
    }
    return "";
};

function sendPostRequest(url, postData, successCallback, errorCallback) {
    $.ajax(
    {
        url: url,
        type: "POST",
        data: postData,
        mimeType: "Application/JSON",
        success: successCallback,
        error: errorCallback
    });
};