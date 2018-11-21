
$(document).on('input', '#inputTextareaPhone', function (e) {
    if ($('#inputTextareaPhone').val().length > 13) {
        $('#inputTextareaPhone').css("border", "red solid 1px");
        $('#inputTextareaPhone').val("");
    }
});

$(document).on('input', '#inputTextareaAddressFrom', function (e) {
    if ($('#inputTextareaAddressFrom').val().length > 120) {
        $('#inputTextareaAddressFrom').css("border", "red solid 1px");
        $('#inputTextareaAddressFrom').val("");
    }
});

$(document).on('input', '#inputTextareaAddressTo', function (e) {
    if ($('#inputTextareaAddressTo').val().length > 120) {
        $('#inputTextareaAddressTo').css("border", "red solid 1px");
        $('#inputTextareaAddressTo').val("");
    }
});