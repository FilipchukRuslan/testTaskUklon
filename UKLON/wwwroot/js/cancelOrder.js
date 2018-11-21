$(document).on('click', '#cancelOrder', function (e) {
    var obj = new Object();
    var $this = $(this),
        parent = $this.parents('.parent'),
        showHideEl = parent.find('.info');

    OrderId = showHideEl.data('id');
    Flag = showHideEl.data('flag');

    obj.OrderId = OrderId;
    obj.Flag = Flag;

    $.ajax({
        type: "POST",
        url: "/Home/CancelOrder",
        data: obj,
        success: function (data) {
            location.reload();
        }
    });
});