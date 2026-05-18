// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function openEditModal(id)
{
    $.get('/Employee/Edit/' + id,
    function(response)
    {
        $('#modalBody').html(response);

        $('#employeeModal').modal('show');
    });
}