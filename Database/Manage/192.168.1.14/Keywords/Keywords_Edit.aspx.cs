using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_Keywords_Edit : GetTogether.Web.UI.Page
{
    public DO_Keywords.UO_Keywords UO;
    protected void Page_Load(object sender, EventArgs e)
    {
        Int64 id = 0;
		if(!string.IsNullOrEmpty(Request["id"])) id = Convert.ToInt64(Request["id"]);
        if (id > 0)
        {
            UO = BO_Keywords.GetObjectById(id);
        }
        if (UO == null) UO = new DO_Keywords.UO_Keywords();

        if (Request.Form.Keys.Count > 0)
        {
            GetTogether.Web.WebHelper.SetValues<DO_Keywords.UO_Keywords>(UO, "Keywords_");
            if (id > 0)
            {
				//Pending
				UO["UpdateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["UpdateBy"] = string.Concat("WS-",Request.UserHostAddress);
                UO.Update(BO_Keywords.GetConditionsById(id));
            }
            else
            {
				//Pending
				UO["CreateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["CreateBy"]=string.Concat("WS-",Request.UserHostAddress);
                UO.Insert();
            }
            Response.Redirect("Keywords.aspx");
        }
    }
	public partial class DO_Keywords : DOBase<DO_Keywords.UO_Keywords, DO_Keywords.UOList_Keywords>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "Keywords",
                        @"Data Source=120.24.176.97;Initial Catalog=NHOMEKF;Persist Security Info=True;User ID=sqlnet2;Password=sqlnet2015;Connect Timeout=99999999",
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
			Find,
			Replacement,
			Editor,
			EditTime,
		}
		public DO_Keywords()
		{
		}
		public partial class UO_Keywords : UOBase<UO_Keywords,UOList_Keywords>
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
			private System.String _Find;
			[Mapping("Find")]
			public System.String Find
			{
				get
				{
					return _Find;
				}
				set
				{
					_Find = value;
				}
			}
			private System.String _Replacement;
			[Mapping("Replacement")]
			public System.String Replacement
			{
				get
				{
					return _Replacement;
				}
				set
				{
					_Replacement = value;
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
			public UO_Keywords()
			{
			}
		}
		public partial class UOList_Keywords : GetTogether.ObjectBase.ListBase<UO_Keywords>
		{
			public UOList_Keywords()
			{
			}
		}
	}


	public partial class BO_Keywords
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
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_Keywords.Columns.Id, Id);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int64 Id)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_Keywords.Columns.Id, Id);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_Keywords.Columns column,Dictionary<DO_Keywords.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_Keywords.UO_Keywords parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_Keywords.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.Id != 0 || (extTokens != null && extTokens.ContainsKey(DO_Keywords.Columns.Id)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Keywords.Columns.Id,extTokens), DO_Keywords.Columns.Id,parameterObj.Id);
			}
			if (!string.IsNullOrEmpty(parameterObj.Find))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Keywords.Columns.Find,extTokens), DO_Keywords.Columns.Find,parameterObj.Find);
			}
			if (!string.IsNullOrEmpty(parameterObj.Replacement))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Keywords.Columns.Replacement,extTokens), DO_Keywords.Columns.Replacement,parameterObj.Replacement);
			}
			if (!string.IsNullOrEmpty(parameterObj.Editor))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Keywords.Columns.Editor,extTokens), DO_Keywords.Columns.Editor,parameterObj.Editor);
			}
			if (parameterObj.EditTime != DateTime.MinValue)
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Keywords.Columns.EditTime,extTokens), DO_Keywords.Columns.EditTime,parameterObj.EditTime);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_Keywords.UOList_Keywords GetAllList()
		{
			DO_Keywords da = new DO_Keywords();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_Keywords da = new DO_Keywords();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_Keywords.UO_Keywords parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_Keywords.UO_Keywords parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_Keywords.Columns, TokenTypes> extTokens)
		{
			DO_Keywords da = new DO_Keywords();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_Keywords.UOList_Keywords GetList(DO_Keywords.UO_Keywords parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_Keywords.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_Keywords.UOList_Keywords GetList(DO_Keywords.UO_Keywords parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_Keywords.UO_Keywords GetObject(System.Int64 Id)
		{
			DO_Keywords da = new DO_Keywords();
			DO_Keywords.UOList_Keywords l = da.GetList(GetConditionsByPrimaryKey(Id));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_Keywords.UO_Keywords GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_Keywords da = new DO_Keywords();
			DO_Keywords.UOList_Keywords l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_Keywords.UO_Keywords, DO_Keywords.UOList_Keywords> GetPagingList(DO_Keywords.UO_Keywords parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_Keywords.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_Keywords.UO_Keywords, DO_Keywords.UOList_Keywords> GetPagingList(DO_Keywords.UO_Keywords parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_Keywords.UO_Keywords GetObjectById(System.Int64 Id)
		{
			DO_Keywords da = new DO_Keywords();
			DO_Keywords.UOList_Keywords l = da.GetList(GetConditionsById(Id));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_Keywords.UO_Keywords obj, System.Int64 Id)
		{
			return obj.Update(GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_Keywords.UO_Keywords obj, System.Int64 Id, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_Keywords.UO_Keywords obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_Keywords.UO_Keywords obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
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
			DO_Keywords da = new DO_Keywords();
			return da.Delete(GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int64 Id, IDbConnection connection, IDbTransaction transaction)
		{
			DO_Keywords da = new DO_Keywords();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_Keywords da = new DO_Keywords();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_Keywords da = new DO_Keywords();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}