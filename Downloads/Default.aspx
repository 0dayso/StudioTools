<%@ page language="C#" masterpagefile="~/MP.master" autoeventwireup="true" inherits="Downloads_Index, App_Web_pt2hgile" %>

<%@ Register Src="~/Downloads/Components/DownloadFiles.ascx" TagName="DownloadFiles"
    TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MP1" runat="Server">
    <div class="box">
        <uc1:DownloadFiles ID="DownloadFiles1" runat="server" />
    </div>
</asp:Content>
