using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_SaleShop_ShopInfo_Callback : GetTogether.Web.UI.PageCallback
{
    protected void Page_Load(object sender, EventArgs e)
    {
        switch (type)
        {
            case 1:
                GetList();
                break;
			case 4:
				Delete();
				break;
            default:
                break;
        }
    }

    private void GetList()
    {
        Database_Output_SaleShop_ShopInfo_Result c = (Database_Output_SaleShop_ShopInfo_Result)Page.LoadControl("SaleShop_ShopInfo_Result.ascx");
        DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo l = new DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo();
        GetTogether.Web.WebHelper.SetValues<DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo>(l, "SaleShop_ShopInfo_");
        if (string.IsNullOrEmpty(Sort)) Sort = DO_SaleShop_ShopInfo.Columns.ShopId.ToString();
        PagingResult<DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo, DO_SaleShop_ShopInfo.UOList_SaleShop_ShopInfo> resultPaging = BO_SaleShop_ShopInfo.GetPagingList(l, PageIndex, PageSize, Sort, IsAsc);
        c.JsFunction = "SaleShop_ShopInfo_Search";
        c.SetData<DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo, DO_SaleShop_ShopInfo.UOList_SaleShop_ShopInfo>(resultPaging.Result);
        c.Total = resultPaging.Total;
        c.Sort = Sort;
        c.PageIndex = PageIndex;
        c.PageSize = PageSize;
        c.IsAsc = IsAsc;
        this.Controls.Add(c);
    }

    private void Delete()
    {
        try
        {
            if (string.IsNullOrEmpty(Request["keys"]))
            {
                JsonSuccess();
            }
            int[] ids = GetParameterArrayInt(Request["keys"], "SaleShop_ShopInfo_", ',');
            ParameterCollection conditions = new ParameterCollection();
            conditions.AddCondition(ParameterType.Initial, TokenTypes.In, DO_SaleShop_ShopInfo.Columns.ShopId, ids);
 
            if (new DO_SaleShop_ShopInfo().Delete(conditions) > 0)
                JsonSuccess();
            else
                JsonError("Delete Failure");
        }
        catch (Exception ex)
        {
            JsonError(ex.Message);
        }
    }

	public partial class DO_SaleShop_ShopInfo : DOBase<DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo, DO_SaleShop_ShopInfo.UOList_SaleShop_ShopInfo>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "SaleShop_ShopInfo",
                        @"Data Source=112.124.118.0;Initial Catalog=NHOMEKF;Persist Security Info=True;User ID=sa;Password=Esunlit2008;Connect Timeout=99999999",
                        new string[] {"ShopId"},
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
			ShopId,
			CorpId,
			StId,
			ShopType,
			ShopBelong,
			ScId,
			ScIdSon,
			ShopName,
			ShopSubName,
			WebTitle,
			ProvinceId,
			CityId,
			AreaId,
			ShopGrade,
			ShopImg,
			Landmark,
			Address,
			SvrTel,
			SvrQQ,
			SvrWorking,
			DiscountInfo,
			DiscountStartTime,
			DiscountEndTime,
			MapAddress,
			Longitude,
			Latitude,
			IsMain,
			ShopInstroduction,
			ShoppingGuide,
			SvrCusServices,
			TradeRate,
			IsMsgSend,
			Domain,
			LogoType,
			LogoText,
			LogoImg,
			StartLevel,
			Population,
			HitCount,
			Deposit,
			MetaKeyword,
			MetaDescrition,
			ShopICP,
			WeixinToken,
			WeixinAppid,
			WeixinAppSecret,
			WeixinPublicAcount,
			WeixinQrCode,
			WeixinImg,
			BankType,
			BankOwer,
			BankName,
			BankAccount,
			MgrName,
			MgrEmail,
			MgrQQ,
			MgrTel,
			AttachLicense,
			AttachJoin,
			AttachMgrIDCard,
			ApplyId,
			OrderNum,
			Disable,
			CreateTime,
			Editor,
			EditTime,
		}
		public DO_SaleShop_ShopInfo()
		{
		}
		public partial class UO_SaleShop_ShopInfo : UOBase<UO_SaleShop_ShopInfo,UOList_SaleShop_ShopInfo>
		{
                        public override ConnectionInformation GetDefaultConnectionInformation()
                        {
                            return GetConnectionInformation();
                        }
			#region Columns
			private System.Int64 _ShopId;
			/// <summary>
			///Primary Key,Auto Increment
			/// </summary>
			[Mapping("ShopId,un-insert,un-update")]
			public System.Int64 ShopId
			{
				get
				{
					return _ShopId;
				}
				set
				{
					_ShopId = value;
				}
			}
			private System.Int64 _CorpId;
			[Mapping("CorpId")]
			public System.Int64 CorpId
			{
				get
				{
					return _CorpId;
				}
				set
				{
					_CorpId = value;
				}
			}
			private System.Int64 _StId;
			[Mapping("StId")]
			public System.Int64 StId
			{
				get
				{
					return _StId;
				}
				set
				{
					_StId = value;
				}
			}
			private System.Int32 _ShopType;
			[Mapping("ShopType")]
			public System.Int32 ShopType
			{
				get
				{
					return _ShopType;
				}
				set
				{
					_ShopType = value;
				}
			}
			private System.Int32 _ShopBelong;
			[Mapping("ShopBelong")]
			public System.Int32 ShopBelong
			{
				get
				{
					return _ShopBelong;
				}
				set
				{
					_ShopBelong = value;
				}
			}
			private System.Int64 _ScId;
			[Mapping("ScId")]
			public System.Int64 ScId
			{
				get
				{
					return _ScId;
				}
				set
				{
					_ScId = value;
				}
			}
			private System.Int64 _ScIdSon;
			[Mapping("ScIdSon")]
			public System.Int64 ScIdSon
			{
				get
				{
					return _ScIdSon;
				}
				set
				{
					_ScIdSon = value;
				}
			}
			private System.String _ShopName;
			[Mapping("ShopName")]
			public System.String ShopName
			{
				get
				{
					return _ShopName;
				}
				set
				{
					_ShopName = value;
				}
			}
			private System.String _ShopSubName;
			[Mapping("ShopSubName")]
			public System.String ShopSubName
			{
				get
				{
					return _ShopSubName;
				}
				set
				{
					_ShopSubName = value;
				}
			}
			private System.String _WebTitle;
			[Mapping("WebTitle")]
			public System.String WebTitle
			{
				get
				{
					return _WebTitle;
				}
				set
				{
					_WebTitle = value;
				}
			}
			private System.Int64 _ProvinceId;
			[Mapping("ProvinceId")]
			public System.Int64 ProvinceId
			{
				get
				{
					return _ProvinceId;
				}
				set
				{
					_ProvinceId = value;
				}
			}
			private System.Int64 _CityId;
			[Mapping("CityId")]
			public System.Int64 CityId
			{
				get
				{
					return _CityId;
				}
				set
				{
					_CityId = value;
				}
			}
			private System.Int64 _AreaId;
			[Mapping("AreaId")]
			public System.Int64 AreaId
			{
				get
				{
					return _AreaId;
				}
				set
				{
					_AreaId = value;
				}
			}
			private System.String _ShopGrade;
			[Mapping("ShopGrade")]
			public System.String ShopGrade
			{
				get
				{
					return _ShopGrade;
				}
				set
				{
					_ShopGrade = value;
				}
			}
			private System.String _ShopImg;
			[Mapping("ShopImg")]
			public System.String ShopImg
			{
				get
				{
					return _ShopImg;
				}
				set
				{
					_ShopImg = value;
				}
			}
			private System.String _Landmark;
			[Mapping("Landmark")]
			public System.String Landmark
			{
				get
				{
					return _Landmark;
				}
				set
				{
					_Landmark = value;
				}
			}
			private System.String _Address;
			[Mapping("Address")]
			public System.String Address
			{
				get
				{
					return _Address;
				}
				set
				{
					_Address = value;
				}
			}
			private System.String _SvrTel;
			[Mapping("SvrTel")]
			public System.String SvrTel
			{
				get
				{
					return _SvrTel;
				}
				set
				{
					_SvrTel = value;
				}
			}
			private System.String _SvrQQ;
			[Mapping("SvrQQ")]
			public System.String SvrQQ
			{
				get
				{
					return _SvrQQ;
				}
				set
				{
					_SvrQQ = value;
				}
			}
			private System.String _SvrWorking;
			[Mapping("SvrWorking")]
			public System.String SvrWorking
			{
				get
				{
					return _SvrWorking;
				}
				set
				{
					_SvrWorking = value;
				}
			}
			private System.String _DiscountInfo;
			[Mapping("DiscountInfo")]
			public System.String DiscountInfo
			{
				get
				{
					return _DiscountInfo;
				}
				set
				{
					_DiscountInfo = value;
				}
			}
			private System.DateTime _DiscountStartTime;
			[Mapping("DiscountStartTime")]
			public System.DateTime DiscountStartTime
			{
				get
				{
					return _DiscountStartTime;
				}
				set
				{
					_DiscountStartTime = value;
				}
			}
			private System.DateTime _DiscountEndTime;
			[Mapping("DiscountEndTime")]
			public System.DateTime DiscountEndTime
			{
				get
				{
					return _DiscountEndTime;
				}
				set
				{
					_DiscountEndTime = value;
				}
			}
			private System.String _MapAddress;
			[Mapping("MapAddress")]
			public System.String MapAddress
			{
				get
				{
					return _MapAddress;
				}
				set
				{
					_MapAddress = value;
				}
			}
			private System.Double _Longitude;
			[Mapping("Longitude")]
			public System.Double Longitude
			{
				get
				{
					return _Longitude;
				}
				set
				{
					_Longitude = value;
				}
			}
			private System.Double _Latitude;
			[Mapping("Latitude")]
			public System.Double Latitude
			{
				get
				{
					return _Latitude;
				}
				set
				{
					_Latitude = value;
				}
			}
			private System.Boolean _IsMain;
			[Mapping("IsMain")]
			public System.Boolean IsMain
			{
				get
				{
					return _IsMain;
				}
				set
				{
					_IsMain = value;
				}
			}
			private System.String _ShopInstroduction;
			[Mapping("ShopInstroduction")]
			public System.String ShopInstroduction
			{
				get
				{
					return _ShopInstroduction;
				}
				set
				{
					_ShopInstroduction = value;
				}
			}
			private System.String _ShoppingGuide;
			[Mapping("ShoppingGuide")]
			public System.String ShoppingGuide
			{
				get
				{
					return _ShoppingGuide;
				}
				set
				{
					_ShoppingGuide = value;
				}
			}
			private System.String _SvrCusServices;
			[Mapping("SvrCusServices")]
			public System.String SvrCusServices
			{
				get
				{
					return _SvrCusServices;
				}
				set
				{
					_SvrCusServices = value;
				}
			}
			private System.Double _TradeRate;
			[Mapping("TradeRate")]
			public System.Double TradeRate
			{
				get
				{
					return _TradeRate;
				}
				set
				{
					_TradeRate = value;
				}
			}
			private System.Boolean _IsMsgSend;
			[Mapping("IsMsgSend")]
			public System.Boolean IsMsgSend
			{
				get
				{
					return _IsMsgSend;
				}
				set
				{
					_IsMsgSend = value;
				}
			}
			private System.String _Domain;
			[Mapping("Domain")]
			public System.String Domain
			{
				get
				{
					return _Domain;
				}
				set
				{
					_Domain = value;
				}
			}
			private System.Int32 _LogoType;
			[Mapping("LogoType")]
			public System.Int32 LogoType
			{
				get
				{
					return _LogoType;
				}
				set
				{
					_LogoType = value;
				}
			}
			private System.String _LogoText;
			[Mapping("LogoText")]
			public System.String LogoText
			{
				get
				{
					return _LogoText;
				}
				set
				{
					_LogoText = value;
				}
			}
			private System.String _LogoImg;
			[Mapping("LogoImg")]
			public System.String LogoImg
			{
				get
				{
					return _LogoImg;
				}
				set
				{
					_LogoImg = value;
				}
			}
			private System.Int32 _StartLevel;
			[Mapping("StartLevel")]
			public System.Int32 StartLevel
			{
				get
				{
					return _StartLevel;
				}
				set
				{
					_StartLevel = value;
				}
			}
			private System.Int32 _Population;
			[Mapping("Population")]
			public System.Int32 Population
			{
				get
				{
					return _Population;
				}
				set
				{
					_Population = value;
				}
			}
			private System.Int32 _HitCount;
			[Mapping("HitCount")]
			public System.Int32 HitCount
			{
				get
				{
					return _HitCount;
				}
				set
				{
					_HitCount = value;
				}
			}
			private System.Decimal _Deposit;
			[Mapping("Deposit")]
			public System.Decimal Deposit
			{
				get
				{
					return _Deposit;
				}
				set
				{
					_Deposit = value;
				}
			}
			private System.String _MetaKeyword;
			[Mapping("MetaKeyword")]
			public System.String MetaKeyword
			{
				get
				{
					return _MetaKeyword;
				}
				set
				{
					_MetaKeyword = value;
				}
			}
			private System.String _MetaDescrition;
			[Mapping("MetaDescrition")]
			public System.String MetaDescrition
			{
				get
				{
					return _MetaDescrition;
				}
				set
				{
					_MetaDescrition = value;
				}
			}
			private System.String _ShopICP;
			[Mapping("ShopICP")]
			public System.String ShopICP
			{
				get
				{
					return _ShopICP;
				}
				set
				{
					_ShopICP = value;
				}
			}
			private System.String _WeixinToken;
			[Mapping("WeixinToken")]
			public System.String WeixinToken
			{
				get
				{
					return _WeixinToken;
				}
				set
				{
					_WeixinToken = value;
				}
			}
			private System.String _WeixinAppid;
			[Mapping("WeixinAppid")]
			public System.String WeixinAppid
			{
				get
				{
					return _WeixinAppid;
				}
				set
				{
					_WeixinAppid = value;
				}
			}
			private System.String _WeixinAppSecret;
			[Mapping("WeixinAppSecret")]
			public System.String WeixinAppSecret
			{
				get
				{
					return _WeixinAppSecret;
				}
				set
				{
					_WeixinAppSecret = value;
				}
			}
			private System.Boolean _WeixinPublicAcount;
			[Mapping("WeixinPublicAcount")]
			public System.Boolean WeixinPublicAcount
			{
				get
				{
					return _WeixinPublicAcount;
				}
				set
				{
					_WeixinPublicAcount = value;
				}
			}
			private System.String _WeixinQrCode;
			[Mapping("WeixinQrCode")]
			public System.String WeixinQrCode
			{
				get
				{
					return _WeixinQrCode;
				}
				set
				{
					_WeixinQrCode = value;
				}
			}
			private System.String _WeixinImg;
			[Mapping("WeixinImg")]
			public System.String WeixinImg
			{
				get
				{
					return _WeixinImg;
				}
				set
				{
					_WeixinImg = value;
				}
			}
			private System.Int32 _BankType;
			[Mapping("BankType")]
			public System.Int32 BankType
			{
				get
				{
					return _BankType;
				}
				set
				{
					_BankType = value;
				}
			}
			private System.String _BankOwer;
			[Mapping("BankOwer")]
			public System.String BankOwer
			{
				get
				{
					return _BankOwer;
				}
				set
				{
					_BankOwer = value;
				}
			}
			private System.String _BankName;
			[Mapping("BankName")]
			public System.String BankName
			{
				get
				{
					return _BankName;
				}
				set
				{
					_BankName = value;
				}
			}
			private System.String _BankAccount;
			[Mapping("BankAccount")]
			public System.String BankAccount
			{
				get
				{
					return _BankAccount;
				}
				set
				{
					_BankAccount = value;
				}
			}
			private System.String _MgrName;
			[Mapping("MgrName")]
			public System.String MgrName
			{
				get
				{
					return _MgrName;
				}
				set
				{
					_MgrName = value;
				}
			}
			private System.String _MgrEmail;
			[Mapping("MgrEmail")]
			public System.String MgrEmail
			{
				get
				{
					return _MgrEmail;
				}
				set
				{
					_MgrEmail = value;
				}
			}
			private System.String _MgrQQ;
			[Mapping("MgrQQ")]
			public System.String MgrQQ
			{
				get
				{
					return _MgrQQ;
				}
				set
				{
					_MgrQQ = value;
				}
			}
			private System.String _MgrTel;
			[Mapping("MgrTel")]
			public System.String MgrTel
			{
				get
				{
					return _MgrTel;
				}
				set
				{
					_MgrTel = value;
				}
			}
			private System.String _AttachLicense;
			[Mapping("AttachLicense")]
			public System.String AttachLicense
			{
				get
				{
					return _AttachLicense;
				}
				set
				{
					_AttachLicense = value;
				}
			}
			private System.String _AttachJoin;
			[Mapping("AttachJoin")]
			public System.String AttachJoin
			{
				get
				{
					return _AttachJoin;
				}
				set
				{
					_AttachJoin = value;
				}
			}
			private System.String _AttachMgrIDCard;
			[Mapping("AttachMgrIDCard")]
			public System.String AttachMgrIDCard
			{
				get
				{
					return _AttachMgrIDCard;
				}
				set
				{
					_AttachMgrIDCard = value;
				}
			}
			private System.Int64 _ApplyId;
			[Mapping("ApplyId")]
			public System.Int64 ApplyId
			{
				get
				{
					return _ApplyId;
				}
				set
				{
					_ApplyId = value;
				}
			}
			private System.Int32 _OrderNum;
			[Mapping("OrderNum")]
			public System.Int32 OrderNum
			{
				get
				{
					return _OrderNum;
				}
				set
				{
					_OrderNum = value;
				}
			}
			private System.Boolean _Disable;
			[Mapping("Disable")]
			public System.Boolean Disable
			{
				get
				{
					return _Disable;
				}
				set
				{
					_Disable = value;
				}
			}
			private System.DateTime _CreateTime;
			[Mapping("CreateTime")]
			public System.DateTime CreateTime
			{
				get
				{
					return _CreateTime;
				}
				set
				{
					_CreateTime = value;
				}
			}
			private System.String _Editor;
			[Mapping("Editor")]
			public System.String Editor
			{
				get
				{
					return _Editor;
				}
				set
				{
					_Editor = value;
				}
			}
			private System.DateTime _EditTime;
			[Mapping("EditTime")]
			public System.DateTime EditTime
			{
				get
				{
					return _EditTime;
				}
				set
				{
					_EditTime = value;
				}
			}
			#endregion
			public UO_SaleShop_ShopInfo()
			{
			}
		}
		public partial class UOList_SaleShop_ShopInfo : GetTogether.ObjectBase.ListBase<UO_SaleShop_ShopInfo>
		{
			public UOList_SaleShop_ShopInfo()
			{
			}
		}
	}


	public partial class BO_SaleShop_ShopInfo
	{
		#region Condition functions
		///<summary>
		///Get conditions by primary key string.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKeyString(string primaryKeyString)
		{
			string[] primaryKeys = primaryKeyString.Split('|');
			System.Int64 ShopId = Convert.ToInt64(primaryKeys[0]);
			return GetConditionsByPrimaryKey(ShopId);
		}

		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKey(System.Int64 ShopId)
		{
			ParameterCollection primaryConditions = new ParameterCollection();
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_SaleShop_ShopInfo.Columns.ShopId, ShopId);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int64 ShopId)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_SaleShop_ShopInfo.Columns.ShopId, ShopId);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_SaleShop_ShopInfo.Columns column,Dictionary<DO_SaleShop_ShopInfo.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_ShopInfo.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.ShopId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.ShopId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ShopId,extTokens), DO_SaleShop_ShopInfo.Columns.ShopId,parameterObj.ShopId);
			}
			if (parameterObj.CorpId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.CorpId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.CorpId,extTokens), DO_SaleShop_ShopInfo.Columns.CorpId,parameterObj.CorpId);
			}
			if (parameterObj.StId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.StId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.StId,extTokens), DO_SaleShop_ShopInfo.Columns.StId,parameterObj.StId);
			}
			if (parameterObj.ShopType != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.ShopType)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ShopType,extTokens), DO_SaleShop_ShopInfo.Columns.ShopType,parameterObj.ShopType);
			}
			if (parameterObj.ShopBelong != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.ShopBelong)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ShopBelong,extTokens), DO_SaleShop_ShopInfo.Columns.ShopBelong,parameterObj.ShopBelong);
			}
			if (parameterObj.ScId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.ScId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ScId,extTokens), DO_SaleShop_ShopInfo.Columns.ScId,parameterObj.ScId);
			}
			if (parameterObj.ScIdSon != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.ScIdSon)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ScIdSon,extTokens), DO_SaleShop_ShopInfo.Columns.ScIdSon,parameterObj.ScIdSon);
			}
			if (!string.IsNullOrEmpty(parameterObj.ShopName))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ShopName,extTokens), DO_SaleShop_ShopInfo.Columns.ShopName,parameterObj.ShopName);
			}
			if (!string.IsNullOrEmpty(parameterObj.ShopSubName))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ShopSubName,extTokens), DO_SaleShop_ShopInfo.Columns.ShopSubName,parameterObj.ShopSubName);
			}
			if (!string.IsNullOrEmpty(parameterObj.WebTitle))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.WebTitle,extTokens), DO_SaleShop_ShopInfo.Columns.WebTitle,parameterObj.WebTitle);
			}
			if (parameterObj.ProvinceId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.ProvinceId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ProvinceId,extTokens), DO_SaleShop_ShopInfo.Columns.ProvinceId,parameterObj.ProvinceId);
			}
			if (parameterObj.CityId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.CityId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.CityId,extTokens), DO_SaleShop_ShopInfo.Columns.CityId,parameterObj.CityId);
			}
			if (parameterObj.AreaId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.AreaId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.AreaId,extTokens), DO_SaleShop_ShopInfo.Columns.AreaId,parameterObj.AreaId);
			}
			if (!string.IsNullOrEmpty(parameterObj.ShopGrade))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ShopGrade,extTokens), DO_SaleShop_ShopInfo.Columns.ShopGrade,parameterObj.ShopGrade);
			}
			if (!string.IsNullOrEmpty(parameterObj.ShopImg))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ShopImg,extTokens), DO_SaleShop_ShopInfo.Columns.ShopImg,parameterObj.ShopImg);
			}
			if (!string.IsNullOrEmpty(parameterObj.Landmark))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.Landmark,extTokens), DO_SaleShop_ShopInfo.Columns.Landmark,parameterObj.Landmark);
			}
			if (!string.IsNullOrEmpty(parameterObj.Address))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.Address,extTokens), DO_SaleShop_ShopInfo.Columns.Address,parameterObj.Address);
			}
			if (!string.IsNullOrEmpty(parameterObj.SvrTel))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.SvrTel,extTokens), DO_SaleShop_ShopInfo.Columns.SvrTel,parameterObj.SvrTel);
			}
			if (!string.IsNullOrEmpty(parameterObj.SvrQQ))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.SvrQQ,extTokens), DO_SaleShop_ShopInfo.Columns.SvrQQ,parameterObj.SvrQQ);
			}
			if (!string.IsNullOrEmpty(parameterObj.SvrWorking))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.SvrWorking,extTokens), DO_SaleShop_ShopInfo.Columns.SvrWorking,parameterObj.SvrWorking);
			}
			if (!string.IsNullOrEmpty(parameterObj.DiscountInfo))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.DiscountInfo,extTokens), DO_SaleShop_ShopInfo.Columns.DiscountInfo,parameterObj.DiscountInfo);
			}
			if (parameterObj.DiscountStartTime != DateTime.MinValue)
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.DiscountStartTime,extTokens), DO_SaleShop_ShopInfo.Columns.DiscountStartTime,parameterObj.DiscountStartTime);
			}
			if (parameterObj.DiscountEndTime != DateTime.MinValue)
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.DiscountEndTime,extTokens), DO_SaleShop_ShopInfo.Columns.DiscountEndTime,parameterObj.DiscountEndTime);
			}
			if (!string.IsNullOrEmpty(parameterObj.MapAddress))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.MapAddress,extTokens), DO_SaleShop_ShopInfo.Columns.MapAddress,parameterObj.MapAddress);
			}
			if (!string.IsNullOrEmpty(parameterObj.ShopInstroduction))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ShopInstroduction,extTokens), DO_SaleShop_ShopInfo.Columns.ShopInstroduction,parameterObj.ShopInstroduction);
			}
			if (!string.IsNullOrEmpty(parameterObj.ShoppingGuide))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ShoppingGuide,extTokens), DO_SaleShop_ShopInfo.Columns.ShoppingGuide,parameterObj.ShoppingGuide);
			}
			if (!string.IsNullOrEmpty(parameterObj.SvrCusServices))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.SvrCusServices,extTokens), DO_SaleShop_ShopInfo.Columns.SvrCusServices,parameterObj.SvrCusServices);
			}
			if (!string.IsNullOrEmpty(parameterObj.Domain))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.Domain,extTokens), DO_SaleShop_ShopInfo.Columns.Domain,parameterObj.Domain);
			}
			if (parameterObj.LogoType != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.LogoType)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.LogoType,extTokens), DO_SaleShop_ShopInfo.Columns.LogoType,parameterObj.LogoType);
			}
			if (!string.IsNullOrEmpty(parameterObj.LogoText))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.LogoText,extTokens), DO_SaleShop_ShopInfo.Columns.LogoText,parameterObj.LogoText);
			}
			if (!string.IsNullOrEmpty(parameterObj.LogoImg))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.LogoImg,extTokens), DO_SaleShop_ShopInfo.Columns.LogoImg,parameterObj.LogoImg);
			}
			if (parameterObj.StartLevel != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.StartLevel)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.StartLevel,extTokens), DO_SaleShop_ShopInfo.Columns.StartLevel,parameterObj.StartLevel);
			}
			if (parameterObj.Population != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.Population)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.Population,extTokens), DO_SaleShop_ShopInfo.Columns.Population,parameterObj.Population);
			}
			if (parameterObj.HitCount != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.HitCount)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.HitCount,extTokens), DO_SaleShop_ShopInfo.Columns.HitCount,parameterObj.HitCount);
			}
			if (parameterObj.Deposit != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.Deposit)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.Deposit,extTokens), DO_SaleShop_ShopInfo.Columns.Deposit,parameterObj.Deposit);
			}
			if (!string.IsNullOrEmpty(parameterObj.MetaKeyword))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.MetaKeyword,extTokens), DO_SaleShop_ShopInfo.Columns.MetaKeyword,parameterObj.MetaKeyword);
			}
			if (!string.IsNullOrEmpty(parameterObj.MetaDescrition))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.MetaDescrition,extTokens), DO_SaleShop_ShopInfo.Columns.MetaDescrition,parameterObj.MetaDescrition);
			}
			if (!string.IsNullOrEmpty(parameterObj.ShopICP))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ShopICP,extTokens), DO_SaleShop_ShopInfo.Columns.ShopICP,parameterObj.ShopICP);
			}
			if (!string.IsNullOrEmpty(parameterObj.WeixinToken))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.WeixinToken,extTokens), DO_SaleShop_ShopInfo.Columns.WeixinToken,parameterObj.WeixinToken);
			}
			if (!string.IsNullOrEmpty(parameterObj.WeixinAppid))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.WeixinAppid,extTokens), DO_SaleShop_ShopInfo.Columns.WeixinAppid,parameterObj.WeixinAppid);
			}
			if (!string.IsNullOrEmpty(parameterObj.WeixinAppSecret))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.WeixinAppSecret,extTokens), DO_SaleShop_ShopInfo.Columns.WeixinAppSecret,parameterObj.WeixinAppSecret);
			}
			if (!string.IsNullOrEmpty(parameterObj.WeixinQrCode))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.WeixinQrCode,extTokens), DO_SaleShop_ShopInfo.Columns.WeixinQrCode,parameterObj.WeixinQrCode);
			}
			if (!string.IsNullOrEmpty(parameterObj.WeixinImg))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.WeixinImg,extTokens), DO_SaleShop_ShopInfo.Columns.WeixinImg,parameterObj.WeixinImg);
			}
			if (parameterObj.BankType != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.BankType)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.BankType,extTokens), DO_SaleShop_ShopInfo.Columns.BankType,parameterObj.BankType);
			}
			if (!string.IsNullOrEmpty(parameterObj.BankOwer))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.BankOwer,extTokens), DO_SaleShop_ShopInfo.Columns.BankOwer,parameterObj.BankOwer);
			}
			if (!string.IsNullOrEmpty(parameterObj.BankName))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.BankName,extTokens), DO_SaleShop_ShopInfo.Columns.BankName,parameterObj.BankName);
			}
			if (!string.IsNullOrEmpty(parameterObj.BankAccount))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.BankAccount,extTokens), DO_SaleShop_ShopInfo.Columns.BankAccount,parameterObj.BankAccount);
			}
			if (!string.IsNullOrEmpty(parameterObj.MgrName))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.MgrName,extTokens), DO_SaleShop_ShopInfo.Columns.MgrName,parameterObj.MgrName);
			}
			if (!string.IsNullOrEmpty(parameterObj.MgrEmail))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.MgrEmail,extTokens), DO_SaleShop_ShopInfo.Columns.MgrEmail,parameterObj.MgrEmail);
			}
			if (!string.IsNullOrEmpty(parameterObj.MgrQQ))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.MgrQQ,extTokens), DO_SaleShop_ShopInfo.Columns.MgrQQ,parameterObj.MgrQQ);
			}
			if (!string.IsNullOrEmpty(parameterObj.MgrTel))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.MgrTel,extTokens), DO_SaleShop_ShopInfo.Columns.MgrTel,parameterObj.MgrTel);
			}
			if (!string.IsNullOrEmpty(parameterObj.AttachLicense))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.AttachLicense,extTokens), DO_SaleShop_ShopInfo.Columns.AttachLicense,parameterObj.AttachLicense);
			}
			if (!string.IsNullOrEmpty(parameterObj.AttachJoin))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.AttachJoin,extTokens), DO_SaleShop_ShopInfo.Columns.AttachJoin,parameterObj.AttachJoin);
			}
			if (!string.IsNullOrEmpty(parameterObj.AttachMgrIDCard))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.AttachMgrIDCard,extTokens), DO_SaleShop_ShopInfo.Columns.AttachMgrIDCard,parameterObj.AttachMgrIDCard);
			}
			if (parameterObj.ApplyId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.ApplyId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.ApplyId,extTokens), DO_SaleShop_ShopInfo.Columns.ApplyId,parameterObj.ApplyId);
			}
			if (parameterObj.OrderNum != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ShopInfo.Columns.OrderNum)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.OrderNum,extTokens), DO_SaleShop_ShopInfo.Columns.OrderNum,parameterObj.OrderNum);
			}
			if (parameterObj.CreateTime != DateTime.MinValue)
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.CreateTime,extTokens), DO_SaleShop_ShopInfo.Columns.CreateTime,parameterObj.CreateTime);
			}
			if (!string.IsNullOrEmpty(parameterObj.Editor))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.Editor,extTokens), DO_SaleShop_ShopInfo.Columns.Editor,parameterObj.Editor);
			}
			if (parameterObj.EditTime != DateTime.MinValue)
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ShopInfo.Columns.EditTime,extTokens), DO_SaleShop_ShopInfo.Columns.EditTime,parameterObj.EditTime);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_SaleShop_ShopInfo.UOList_SaleShop_ShopInfo GetAllList()
		{
			DO_SaleShop_ShopInfo da = new DO_SaleShop_ShopInfo();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_SaleShop_ShopInfo da = new DO_SaleShop_ShopInfo();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_ShopInfo.Columns, TokenTypes> extTokens)
		{
			DO_SaleShop_ShopInfo da = new DO_SaleShop_ShopInfo();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_SaleShop_ShopInfo.UOList_SaleShop_ShopInfo GetList(DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_ShopInfo.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_SaleShop_ShopInfo.UOList_SaleShop_ShopInfo GetList(DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo GetObject(System.Int64 ShopId)
		{
			DO_SaleShop_ShopInfo da = new DO_SaleShop_ShopInfo();
			DO_SaleShop_ShopInfo.UOList_SaleShop_ShopInfo l = da.GetList(GetConditionsByPrimaryKey(ShopId));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_SaleShop_ShopInfo da = new DO_SaleShop_ShopInfo();
			DO_SaleShop_ShopInfo.UOList_SaleShop_ShopInfo l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo, DO_SaleShop_ShopInfo.UOList_SaleShop_ShopInfo> GetPagingList(DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_ShopInfo.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo, DO_SaleShop_ShopInfo.UOList_SaleShop_ShopInfo> GetPagingList(DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo GetObjectById(System.Int64 ShopId)
		{
			DO_SaleShop_ShopInfo da = new DO_SaleShop_ShopInfo();
			DO_SaleShop_ShopInfo.UOList_SaleShop_ShopInfo l = da.GetList(GetConditionsById(ShopId));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo obj, System.Int64 ShopId)
		{
			return obj.Update(GetConditionsByPrimaryKey(ShopId)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo obj, System.Int64 ShopId, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(ShopId)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_SaleShop_ShopInfo.UO_SaleShop_ShopInfo obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}
		#endregion

		#region Delete functions
		///<summary>
		///Delete object by primary key.
		///</summary>
		public static int Delete(System.Int64 ShopId)
		{
			DO_SaleShop_ShopInfo da = new DO_SaleShop_ShopInfo();
			return da.Delete(GetConditionsByPrimaryKey(ShopId));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int64 ShopId, IDbConnection connection, IDbTransaction transaction)
		{
			DO_SaleShop_ShopInfo da = new DO_SaleShop_ShopInfo();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(ShopId));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_SaleShop_ShopInfo da = new DO_SaleShop_ShopInfo();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_SaleShop_ShopInfo da = new DO_SaleShop_ShopInfo();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}