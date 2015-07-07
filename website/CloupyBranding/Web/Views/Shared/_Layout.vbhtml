
    @Code
        Layout = "_LayoutBase.vbhtml"
    End Code

    @section Head
        @RenderSection("HeadSection",required:=False)
    End Section


    <header>
        @Html.Partial("MenuControl")
    </header>

    
    @RenderBody()

    @Html.Partial("FooterControl")

    @section scripts
        @RenderSection("scripts",required:=False)
        @RenderSection("ScriptsFooter", required:=False)
    End Section

