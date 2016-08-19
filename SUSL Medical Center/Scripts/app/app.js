

/*

<!--
<div ng-app="myApp">
    <div ng-controller="stuctrl">
        <table class="table table-bordered">
            <tr>
                <th>
                    id
                </th>
                <th>
                    first name
                </th>
                <th>
                    Last Name
                </th>
                <th>
                    date of birth
                </th>
            </tr>
            <tr ng-repeat="astudent in studentsScope">
                <td>{{astudent.stu_id}}</td>
                <td>{{astudent.stu_first_name}}</td>
                <td>{{astudent.stu_last_name}}</td>
                <td>{{astudent.stu_dob}}</td>
            </tr>
        </table>
</div>
</div>
-->
@section scripts{
    <script src="~/Scripts/angular.js"></script>
    <script src="~/Scripts/app/stuControllers.js"></script>
}
*/












/*


<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(model => model.stu_id)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.stu_first_name)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.stu_last_name)
        </th>
        <th>
            @Html.DisplayNameFor(model => model.stu_dob)
        </th>
        <th></th>
    </tr>

@foreach (var item in Model) {
    <tr>
        <td>
            @Html.DisplayFor(modelItem => item.stu_id)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.stu_first_name)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.stu_last_name)
        </td>
        <td>
            @Html.DisplayFor(modelItem => item.stu_dob)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", new { id=item.stu_reg_number }) |
            @Html.ActionLink("Details", "Details", new { id=item.stu_reg_number }) |
            @Html.ActionLink("Delete", "Delete", new { id=item.stu_reg_number })
        </td>
    </tr>
}

</table>

*/