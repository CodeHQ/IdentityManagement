@model IEnumerable<$rootnamespace$.Models.ApplicationUser>

@{
    ViewBag.Title = "Users";
}
<div class="page-header"><h1>Users Administration</h1></div>
<div class="row">
    <div class="col-xs-12">
        @if (!Model.Any())
        {

        }
        else
        {
            <div class="row">
                <div class="col-xs-6">
                    <table class="table table-striped table-bordered table-hover">
                        <thead>
                            <tr>
                                <th>
                                    <i class="ace-icon fa fa-user"></i> User Name
                                </th>
                                <th></th>
                            </tr>
                        </thead>
                        <tbody>
                            @foreach (var user in Model)
                            {
                                <tr>
                                    <td>@user.UserName</td>
                                    <td>
                                        <div class="hidden-sm btn-group">
                                            <a class="btn btn-xs btn-info" href="@Url.Action("Details", "Users", new{id=user.Id})"><i class="ace-icon fa fa-eye"></i></a>
                                            <a class="btn btn-xs btn-info" href="@Url.Action("Edit", "Users", new{id=user.Id})"><i class="ace-icon fa fa-pencil"></i></a>
                                            <a class="btn btn-xs btn-danger" href="@Url.Action("Delete", "Users", new{id=user.Id})"><i class="ace-icon fa fa-trash-o"></i></a>
                                        </div>
                                    </td>
                                </tr>
                            }
                        </tbody>
                    </table>
                </div>
            </div>
            
        }
    </div>
</div>