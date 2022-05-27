var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#DT_load').DataTable({
        "ajax": {
            "url": "/api/account",
            "type": "GET",
            "datatype": "json"
        },
        "columns": [
            { "data": "Id", "width": "20%" },
            { "data": "ФИО собственника", "width": "20%" },
            { "data": "Адрес", "width": "20%" },
            { "data": "Дата открытия", "width": "20%" },
            { "data": "Дата закрытия", "width": "20%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
                        <a href="/AccountList/UpdateAcount?id=${data}" class='btn btn-outline-success' style='cursor:pointer; width:70px;'>
                            Редактировать
                        </a>
                        &nbsp;
                        <a class='btn btn-outline-danger' style='cursor:pointer; width:70px;'
                            onclick=Close('/api/account?id='+${data})>
                            Закрыть ЛС
                        </a>
                        </div>`;
                }, "width": "40%"
            }
        ],
        "language": {
            "emptyTable": "no data found"
        },
        "width": "100%"
    });
}

function Close(url) {
    swal({
        title: "Вы уверены?",
        text: "После закрытия, вы не сможете восстановить ЛС",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willClose) => {
        if (willClose) {
            $.ajax({
                type: "UPDATE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });
}