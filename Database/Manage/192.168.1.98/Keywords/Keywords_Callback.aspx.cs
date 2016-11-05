using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_Keywords_Callback : GetTogether.Web.UI.PageCallback
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
        Database_Output_Keywords_Result c = (Database_Output_Keywords_Result)Page.LoadControl("Keywords_Result.ascx");
        DO_Keywords.UO_Keywords l = new DO_Keywords.UO_Keywords();
        GetTogether.Web.WebHelper.SetValues<DO_Keywords.UO_Keywords>(l, "Keywords_");
        if (string.IsNullOrEmpty(Sort)) Sort = DO_Keywords.Columns.id.ToString();
        PagingResult<DO_Keywords.UO_Keywords, DO_Keywords.UOList_Keywords> resultPaging = BO_Keywords.GetPagingList(l, PageIndex, PageSize, Sort, IsAsc);
        c.JsFunction = "Keywords_Search";
        c.SetData<DO_Keywords.UO_Keywords, DO_Keywords.UOList_Keywords>(resultPaging.Result);
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
            int[] ids = GetParameterArrayInt(Request["keys"], "Keywords_", ',');
            ParameterCollection conditions = new ParameterCollection();
            conditions.AddCondition(ParameterType.Initial, TokenTypes.In, DO_Keywords.Columns.id, ids);
 
            if (new DO_Keywords().Delete(conditions) > 0)
                JsonSuccess();
            else
                JsonError("Delete Failure");
        }
        catch (Exception ex)
        {
            JsonError(ex.Message);
        }
    }

	public partial class DO_Keywords : DOBase<DO_Keywords.UO_Keywords, DO_Keywords.UOList_Keywords>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "Keywords",
                        @"Data Source=192.168.1.88;Initial Catalog=YSL_Shop;Persist Security Info=True;User ID=sa;Password=Esunlit2008;Connect Timeout=30",
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
			find,
			replacement,
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
			private System.String _find;
			[Mapping("find")]
			public System.String find
			{
				get
				{
					return _find;
				}
				set
				{
					_find = value;
				}
			}
			private System.String _replacement;
			[Mapping("replacement")]
			public System.String replacement
			{
				get
				{
					return _replacement;
				}
				set
				{
					_replacement = value;
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
			System.Int32 id = Convert.ToInt32(primaryKeys[0]);
			return GetConditionsByPrimaryKey(id);
		}

		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKey(System.Int32 id)
		{
			ParameterCollection primaryConditions = new ParameterCollection();
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_Keywords.Columns.id, id);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int32 id)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_Keywords.Columns.id, id);
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
			if (parameterObj.id != 0 || (extTokens != null && extTokens.ContainsKey(DO_Keywords.Columns.id)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Keywords.Columns.id,extTokens), DO_Keywords.Columns.id,parameterObj.id);
			}
			if (!string.IsNullOrEmpty(parameterObj.find))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Keywords.Columns.find,extTokens), DO_Keywords.Columns.find,parameterObj.find);
			}
			if (!string.IsNullOrEmpty(parameterObj.replacement))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Keywords.Columns.replacement,extTokens), DO_Keywords.Columns.replacement,parameterObj.replacement);
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
		public static DO_Keywords.UO_Keywords GetObject(System.Int32 id)
		{
			DO_Keywords da = new DO_Keywords();
			DO_Keywords.UOList_Keywords l = da.GetList(GetConditionsByPrimaryKey(id));
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
		public static DO_Keywords.UO_Keywords GetObjectById(System.Int32 id)
		{
			DO_Keywords da = new DO_Keywords();
			DO_Keywords.UOList_Keywords l = da.GetList(GetConditionsById(id));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_Keywords.UO_Keywords obj, System.Int32 id)
		{
			return obj.Update(GetConditionsByPrimaryKey(id)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_Keywords.UO_Keywords obj, System.Int32 id, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(id)) > 0;
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
		public static int Delete(System.Int32 id)
		{
			DO_Keywords da = new DO_Keywords();
			return da.Delete(GetConditionsByPrimaryKey(id));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int32 id, IDbConnection connection, IDbTransaction transaction)
		{
			DO_Keywords da = new DO_Keywords();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(id));
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