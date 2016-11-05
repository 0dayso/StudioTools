using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_SaleShop_Member_Edit : GetTogether.Web.UI.Page
{
    public DO_SaleShop_Member.UO_SaleShop_Member UO;
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 id = 0;
		if(!string.IsNullOrEmpty(Request["id"])) id = Convert.ToInt32(Request["id"]);
        if (id > 0)
        {
            UO = BO_SaleShop_Member.GetObjectById(id);
        }
        if (UO == null) UO = new DO_SaleShop_Member.UO_SaleShop_Member();

        if (Request.Form.Keys.Count > 0)
        {
            GetTogether.Web.WebHelper.SetValues<DO_SaleShop_Member.UO_SaleShop_Member>(UO, "SaleShop_Member_");
            if (id > 0)
            {
				//Pending
				UO["UpdateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["UpdateBy"] = string.Concat("WS-",Request.UserHostAddress);
                UO.Update(BO_SaleShop_Member.GetConditionsById(id));
            }
            else
            {
				//Pending
				UO["CreateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["CreateBy"]=string.Concat("WS-",Request.UserHostAddress);
                UO.Insert();
            }
            Response.Redirect("SaleShop_Member.aspx");
        }
    }
	public partial class DO_SaleShop_Member : DOBase<DO_SaleShop_Member.UO_SaleShop_Member, DO_SaleShop_Member.UOList_SaleShop_Member>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "SaleShop_Member",
                        @"Data Source=.;Initial Catalog=YSL_Shop;Persist Security Info=True;User ID=sa;Password=Esunlit2008;Connect Timeout=30",
                        new string[] {"UId"},
                        DatabaseType.SQLServer);
                }
                public override ConnectionInformation GetDefaultConnectionInformation()
                {
                    return GetConnectionInformation();
                }
		public enum Columns
		{
			/// <summary>
			///Primary Key,Auto Increment
			/// </summary>
			UId,
			/// <summary>
			///,Remark:会员名
			/// </summary>
			UserName,
			/// <summary>
			///,Remark:会员真实姓名
			/// </summary>
			RealName,
			ICON,
			/// <summary>
			///,Remark:密码
			/// </summary>
			Password,
			/// <summary>
			///,Remark:性别，1男，2女
			/// </summary>
			Gender,
			/// <summary>
			///,Remark:会员分组
			/// </summary>
			GroupId,
			/// <summary>
			///,Remark:邮箱地址
			/// </summary>
			Email,
			/// <summary>
			///,Remark:手机号码
			/// </summary>
			Mobile,
			/// <summary>
			///,Remark:地区
			/// </summary>
			District,
			/// <summary>
			///,Remark:其他联系方式
			/// </summary>
			OtherContact,
			/// <summary>
			///,Remark:会员可用资金
			/// </summary>
			Funds,
			/// <summary>
			///,Remark:被冻结的金额
			/// </summary>
			frostFunds,
			/// <summary>
			///,Remark:站内积分
			/// </summary>
			Integral,
			/// <summary>
			///,Remark:推荐人
			/// </summary>
			Referee,
			/// <summary>
			///,Remark:最后登录IP
			/// </summary>
			LastIP,
			/// <summary>
			///,Remark:上次登录IP
			/// </summary>
			PrevIP,
			/// <summary>
			///,Remark:注册IP
			/// </summary>
			RegIP,
			/// <summary>
			///,Remark:最后登录时间
			/// </summary>
			LastLoginTime,
			logingtime,
			/// <summary>
			///,Remark:状态，0禁用，1启用
			/// </summary>
			State,
			/// <summary>
			///,Remark:注册时间
			/// </summary>
			RegTime,
			/// <summary>
			///,Remark:添加时间
			/// </summary>
			AddTime,
			/// <summary>
			///,Remark:是否接受最新团购短信，1是，0否
			/// </summary>
			IsReceiveSms,
			/// <summary>
			///,Remark:我的好友
			/// </summary>
			Friends,
			loginappid,
			forgotpwdtime,
			/// <summary>
			///,Remark:身份证号
			/// </summary>
			idcard,
			/// <summary>
			///,Remark:出生日期
			/// </summary>
			birthtime,
			/// <summary>
			///,Remark:联系地址
			/// </summary>
			linkaddress,
			industry,
			/// <summary>
			///,Remark:会员绑定商户ID
			/// </summary>
			mshopid,
			/// <summary>
			///,Remark:父级ID
			/// </summary>
			headuid,
			areaid1,
			areaid2,
			areaid3,
			paypwd,
			icon_old,
			experience,
			IsPerfectInfo,
			/// <summary>
			///,Remark:是否绑定邮箱
			/// </summary>
			emailApprove,
			/// <summary>
			///,Remark:是否绑定手机号码
			/// </summary>
			phoneApprove,
			/// <summary>
			///,Remark:是否绑定安全问题
			/// </summary>
			isSetSafeQuestion,
			/// <summary>
			///,Remark:绑定的问题
			/// </summary>
			question,
			/// <summary>
			///,Remark:绑定的答案
			/// </summary>
			answer,
			/// <summary>
			///,Remark:是否绑定身份证
			/// </summary>
			isIdApprove,
			/// <summary>
			///,Remark:银行帐号
			/// </summary>
			bankNum,
			/// <summary>
			///,Remark:是否绑定银行
			/// </summary>
			isBingBank,
			honourId,
			gradeId,
			weixin_openid,
			qq_openid,
		}
		public DO_SaleShop_Member()
		{
		}
		public partial class UO_SaleShop_Member : UOBase<UO_SaleShop_Member,UOList_SaleShop_Member>
		{
public override ConnectionInformation GetDefaultConnectionInformation()
            {
                return GetConnectionInformation();
            }
			#region Columns
			private System.Int32 _UId;
			/// <summary>
			///Primary Key,Auto Increment
			/// </summary>
			[Mapping("UId,un-insert,un-update")]
			public System.Int32 UId
			{
				get
				{
					return _UId;
				}
				set
				{
					_UId = value;
				}
			}
			private System.String _UserName;
			/// <summary>
			///,Remark:会员名
			/// </summary>
			[Mapping("UserName")]
			public System.String UserName
			{
				get
				{
					return _UserName;
				}
				set
				{
					_UserName = value;
				}
			}
			private System.String _RealName;
			/// <summary>
			///,Remark:会员真实姓名
			/// </summary>
			[Mapping("RealName")]
			public System.String RealName
			{
				get
				{
					return _RealName;
				}
				set
				{
					_RealName = value;
				}
			}
			private System.String _ICON;
			[Mapping("ICON")]
			public System.String ICON
			{
				get
				{
					return _ICON;
				}
				set
				{
					_ICON = value;
				}
			}
			private System.String _Password;
			/// <summary>
			///,Remark:密码
			/// </summary>
			[Mapping("Password")]
			public System.String Password
			{
				get
				{
					return _Password;
				}
				set
				{
					_Password = value;
				}
			}
			private System.Int32 _Gender;
			/// <summary>
			///,Remark:性别，1男，2女
			/// </summary>
			[Mapping("Gender")]
			public System.Int32 Gender
			{
				get
				{
					return _Gender;
				}
				set
				{
					_Gender = value;
				}
			}
			private System.Int32 _GroupId;
			/// <summary>
			///,Remark:会员分组
			/// </summary>
			[Mapping("GroupId")]
			public System.Int32 GroupId
			{
				get
				{
					return _GroupId;
				}
				set
				{
					_GroupId = value;
				}
			}
			private System.String _Email;
			/// <summary>
			///,Remark:邮箱地址
			/// </summary>
			[Mapping("Email")]
			public System.String Email
			{
				get
				{
					return _Email;
				}
				set
				{
					_Email = value;
				}
			}
			private System.String _Mobile;
			/// <summary>
			///,Remark:手机号码
			/// </summary>
			[Mapping("Mobile")]
			public System.String Mobile
			{
				get
				{
					return _Mobile;
				}
				set
				{
					_Mobile = value;
				}
			}
			private System.Int32 _District;
			/// <summary>
			///,Remark:地区
			/// </summary>
			[Mapping("District")]
			public System.Int32 District
			{
				get
				{
					return _District;
				}
				set
				{
					_District = value;
				}
			}
			private System.String _OtherContact;
			/// <summary>
			///,Remark:其他联系方式
			/// </summary>
			[Mapping("OtherContact")]
			public System.String OtherContact
			{
				get
				{
					return _OtherContact;
				}
				set
				{
					_OtherContact = value;
				}
			}
			private System.Decimal _Funds;
			/// <summary>
			///,Remark:会员可用资金
			/// </summary>
			[Mapping("Funds")]
			public System.Decimal Funds
			{
				get
				{
					return _Funds;
				}
				set
				{
					_Funds = value;
				}
			}
			private System.Decimal _frostFunds;
			/// <summary>
			///,Remark:被冻结的金额
			/// </summary>
			[Mapping("frostFunds")]
			public System.Decimal frostFunds
			{
				get
				{
					return _frostFunds;
				}
				set
				{
					_frostFunds = value;
				}
			}
			private System.Double _Integral;
			/// <summary>
			///,Remark:站内积分
			/// </summary>
			[Mapping("Integral")]
			public System.Double Integral
			{
				get
				{
					return _Integral;
				}
				set
				{
					_Integral = value;
				}
			}
			private System.Int32 _Referee;
			/// <summary>
			///,Remark:推荐人
			/// </summary>
			[Mapping("Referee")]
			public System.Int32 Referee
			{
				get
				{
					return _Referee;
				}
				set
				{
					_Referee = value;
				}
			}
			private System.String _LastIP;
			/// <summary>
			///,Remark:最后登录IP
			/// </summary>
			[Mapping("LastIP")]
			public System.String LastIP
			{
				get
				{
					return _LastIP;
				}
				set
				{
					_LastIP = value;
				}
			}
			private System.String _PrevIP;
			/// <summary>
			///,Remark:上次登录IP
			/// </summary>
			[Mapping("PrevIP")]
			public System.String PrevIP
			{
				get
				{
					return _PrevIP;
				}
				set
				{
					_PrevIP = value;
				}
			}
			private System.String _RegIP;
			/// <summary>
			///,Remark:注册IP
			/// </summary>
			[Mapping("RegIP")]
			public System.String RegIP
			{
				get
				{
					return _RegIP;
				}
				set
				{
					_RegIP = value;
				}
			}
			private System.DateTime _LastLoginTime;
			/// <summary>
			///,Remark:最后登录时间
			/// </summary>
			[Mapping("LastLoginTime")]
			public System.DateTime LastLoginTime
			{
				get
				{
					return _LastLoginTime;
				}
				set
				{
					_LastLoginTime = value;
				}
			}
			private System.DateTime _logingtime;
			[Mapping("logingtime")]
			public System.DateTime logingtime
			{
				get
				{
					return _logingtime;
				}
				set
				{
					_logingtime = value;
				}
			}
			private System.Int32 _State;
			/// <summary>
			///,Remark:状态，0禁用，1启用
			/// </summary>
			[Mapping("State")]
			public System.Int32 State
			{
				get
				{
					return _State;
				}
				set
				{
					_State = value;
				}
			}
			private System.DateTime _RegTime;
			/// <summary>
			///,Remark:注册时间
			/// </summary>
			[Mapping("RegTime")]
			public System.DateTime RegTime
			{
				get
				{
					return _RegTime;
				}
				set
				{
					_RegTime = value;
				}
			}
			private System.DateTime _AddTime;
			/// <summary>
			///,Remark:添加时间
			/// </summary>
			[Mapping("AddTime")]
			public System.DateTime AddTime
			{
				get
				{
					return _AddTime;
				}
				set
				{
					_AddTime = value;
				}
			}
			private System.Int32 _IsReceiveSms;
			/// <summary>
			///,Remark:是否接受最新团购短信，1是，0否
			/// </summary>
			[Mapping("IsReceiveSms")]
			public System.Int32 IsReceiveSms
			{
				get
				{
					return _IsReceiveSms;
				}
				set
				{
					_IsReceiveSms = value;
				}
			}
			private System.String _Friends;
			/// <summary>
			///,Remark:我的好友
			/// </summary>
			[Mapping("Friends")]
			public System.String Friends
			{
				get
				{
					return _Friends;
				}
				set
				{
					_Friends = value;
				}
			}
			private System.String _loginappid;
			[Mapping("loginappid")]
			public System.String loginappid
			{
				get
				{
					return _loginappid;
				}
				set
				{
					_loginappid = value;
				}
			}
			private System.DateTime _forgotpwdtime;
			[Mapping("forgotpwdtime")]
			public System.DateTime forgotpwdtime
			{
				get
				{
					return _forgotpwdtime;
				}
				set
				{
					_forgotpwdtime = value;
				}
			}
			private System.String _idcard;
			/// <summary>
			///,Remark:身份证号
			/// </summary>
			[Mapping("idcard")]
			public System.String idcard
			{
				get
				{
					return _idcard;
				}
				set
				{
					_idcard = value;
				}
			}
			private System.DateTime _birthtime;
			/// <summary>
			///,Remark:出生日期
			/// </summary>
			[Mapping("birthtime")]
			public System.DateTime birthtime
			{
				get
				{
					return _birthtime;
				}
				set
				{
					_birthtime = value;
				}
			}
			private System.String _linkaddress;
			/// <summary>
			///,Remark:联系地址
			/// </summary>
			[Mapping("linkaddress")]
			public System.String linkaddress
			{
				get
				{
					return _linkaddress;
				}
				set
				{
					_linkaddress = value;
				}
			}
			private System.String _industry;
			[Mapping("industry")]
			public System.String industry
			{
				get
				{
					return _industry;
				}
				set
				{
					_industry = value;
				}
			}
			private System.Int32 _mshopid;
			/// <summary>
			///,Remark:会员绑定商户ID
			/// </summary>
			[Mapping("mshopid")]
			public System.Int32 mshopid
			{
				get
				{
					return _mshopid;
				}
				set
				{
					_mshopid = value;
				}
			}
			private System.Int32 _headuid;
			/// <summary>
			///,Remark:父级ID
			/// </summary>
			[Mapping("headuid")]
			public System.Int32 headuid
			{
				get
				{
					return _headuid;
				}
				set
				{
					_headuid = value;
				}
			}
			private System.Int32 _areaid1;
			[Mapping("areaid1")]
			public System.Int32 areaid1
			{
				get
				{
					return _areaid1;
				}
				set
				{
					_areaid1 = value;
				}
			}
			private System.Int32 _areaid2;
			[Mapping("areaid2")]
			public System.Int32 areaid2
			{
				get
				{
					return _areaid2;
				}
				set
				{
					_areaid2 = value;
				}
			}
			private System.Int32 _areaid3;
			[Mapping("areaid3")]
			public System.Int32 areaid3
			{
				get
				{
					return _areaid3;
				}
				set
				{
					_areaid3 = value;
				}
			}
			private System.String _paypwd;
			[Mapping("paypwd")]
			public System.String paypwd
			{
				get
				{
					return _paypwd;
				}
				set
				{
					_paypwd = value;
				}
			}
			private System.String _icon_old;
			[Mapping("icon_old")]
			public System.String icon_old
			{
				get
				{
					return _icon_old;
				}
				set
				{
					_icon_old = value;
				}
			}
			private System.Int32 _experience;
			[Mapping("experience")]
			public System.Int32 experience
			{
				get
				{
					return _experience;
				}
				set
				{
					_experience = value;
				}
			}
			private System.Boolean _IsPerfectInfo;
			[Mapping("IsPerfectInfo")]
			public System.Boolean IsPerfectInfo
			{
				get
				{
					return _IsPerfectInfo;
				}
				set
				{
					_IsPerfectInfo = value;
				}
			}
			private System.Boolean _emailApprove;
			/// <summary>
			///,Remark:是否绑定邮箱
			/// </summary>
			[Mapping("emailApprove")]
			public System.Boolean emailApprove
			{
				get
				{
					return _emailApprove;
				}
				set
				{
					_emailApprove = value;
				}
			}
			private System.Boolean _phoneApprove;
			/// <summary>
			///,Remark:是否绑定手机号码
			/// </summary>
			[Mapping("phoneApprove")]
			public System.Boolean phoneApprove
			{
				get
				{
					return _phoneApprove;
				}
				set
				{
					_phoneApprove = value;
				}
			}
			private System.Boolean _isSetSafeQuestion;
			/// <summary>
			///,Remark:是否绑定安全问题
			/// </summary>
			[Mapping("isSetSafeQuestion")]
			public System.Boolean isSetSafeQuestion
			{
				get
				{
					return _isSetSafeQuestion;
				}
				set
				{
					_isSetSafeQuestion = value;
				}
			}
			private System.String _question;
			/// <summary>
			///,Remark:绑定的问题
			/// </summary>
			[Mapping("question")]
			public System.String question
			{
				get
				{
					return _question;
				}
				set
				{
					_question = value;
				}
			}
			private System.String _answer;
			/// <summary>
			///,Remark:绑定的答案
			/// </summary>
			[Mapping("answer")]
			public System.String answer
			{
				get
				{
					return _answer;
				}
				set
				{
					_answer = value;
				}
			}
			private System.Boolean _isIdApprove;
			/// <summary>
			///,Remark:是否绑定身份证
			/// </summary>
			[Mapping("isIdApprove")]
			public System.Boolean isIdApprove
			{
				get
				{
					return _isIdApprove;
				}
				set
				{
					_isIdApprove = value;
				}
			}
			private System.String _bankNum;
			/// <summary>
			///,Remark:银行帐号
			/// </summary>
			[Mapping("bankNum")]
			public System.String bankNum
			{
				get
				{
					return _bankNum;
				}
				set
				{
					_bankNum = value;
				}
			}
			private System.Boolean _isBingBank;
			/// <summary>
			///,Remark:是否绑定银行
			/// </summary>
			[Mapping("isBingBank")]
			public System.Boolean isBingBank
			{
				get
				{
					return _isBingBank;
				}
				set
				{
					_isBingBank = value;
				}
			}
			private System.String _honourId;
			[Mapping("honourId")]
			public System.String honourId
			{
				get
				{
					return _honourId;
				}
				set
				{
					_honourId = value;
				}
			}
			private System.Int32 _gradeId;
			[Mapping("gradeId")]
			public System.Int32 gradeId
			{
				get
				{
					return _gradeId;
				}
				set
				{
					_gradeId = value;
				}
			}
			private System.String _weixin_openid;
			[Mapping("weixin_openid")]
			public System.String weixin_openid
			{
				get
				{
					return _weixin_openid;
				}
				set
				{
					_weixin_openid = value;
				}
			}
			private System.String _qq_openid;
			[Mapping("qq_openid")]
			public System.String qq_openid
			{
				get
				{
					return _qq_openid;
				}
				set
				{
					_qq_openid = value;
				}
			}
			#endregion
			public UO_SaleShop_Member()
			{
			}
		}
		public partial class UOList_SaleShop_Member : GetTogether.ObjectBase.ListBase<UO_SaleShop_Member>
		{
			public UOList_SaleShop_Member()
			{
			}
		}
	}


	public partial class BO_SaleShop_Member
	{
		#region Condition functions
		///<summary>
		///Get conditions by primary key string.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKeyString(string primaryKeyString)
		{
			string[] primaryKeys = primaryKeyString.Split('|');
			System.Int32 UId = Convert.ToInt32(primaryKeys[0]);
			return GetConditionsByPrimaryKey(UId);
		}

		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKey(System.Int32 UId)
		{
			ParameterCollection primaryConditions = new ParameterCollection();
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_SaleShop_Member.Columns.UId, UId);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int32 UId)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_SaleShop_Member.Columns.UId, UId);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_SaleShop_Member.Columns column,Dictionary<DO_SaleShop_Member.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_SaleShop_Member.UO_SaleShop_Member parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_Member.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.UId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.UId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.UId,extTokens), DO_SaleShop_Member.Columns.UId,parameterObj.UId);
			}
			if (!string.IsNullOrEmpty(parameterObj.UserName))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.UserName,extTokens), DO_SaleShop_Member.Columns.UserName,parameterObj.UserName);
			}
			if (!string.IsNullOrEmpty(parameterObj.RealName))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.RealName,extTokens), DO_SaleShop_Member.Columns.RealName,parameterObj.RealName);
			}
			if (!string.IsNullOrEmpty(parameterObj.ICON))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.ICON,extTokens), DO_SaleShop_Member.Columns.ICON,parameterObj.ICON);
			}
			if (!string.IsNullOrEmpty(parameterObj.Password))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.Password,extTokens), DO_SaleShop_Member.Columns.Password,parameterObj.Password);
			}
			if (parameterObj.Gender != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.Gender)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.Gender,extTokens), DO_SaleShop_Member.Columns.Gender,parameterObj.Gender);
			}
			if (parameterObj.GroupId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.GroupId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.GroupId,extTokens), DO_SaleShop_Member.Columns.GroupId,parameterObj.GroupId);
			}
			if (!string.IsNullOrEmpty(parameterObj.Email))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.Email,extTokens), DO_SaleShop_Member.Columns.Email,parameterObj.Email);
			}
			if (!string.IsNullOrEmpty(parameterObj.Mobile))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.Mobile,extTokens), DO_SaleShop_Member.Columns.Mobile,parameterObj.Mobile);
			}
			if (parameterObj.District != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.District)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.District,extTokens), DO_SaleShop_Member.Columns.District,parameterObj.District);
			}
			if (!string.IsNullOrEmpty(parameterObj.OtherContact))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.OtherContact,extTokens), DO_SaleShop_Member.Columns.OtherContact,parameterObj.OtherContact);
			}
			if (parameterObj.Funds != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.Funds)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.Funds,extTokens), DO_SaleShop_Member.Columns.Funds,parameterObj.Funds);
			}
			if (parameterObj.frostFunds != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.frostFunds)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.frostFunds,extTokens), DO_SaleShop_Member.Columns.frostFunds,parameterObj.frostFunds);
			}
			if (parameterObj.Referee != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.Referee)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.Referee,extTokens), DO_SaleShop_Member.Columns.Referee,parameterObj.Referee);
			}
			if (!string.IsNullOrEmpty(parameterObj.LastIP))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.LastIP,extTokens), DO_SaleShop_Member.Columns.LastIP,parameterObj.LastIP);
			}
			if (!string.IsNullOrEmpty(parameterObj.PrevIP))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.PrevIP,extTokens), DO_SaleShop_Member.Columns.PrevIP,parameterObj.PrevIP);
			}
			if (!string.IsNullOrEmpty(parameterObj.RegIP))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.RegIP,extTokens), DO_SaleShop_Member.Columns.RegIP,parameterObj.RegIP);
			}
			if (parameterObj.State != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.State)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.State,extTokens), DO_SaleShop_Member.Columns.State,parameterObj.State);
			}
			if (parameterObj.IsReceiveSms != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.IsReceiveSms)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.IsReceiveSms,extTokens), DO_SaleShop_Member.Columns.IsReceiveSms,parameterObj.IsReceiveSms);
			}
			if (!string.IsNullOrEmpty(parameterObj.Friends))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.Friends,extTokens), DO_SaleShop_Member.Columns.Friends,parameterObj.Friends);
			}
			if (!string.IsNullOrEmpty(parameterObj.loginappid))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.loginappid,extTokens), DO_SaleShop_Member.Columns.loginappid,parameterObj.loginappid);
			}
			if (!string.IsNullOrEmpty(parameterObj.idcard))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.idcard,extTokens), DO_SaleShop_Member.Columns.idcard,parameterObj.idcard);
			}
			if (!string.IsNullOrEmpty(parameterObj.linkaddress))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.linkaddress,extTokens), DO_SaleShop_Member.Columns.linkaddress,parameterObj.linkaddress);
			}
			if (!string.IsNullOrEmpty(parameterObj.industry))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.industry,extTokens), DO_SaleShop_Member.Columns.industry,parameterObj.industry);
			}
			if (parameterObj.mshopid != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.mshopid)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.mshopid,extTokens), DO_SaleShop_Member.Columns.mshopid,parameterObj.mshopid);
			}
			if (parameterObj.headuid != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.headuid)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.headuid,extTokens), DO_SaleShop_Member.Columns.headuid,parameterObj.headuid);
			}
			if (parameterObj.areaid1 != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.areaid1)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.areaid1,extTokens), DO_SaleShop_Member.Columns.areaid1,parameterObj.areaid1);
			}
			if (parameterObj.areaid2 != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.areaid2)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.areaid2,extTokens), DO_SaleShop_Member.Columns.areaid2,parameterObj.areaid2);
			}
			if (parameterObj.areaid3 != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.areaid3)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.areaid3,extTokens), DO_SaleShop_Member.Columns.areaid3,parameterObj.areaid3);
			}
			if (!string.IsNullOrEmpty(parameterObj.paypwd))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.paypwd,extTokens), DO_SaleShop_Member.Columns.paypwd,parameterObj.paypwd);
			}
			if (!string.IsNullOrEmpty(parameterObj.icon_old))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.icon_old,extTokens), DO_SaleShop_Member.Columns.icon_old,parameterObj.icon_old);
			}
			if (parameterObj.experience != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.experience)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.experience,extTokens), DO_SaleShop_Member.Columns.experience,parameterObj.experience);
			}
			if (!string.IsNullOrEmpty(parameterObj.question))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.question,extTokens), DO_SaleShop_Member.Columns.question,parameterObj.question);
			}
			if (!string.IsNullOrEmpty(parameterObj.answer))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.answer,extTokens), DO_SaleShop_Member.Columns.answer,parameterObj.answer);
			}
			if (!string.IsNullOrEmpty(parameterObj.bankNum))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.bankNum,extTokens), DO_SaleShop_Member.Columns.bankNum,parameterObj.bankNum);
			}
			if (!string.IsNullOrEmpty(parameterObj.honourId))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.honourId,extTokens), DO_SaleShop_Member.Columns.honourId,parameterObj.honourId);
			}
			if (parameterObj.gradeId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_Member.Columns.gradeId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.gradeId,extTokens), DO_SaleShop_Member.Columns.gradeId,parameterObj.gradeId);
			}
			if (!string.IsNullOrEmpty(parameterObj.weixin_openid))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.weixin_openid,extTokens), DO_SaleShop_Member.Columns.weixin_openid,parameterObj.weixin_openid);
			}
			if (!string.IsNullOrEmpty(parameterObj.qq_openid))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_Member.Columns.qq_openid,extTokens), DO_SaleShop_Member.Columns.qq_openid,parameterObj.qq_openid);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_SaleShop_Member.UOList_SaleShop_Member GetAllList()
		{
			DO_SaleShop_Member da = new DO_SaleShop_Member();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_SaleShop_Member da = new DO_SaleShop_Member();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_SaleShop_Member.UO_SaleShop_Member parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_SaleShop_Member.UO_SaleShop_Member parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_Member.Columns, TokenTypes> extTokens)
		{
			DO_SaleShop_Member da = new DO_SaleShop_Member();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_SaleShop_Member.UOList_SaleShop_Member GetList(DO_SaleShop_Member.UO_SaleShop_Member parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_Member.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_SaleShop_Member.UOList_SaleShop_Member GetList(DO_SaleShop_Member.UO_SaleShop_Member parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_SaleShop_Member.UO_SaleShop_Member GetObject(System.Int32 UId)
		{
			DO_SaleShop_Member da = new DO_SaleShop_Member();
			DO_SaleShop_Member.UOList_SaleShop_Member l = da.GetList(GetConditionsByPrimaryKey(UId));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_SaleShop_Member.UO_SaleShop_Member GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_SaleShop_Member da = new DO_SaleShop_Member();
			DO_SaleShop_Member.UOList_SaleShop_Member l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_SaleShop_Member.UO_SaleShop_Member, DO_SaleShop_Member.UOList_SaleShop_Member> GetPagingList(DO_SaleShop_Member.UO_SaleShop_Member parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_Member.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_SaleShop_Member.UO_SaleShop_Member, DO_SaleShop_Member.UOList_SaleShop_Member> GetPagingList(DO_SaleShop_Member.UO_SaleShop_Member parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_SaleShop_Member.UO_SaleShop_Member GetObjectById(System.Int32 UId)
		{
			DO_SaleShop_Member da = new DO_SaleShop_Member();
			DO_SaleShop_Member.UOList_SaleShop_Member l = da.GetList(GetConditionsById(UId));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_SaleShop_Member.UO_SaleShop_Member obj, System.Int32 UId)
		{
			return obj.Update(GetConditionsByPrimaryKey(UId)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_SaleShop_Member.UO_SaleShop_Member obj, System.Int32 UId, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(UId)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_SaleShop_Member.UO_SaleShop_Member obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_SaleShop_Member.UO_SaleShop_Member obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}
		#endregion

		#region Delete functions
		///<summary>
		///Delete object by primary key.
		///</summary>
		public static int Delete(System.Int32 UId)
		{
			DO_SaleShop_Member da = new DO_SaleShop_Member();
			return da.Delete(GetConditionsByPrimaryKey(UId));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int32 UId, IDbConnection connection, IDbTransaction transaction)
		{
			DO_SaleShop_Member da = new DO_SaleShop_Member();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(UId));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_SaleShop_Member da = new DO_SaleShop_Member();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_SaleShop_Member da = new DO_SaleShop_Member();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}