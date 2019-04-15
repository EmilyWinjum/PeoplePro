// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(function () {
    $('#show-modal').click(function (event) {
        var url = $('#add-employee').data('url');

        $.get(url).done(function (data) {
            $('#modal-content').html(data);

            $('#add-employee').modal('show');
        });
    });

    $('#add-employee').on('click', '[data-save="modal"]', function (event) {
        event.preventDefault();

        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var dataToSend = form.serialize();

        $.post(actionUrl, dataToSend).done(function (data) {
            $('#add-employee').modal('hide');
            console.log("event triggered");
        });
        location.reload();
    });
});