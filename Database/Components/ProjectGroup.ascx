<%@ control language="C#" autoeventwireup="true" inherits="Database_Components_ProjectGroup, App_Web_projectgroup.ascx.2acb5a70" %>
<%@ Register src="Projects.ascx" tagname="Projects" tagprefix="uc1" %>
<%if(Projects==null || Projects.Count==0){ %>
<div class="header box" style="padding-left:5px;margin-bottom:5px;">No project found</div>
<%} %>