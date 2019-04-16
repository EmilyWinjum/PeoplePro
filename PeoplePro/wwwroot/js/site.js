// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// https://softdevpractice.com/blog/asp-net-core-ajax-modals-part-2/ 

$(function () {
    $('#show-modal').click(function (event) {
        var url = $('#add').data('url');

        $.get(url).done(function (data) {
            $('#modal-content').html(data);

            $('#add').modal('show');
        });
    });

    $('#add').on('click', '[data-save="modal"]', function (event) {
        event.preventDefault();

        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var dataToSend = form.serialize();

        $.post(actionUrl, dataToSend).done(function (data) {
            var newBody = $('.modal-body', data);
            $('#add').find('.modal-body').replaceWith(newBody);

            var isValid = newBody.find('[name="IsValid"]').val() == 'True';
            if (isValid) {
                $('#add').modal('hide');
            }
        });
        //location.reload();
        console.log("event triggered");
    });
});