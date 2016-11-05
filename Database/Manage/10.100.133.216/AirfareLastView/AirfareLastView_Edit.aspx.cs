using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_AirfareLastView_Edit : GetTogether.Web.UI.Page
{
    public DO_AirfareLastView.UO_AirfareLastView UO;
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 id = 0;
		if(!string.IsNullOrEmpty(Request["id"])) id = Convert.ToInt32(Request["id"]);
        if (id > 0)
        {
            UO = BO_AirfareLastView.GetObjectById(id);
        }
        if (UO == null) UO = new DO_AirfareLastView.UO_AirfareLastView();

        if (Request.Form.Keys.Count > 0)
        {
            GetTogether.Web.WebHelper.SetValues<DO_AirfareLastView.UO_AirfareLastView>(UO, "AirfareLastView_");
            if (id > 0)
            {
				//Pending
				UO["UpdateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["UpdateBy"] = string.Concat("WS-",Request.UserHostAddress);
                UO.Update(BO_AirfareLastView.GetConditionsById(id));
            }
            else
            {
				//Pending
				UO["CreateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["CreateBy"]=string.Concat("WS-",Request.UserHostAddress);
                UO.Insert();
            }
            Response.Redirect("AirfareLastView.aspx");
        }
    }
	public partial class DO_AirfareLastView : DOBase<DO_AirfareLastView.UO_AirfareLastView, DO_AirfareLastView.UOList_AirfareLastView>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "AirfareLastView",
                        @"Data Source=10.100.133.81\sqlexpress;Initial Catalog=ADHolidays;Persist Security Info=True;User ID=sa;Password=gzuat;Connect Timeout=30",
                        new string[] {"Id"},
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
			Id,
			CompanyCode,
			UserCode,
			Org,
			Dst,
			OWRTOJ,
			LastViewDate,
			IsDirect,
			DepartureDate,
			ReturnDate,
			Airline,
			FareCat,
			BkgClass,
			FareClass,
		}
		public DO_AirfareLastView()
		{
		}
		public partial class UO_AirfareLastView : UOBase<UO_AirfareLastView,UOList_AirfareLastView>
		{
public override ConnectionInformation GetDefaultConnectionInformation()
            {
                return GetConnectionInformation();
            }
			#region Columns
			private System.Int32 _Id;
			/// <summary>
			///Primary Key,Auto Increment
			/// </summary>
			[Mapping("Id,un-insert,un-update")]
			public System.Int32 Id
			{
				get
				{
					return _Id;
				}
				set
				{
					_Id = value;
				}
			}
			private System.String _CompanyCode;
			[Mapping("CompanyCode")]
			public System.String CompanyCode
			{
				get
				{
					return _CompanyCode;
				}
				set
				{
					_CompanyCode = value;
				}
			}
			private System.String _UserCode;
			[Mapping("UserCode")]
			public System.String UserCode
			{
				get
				{
					return _UserCode;
				}
				set
				{
					_UserCode = value;
				}
			}
			private System.String _Org;
			[Mapping("Org")]
			public System.String Org
			{
				get
				{
					return _Org;
				}
				set
				{
					_Org = value;
				}
			}
			private System.String _Dst;
			[Mapping("Dst")]
			public System.String Dst
			{
				get
				{
					return _Dst;
				}
				set
				{
					_Dst = value;
				}
			}
			private System.Int32 _OWRTOJ;
			[Mapping("OWRTOJ")]
			public System.Int32 OWRTOJ
			{
				get
				{
					return _OWRTOJ;
				}
				set
				{
					_OWRTOJ = value;
				}
			}
			private System.DateTime _LastViewDate;
			[Mapping("LastViewDate")]
			public System.DateTime LastViewDate
			{
				get
				{
					return _LastViewDate;
				}
				set
				{
					_LastViewDate = value;
				}
			}
			private System.Boolean _IsDirect;
			[Mapping("IsDirect")]
			public System.Boolean IsDirect
			{
				get
				{
					return _IsDirect;
				}
				set
				{
					_IsDirect = value;
				}
			}
			private System.DateTime _DepartureDate;
			[Mapping("DepartureDate")]
			public System.DateTime DepartureDate
			{
				get
				{
					return _DepartureDate;
				}
				set
				{
					_DepartureDate = value;
				}
			}
			private System.DateTime _ReturnDate;
			[Mapping("ReturnDate")]
			public System.DateTime ReturnDate
			{
				get
				{
					return _ReturnDate;
				}
				set
				{
					_ReturnDate = value;
				}
			}
			private System.String _Airline;
			[Mapping("Airline")]
			public System.String Airline
			{
				get
				{
					return _Airline;
				}
				set
				{
					_Airline = value;
				}
			}
			private System.String _FareCat;
			[Mapping("FareCat")]
			public System.String FareCat
			{
				get
				{
					return _FareCat;
				}
				set
				{
					_FareCat = value;
				}
			}
			private System.String _BkgClass;
			[Mapping("BkgClass")]
			public System.String BkgClass
			{
				get
				{
					return _BkgClass;
				}
				set
				{
					_BkgClass = value;
				}
			}
			private System.String _FareClass;
			[Mapping("FareClass")]
			public System.String FareClass
			{
				get
				{
					return _FareClass;
				}
				set
				{
					_FareClass = value;
				}
			}
			#endregion
			public UO_AirfareLastView()
			{
			}
		}
		public partial class UOList_AirfareLastView : GetTogether.ObjectBase.ListBase<UO_AirfareLastView>
		{
			public UOList_AirfareLastView()
			{
			}
		}
	}


	public partial class BO_AirfareLastView
	{
		#region Condition functions
		///<summary>
		///Get conditions by primary key string.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKeyString(string primaryKeyString)
		{
			string[] primaryKeys = primaryKeyString.Split('|');
			System.Int32 Id = Convert.ToInt32(primaryKeys[0]);
			return GetConditionsByPrimaryKey(Id);
		}

		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKey(System.Int32 Id)
		{
			ParameterCollection primaryConditions = new ParameterCollection();
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_AirfareLastView.Columns.Id, Id);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int32 Id)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_AirfareLastView.Columns.Id, Id);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_AirfareLastView.Columns column,Dictionary<DO_AirfareLastView.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_AirfareLastView.UO_AirfareLastView parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_AirfareLastView.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.Id != 0 || (extTokens != null && extTokens.ContainsKey(DO_AirfareLastView.Columns.Id)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareLastView.Columns.Id,extTokens), DO_AirfareLastView.Columns.Id,parameterObj.Id);
			}
			if (!string.IsNullOrEmpty(parameterObj.CompanyCode))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareLastView.Columns.CompanyCode,extTokens), DO_AirfareLastView.Columns.CompanyCode,parameterObj.CompanyCode);
			}
			if (!string.IsNullOrEmpty(parameterObj.UserCode))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareLastView.Columns.UserCode,extTokens), DO_AirfareLastView.Columns.UserCode,parameterObj.UserCode);
			}
			if (!string.IsNullOrEmpty(parameterObj.Org))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareLastView.Columns.Org,extTokens), DO_AirfareLastView.Columns.Org,parameterObj.Org);
			}
			if (!string.IsNullOrEmpty(parameterObj.Dst))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareLastView.Columns.Dst,extTokens), DO_AirfareLastView.Columns.Dst,parameterObj.Dst);
			}
			if (parameterObj.OWRTOJ != 0 || (extTokens != null && extTokens.ContainsKey(DO_AirfareLastView.Columns.OWRTOJ)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareLastView.Columns.OWRTOJ,extTokens), DO_AirfareLastView.Columns.OWRTOJ,parameterObj.OWRTOJ);
			}
			if (!string.IsNullOrEmpty(parameterObj.Airline))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareLastView.Columns.Airline,extTokens), DO_AirfareLastView.Columns.Airline,parameterObj.Airline);
			}
			if (!string.IsNullOrEmpty(parameterObj.FareCat))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareLastView.Columns.FareCat,extTokens), DO_AirfareLastView.Columns.FareCat,parameterObj.FareCat);
			}
			if (!string.IsNullOrEmpty(parameterObj.BkgClass))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareLastView.Columns.BkgClass,extTokens), DO_AirfareLastView.Columns.BkgClass,parameterObj.BkgClass);
			}
			if (!string.IsNullOrEmpty(parameterObj.FareClass))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareLastView.Columns.FareClass,extTokens), DO_AirfareLastView.Columns.FareClass,parameterObj.FareClass);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_AirfareLastView.UOList_AirfareLastView GetAllList()
		{
			DO_AirfareLastView da = new DO_AirfareLastView();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_AirfareLastView da = new DO_AirfareLastView();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_AirfareLastView.UO_AirfareLastView parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_AirfareLastView.UO_AirfareLastView parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_AirfareLastView.Columns, TokenTypes> extTokens)
		{
			DO_AirfareLastView da = new DO_AirfareLastView();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_AirfareLastView.UOList_AirfareLastView GetList(DO_AirfareLastView.UO_AirfareLastView parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_AirfareLastView.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_AirfareLastView.UOList_AirfareLastView GetList(DO_AirfareLastView.UO_AirfareLastView parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_AirfareLastView.UO_AirfareLastView GetObject(System.Int32 Id)
		{
			DO_AirfareLastView da = new DO_AirfareLastView();
			DO_AirfareLastView.UOList_AirfareLastView l = da.GetList(GetConditionsByPrimaryKey(Id));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_AirfareLastView.UO_AirfareLastView GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_AirfareLastView da = new DO_AirfareLastView();
			DO_AirfareLastView.UOList_AirfareLastView l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_AirfareLastView.UO_AirfareLastView, DO_AirfareLastView.UOList_AirfareLastView> GetPagingList(DO_AirfareLastView.UO_AirfareLastView parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_AirfareLastView.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_AirfareLastView.UO_AirfareLastView, DO_AirfareLastView.UOList_AirfareLastView> GetPagingList(DO_AirfareLastView.UO_AirfareLastView parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_AirfareLastView.UO_AirfareLastView GetObjectById(System.Int32 Id)
		{
			DO_AirfareLastView da = new DO_AirfareLastView();
			DO_AirfareLastView.UOList_AirfareLastView l = da.GetList(GetConditionsById(Id));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_AirfareLastView.UO_AirfareLastView obj, System.Int32 Id)
		{
			return obj.Update(GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_AirfareLastView.UO_AirfareLastView obj, System.Int32 Id, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_AirfareLastView.UO_AirfareLastView obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_AirfareLastView.UO_AirfareLastView obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}
		#endregion

		#region Delete functions
		///<summary>
		///Delete object by primary key.
		///</summary>
		public static int Delete(System.Int32 Id)
		{
			DO_AirfareLastView da = new DO_AirfareLastView();
			return da.Delete(GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int32 Id, IDbConnection connection, IDbTransaction transaction)
		{
			DO_AirfareLastView da = new DO_AirfareLastView();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_AirfareLastView da = new DO_AirfareLastView();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_AirfareLastView da = new DO_AirfareLastView();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}