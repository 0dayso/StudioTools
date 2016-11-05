using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_SaleShop_profits_qyjl_log_Callback : GetTogether.Web.UI.PageCallback
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
        Database_Output_SaleShop_profits_qyjl_log_Result c = (Database_Output_SaleShop_profits_qyjl_log_Result)Page.LoadControl("SaleShop_profits_qyjl_log_Result.ascx");
        DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log l = new DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log();
        GetTogether.Web.WebHelper.SetValues<DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log>(l, "SaleShop_profits_qyjl_log_");
        if (string.IsNullOrEmpty(Sort)) Sort = DO_SaleShop_profits_qyjl_log.Columns.id.ToString();
        PagingResult<DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log, DO_SaleShop_profits_qyjl_log.UOList_SaleShop_profits_qyjl_log> resultPaging = BO_SaleShop_profits_qyjl_log.GetPagingList(l, PageIndex, PageSize, Sort, IsAsc);
        c.JsFunction = "SaleShop_profits_qyjl_log_Search";
        c.SetData<DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log, DO_SaleShop_profits_qyjl_log.UOList_SaleShop_profits_qyjl_log>(resultPaging.Result);
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
            int[] ids = GetParameterArrayInt(Request["keys"], "SaleShop_profits_qyjl_log_", ',');
            ParameterCollection conditions = new ParameterCollection();
            conditions.AddCondition(ParameterType.Initial, TokenTypes.In, DO_SaleShop_profits_qyjl_log.Columns.id, ids);
 
            if (new DO_SaleShop_profits_qyjl_log().Delete(conditions) > 0)
                JsonSuccess();
            else
                JsonError("Delete Failure");
        }
        catch (Exception ex)
        {
            JsonError(ex.Message);
        }
    }

	public partial class DO_SaleShop_profits_qyjl_log : DOBase<DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log, DO_SaleShop_profits_qyjl_log.UOList_SaleShop_profits_qyjl_log>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "SaleShop_profits_qyjl_log",
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
			uid,
			orderid,
			mshopid,
			original_price,
			managerRatio,
			profits_price,
			addtime,
			status,
		}
		public DO_SaleShop_profits_qyjl_log()
		{
		}
		public partial class UO_SaleShop_profits_qyjl_log : UOBase<UO_SaleShop_profits_qyjl_log,UOList_SaleShop_profits_qyjl_log>
		{
public override ConnectionInformation GetDefaultConnectionInformation()
            {
                return GetConnectionInformation();
            }
			#region Columns
			private System.Int32 _id;
			/// <summary>
			///Primary Key,Auto Increment
			/// </summary>
			[Mapping("id,un-insert,un-update")]
			public System.Int32 id
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
			private System.Int32 _uid;
			[Mapping("uid")]
			public System.Int32 uid
			{
				get
				{
					return _uid;
				}
				set
				{
					_uid = value;
				}
			}
			private System.String _orderid;
			[Mapping("orderid")]
			public System.String orderid
			{
				get
				{
					return _orderid;
				}
				set
				{
					_orderid = value;
				}
			}
			private System.Int32 _mshopid;
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
			private System.Decimal _original_price;
			[Mapping("original_price")]
			public System.Decimal original_price
			{
				get
				{
					return _original_price;
				}
				set
				{
					_original_price = value;
				}
			}
			private System.Double _managerRatio;
			[Mapping("managerRatio")]
			public System.Double managerRatio
			{
				get
				{
					return _managerRatio;
				}
				set
				{
					_managerRatio = value;
				}
			}
			private System.Decimal _profits_price;
			[Mapping("profits_price")]
			public System.Decimal profits_price
			{
				get
				{
					return _profits_price;
				}
				set
				{
					_profits_price = value;
				}
			}
			private System.DateTime _addtime;
			[Mapping("addtime")]
			public System.DateTime addtime
			{
				get
				{
					return _addtime;
				}
				set
				{
					_addtime = value;
				}
			}
			private System.Int32 _status;
			[Mapping("status")]
			public System.Int32 status
			{
				get
				{
					return _status;
				}
				set
				{
					_status = value;
				}
			}
			#endregion
			public UO_SaleShop_profits_qyjl_log()
			{
			}
		}
		public partial class UOList_SaleShop_profits_qyjl_log : GetTogether.ObjectBase.ListBase<UO_SaleShop_profits_qyjl_log>
		{
			public UOList_SaleShop_profits_qyjl_log()
			{
			}
		}
	}


	public partial class BO_SaleShop_profits_qyjl_log
	{
		#region Condition functions
		///<summary>
		///Get conditions by primary key string.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKeyString(string primaryKeyString)
		{
			string[] primaryKeys = primaryKeyString.Split('|');
			System.Int32 id = Convert.ToInt32(primaryKeys[0]);
			return GetConditionsByPrimaryKey(id);
		}

		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKey(System.Int32 id)
		{
			ParameterCollection primaryConditions = new ParameterCollection();
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_SaleShop_profits_qyjl_log.Columns.id, id);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int32 id)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_SaleShop_profits_qyjl_log.Columns.id, id);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_SaleShop_profits_qyjl_log.Columns column,Dictionary<DO_SaleShop_profits_qyjl_log.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_profits_qyjl_log.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.id != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_profits_qyjl_log.Columns.id)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_profits_qyjl_log.Columns.id,extTokens), DO_SaleShop_profits_qyjl_log.Columns.id,parameterObj.id);
			}
			if (parameterObj.uid != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_profits_qyjl_log.Columns.uid)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_profits_qyjl_log.Columns.uid,extTokens), DO_SaleShop_profits_qyjl_log.Columns.uid,parameterObj.uid);
			}
			if (!string.IsNullOrEmpty(parameterObj.orderid))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_profits_qyjl_log.Columns.orderid,extTokens), DO_SaleShop_profits_qyjl_log.Columns.orderid,parameterObj.orderid);
			}
			if (parameterObj.mshopid != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_profits_qyjl_log.Columns.mshopid)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_profits_qyjl_log.Columns.mshopid,extTokens), DO_SaleShop_profits_qyjl_log.Columns.mshopid,parameterObj.mshopid);
			}
			if (parameterObj.original_price != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_profits_qyjl_log.Columns.original_price)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_profits_qyjl_log.Columns.original_price,extTokens), DO_SaleShop_profits_qyjl_log.Columns.original_price,parameterObj.original_price);
			}
			if (parameterObj.profits_price != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_profits_qyjl_log.Columns.profits_price)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_profits_qyjl_log.Columns.profits_price,extTokens), DO_SaleShop_profits_qyjl_log.Columns.profits_price,parameterObj.profits_price);
			}
			if (parameterObj.status != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_profits_qyjl_log.Columns.status)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_profits_qyjl_log.Columns.status,extTokens), DO_SaleShop_profits_qyjl_log.Columns.status,parameterObj.status);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_SaleShop_profits_qyjl_log.UOList_SaleShop_profits_qyjl_log GetAllList()
		{
			DO_SaleShop_profits_qyjl_log da = new DO_SaleShop_profits_qyjl_log();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_SaleShop_profits_qyjl_log da = new DO_SaleShop_profits_qyjl_log();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_profits_qyjl_log.Columns, TokenTypes> extTokens)
		{
			DO_SaleShop_profits_qyjl_log da = new DO_SaleShop_profits_qyjl_log();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_SaleShop_profits_qyjl_log.UOList_SaleShop_profits_qyjl_log GetList(DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_profits_qyjl_log.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_SaleShop_profits_qyjl_log.UOList_SaleShop_profits_qyjl_log GetList(DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log GetObject(System.Int32 id)
		{
			DO_SaleShop_profits_qyjl_log da = new DO_SaleShop_profits_qyjl_log();
			DO_SaleShop_profits_qyjl_log.UOList_SaleShop_profits_qyjl_log l = da.GetList(GetConditionsByPrimaryKey(id));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_SaleShop_profits_qyjl_log da = new DO_SaleShop_profits_qyjl_log();
			DO_SaleShop_profits_qyjl_log.UOList_SaleShop_profits_qyjl_log l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log, DO_SaleShop_profits_qyjl_log.UOList_SaleShop_profits_qyjl_log> GetPagingList(DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_profits_qyjl_log.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log, DO_SaleShop_profits_qyjl_log.UOList_SaleShop_profits_qyjl_log> GetPagingList(DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log GetObjectById(System.Int32 id)
		{
			DO_SaleShop_profits_qyjl_log da = new DO_SaleShop_profits_qyjl_log();
			DO_SaleShop_profits_qyjl_log.UOList_SaleShop_profits_qyjl_log l = da.GetList(GetConditionsById(id));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log obj, System.Int32 id)
		{
			return obj.Update(GetConditionsByPrimaryKey(id)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log obj, System.Int32 id, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(id)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_SaleShop_profits_qyjl_log.UO_SaleShop_profits_qyjl_log obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}
		#endregion

		#region Delete functions
		///<summary>
		///Delete object by primary key.
		///</summary>
		public static int Delete(System.Int32 id)
		{
			DO_SaleShop_profits_qyjl_log da = new DO_SaleShop_profits_qyjl_log();
			return da.Delete(GetConditionsByPrimaryKey(id));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int32 id, IDbConnection connection, IDbTransaction transaction)
		{
			DO_SaleShop_profits_qyjl_log da = new DO_SaleShop_profits_qyjl_log();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(id));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_SaleShop_profits_qyjl_log da = new DO_SaleShop_profits_qyjl_log();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_SaleShop_profits_qyjl_log da = new DO_SaleShop_profits_qyjl_log();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}