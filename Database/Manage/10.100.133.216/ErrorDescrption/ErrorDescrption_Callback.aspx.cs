using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_ErrorDescrption_Callback : GetTogether.Web.UI.PageCallback
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
        Database_Output_ErrorDescrption_Result c = (Database_Output_ErrorDescrption_Result)Page.LoadControl("ErrorDescrption_Result.ascx");
        DO_ErrorDescrption.UO_ErrorDescrption l = new DO_ErrorDescrption.UO_ErrorDescrption();
        GetTogether.Web.WebHelper.SetValues<DO_ErrorDescrption.UO_ErrorDescrption>(l, "ErrorDescrption_");
        if (string.IsNullOrEmpty(Sort)) Sort = DO_ErrorDescrption.Columns.Code.ToString();
        PagingResult<DO_ErrorDescrption.UO_ErrorDescrption, DO_ErrorDescrption.UOList_ErrorDescrption> resultPaging = BO_ErrorDescrption.GetPagingList(l, PageIndex, PageSize, Sort, IsAsc);
        c.JsFunction = "ErrorDescrption_Search";
        c.SetData<DO_ErrorDescrption.UO_ErrorDescrption, DO_ErrorDescrption.UOList_ErrorDescrption>(resultPaging.Result);
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
            string[] primaryKeyStrings = GetParameterArrayString(Request["keys"], "ErrorDescrption_", ',');
			bool success=false;
            foreach(string primaryKeyString in primaryKeyStrings)
			{
				success = BO_ErrorDescrption.DeleteByPrimaryKeyString(primaryKeyString)>0;
				if(!success) break;
			}
            if (success)
                JsonSuccess();
            else
                JsonError("Delete Failure");
        }
        catch (Exception ex)
        {
            JsonError(ex.Message);
        }
    }

	public partial class DO_ErrorDescrption : DOBase<DO_ErrorDescrption.UO_ErrorDescrption, DO_ErrorDescrption.UOList_ErrorDescrption>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "ErrorDescrption",
                        @"Data Source=10.100.133.81\sqlexpress;Initial Catalog=AutoTicket;Persist Security Info=True;User ID=sa;Password=gzuat;Connect Timeout=30",
                        new string[] {"Code"},
                        DatabaseType.SQLServer);
                }
                public override ConnectionInformation GetDefaultConnectionInformation()
                {
                    return GetConnectionInformation();
                }
		public enum Columns
		{
			/// <summary>
			///Primary Key
			/// </summary>
			Code,
			Description,
			DescriptionKeywords,
			DescriptionType,
			CreateOn,
			CreateBy,
			UpdateOn,
			UpdateBy,
		}
		public DO_ErrorDescrption()
		{
		}
		public partial class UO_ErrorDescrption : UOBase<UO_ErrorDescrption,UOList_ErrorDescrption>
		{
public override ConnectionInformation GetDefaultConnectionInformation()
            {
                return GetConnectionInformation();
            }
			#region Columns
			private System.String _Code;
			/// <summary>
			///Primary Key
			/// </summary>
			[Mapping("Code,un-update")]
			public System.String Code
			{
				get
				{
					return _Code;
				}
				set
				{
					_Code = value;
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
			private System.String _DescriptionKeywords;
			[Mapping("DescriptionKeywords")]
			public System.String DescriptionKeywords
			{
				get
				{
					return _DescriptionKeywords;
				}
				set
				{
					_DescriptionKeywords = value;
				}
			}
			private System.Int32 _DescriptionType;
			[Mapping("DescriptionType")]
			public System.Int32 DescriptionType
			{
				get
				{
					return _DescriptionType;
				}
				set
				{
					_DescriptionType = value;
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
			public UO_ErrorDescrption()
			{
			}
		}
		public partial class UOList_ErrorDescrption : GetTogether.ObjectBase.ListBase<UO_ErrorDescrption>
		{
			public UOList_ErrorDescrption()
			{
			}
		}
	}


	public partial class BO_ErrorDescrption
	{
		#region Condition functions
		///<summary>
		///Get conditions by primary key string.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKeyString(string primaryKeyString)
		{
			string[] primaryKeys = primaryKeyString.Split('|');
			System.String Code = primaryKeys[0];
			return GetConditionsByPrimaryKey(Code);
		}

		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsByPrimaryKey(System.String Code)
		{
			ParameterCollection primaryConditions = new ParameterCollection();
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_ErrorDescrption.Columns.Code, Code);
			return primaryConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_ErrorDescrption.Columns column,Dictionary<DO_ErrorDescrption.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_ErrorDescrption.UO_ErrorDescrption parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_ErrorDescrption.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (!string.IsNullOrEmpty(parameterObj.Code))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_ErrorDescrption.Columns.Code,extTokens), DO_ErrorDescrption.Columns.Code,parameterObj.Code);
			}
			if (!string.IsNullOrEmpty(parameterObj.Description))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_ErrorDescrption.Columns.Description,extTokens), DO_ErrorDescrption.Columns.Description,parameterObj.Description);
			}
			if (!string.IsNullOrEmpty(parameterObj.DescriptionKeywords))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_ErrorDescrption.Columns.DescriptionKeywords,extTokens), DO_ErrorDescrption.Columns.DescriptionKeywords,parameterObj.DescriptionKeywords);
			}
			if (parameterObj.DescriptionType != 0 || (extTokens != null && extTokens.ContainsKey(DO_ErrorDescrption.Columns.DescriptionType)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_ErrorDescrption.Columns.DescriptionType,extTokens), DO_ErrorDescrption.Columns.DescriptionType,parameterObj.DescriptionType);
			}
			if (!string.IsNullOrEmpty(parameterObj.CreateBy))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_ErrorDescrption.Columns.CreateBy,extTokens), DO_ErrorDescrption.Columns.CreateBy,parameterObj.CreateBy);
			}
			if (!string.IsNullOrEmpty(parameterObj.UpdateBy))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_ErrorDescrption.Columns.UpdateBy,extTokens), DO_ErrorDescrption.Columns.UpdateBy,parameterObj.UpdateBy);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_ErrorDescrption.UOList_ErrorDescrption GetAllList()
		{
			DO_ErrorDescrption da = new DO_ErrorDescrption();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_ErrorDescrption da = new DO_ErrorDescrption();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_ErrorDescrption.UO_ErrorDescrption parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_ErrorDescrption.UO_ErrorDescrption parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_ErrorDescrption.Columns, TokenTypes> extTokens)
		{
			DO_ErrorDescrption da = new DO_ErrorDescrption();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_ErrorDescrption.UOList_ErrorDescrption GetList(DO_ErrorDescrption.UO_ErrorDescrption parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_ErrorDescrption.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_ErrorDescrption.UOList_ErrorDescrption GetList(DO_ErrorDescrption.UO_ErrorDescrption parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_ErrorDescrption.UO_ErrorDescrption GetObject(System.String Code)
		{
			DO_ErrorDescrption da = new DO_ErrorDescrption();
			DO_ErrorDescrption.UOList_ErrorDescrption l = da.GetList(GetConditionsByPrimaryKey(Code));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_ErrorDescrption.UO_ErrorDescrption GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_ErrorDescrption da = new DO_ErrorDescrption();
			DO_ErrorDescrption.UOList_ErrorDescrption l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_ErrorDescrption.UO_ErrorDescrption, DO_ErrorDescrption.UOList_ErrorDescrption> GetPagingList(DO_ErrorDescrption.UO_ErrorDescrption parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_ErrorDescrption.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_ErrorDescrption.UO_ErrorDescrption, DO_ErrorDescrption.UOList_ErrorDescrption> GetPagingList(DO_ErrorDescrption.UO_ErrorDescrption parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_ErrorDescrption.UO_ErrorDescrption obj, System.String Code)
		{
			return obj.Update(GetConditionsByPrimaryKey(Code)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_ErrorDescrption.UO_ErrorDescrption obj, System.String Code, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(Code)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_ErrorDescrption.UO_ErrorDescrption obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_ErrorDescrption.UO_ErrorDescrption obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}
		#endregion

		#region Delete functions
		///<summary>
		///Delete object by primary key.
		///</summary>
		public static int Delete(System.String Code)
		{
			DO_ErrorDescrption da = new DO_ErrorDescrption();
			return da.Delete(GetConditionsByPrimaryKey(Code));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.String Code, IDbConnection connection, IDbTransaction transaction)
		{
			DO_ErrorDescrption da = new DO_ErrorDescrption();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(Code));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_ErrorDescrption da = new DO_ErrorDescrption();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_ErrorDescrption da = new DO_ErrorDescrption();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}