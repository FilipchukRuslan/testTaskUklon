$(document).on('click', '#cancelOrder', function (e) {
    var obj = new Object();
    var $this = $(this),
        parent = $this.parents('.parent'),
        showHideEl = parent.find('.info');

    orderId = showHideEl.data('id');
    flag = showHideEl.data('flag');

    obj.orderId = orderId;
    obj.flag = flag;

    $.ajax({
        type: "POST",
        url: "/Home/CancelOrder",
        data: obj,
        success: function (data) {
            location.reload();
        }
    });
});