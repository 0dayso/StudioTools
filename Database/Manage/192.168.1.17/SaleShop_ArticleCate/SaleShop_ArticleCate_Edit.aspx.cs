using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_SaleShop_ArticleCate_Edit : GetTogether.Web.UI.Page
{
    public DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate UO;
    protected void Page_Load(object sender, EventArgs e)
    {
        Int64 id = 0;
		if(!string.IsNullOrEmpty(Request["id"])) id = Convert.ToInt64(Request["id"]);
        if (id > 0)
        {
            UO = BO_SaleShop_ArticleCate.GetObjectById(id);
        }
        if (UO == null) UO = new DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate();

        if (Request.Form.Keys.Count > 0)
        {
            GetTogether.Web.WebHelper.SetValues<DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate>(UO, "SaleShop_ArticleCate_");
            if (id > 0)
            {
				//Pending
				UO["UpdateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["UpdateBy"] = string.Concat("WS-",Request.UserHostAddress);
                UO.Update(BO_SaleShop_ArticleCate.GetConditionsById(id));
            }
            else
            {
				//Pending
				UO["CreateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["CreateBy"]=string.Concat("WS-",Request.UserHostAddress);
                UO.Insert();
            }
            Response.Redirect("SaleShop_ArticleCate.aspx");
        }
    }
	public partial class DO_SaleShop_ArticleCate : DOBase<DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate, DO_SaleShop_ArticleCate.UOList_SaleShop_ArticleCate>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "SaleShop_ArticleCate",
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
			Level,
			ParentId,
			Name,
			CateType,
			ShopId,
			UrlAlias,
			AddTime,
			Adder,
			SeoKeywords,
			SeoDescription,
			IsSys,
			OrderNum,
			Editor,
			EditTime,
			Disable,
		}
		public DO_SaleShop_ArticleCate()
		{
		}
		public partial class UO_SaleShop_ArticleCate : UOBase<UO_SaleShop_ArticleCate,UOList_SaleShop_ArticleCate>
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
			private System.Int32 _Level;
			[Mapping("Level")]
			public System.Int32 Level
			{
				get
				{
					return _Level;
				}
				set
				{
					_Level = value;
				}
			}
			private System.Int64 _ParentId;
			[Mapping("ParentId")]
			public System.Int64 ParentId
			{
				get
				{
					return _ParentId;
				}
				set
				{
					_ParentId = value;
				}
			}
			private System.String _Name;
			[Mapping("Name")]
			public System.String Name
			{
				get
				{
					return _Name;
				}
				set
				{
					_Name = value;
				}
			}
			private System.Int32 _CateType;
			[Mapping("CateType")]
			public System.Int32 CateType
			{
				get
				{
					return _CateType;
				}
				set
				{
					_CateType = value;
				}
			}
			private System.Int64 _ShopId;
			[Mapping("ShopId")]
			public System.Int64 ShopId
			{
				get
				{
					return _ShopId;
				}
				set
				{
					_ShopId = value;
				}
			}
			private System.String _UrlAlias;
			[Mapping("UrlAlias")]
			public System.String UrlAlias
			{
				get
				{
					return _UrlAlias;
				}
				set
				{
					_UrlAlias = value;
				}
			}
			private System.DateTime _AddTime;
			[Mapping("AddTime")]
			public System.DateTime AddTime
			{
				get
				{
					return _AddTime;
				}
				set
				{
					_AddTime = value;
				}
			}
			private System.String _Adder;
			[Mapping("Adder")]
			public System.String Adder
			{
				get
				{
					return _Adder;
				}
				set
				{
					_Adder = value;
				}
			}
			private System.String _SeoKeywords;
			[Mapping("SeoKeywords")]
			public System.String SeoKeywords
			{
				get
				{
					return _SeoKeywords;
				}
				set
				{
					_SeoKeywords = value;
				}
			}
			private System.String _SeoDescription;
			[Mapping("SeoDescription")]
			public System.String SeoDescription
			{
				get
				{
					return _SeoDescription;
				}
				set
				{
					_SeoDescription = value;
				}
			}
			private System.Boolean _IsSys;
			[Mapping("IsSys")]
			public System.Boolean IsSys
			{
				get
				{
					return _IsSys;
				}
				set
				{
					_IsSys = value;
				}
			}
			private System.Int32 _OrderNum;
			[Mapping("OrderNum")]
			public System.Int32 OrderNum
			{
				get
				{
					return _OrderNum;
				}
				set
				{
					_OrderNum = value;
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
			private System.Boolean _Disable;
			[Mapping("Disable")]
			public System.Boolean Disable
			{
				get
				{
					return _Disable;
				}
				set
				{
					_Disable = value;
				}
			}
			#endregion
			public UO_SaleShop_ArticleCate()
			{
			}
		}
		public partial class UOList_SaleShop_ArticleCate : GetTogether.ObjectBase.ListBase<UO_SaleShop_ArticleCate>
		{
			public UOList_SaleShop_ArticleCate()
			{
			}
		}
	}


	public partial class BO_SaleShop_ArticleCate
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
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_SaleShop_ArticleCate.Columns.Id, Id);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int64 Id)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_SaleShop_ArticleCate.Columns.Id, Id);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_SaleShop_ArticleCate.Columns column,Dictionary<DO_SaleShop_ArticleCate.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_ArticleCate.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.Id != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ArticleCate.Columns.Id)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.Id,extTokens), DO_SaleShop_ArticleCate.Columns.Id,parameterObj.Id);
			}
			if (parameterObj.Level != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ArticleCate.Columns.Level)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.Level,extTokens), DO_SaleShop_ArticleCate.Columns.Level,parameterObj.Level);
			}
			if (parameterObj.ParentId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ArticleCate.Columns.ParentId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.ParentId,extTokens), DO_SaleShop_ArticleCate.Columns.ParentId,parameterObj.ParentId);
			}
			if (!string.IsNullOrEmpty(parameterObj.Name))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.Name,extTokens), DO_SaleShop_ArticleCate.Columns.Name,parameterObj.Name);
			}
			if (parameterObj.CateType != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ArticleCate.Columns.CateType)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.CateType,extTokens), DO_SaleShop_ArticleCate.Columns.CateType,parameterObj.CateType);
			}
			if (parameterObj.ShopId != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ArticleCate.Columns.ShopId)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.ShopId,extTokens), DO_SaleShop_ArticleCate.Columns.ShopId,parameterObj.ShopId);
			}
			if (!string.IsNullOrEmpty(parameterObj.UrlAlias))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.UrlAlias,extTokens), DO_SaleShop_ArticleCate.Columns.UrlAlias,parameterObj.UrlAlias);
			}
			if (parameterObj.AddTime != DateTime.MinValue)
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.AddTime,extTokens), DO_SaleShop_ArticleCate.Columns.AddTime,parameterObj.AddTime);
			}
			if (!string.IsNullOrEmpty(parameterObj.Adder))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.Adder,extTokens), DO_SaleShop_ArticleCate.Columns.Adder,parameterObj.Adder);
			}
			if (!string.IsNullOrEmpty(parameterObj.SeoKeywords))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.SeoKeywords,extTokens), DO_SaleShop_ArticleCate.Columns.SeoKeywords,parameterObj.SeoKeywords);
			}
			if (!string.IsNullOrEmpty(parameterObj.SeoDescription))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.SeoDescription,extTokens), DO_SaleShop_ArticleCate.Columns.SeoDescription,parameterObj.SeoDescription);
			}
			if (parameterObj.OrderNum != 0 || (extTokens != null && extTokens.ContainsKey(DO_SaleShop_ArticleCate.Columns.OrderNum)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.OrderNum,extTokens), DO_SaleShop_ArticleCate.Columns.OrderNum,parameterObj.OrderNum);
			}
			if (!string.IsNullOrEmpty(parameterObj.Editor))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.Editor,extTokens), DO_SaleShop_ArticleCate.Columns.Editor,parameterObj.Editor);
			}
			if (parameterObj.EditTime != DateTime.MinValue)
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_SaleShop_ArticleCate.Columns.EditTime,extTokens), DO_SaleShop_ArticleCate.Columns.EditTime,parameterObj.EditTime);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_SaleShop_ArticleCate.UOList_SaleShop_ArticleCate GetAllList()
		{
			DO_SaleShop_ArticleCate da = new DO_SaleShop_ArticleCate();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_SaleShop_ArticleCate da = new DO_SaleShop_ArticleCate();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_ArticleCate.Columns, TokenTypes> extTokens)
		{
			DO_SaleShop_ArticleCate da = new DO_SaleShop_ArticleCate();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_SaleShop_ArticleCate.UOList_SaleShop_ArticleCate GetList(DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_ArticleCate.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_SaleShop_ArticleCate.UOList_SaleShop_ArticleCate GetList(DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate GetObject(System.Int64 Id)
		{
			DO_SaleShop_ArticleCate da = new DO_SaleShop_ArticleCate();
			DO_SaleShop_ArticleCate.UOList_SaleShop_ArticleCate l = da.GetList(GetConditionsByPrimaryKey(Id));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_SaleShop_ArticleCate da = new DO_SaleShop_ArticleCate();
			DO_SaleShop_ArticleCate.UOList_SaleShop_ArticleCate l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate, DO_SaleShop_ArticleCate.UOList_SaleShop_ArticleCate> GetPagingList(DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_SaleShop_ArticleCate.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate, DO_SaleShop_ArticleCate.UOList_SaleShop_ArticleCate> GetPagingList(DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate GetObjectById(System.Int64 Id)
		{
			DO_SaleShop_ArticleCate da = new DO_SaleShop_ArticleCate();
			DO_SaleShop_ArticleCate.UOList_SaleShop_ArticleCate l = da.GetList(GetConditionsById(Id));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate obj, System.Int64 Id)
		{
			return obj.Update(GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate obj, System.Int64 Id, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_SaleShop_ArticleCate.UO_SaleShop_ArticleCate obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
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
			DO_SaleShop_ArticleCate da = new DO_SaleShop_ArticleCate();
			return da.Delete(GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int64 Id, IDbConnection connection, IDbTransaction transaction)
		{
			DO_SaleShop_ArticleCate da = new DO_SaleShop_ArticleCate();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_SaleShop_ArticleCate da = new DO_SaleShop_ArticleCate();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_SaleShop_ArticleCate da = new DO_SaleShop_ArticleCate();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}