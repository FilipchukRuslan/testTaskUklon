$(document).on('click', '#editlOrder', function (e) {
    var obj = new Object();
    var $this = $(this),
        parent = $this.parents('.parent'),
        showHideEl = parent.find('.info');

    orderId = showHideEl.data('id');

    obj.orderId = orderId;

    $.ajax({
        type: "POST",
        url: "/Home/EditOrder",
        data: obj,
        success: function () {
            location.reload();
        }
    });
});