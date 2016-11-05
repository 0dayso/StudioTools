using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_AirfareMarkupMode_Edit : GetTogether.Web.UI.Page
{
    public DO_AirfareMarkupMode.UO_AirfareMarkupMode UO;
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 id = 0;
		if(!string.IsNullOrEmpty(Request["id"])) id = Convert.ToInt32(Request["id"]);
        if (id > 0)
        {
            UO = BO_AirfareMarkupMode.GetObjectById(id);
        }
        if (UO == null) UO = new DO_AirfareMarkupMode.UO_AirfareMarkupMode();

        if (Request.Form.Keys.Count > 0)
        {
            GetTogether.Web.WebHelper.SetValues<DO_AirfareMarkupMode.UO_AirfareMarkupMode>(UO, "AirfareMarkupMode_");
            if (id > 0)
            {
				//Pending
				UO["UpdateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["UpdateBy"] = string.Concat("WS-",Request.UserHostAddress);
                UO.Update(BO_AirfareMarkupMode.GetConditionsById(id));
            }
            else
            {
				//Pending
				UO["CreateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["CreateBy"]=string.Concat("WS-",Request.UserHostAddress);
                UO.Insert();
            }
            Response.Redirect("AirfareMarkupMode.aspx");
        }
    }
	public partial class DO_AirfareMarkupMode : DOBase<DO_AirfareMarkupMode.UO_AirfareMarkupMode, DO_AirfareMarkupMode.UOList_AirfareMarkupMode>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "AirfareMarkupMode",
                        @"Data Source=10.100.133.81\sqlexpress;Initial Catalog=ADHolidays;Persist Security Info=True;User ID=sa;Password=gzuat;Connect Timeout=30",
                        new string[] {"ID"},
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
			ID,
			DetailId,
			Rank,
			MarkupBy,
			Amount,
			Rate,
			RoundUpBy,
			IsRoundDown,
			MarkupByValue,
			Description,
			AirfareMarkupModeType,
		}
		public DO_AirfareMarkupMode()
		{
		}
		public partial class UO_AirfareMarkupMode : UOBase<UO_AirfareMarkupMode,UOList_AirfareMarkupMode>
		{
public override ConnectionInformation GetDefaultConnectionInformation()
            {
                return GetConnectionInformation();
            }
			#region Columns
			private System.Int32 _ID;
			/// <summary>
			///Primary Key,Auto Increment
			/// </summary>
			[Mapping("ID,un-insert,un-update")]
			public System.Int32 ID
			{
				get
				{
					return _ID;
				}
				set
				{
					_ID = value;
				}
			}
			private System.Int32 _DetailId;
			[Mapping("DetailId")]
			public System.Int32 DetailId
			{
				get
				{
					return _DetailId;
				}
				set
				{
					_DetailId = value;
				}
			}
			private System.Int32 _Rank;
			[Mapping("Rank")]
			public System.Int32 Rank
			{
				get
				{
					return _Rank;
				}
				set
				{
					_Rank = value;
				}
			}
			private System.Int32 _MarkupBy;
			[Mapping("MarkupBy")]
			public System.Int32 MarkupBy
			{
				get
				{
					return _MarkupBy;
				}
				set
				{
					_MarkupBy = value;
				}
			}
			private System.Decimal _Amount;
			[Mapping("Amount")]
			public System.Decimal Amount
			{
				get
				{
					return _Amount;
				}
				set
				{
					_Amount = value;
				}
			}
			private System.Decimal _Rate;
			[Mapping("Rate")]
			public System.Decimal Rate
			{
				get
				{
					return _Rate;
				}
				set
				{
					_Rate = value;
				}
			}
			private System.Int32 _RoundUpBy;
			[Mapping("RoundUpBy")]
			public System.Int32 RoundUpBy
			{
				get
				{
					return _RoundUpBy;
				}
				set
				{
					_RoundUpBy = value;
				}
			}
			private System.Boolean _IsRoundDown;
			[Mapping("IsRoundDown")]
			public System.Boolean IsRoundDown
			{
				get
				{
					return _IsRoundDown;
				}
				set
				{
					_IsRoundDown = value;
				}
			}
			private System.String _MarkupByValue;
			[Mapping("MarkupByValue")]
			public System.String MarkupByValue
			{
				get
				{
					return _MarkupByValue;
				}
				set
				{
					_MarkupByValue = value;
				}
			}
			private System.String _Description;
			[Mapping("Description")]
			public System.String Description
			{
				get
				{
					return _Description;
				}
				set
				{
					_Description = value;
				}
			}
			private System.Int32 _AirfareMarkupModeType;
			[Mapping("AirfareMarkupModeType")]
			public System.Int32 AirfareMarkupModeType
			{
				get
				{
					return _AirfareMarkupModeType;
				}
				set
				{
					_AirfareMarkupModeType = value;
				}
			}
			#endregion
			public UO_AirfareMarkupMode()
			{
			}
		}
		public partial class UOList_AirfareMarkupMode : GetTogether.ObjectBase.ListBase<UO_AirfareMarkupMode>
		{
			public UOList_AirfareMarkupMode()
			{
			}
		}
	}


	public partial class BO_AirfareMarkupMode
	{
		#region Condition functions
		///<summary>
		///Get conditions by primary key string.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKeyString(string primaryKeyString)
		{
			string[] primaryKeys = primaryKeyString.Split('|');
			System.Int32 ID = Convert.ToInt32(primaryKeys[0]);
			return GetConditionsByPrimaryKey(ID);
		}

		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKey(System.Int32 ID)
		{
			ParameterCollection primaryConditions = new ParameterCollection();
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_AirfareMarkupMode.Columns.ID, ID);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int32 ID)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_AirfareMarkupMode.Columns.ID, ID);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_AirfareMarkupMode.Columns column,Dictionary<DO_AirfareMarkupMode.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_AirfareMarkupMode.UO_AirfareMarkupMode parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_AirfareMarkupMode.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.ID != 0 || (extTokens != null && extTokens.ContainsKey(DO_AirfareMarkupMode.Columns.ID)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareMarkupMode.Columns.ID,extTokens), DO_AirfareMarkupMode.Columns.ID,parameterObj.ID);
			}
			if (parameterObj.DetailId != 0 || (extTokens != null && extTokens.ContainsKey(DO_AirfareMarkupMode.Columns.DetailId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareMarkupMode.Columns.DetailId,extTokens), DO_AirfareMarkupMode.Columns.DetailId,parameterObj.DetailId);
			}
			if (parameterObj.Rank != 0 || (extTokens != null && extTokens.ContainsKey(DO_AirfareMarkupMode.Columns.Rank)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareMarkupMode.Columns.Rank,extTokens), DO_AirfareMarkupMode.Columns.Rank,parameterObj.Rank);
			}
			if (parameterObj.MarkupBy != 0 || (extTokens != null && extTokens.ContainsKey(DO_AirfareMarkupMode.Columns.MarkupBy)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareMarkupMode.Columns.MarkupBy,extTokens), DO_AirfareMarkupMode.Columns.MarkupBy,parameterObj.MarkupBy);
			}
			if (parameterObj.Amount != 0 || (extTokens != null && extTokens.ContainsKey(DO_AirfareMarkupMode.Columns.Amount)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareMarkupMode.Columns.Amount,extTokens), DO_AirfareMarkupMode.Columns.Amount,parameterObj.Amount);
			}
			if (parameterObj.Rate != 0 || (extTokens != null && extTokens.ContainsKey(DO_AirfareMarkupMode.Columns.Rate)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareMarkupMode.Columns.Rate,extTokens), DO_AirfareMarkupMode.Columns.Rate,parameterObj.Rate);
			}
			if (parameterObj.RoundUpBy != 0 || (extTokens != null && extTokens.ContainsKey(DO_AirfareMarkupMode.Columns.RoundUpBy)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareMarkupMode.Columns.RoundUpBy,extTokens), DO_AirfareMarkupMode.Columns.RoundUpBy,parameterObj.RoundUpBy);
			}
			if (!string.IsNullOrEmpty(parameterObj.MarkupByValue))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareMarkupMode.Columns.MarkupByValue,extTokens), DO_AirfareMarkupMode.Columns.MarkupByValue,parameterObj.MarkupByValue);
			}
			if (!string.IsNullOrEmpty(parameterObj.Description))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareMarkupMode.Columns.Description,extTokens), DO_AirfareMarkupMode.Columns.Description,parameterObj.Description);
			}
			if (parameterObj.AirfareMarkupModeType != 0 || (extTokens != null && extTokens.ContainsKey(DO_AirfareMarkupMode.Columns.AirfareMarkupModeType)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_AirfareMarkupMode.Columns.AirfareMarkupModeType,extTokens), DO_AirfareMarkupMode.Columns.AirfareMarkupModeType,parameterObj.AirfareMarkupModeType);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_AirfareMarkupMode.UOList_AirfareMarkupMode GetAllList()
		{
			DO_AirfareMarkupMode da = new DO_AirfareMarkupMode();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_AirfareMarkupMode da = new DO_AirfareMarkupMode();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_AirfareMarkupMode.UO_AirfareMarkupMode parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_AirfareMarkupMode.UO_AirfareMarkupMode parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_AirfareMarkupMode.Columns, TokenTypes> extTokens)
		{
			DO_AirfareMarkupMode da = new DO_AirfareMarkupMode();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_AirfareMarkupMode.UOList_AirfareMarkupMode GetList(DO_AirfareMarkupMode.UO_AirfareMarkupMode parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_AirfareMarkupMode.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_AirfareMarkupMode.UOList_AirfareMarkupMode GetList(DO_AirfareMarkupMode.UO_AirfareMarkupMode parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_AirfareMarkupMode.UO_AirfareMarkupMode GetObject(System.Int32 ID)
		{
			DO_AirfareMarkupMode da = new DO_AirfareMarkupMode();
			DO_AirfareMarkupMode.UOList_AirfareMarkupMode l = da.GetList(GetConditionsByPrimaryKey(ID));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_AirfareMarkupMode.UO_AirfareMarkupMode GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_AirfareMarkupMode da = new DO_AirfareMarkupMode();
			DO_AirfareMarkupMode.UOList_AirfareMarkupMode l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_AirfareMarkupMode.UO_AirfareMarkupMode, DO_AirfareMarkupMode.UOList_AirfareMarkupMode> GetPagingList(DO_AirfareMarkupMode.UO_AirfareMarkupMode parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_AirfareMarkupMode.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_AirfareMarkupMode.UO_AirfareMarkupMode, DO_AirfareMarkupMode.UOList_AirfareMarkupMode> GetPagingList(DO_AirfareMarkupMode.UO_AirfareMarkupMode parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_AirfareMarkupMode.UO_AirfareMarkupMode GetObjectById(System.Int32 ID)
		{
			DO_AirfareMarkupMode da = new DO_AirfareMarkupMode();
			DO_AirfareMarkupMode.UOList_AirfareMarkupMode l = da.GetList(GetConditionsById(ID));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_AirfareMarkupMode.UO_AirfareMarkupMode obj, System.Int32 ID)
		{
			return obj.Update(GetConditionsByPrimaryKey(ID)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_AirfareMarkupMode.UO_AirfareMarkupMode obj, System.Int32 ID, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(ID)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_AirfareMarkupMode.UO_AirfareMarkupMode obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_AirfareMarkupMode.UO_AirfareMarkupMode obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}
		#endregion

		#region Delete functions
		///<summary>
		///Delete object by primary key.
		///</summary>
		public static int Delete(System.Int32 ID)
		{
			DO_AirfareMarkupMode da = new DO_AirfareMarkupMode();
			return da.Delete(GetConditionsByPrimaryKey(ID));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int32 ID, IDbConnection connection, IDbTransaction transaction)
		{
			DO_AirfareMarkupMode da = new DO_AirfareMarkupMode();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(ID));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_AirfareMarkupMode da = new DO_AirfareMarkupMode();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_AirfareMarkupMode da = new DO_AirfareMarkupMode();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}