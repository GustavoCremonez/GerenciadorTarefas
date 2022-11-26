$('.close-alert').click(function () {
    $('.alert').hide('hide')
})

var path_to_delete;

$(".deleteItem").click(function (e) {
    path_to_delete = $(this).data('path');
});

$('#btnContinueDelete').click(function () {
    window.location = path_to_delete;
});