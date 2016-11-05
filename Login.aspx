<%@ page title="" language="C#" masterpagefile="~/MP.master" autoeventwireup="true" inherits="Login, App_Web_3v1dlpyk" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MP1" runat="Server">

    <div class="box-option">Sign in to Work Studio</div>
    <div id="dv-container" class="box" style="text-align: center;">
        <center>
            <form action="Login.aspx" method="post" id="sign-form">
                <table>
                    <tr>
                        <td>Username</td>
                        <td>
                            <input type="text" name="sign-username" id="sign-username" class="txt" style="width: 200px;" /></td>

                    </tr>
                    <tr>
                        <td>Password</td>
                        <td>
                            <input type="password" name="sign-password" id="sign-password" class="txt" style="width: 200px;" /></td>

                    </tr>
                    <tr>
                        <td></td>
                        <td style="text-align:left;">
                            <input type="hidden" name="auto-sign-url" value="<%=Request["auto-sign-url"] %>" />
                            <input type="checkbox" id="persistent" onchange="KeepSignIn(this);" value="0" />
                            <label for="persistent">Keep me signed in</label>
                        </td>
                    </tr>
                    <%if(!string.IsNullOrEmpty(Error)){ %>
                    <tr><td></td><td style="color:red;text-align:left;"><%=Error %></td></tr>
                    <%} %>
                    <tr>
                        <td></td>
                        <td style="text-align:left;">
                            <input type="submit" value="Sign In" class="btn5" id="btn-sign" />
                        </td>
                    </tr>
                </table>
            </form>
        </center>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ScriptPlaceHolder" runat="Server">
    <script language="javascript" type="text/javascript">
        function KeepSignIn(obj) {
            if (!obj.checked) {
                delCK('sign-username'); delCK('sign-password');
            }
        }
        $(document).ready(function () {
            var signUsrname = getCK('sign-username');
            if (!IsEmpty(signUsrname)) {
                $('#persistent')[0].checked = true;
                $('#sign-username').val(signUsrname);
                $('#sign-password').val(getCK('sign-password'));
            }
            $('#btn-sign').click(function () {
                if ($('#persistent')[0].checked) {
                    setCK('sign-username', $('#sign-username').val());
                    setCK('sign-password', $('#sign-password').val());
                }
                else {
                    delCK('sign-username');
                    delCK('sign-password');
                }
            });
            if (getUrlParam('auto-sign') == 1) {
                $('#sign-form')[0].submit();
            }
        });
    </script>
</asp:Content>

