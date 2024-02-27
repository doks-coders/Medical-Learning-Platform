$(document).ready(() => {
    loadTables();
});
var dataTable;

const loadTables = () => {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/admin/course/getall",
            //            "dataSrc": "" // This is needed if your data is wrapped in a property (e.g., "data" property)
        },
        "columns": [
            { "data": "name", "width": "15%" }, // Adjust the property name if it's different
            { "data": "description", "width": "15%" },
            {//First of all, you add a new column that is for "id"
                "data": "id",
                "width":"15%",
                "render": (data) => { //Then you add a field called "render", in there you create a function and pass in the data which is id, that will return a string template with two href="/admin/product/upsert?id=${data}", and href="/admin/product/delete?id=${data}"
                    return `<div class="m-75 btn-group" role="group">
                                <a href="/admin/course/upsert?id=${data}" class="btn btn-primary mx-2"> 
                                    <i class="bi bi-pencil-square"> </i> 
                                    Edit
                                </a>

                                <a onClick=DeleteItem('/admin/course/delete?id=${data}')  class="btn btn-danger mx-2"> 
                                    <i class="bi bi-trash-fill"> </i> 
                                    Delete
                                </a>
                            </div>`
                }
            }
        ]
    });
};



const DeleteItem = (url) => {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {

            $.ajax({
                url,
                type: 'DELETE',
                success: (data) => {
                    dataTable.ajax.reload();
                    Swal.fire({
                        title: "Deleted!",
                        text: data.message,
                        icon: "success"
                    });
                    // toastr.success(data.message)
                }
            })

        }
    });
}



