
$(document).ready(function () {
    loadDataTable();
});
function loadDataTable() {
    dataTable = $("#tblData").DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns":[
        { data: 'title', "width": "15%" },
        { data: 'ISBN', "width": "15%" },
        { data: 'Price', "width": "15%" },
        { data: 'Author', "width": "15%" }
        ]
    });
}