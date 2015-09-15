/* Common functions used by multiple javascript pages */

function showCommonModal(title, body) {
    $("#commonModalTitle").html(title);
    $("#commonModalBody").html(body);
    $("#commonModal").modal("show");
}