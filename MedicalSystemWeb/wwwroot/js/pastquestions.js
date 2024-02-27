$(document).ready(() => {
    loadTables();
});
var dataTable;

const loadTables = () => {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            "url": "/client/pastquestion/getall",
            //            "dataSrc": "" // This is needed if your data is wrapped in a property (e.g., "data" property)
        },
        "columns": [
            { "data": "courseName", "width": "15%" }, // Adjust the property name if it's different
            { "data": "examName", "width": "15%" },
            { "data": "year", "width": "15%" },
            {//First of all, you add a new column that is for "id"
                "data": "id",
                "width": "15%",
                "render": (data) => { //Then you add a field called "render", in there you create a function and pass in the data which is id, that will return a string template with two href="/admin/product/upsert?id=${data}", and href="/admin/product/delete?id=${data}"
                    return `<div class="m-75 btn-group" role="group">
                                <a href="/client/pastquestion/questions?id=${data}" class="btn btn-primary mx-2"> 
                                    <i class="bi bi-eye"> </i> 
                                    View
                                </a>

                            </div>`
                }
            }
        ]
    });
};



