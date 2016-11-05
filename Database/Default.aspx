<%@ page language="C#" masterpagefile="~/MP.master" autoeventwireup="true" inherits="MSSQL_MS_ProjectList, App_Web_default.aspx.c985e3fb" title="Database Projects" %>

<%@ Register Src="~/Database/Components/Projects.ascx" TagName="Projects" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MP1" runat="Server">
    <div id="dv-content" style="width: 100%; min-height: 300px;">
                <div style="margin-bottom: 5px;">
            Database Projects            <%if (GetTogether.Utility.NumberHelper.ToInt(Request["show"], 0) == 0)
              { %>
            &nbsp;&nbsp;<span class="mm-split">|</span>&nbsp;&nbsp;<a
                style="" href="?show=1">Show All</a>
            <%}
              else
              { %>
            &nbsp;&nbsp;<span class="mm-split">|</span>&nbsp;&nbsp;<a
                style="" href="?show=0">By Group</a><%} %>
        </div>
        <div id="dv-projects" style="text-align: left; min-height: 1px;">
        </div>
        <div style="text-align: right;margin-bottom:5px;">
            <input type="button" class="btn6" value="Create New Project"
                onclick="AjaxMsg('Create New Project',null,null,SerUrl,'Database/Callback/Projects.aspx?type=1&get=1','',null,23);" /></div>
    </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptPlaceHolder" Runat="Server">
        <script language="javascript">
            var ProjectCategory = '<%=GetTogether.Studio.ProjectParameter.ProjectCategory.Database%>';
            $(document).ready(function () {
                LoadProjects();
            });
    </script>
</asp:Content>