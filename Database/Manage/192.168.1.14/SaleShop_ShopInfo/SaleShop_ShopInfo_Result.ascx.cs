using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Database_Output_SaleShop_ShopInfo_Result : GetTogether.Web.UI.ControlPaging
{
    protected void Page_Load(object sender, EventArgs e)
    {
        RepeaterLogin.DataSource = BindingResult;
        RepeaterLogin.DataBind();
    }
}