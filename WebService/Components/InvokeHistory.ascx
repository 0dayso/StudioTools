<%@ control language="C#" autoeventwireup="true" inherits="WebService_Components_InvokeHistory, App_Web_mo93y8pd" %>

<%--<div class="header-2" style="padding-left:2px;">
    Invoke History
    <%if(Recent!=null){ %>
    <a href="javascript:;;" onclick="LoadRecent('<%=MethodName %>','<%=Recent.Name %>')">
                        <%=Recent.Name%>
                        </a><%=Recent.ActionTime.ToString("yy/MM/dd HH:mm")%>
                        <a href="javascript:;;" onclick="DeleteInvokeHistory('<%=MethodName %>','<%=Recent.Name%>');" style="color:Red;">X</a>
    <%} %>
    </div>--%>
<%--    <div class="line-sub"></div>--%>

<div class="header-2" style="width: 100%; float: left;">
    <ul style="float: left;">
        <%if (Recent != null)
          { %>
        <li style="float: left; width: 300px;">
            <span style="white-space: nowrap;padding-left: 2px;">Invoke History:
                <a href="javascript:;;" onclick="LoadRecent('<%=MethodName %>','<%=Recent.Name %>')">
                    <%=Recent.Name%>
                </a><%=Recent.ActionTime.ToString("yy/MM/dd HH:mm")%>
                <a href="javascript:;;" onclick="DeleteInvokeHistory('<%=MethodName %>','<%=Recent.Name%>');" style="color: Red;">X</a>
            </span>
        </li>
        <%} %>
        
        <asp:Repeater ID="rptResult" runat="server">
            <ItemTemplate>
                <%--<%#Container.ItemIndex>0?"&nbsp;&nbsp;<span class='mm-split'>|</span>&nbsp;&nbsp;": ""%>--%>
                <li style="float: left; width: 300px;">
                    <span style="white-space: nowrap;padding-left: 2px;"">
                        <a href="javascript:;;" onclick="LoadRecent('<%=MethodName %>','<%#Eval("Name") %>');">
                            <%#Eval("Name") %>
                        </a><%#((DateTime)Eval("ActionTime")).ToString("yy/MM/dd HH:mm")%>
                        <a href="javascript:;;" onclick="DeleteInvokeHistory('<%=MethodName %>','<%#System.Web.HttpUtility.UrlEncode((string) Eval("Name")) %>');" style="color: Red;">X</a>
                    </span>
                </li>
            </ItemTemplate>
        </asp:Repeater>

    </ul>

</div>
            <%if(Recent!=null || Histories!=null && Histories.Count>0){ %>
        <div class="line-sub"></div>
        <%} %>
