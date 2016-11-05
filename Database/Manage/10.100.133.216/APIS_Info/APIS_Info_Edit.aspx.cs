using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_APIS_Info_Edit : GetTogether.Web.UI.Page
{
    public DO_APIS_Info.UO_APIS_Info UO;
    protected void Page_Load(object sender, EventArgs e)
    {
        Int32 id = 0;
		if(!string.IsNullOrEmpty(Request["id"])) id = Convert.ToInt32(Request["id"]);
        if (id > 0)
        {
            UO = BO_APIS_Info.GetObjectById(id);
        }
        if (UO == null) UO = new DO_APIS_Info.UO_APIS_Info();

        if (Request.Form.Keys.Count > 0)
        {
            GetTogether.Web.WebHelper.SetValues<DO_APIS_Info.UO_APIS_Info>(UO, "APIS_Info_");
            if (id > 0)
            {
				//Pending
				UO["UpdateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["UpdateBy"] = string.Concat("WS-",Request.UserHostAddress);
                UO.Update(BO_APIS_Info.GetConditionsById(id));
            }
            else
            {
				//Pending
				UO["CreateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["CreateBy"]=string.Concat("WS-",Request.UserHostAddress);
                UO.Insert();
            }
            Response.Redirect("APIS_Info.aspx");
        }
    }
	public partial class DO_APIS_Info : DOBase<DO_APIS_Info.UO_APIS_Info, DO_APIS_Info.UOList_APIS_Info>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "APIS_Info",
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
			Country,
			Airlines,
			IsRequired,
			CreateOn,
			CreateBy,
			UpdateOn,
			UpdateBy,
		}
		public DO_APIS_Info()
		{
		}
		public partial class UO_APIS_Info : UOBase<UO_APIS_Info,UOList_APIS_Info>
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
			private System.String _Country;
			[Mapping("Country")]
			public System.String Country
			{
				get
				{
					return _Country;
				}
				set
				{
					_Country = value;
				}
			}
			private System.String _Airlines;
			[Mapping("Airlines")]
			public System.String Airlines
			{
				get
				{
					return _Airlines;
				}
				set
				{
					_Airlines = value;
				}
			}
			private System.Boolean _IsRequired;
			[Mapping("IsRequired")]
			public System.Boolean IsRequired
			{
				get
				{
					return _IsRequired;
				}
				set
				{
					_IsRequired = value;
				}
			}
			private System.DateTime _CreateOn;
			[Mapping("CreateOn,un-insert,un-update")]
			public System.DateTime CreateOn
			{
				get
				{
					return _CreateOn;
				}
				set
				{
					_CreateOn = value;
				}
			}
			private System.String _CreateBy;
			[Mapping("CreateBy,un-update")]
			public System.String CreateBy
			{
				get
				{
					return _CreateBy;
				}
				set
				{
					_CreateBy = value;
				}
			}
			private System.DateTime _UpdateOn;
			[Mapping("UpdateOn,un-insert")]
			public System.DateTime UpdateOn
			{
				get
				{
					return _UpdateOn;
				}
				set
				{
					_UpdateOn = value;
				}
			}
			private System.String _UpdateBy;
			[Mapping("UpdateBy,un-insert")]
			public System.String UpdateBy
			{
				get
				{
					return _UpdateBy;
				}
				set
				{
					_UpdateBy = value;
				}
			}
			#endregion
			public UO_APIS_Info()
			{
			}
		}
		public partial class UOList_APIS_Info : GetTogether.ObjectBase.ListBase<UO_APIS_Info>
		{
			public UOList_APIS_Info()
			{
			}
		}
	}


	public partial class BO_APIS_Info
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
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_APIS_Info.Columns.Id, Id);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int32 Id)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_APIS_Info.Columns.Id, Id);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_APIS_Info.Columns column,Dictionary<DO_APIS_Info.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_APIS_Info.UO_APIS_Info parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_APIS_Info.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.Id != 0 || (extTokens != null && extTokens.ContainsKey(DO_APIS_Info.Columns.Id)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_APIS_Info.Columns.Id,extTokens), DO_APIS_Info.Columns.Id,parameterObj.Id);
			}
			if (!string.IsNullOrEmpty(parameterObj.Country))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_APIS_Info.Columns.Country,extTokens), DO_APIS_Info.Columns.Country,parameterObj.Country);
			}
			if (!string.IsNullOrEmpty(parameterObj.Airlines))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_APIS_Info.Columns.Airlines,extTokens), DO_APIS_Info.Columns.Airlines,parameterObj.Airlines);
			}
			if (!string.IsNullOrEmpty(parameterObj.CreateBy))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_APIS_Info.Columns.CreateBy,extTokens), DO_APIS_Info.Columns.CreateBy,parameterObj.CreateBy);
			}
			if (!string.IsNullOrEmpty(parameterObj.UpdateBy))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_APIS_Info.Columns.UpdateBy,extTokens), DO_APIS_Info.Columns.UpdateBy,parameterObj.UpdateBy);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_APIS_Info.UOList_APIS_Info GetAllList()
		{
			DO_APIS_Info da = new DO_APIS_Info();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_APIS_Info da = new DO_APIS_Info();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_APIS_Info.UO_APIS_Info parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_APIS_Info.UO_APIS_Info parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_APIS_Info.Columns, TokenTypes> extTokens)
		{
			DO_APIS_Info da = new DO_APIS_Info();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_APIS_Info.UOList_APIS_Info GetList(DO_APIS_Info.UO_APIS_Info parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_APIS_Info.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_APIS_Info.UOList_APIS_Info GetList(DO_APIS_Info.UO_APIS_Info parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_APIS_Info.UO_APIS_Info GetObject(System.Int32 Id)
		{
			DO_APIS_Info da = new DO_APIS_Info();
			DO_APIS_Info.UOList_APIS_Info l = da.GetList(GetConditionsByPrimaryKey(Id));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_APIS_Info.UO_APIS_Info GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_APIS_Info da = new DO_APIS_Info();
			DO_APIS_Info.UOList_APIS_Info l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_APIS_Info.UO_APIS_Info, DO_APIS_Info.UOList_APIS_Info> GetPagingList(DO_APIS_Info.UO_APIS_Info parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_APIS_Info.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_APIS_Info.UO_APIS_Info, DO_APIS_Info.UOList_APIS_Info> GetPagingList(DO_APIS_Info.UO_APIS_Info parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_APIS_Info.UO_APIS_Info GetObjectById(System.Int32 Id)
		{
			DO_APIS_Info da = new DO_APIS_Info();
			DO_APIS_Info.UOList_APIS_Info l = da.GetList(GetConditionsById(Id));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_APIS_Info.UO_APIS_Info obj, System.Int32 Id)
		{
			return obj.Update(GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_APIS_Info.UO_APIS_Info obj, System.Int32 Id, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_APIS_Info.UO_APIS_Info obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_APIS_Info.UO_APIS_Info obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
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
			DO_APIS_Info da = new DO_APIS_Info();
			return da.Delete(GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int32 Id, IDbConnection connection, IDbTransaction transaction)
		{
			DO_APIS_Info da = new DO_APIS_Info();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_APIS_Info da = new DO_APIS_Info();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_APIS_Info da = new DO_APIS_Info();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}