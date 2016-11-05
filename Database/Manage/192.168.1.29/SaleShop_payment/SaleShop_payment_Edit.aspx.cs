using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_SaleShop_payment_Edit : GetTogether.Web.UI.Page
{
    public DO_SaleShop_payment.UO_SaleShop_payment UO;
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 id = 0;
		if(!string.IsNullOrEmpty(Request["id"])) id = Convert.ToInt32(Request["id"]);
        if (id > 0)
        {
            UO = BO_SaleShop_payment.GetObjectById(id);
        }
        if (UO == null) UO = new DO_SaleShop_payment.UO_SaleShop_payment();

        if (Request.Form.Keys.Count > 0)
        {
            GetTogether.Web.WebHelper.SetValues<DO_SaleShop_payment.UO_SaleShop_payment>(UO, "SaleShop_payment_");
            if (id > 0)
            {
				//Pending
				UO["UpdateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["UpdateBy"] = string.Concat("WS-",Request.UserHostAddress);
                UO.Update(BO_SaleShop_payment.GetConditionsById(id));
            }
            else
            {
				//Pending
				UO["CreateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["CreateBy"]=string.Concat("WS-",Request.UserHostAddress);
                UO.Insert();
            }
            Response.Redirect("SaleShop_payment.aspx");
        }
    }
	public partial class DO_SaleShop_payment : DOBase<DO_SaleShop_payment.UO_SaleShop_payment, DO_SaleShop_payment.UOList_SaleShop_payment>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "SaleShop_payment",
                        @"Data Source=192.168.1.88;Initial Catalog=YSL_Shop;Persist Security Info=True;User ID=sa;Password=Esunlit2008;Connect Timeout=30",
                        new string[] {"pay_id"},
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
			pay_id,
			pay_name,
			pay_code,
			pay_fee,
			pay_desc,
			Orderdisplay,
			/// <summary>
			///,Remark:接口类型,1为使用我方接口0为自定义配置
			/// </summary>
			Interface,
			pay_config,
			/// <summary>
			///,Remark:是否启用
			/// </summary>
			enabled,
			is_cod,
			is_online,
		}
		public DO_SaleShop_payment()
		{
		}
		public partial class UO_SaleShop_payment : UOBase<UO_SaleShop_payment,UOList_SaleShop_payment>
		{
public override ConnectionInformation GetDefaultConnectionInformation()
            {
                return GetConnectionInformation();
            }
			#region Columns
			private System.Int32 _pay_id;
			/// <summary>
			///Primary Key,Auto Increment
			/// </summary>
			[Mapping("pay_id,un-insert,un-update")]
			public System.Int32 pay_id
			{
				get
				{
					return _pay_id;
				}
				set
				{
					_pay_id = value;
				}
			}
			private System.String _pay_name;
			[Mapping("pay_name")]
			public System.String pay_name
			{
				get
				{
					return _pay_name;
				}
				set
				{
					_pay_name = value;
				}
			}
			private System.String _pay_code;
			[Mapping("pay_code")]
			public System.String pay_code
			{
				get
				{
					return _pay_code;
				}
				set
				{
					_pay_code = value;
				}
			}
			private System.String _pay_fee;
			[Mapping("pay_fee")]
			public System.String pay_fee
			{
				get
				{
					return _pay_fee;
				}
				set
				{
					_pay_fee = value;
				}
			}
			private System.String _pay_desc;
			[Mapping("pay_desc")]
			public System.String pay_desc
			{
				get
				{
					return _pay_desc;
				}
				set
				{
					_pay_desc = value;
				}
			}
			private System.Int32 _Orderdisplay;
			[Mapping("Orderdisplay")]
			public System.Int32 Orderdisplay
			{
				get
				{
					return _Orderdisplay;
				}
				set
				{
					_Orderdisplay = value;
				}
			}
			private System.Byte _Interface;
			/// <summary>
			///,Remark:接口类型,1为使用我方接口0为自定义配置
			/// </summary>
			[Mapping("Interface")]
			public System.Byte Interface
			{
				get
				{
					return _Interface;
				}
				set
				{
					_Interface = value;
				}
			}
			private System.String _pay_config;
			[Mapping("pay_config")]
			public System.String pay_config
			{
				get
				{
					return _pay_config;
				}
				set
				{
					_pay_config = value;
				}
			}
			private System.Byte _enabled;
			/// <summary>
			///,Remark:是否启用
			/// </summary>
			[Mapping("enabled")]
			public System.Byte enabled
			{
				get
				{
					return _enabled;
				}
				set
				{
					_enabled = value;
				}
			}
			private System.Byte _is_cod;
			[Mapping("is_cod")]
			public System.Byte is_cod
			{
				get
				{
					return _is_cod;
				}
				set
				{
					_is_cod = value;
				}
			}
			private System.Byte _is_online;
			[Mapping("is_online")]
			public System.Byte is_online
			{
				get
				{
					return _is_online;
				}
				set
				{
					_is_online = value;
				}
			}
			#endregion
			public UO_SaleShop_payment()
			{
			}
		}
		public partial class UOList_SaleShop_payment : GetTogether.ObjectBase.ListBase<UO_SaleShop_payment>
		{
			public UOList_SaleShop_payment()
			{
			}
		}
	}


	public partial class BO_SaleShop_payment
	{
		#region Condition functions
		///<summary>
		///Get conditions by primary key string.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKeyString(string primaryKeyString)
		{
			string[] primaryKeys = primaryKeyString.Split('|');
			System.Int32 pay_id = Convert.ToInt32(primaryKeys[0]);
			return GetConditionsByPrimaryKey(pay_id);
		}

		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKey(System.Int32 pay_id)
		{
			ParameterCollection primaryConditions = new ParameterCollection();
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_SaleShop_payment.Columns.pay_id, pay_id);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int32 pay_id)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_SaleShop_payment.Columns.pay_id, pay_id);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_SaleShop_payment.Columns column,Dictionary<DO_SaleShop_payment.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_SaleShop_payment.UO_SaleShop_payment parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_payment.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.pay_id != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_payment.Columns.pay_id)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_payment.Columns.pay_id,extTokens), DO_SaleShop_payment.Columns.pay_id,parameterObj.pay_id);
			}
			if (!string.IsNullOrEmpty(parameterObj.pay_name))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_payment.Columns.pay_name,extTokens), DO_SaleShop_payment.Columns.pay_name,parameterObj.pay_name);
			}
			if (!string.IsNullOrEmpty(parameterObj.pay_code))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_payment.Columns.pay_code,extTokens), DO_SaleShop_payment.Columns.pay_code,parameterObj.pay_code);
			}
			if (!string.IsNullOrEmpty(parameterObj.pay_fee))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_payment.Columns.pay_fee,extTokens), DO_SaleShop_payment.Columns.pay_fee,parameterObj.pay_fee);
			}
			if (!string.IsNullOrEmpty(parameterObj.pay_desc))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_payment.Columns.pay_desc,extTokens), DO_SaleShop_payment.Columns.pay_desc,parameterObj.pay_desc);
			}
			if (parameterObj.Orderdisplay != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_payment.Columns.Orderdisplay)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_payment.Columns.Orderdisplay,extTokens), DO_SaleShop_payment.Columns.Orderdisplay,parameterObj.Orderdisplay);
			}
			if (!string.IsNullOrEmpty(parameterObj.pay_config))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_payment.Columns.pay_config,extTokens), DO_SaleShop_payment.Columns.pay_config,parameterObj.pay_config);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_SaleShop_payment.UOList_SaleShop_payment GetAllList()
		{
			DO_SaleShop_payment da = new DO_SaleShop_payment();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_SaleShop_payment da = new DO_SaleShop_payment();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_SaleShop_payment.UO_SaleShop_payment parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_SaleShop_payment.UO_SaleShop_payment parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_payment.Columns, TokenTypes> extTokens)
		{
			DO_SaleShop_payment da = new DO_SaleShop_payment();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_SaleShop_payment.UOList_SaleShop_payment GetList(DO_SaleShop_payment.UO_SaleShop_payment parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_payment.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_SaleShop_payment.UOList_SaleShop_payment GetList(DO_SaleShop_payment.UO_SaleShop_payment parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_SaleShop_payment.UO_SaleShop_payment GetObject(System.Int32 pay_id)
		{
			DO_SaleShop_payment da = new DO_SaleShop_payment();
			DO_SaleShop_payment.UOList_SaleShop_payment l = da.GetList(GetConditionsByPrimaryKey(pay_id));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_SaleShop_payment.UO_SaleShop_payment GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_SaleShop_payment da = new DO_SaleShop_payment();
			DO_SaleShop_payment.UOList_SaleShop_payment l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_SaleShop_payment.UO_SaleShop_payment, DO_SaleShop_payment.UOList_SaleShop_payment> GetPagingList(DO_SaleShop_payment.UO_SaleShop_payment parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_payment.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_SaleShop_payment.UO_SaleShop_payment, DO_SaleShop_payment.UOList_SaleShop_payment> GetPagingList(DO_SaleShop_payment.UO_SaleShop_payment parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_SaleShop_payment.UO_SaleShop_payment GetObjectById(System.Int32 pay_id)
		{
			DO_SaleShop_payment da = new DO_SaleShop_payment();
			DO_SaleShop_payment.UOList_SaleShop_payment l = da.GetList(GetConditionsById(pay_id));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_SaleShop_payment.UO_SaleShop_payment obj, System.Int32 pay_id)
		{
			return obj.Update(GetConditionsByPrimaryKey(pay_id)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_SaleShop_payment.UO_SaleShop_payment obj, System.Int32 pay_id, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(pay_id)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_SaleShop_payment.UO_SaleShop_payment obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_SaleShop_payment.UO_SaleShop_payment obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}
		#endregion

		#region Delete functions
		///<summary>
		///Delete object by primary key.
		///</summary>
		public static int Delete(System.Int32 pay_id)
		{
			DO_SaleShop_payment da = new DO_SaleShop_payment();
			return da.Delete(GetConditionsByPrimaryKey(pay_id));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int32 pay_id, IDbConnection connection, IDbTransaction transaction)
		{
			DO_SaleShop_payment da = new DO_SaleShop_payment();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(pay_id));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_SaleShop_payment da = new DO_SaleShop_payment();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_SaleShop_payment da = new DO_SaleShop_payment();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}