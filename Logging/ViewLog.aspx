<%@ page title="" language="C#" masterpagefile="~/MP.master" autoeventwireup="true" inherits="logging_ViewLog, App_Web_vgzer5r6" %>

<%@ Register Src="Components/SoapList.ascx" TagName="SoapList" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MP1" runat="Server">
    <div id="soap-logging">
    <uc1:soaplist id="SoapList1" runat="server" />
        </div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ScriptPlaceHolder" runat="Server">
   <script language="javascript" type="text/javascript">
       //EnhanceTextarea('soap-logging');
   </script>
</asp:Content>

