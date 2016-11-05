using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_User_OrderUser_Log_Callback : GetTogether.Web.UI.PageCallback
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
        Database_Output_User_OrderUser_Log_Result c = (Database_Output_User_OrderUser_Log_Result)Page.LoadControl("User_OrderUser_Log_Result.ascx");
        DO_User_OrderUser_Log.UO_User_OrderUser_Log l = new DO_User_OrderUser_Log.UO_User_OrderUser_Log();
        GetTogether.Web.WebHelper.SetValues<DO_User_OrderUser_Log.UO_User_OrderUser_Log>(l, "User_OrderUser_Log_");
        if (string.IsNullOrEmpty(Sort)) Sort = DO_User_OrderUser_Log.Columns.id.ToString();
        PagingResult<DO_User_OrderUser_Log.UO_User_OrderUser_Log, DO_User_OrderUser_Log.UOList_User_OrderUser_Log> resultPaging = BO_User_OrderUser_Log.GetPagingList(l, PageIndex, PageSize, Sort, IsAsc);
        c.JsFunction = "User_OrderUser_Log_Search";
        c.SetData<DO_User_OrderUser_Log.UO_User_OrderUser_Log, DO_User_OrderUser_Log.UOList_User_OrderUser_Log>(resultPaging.Result);
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
            int[] ids = GetParameterArrayInt(Request["keys"], "User_OrderUser_Log_", ',');
            ParameterCollection conditions = new ParameterCollection();
            conditions.AddCondition(ParameterType.Initial, TokenTypes.In, DO_User_OrderUser_Log.Columns.id, ids);
 
            if (new DO_User_OrderUser_Log().Delete(conditions) > 0)
                JsonSuccess();
            else
                JsonError("Delete Failure");
        }
        catch (Exception ex)
        {
            JsonError(ex.Message);
        }
    }

	public partial class DO_User_OrderUser_Log : DOBase<DO_User_OrderUser_Log.UO_User_OrderUser_Log, DO_User_OrderUser_Log.UOList_User_OrderUser_Log>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "User_OrderUser_Log",
                        @"Data Source=.;Initial Catalog=YSL_Shop;Persist Security Info=True;User ID=sa;Password=Esunlit2008;Connect Timeout=30",
                        new string[] {"id"},
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
			id,
			ordersid,
			remark,
			receivename,
			receivetel,
			receivemobile,
			receivepostcode,
			receiveaddress,
			adminname,
			logtime,
		}
		public DO_User_OrderUser_Log()
		{
		}
		public partial class UO_User_OrderUser_Log : UOBase<UO_User_OrderUser_Log,UOList_User_OrderUser_Log>
		{
public override ConnectionInformation GetDefaultConnectionInformation()
            {
                return GetConnectionInformation();
            }
			#region Columns
			private System.Int64 _id;
			/// <summary>
			///Primary Key,Auto Increment
			/// </summary>
			[Mapping("id,un-insert,un-update")]
			public System.Int64 id
			{
				get
				{
					return _id;
				}
				set
				{
					_id = value;
				}
			}
			private System.String _ordersid;
			[Mapping("ordersid")]
			public System.String ordersid
			{
				get
				{
					return _ordersid;
				}
				set
				{
					_ordersid = value;
				}
			}
			private System.String _remark;
			[Mapping("remark")]
			public System.String remark
			{
				get
				{
					return _remark;
				}
				set
				{
					_remark = value;
				}
			}
			private System.String _receivename;
			[Mapping("receivename")]
			public System.String receivename
			{
				get
				{
					return _receivename;
				}
				set
				{
					_receivename = value;
				}
			}
			private System.String _receivetel;
			[Mapping("receivetel")]
			public System.String receivetel
			{
				get
				{
					return _receivetel;
				}
				set
				{
					_receivetel = value;
				}
			}
			private System.String _receivemobile;
			[Mapping("receivemobile")]
			public System.String receivemobile
			{
				get
				{
					return _receivemobile;
				}
				set
				{
					_receivemobile = value;
				}
			}
			private System.String _receivepostcode;
			[Mapping("receivepostcode")]
			public System.String receivepostcode
			{
				get
				{
					return _receivepostcode;
				}
				set
				{
					_receivepostcode = value;
				}
			}
			private System.String _receiveaddress;
			[Mapping("receiveaddress")]
			public System.String receiveaddress
			{
				get
				{
					return _receiveaddress;
				}
				set
				{
					_receiveaddress = value;
				}
			}
			private System.String _adminname;
			[Mapping("adminname")]
			public System.String adminname
			{
				get
				{
					return _adminname;
				}
				set
				{
					_adminname = value;
				}
			}
			private System.DateTime _logtime;
			[Mapping("logtime")]
			public System.DateTime logtime
			{
				get
				{
					return _logtime;
				}
				set
				{
					_logtime = value;
				}
			}
			#endregion
			public UO_User_OrderUser_Log()
			{
			}
		}
		public partial class UOList_User_OrderUser_Log : GetTogether.ObjectBase.ListBase<UO_User_OrderUser_Log>
		{
			public UOList_User_OrderUser_Log()
			{
			}
		}
	}


	public partial class BO_User_OrderUser_Log
	{
		#region Condition functions
		///<summary>
		///Get conditions by primary key string.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKeyString(string primaryKeyString)
		{
			string[] primaryKeys = primaryKeyString.Split('|');
			System.Int64 id = Convert.ToInt64(primaryKeys[0]);
			return GetConditionsByPrimaryKey(id);
		}

		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKey(System.Int64 id)
		{
			ParameterCollection primaryConditions = new ParameterCollection();
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_User_OrderUser_Log.Columns.id, id);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int64 id)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_User_OrderUser_Log.Columns.id, id);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_User_OrderUser_Log.Columns column,Dictionary<DO_User_OrderUser_Log.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_User_OrderUser_Log.UO_User_OrderUser_Log parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_User_OrderUser_Log.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.id != 0 || (extTokens != null && extTokens.ContainsKey(DO_User_OrderUser_Log.Columns.id)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_OrderUser_Log.Columns.id,extTokens), DO_User_OrderUser_Log.Columns.id,parameterObj.id);
			}
			if (!string.IsNullOrEmpty(parameterObj.ordersid))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_OrderUser_Log.Columns.ordersid,extTokens), DO_User_OrderUser_Log.Columns.ordersid,parameterObj.ordersid);
			}
			if (!string.IsNullOrEmpty(parameterObj.remark))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_OrderUser_Log.Columns.remark,extTokens), DO_User_OrderUser_Log.Columns.remark,parameterObj.remark);
			}
			if (!string.IsNullOrEmpty(parameterObj.receivename))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_OrderUser_Log.Columns.receivename,extTokens), DO_User_OrderUser_Log.Columns.receivename,parameterObj.receivename);
			}
			if (!string.IsNullOrEmpty(parameterObj.receivetel))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_OrderUser_Log.Columns.receivetel,extTokens), DO_User_OrderUser_Log.Columns.receivetel,parameterObj.receivetel);
			}
			if (!string.IsNullOrEmpty(parameterObj.receivemobile))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_OrderUser_Log.Columns.receivemobile,extTokens), DO_User_OrderUser_Log.Columns.receivemobile,parameterObj.receivemobile);
			}
			if (!string.IsNullOrEmpty(parameterObj.receivepostcode))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_OrderUser_Log.Columns.receivepostcode,extTokens), DO_User_OrderUser_Log.Columns.receivepostcode,parameterObj.receivepostcode);
			}
			if (!string.IsNullOrEmpty(parameterObj.receiveaddress))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_OrderUser_Log.Columns.receiveaddress,extTokens), DO_User_OrderUser_Log.Columns.receiveaddress,parameterObj.receiveaddress);
			}
			if (!string.IsNullOrEmpty(parameterObj.adminname))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_OrderUser_Log.Columns.adminname,extTokens), DO_User_OrderUser_Log.Columns.adminname,parameterObj.adminname);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_User_OrderUser_Log.UOList_User_OrderUser_Log GetAllList()
		{
			DO_User_OrderUser_Log da = new DO_User_OrderUser_Log();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_User_OrderUser_Log da = new DO_User_OrderUser_Log();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_User_OrderUser_Log.UO_User_OrderUser_Log parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_User_OrderUser_Log.UO_User_OrderUser_Log parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_User_OrderUser_Log.Columns, TokenTypes> extTokens)
		{
			DO_User_OrderUser_Log da = new DO_User_OrderUser_Log();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_User_OrderUser_Log.UOList_User_OrderUser_Log GetList(DO_User_OrderUser_Log.UO_User_OrderUser_Log parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_User_OrderUser_Log.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_User_OrderUser_Log.UOList_User_OrderUser_Log GetList(DO_User_OrderUser_Log.UO_User_OrderUser_Log parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_User_OrderUser_Log.UO_User_OrderUser_Log GetObject(System.Int64 id)
		{
			DO_User_OrderUser_Log da = new DO_User_OrderUser_Log();
			DO_User_OrderUser_Log.UOList_User_OrderUser_Log l = da.GetList(GetConditionsByPrimaryKey(id));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_User_OrderUser_Log.UO_User_OrderUser_Log GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_User_OrderUser_Log da = new DO_User_OrderUser_Log();
			DO_User_OrderUser_Log.UOList_User_OrderUser_Log l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_User_OrderUser_Log.UO_User_OrderUser_Log, DO_User_OrderUser_Log.UOList_User_OrderUser_Log> GetPagingList(DO_User_OrderUser_Log.UO_User_OrderUser_Log parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_User_OrderUser_Log.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_User_OrderUser_Log.UO_User_OrderUser_Log, DO_User_OrderUser_Log.UOList_User_OrderUser_Log> GetPagingList(DO_User_OrderUser_Log.UO_User_OrderUser_Log parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_User_OrderUser_Log.UO_User_OrderUser_Log GetObjectById(System.Int64 id)
		{
			DO_User_OrderUser_Log da = new DO_User_OrderUser_Log();
			DO_User_OrderUser_Log.UOList_User_OrderUser_Log l = da.GetList(GetConditionsById(id));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_User_OrderUser_Log.UO_User_OrderUser_Log obj, System.Int64 id)
		{
			return obj.Update(GetConditionsByPrimaryKey(id)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_User_OrderUser_Log.UO_User_OrderUser_Log obj, System.Int64 id, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(id)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_User_OrderUser_Log.UO_User_OrderUser_Log obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_User_OrderUser_Log.UO_User_OrderUser_Log obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}
		#endregion

		#region Delete functions
		///<summary>
		///Delete object by primary key.
		///</summary>
		public static int Delete(System.Int64 id)
		{
			DO_User_OrderUser_Log da = new DO_User_OrderUser_Log();
			return da.Delete(GetConditionsByPrimaryKey(id));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int64 id, IDbConnection connection, IDbTransaction transaction)
		{
			DO_User_OrderUser_Log da = new DO_User_OrderUser_Log();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(id));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_User_OrderUser_Log da = new DO_User_OrderUser_Log();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_User_OrderUser_Log da = new DO_User_OrderUser_Log();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}