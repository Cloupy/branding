<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width" />

    @Html.Partial("MetaHeadControl")

    <title>@ViewData("Title")</title>


    @Html.Partial("IconsControl")


    @Styles.Render("~/Content/css")

    @RenderSection("Head", required:=False)

    
    

</head>
<body>


    @RenderBody()



    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/app")
    @RenderSection("scripts", required:=False)





    @Html.Partial("GoogleControl")

</body>
</html>
