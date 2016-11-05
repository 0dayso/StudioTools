using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_User_MoneyInOut_Callback : GetTogether.Web.UI.PageCallback
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
        Database_Output_User_MoneyInOut_Result c = (Database_Output_User_MoneyInOut_Result)Page.LoadControl("User_MoneyInOut_Result.ascx");
        DO_User_MoneyInOut.UO_User_MoneyInOut l = new DO_User_MoneyInOut.UO_User_MoneyInOut();
        GetTogether.Web.WebHelper.SetValues<DO_User_MoneyInOut.UO_User_MoneyInOut>(l, "User_MoneyInOut_");
        if (string.IsNullOrEmpty(Sort)) Sort = DO_User_MoneyInOut.Columns.Id.ToString();
        PagingResult<DO_User_MoneyInOut.UO_User_MoneyInOut, DO_User_MoneyInOut.UOList_User_MoneyInOut> resultPaging = BO_User_MoneyInOut.GetPagingList(l, PageIndex, PageSize, Sort, IsAsc);
        c.JsFunction = "User_MoneyInOut_Search";
        c.SetData<DO_User_MoneyInOut.UO_User_MoneyInOut, DO_User_MoneyInOut.UOList_User_MoneyInOut>(resultPaging.Result);
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
            int[] ids = GetParameterArrayInt(Request["keys"], "User_MoneyInOut_", ',');
            ParameterCollection conditions = new ParameterCollection();
            conditions.AddCondition(ParameterType.Initial, TokenTypes.In, DO_User_MoneyInOut.Columns.Id, ids);
 
            if (new DO_User_MoneyInOut().Delete(conditions) > 0)
                JsonSuccess();
            else
                JsonError("Delete Failure");
        }
        catch (Exception ex)
        {
            JsonError(ex.Message);
        }
    }

	public partial class DO_User_MoneyInOut : DOBase<DO_User_MoneyInOut.UO_User_MoneyInOut, DO_User_MoneyInOut.UOList_User_MoneyInOut>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "User_MoneyInOut",
                        @"Data Source=112.124.118.0;Initial Catalog=NHOMEKF;Persist Security Info=True;User ID=sa;Password=Esunlit2008;Connect Timeout=99999999",
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
			WasteBookId,
			UId,
			OrderId,
			Flag,
			Momey,
			MoneyType,
			Note,
			Source,
			PayCode,
			PayBookId,
			BeginTime,
			EndTime,
			State,
		}
		public DO_User_MoneyInOut()
		{
		}
		public partial class UO_User_MoneyInOut : UOBase<UO_User_MoneyInOut,UOList_User_MoneyInOut>
		{
                        public override ConnectionInformation GetDefaultConnectionInformation()
                        {
                            return GetConnectionInformation();
                        }
			#region Columns
			private System.Int64 _Id;
			/// <summary>
			///Primary Key,Auto Increment
			/// </summary>
			[Mapping("Id,un-insert,un-update")]
			public System.Int64 Id
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
			private System.String _WasteBookId;
			[Mapping("WasteBookId")]
			public System.String WasteBookId
			{
				get
				{
					return _WasteBookId;
				}
				set
				{
					_WasteBookId = value;
				}
			}
			private System.Int64 _UId;
			[Mapping("UId")]
			public System.Int64 UId
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
			private System.String _OrderId;
			[Mapping("OrderId")]
			public System.String OrderId
			{
				get
				{
					return _OrderId;
				}
				set
				{
					_OrderId = value;
				}
			}
			private System.Int32 _Flag;
			[Mapping("Flag")]
			public System.Int32 Flag
			{
				get
				{
					return _Flag;
				}
				set
				{
					_Flag = value;
				}
			}
			private System.Decimal _Momey;
			[Mapping("Momey")]
			public System.Decimal Momey
			{
				get
				{
					return _Momey;
				}
				set
				{
					_Momey = value;
				}
			}
			private System.Int32 _MoneyType;
			[Mapping("MoneyType")]
			public System.Int32 MoneyType
			{
				get
				{
					return _MoneyType;
				}
				set
				{
					_MoneyType = value;
				}
			}
			private System.String _Note;
			[Mapping("Note")]
			public System.String Note
			{
				get
				{
					return _Note;
				}
				set
				{
					_Note = value;
				}
			}
			private System.String _Source;
			[Mapping("Source")]
			public System.String Source
			{
				get
				{
					return _Source;
				}
				set
				{
					_Source = value;
				}
			}
			private System.String _PayCode;
			[Mapping("PayCode")]
			public System.String PayCode
			{
				get
				{
					return _PayCode;
				}
				set
				{
					_PayCode = value;
				}
			}
			private System.String _PayBookId;
			[Mapping("PayBookId")]
			public System.String PayBookId
			{
				get
				{
					return _PayBookId;
				}
				set
				{
					_PayBookId = value;
				}
			}
			private System.DateTime _BeginTime;
			[Mapping("BeginTime")]
			public System.DateTime BeginTime
			{
				get
				{
					return _BeginTime;
				}
				set
				{
					_BeginTime = value;
				}
			}
			private System.DateTime _EndTime;
			[Mapping("EndTime")]
			public System.DateTime EndTime
			{
				get
				{
					return _EndTime;
				}
				set
				{
					_EndTime = value;
				}
			}
			private System.Int32 _State;
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
			#endregion
			public UO_User_MoneyInOut()
			{
			}
		}
		public partial class UOList_User_MoneyInOut : GetTogether.ObjectBase.ListBase<UO_User_MoneyInOut>
		{
			public UOList_User_MoneyInOut()
			{
			}
		}
	}


	public partial class BO_User_MoneyInOut
	{
		#region Condition functions
		///<summary>
		///Get conditions by primary key string.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKeyString(string primaryKeyString)
		{
			string[] primaryKeys = primaryKeyString.Split('|');
			System.Int64 Id = Convert.ToInt64(primaryKeys[0]);
			return GetConditionsByPrimaryKey(Id);
		}

		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKey(System.Int64 Id)
		{
			ParameterCollection primaryConditions = new ParameterCollection();
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_User_MoneyInOut.Columns.Id, Id);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int64 Id)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_User_MoneyInOut.Columns.Id, Id);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_User_MoneyInOut.Columns column,Dictionary<DO_User_MoneyInOut.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_User_MoneyInOut.UO_User_MoneyInOut parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_User_MoneyInOut.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.Id != 0 || (extTokens != null && extTokens.ContainsKey(DO_User_MoneyInOut.Columns.Id)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.Id,extTokens), DO_User_MoneyInOut.Columns.Id,parameterObj.Id);
			}
			if (!string.IsNullOrEmpty(parameterObj.WasteBookId))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.WasteBookId,extTokens), DO_User_MoneyInOut.Columns.WasteBookId,parameterObj.WasteBookId);
			}
			if (parameterObj.UId != 0 || (extTokens != null && extTokens.ContainsKey(DO_User_MoneyInOut.Columns.UId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.UId,extTokens), DO_User_MoneyInOut.Columns.UId,parameterObj.UId);
			}
			if (!string.IsNullOrEmpty(parameterObj.OrderId))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.OrderId,extTokens), DO_User_MoneyInOut.Columns.OrderId,parameterObj.OrderId);
			}
			if (parameterObj.Flag != 0 || (extTokens != null && extTokens.ContainsKey(DO_User_MoneyInOut.Columns.Flag)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.Flag,extTokens), DO_User_MoneyInOut.Columns.Flag,parameterObj.Flag);
			}
			if (parameterObj.Momey != 0 || (extTokens != null && extTokens.ContainsKey(DO_User_MoneyInOut.Columns.Momey)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.Momey,extTokens), DO_User_MoneyInOut.Columns.Momey,parameterObj.Momey);
			}
			if (parameterObj.MoneyType != 0 || (extTokens != null && extTokens.ContainsKey(DO_User_MoneyInOut.Columns.MoneyType)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.MoneyType,extTokens), DO_User_MoneyInOut.Columns.MoneyType,parameterObj.MoneyType);
			}
			if (!string.IsNullOrEmpty(parameterObj.Note))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.Note,extTokens), DO_User_MoneyInOut.Columns.Note,parameterObj.Note);
			}
			if (!string.IsNullOrEmpty(parameterObj.Source))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.Source,extTokens), DO_User_MoneyInOut.Columns.Source,parameterObj.Source);
			}
			if (!string.IsNullOrEmpty(parameterObj.PayCode))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.PayCode,extTokens), DO_User_MoneyInOut.Columns.PayCode,parameterObj.PayCode);
			}
			if (!string.IsNullOrEmpty(parameterObj.PayBookId))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.PayBookId,extTokens), DO_User_MoneyInOut.Columns.PayBookId,parameterObj.PayBookId);
			}
			if (parameterObj.BeginTime != DateTime.MinValue)
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.BeginTime,extTokens), DO_User_MoneyInOut.Columns.BeginTime,parameterObj.BeginTime);
			}
			if (parameterObj.EndTime != DateTime.MinValue)
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.EndTime,extTokens), DO_User_MoneyInOut.Columns.EndTime,parameterObj.EndTime);
			}
			if (parameterObj.State != 0 || (extTokens != null && extTokens.ContainsKey(DO_User_MoneyInOut.Columns.State)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_User_MoneyInOut.Columns.State,extTokens), DO_User_MoneyInOut.Columns.State,parameterObj.State);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_User_MoneyInOut.UOList_User_MoneyInOut GetAllList()
		{
			DO_User_MoneyInOut da = new DO_User_MoneyInOut();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_User_MoneyInOut da = new DO_User_MoneyInOut();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_User_MoneyInOut.UO_User_MoneyInOut parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_User_MoneyInOut.UO_User_MoneyInOut parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_User_MoneyInOut.Columns, TokenTypes> extTokens)
		{
			DO_User_MoneyInOut da = new DO_User_MoneyInOut();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_User_MoneyInOut.UOList_User_MoneyInOut GetList(DO_User_MoneyInOut.UO_User_MoneyInOut parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_User_MoneyInOut.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_User_MoneyInOut.UOList_User_MoneyInOut GetList(DO_User_MoneyInOut.UO_User_MoneyInOut parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_User_MoneyInOut.UO_User_MoneyInOut GetObject(System.Int64 Id)
		{
			DO_User_MoneyInOut da = new DO_User_MoneyInOut();
			DO_User_MoneyInOut.UOList_User_MoneyInOut l = da.GetList(GetConditionsByPrimaryKey(Id));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_User_MoneyInOut.UO_User_MoneyInOut GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_User_MoneyInOut da = new DO_User_MoneyInOut();
			DO_User_MoneyInOut.UOList_User_MoneyInOut l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_User_MoneyInOut.UO_User_MoneyInOut, DO_User_MoneyInOut.UOList_User_MoneyInOut> GetPagingList(DO_User_MoneyInOut.UO_User_MoneyInOut parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_User_MoneyInOut.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_User_MoneyInOut.UO_User_MoneyInOut, DO_User_MoneyInOut.UOList_User_MoneyInOut> GetPagingList(DO_User_MoneyInOut.UO_User_MoneyInOut parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_User_MoneyInOut.UO_User_MoneyInOut GetObjectById(System.Int64 Id)
		{
			DO_User_MoneyInOut da = new DO_User_MoneyInOut();
			DO_User_MoneyInOut.UOList_User_MoneyInOut l = da.GetList(GetConditionsById(Id));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_User_MoneyInOut.UO_User_MoneyInOut obj, System.Int64 Id)
		{
			return obj.Update(GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_User_MoneyInOut.UO_User_MoneyInOut obj, System.Int64 Id, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_User_MoneyInOut.UO_User_MoneyInOut obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_User_MoneyInOut.UO_User_MoneyInOut obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}
		#endregion

		#region Delete functions
		///<summary>
		///Delete object by primary key.
		///</summary>
		public static int Delete(System.Int64 Id)
		{
			DO_User_MoneyInOut da = new DO_User_MoneyInOut();
			return da.Delete(GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int64 Id, IDbConnection connection, IDbTransaction transaction)
		{
			DO_User_MoneyInOut da = new DO_User_MoneyInOut();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_User_MoneyInOut da = new DO_User_MoneyInOut();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_User_MoneyInOut da = new DO_User_MoneyInOut();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}