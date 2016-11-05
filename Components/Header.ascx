<%@ control language="C#" autoeventwireup="true" inherits="Components_AT_ATHeader, App_Web_kagkuraq" %>
<div id="header">
    <div id="menu">
        <div id="menu-left">
            <strong style="font-size:15px;">Work Studio</strong><span class="mm-split" style="margin: 0px 5px;">|</span>User:<%=CurrentSession.Address %>
            <%if (!string.IsNullOrEmpty(CurrentSession.SignUsername))
              { %>
            <span class="mm-split" style="margin: 0px 5px;">|</span><%=CurrentSession.SignUsername %>
            <%} %>
            <%--<span style="margin-left:0px;">Version:<%=GetTogether.Studio.Config.Original.Version%></span>--%>
        </div>
        <div id="menu-right">
            <ul id="nav-menu">
                <%=GetTogether.Studio.Web.HtmlHelper.GenMenus(this.Page)%>
            </ul>
        </div>
    </div>
</div>
