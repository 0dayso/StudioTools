using System;
using System.Collections.Generic;
using GetTogether.Data;
using GetTogether.Mapping;
using System.Data;

public partial class Database_Output_Main_AdvertisementsType_Edit : GetTogether.Web.UI.Page
{
    public DO_Main_AdvertisementsType.UO_Main_AdvertisementsType UO;
    protected void Page_Load(object sender, EventArgs e)
    {
        Int64 id = 0;
		if(!string.IsNullOrEmpty(Request["id"])) id = Convert.ToInt64(Request["id"]);
        if (id > 0)
        {
            UO = BO_Main_AdvertisementsType.GetObjectById(id);
        }
        if (UO == null) UO = new DO_Main_AdvertisementsType.UO_Main_AdvertisementsType();

        if (Request.Form.Keys.Count > 0)
        {
            GetTogether.Web.WebHelper.SetValues<DO_Main_AdvertisementsType.UO_Main_AdvertisementsType>(UO, "Main_AdvertisementsType_");
            if (id > 0)
            {
				//Pending
				UO["UpdateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["UpdateBy"] = string.Concat("WS-",Request.UserHostAddress);
                UO.Update(BO_Main_AdvertisementsType.GetConditionsById(id));
            }
            else
            {
				//Pending
				UO["CreateOn","yyyy-MM-dd"]=DateTime.Now.ToString("yyyy-MM-dd");
				UO["CreateBy"]=string.Concat("WS-",Request.UserHostAddress);
                UO.Insert();
            }
            Response.Redirect("Main_AdvertisementsType.aspx");
        }
    }
	public partial class DO_Main_AdvertisementsType : DOBase<DO_Main_AdvertisementsType.UO_Main_AdvertisementsType, DO_Main_AdvertisementsType.UOList_Main_AdvertisementsType>
	{
               public static ConnectionInformation GetConnectionInformation()
                {
                    return new   ConnectionInformation(
                        "Main_AdvertisementsType",
                        @"Data Source=112.124.104.246;Initial Catalog=NHOMEKF;Persist Security Info=True;User ID=sa;Password=Esunlit2008;Connect Timeout=30",
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
			Name,
			Price,
			ImgUrl,
			Adway,
			DefaultHtmlCode,
			DefaultParameter,
			EditTime,
		}
		public DO_Main_AdvertisementsType()
		{
		}
		public partial class UO_Main_AdvertisementsType : UOBase<UO_Main_AdvertisementsType,UOList_Main_AdvertisementsType>
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
			private System.Decimal _Price;
			[Mapping("Price")]
			public System.Decimal Price
			{
				get
				{
					return _Price;
				}
				set
				{
					_Price = value;
				}
			}
			private System.String _ImgUrl;
			[Mapping("ImgUrl")]
			public System.String ImgUrl
			{
				get
				{
					return _ImgUrl;
				}
				set
				{
					_ImgUrl = value;
				}
			}
			private System.String _Adway;
			[Mapping("Adway")]
			public System.String Adway
			{
				get
				{
					return _Adway;
				}
				set
				{
					_Adway = value;
				}
			}
			private System.String _DefaultHtmlCode;
			[Mapping("DefaultHtmlCode")]
			public System.String DefaultHtmlCode
			{
				get
				{
					return _DefaultHtmlCode;
				}
				set
				{
					_DefaultHtmlCode = value;
				}
			}
			private System.String _DefaultParameter;
			[Mapping("DefaultParameter")]
			public System.String DefaultParameter
			{
				get
				{
					return _DefaultParameter;
				}
				set
				{
					_DefaultParameter = value;
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
			public UO_Main_AdvertisementsType()
			{
			}
		}
		public partial class UOList_Main_AdvertisementsType : GetTogether.ObjectBase.ListBase<UO_Main_AdvertisementsType>
		{
			public UOList_Main_AdvertisementsType()
			{
			}
		}
	}


	public partial class BO_Main_AdvertisementsType
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
			primaryConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_Main_AdvertisementsType.Columns.Id, Id);
			return primaryConditions;
		}
		///<summary>
		///Get conditions by primary key.
		///</summary>
		public static ParameterCollection GetConditionsById(System.Int64 Id)
		{
			ParameterCollection autoIncrementConditions = new ParameterCollection();
			autoIncrementConditions.AddCondition(ParameterType.Initial, TokenTypes.Equal, DO_Main_AdvertisementsType.Columns.Id, Id);
			return autoIncrementConditions;
		}

		///<summary>
		///Get the tokenType of the column of condition query.
		///</summary>
		private static TokenTypes GetColumnTokenType(TokenTypes defaultTokenType,DO_Main_AdvertisementsType.Columns column,Dictionary<DO_Main_AdvertisementsType.Columns,TokenTypes> extTokens)
		{
			if (extTokens != null && extTokens.ContainsKey(column))
				return extTokens[column];
			else
				return defaultTokenType;
		}

		///<summary>
		///Get conditions by object with Multi-TokenType.
		///</summary>
		public static ParameterCollection GetConditionsByObject(DO_Main_AdvertisementsType.UO_Main_AdvertisementsType parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_Main_AdvertisementsType.Columns, TokenTypes> extTokens)
		{
			ParameterCollection objectConditions = new ParameterCollection();
			TokenTypes tt = tokenTypes;
			ParameterType pt = isAnd ? ParameterType.And : ParameterType.Or;
			if (parameterObj.Id != 0 || (extTokens != null && extTokens.ContainsKey(DO_Main_AdvertisementsType.Columns.Id)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Main_AdvertisementsType.Columns.Id,extTokens), DO_Main_AdvertisementsType.Columns.Id,parameterObj.Id);
			}
			if (!string.IsNullOrEmpty(parameterObj.Name))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Main_AdvertisementsType.Columns.Name,extTokens), DO_Main_AdvertisementsType.Columns.Name,parameterObj.Name);
			}
			if (parameterObj.Price != 0 || (extTokens != null && extTokens.ContainsKey(DO_Main_AdvertisementsType.Columns.Price)))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Main_AdvertisementsType.Columns.Price,extTokens), DO_Main_AdvertisementsType.Columns.Price,parameterObj.Price);
			}
			if (!string.IsNullOrEmpty(parameterObj.ImgUrl))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Main_AdvertisementsType.Columns.ImgUrl,extTokens), DO_Main_AdvertisementsType.Columns.ImgUrl,parameterObj.ImgUrl);
			}
			if (!string.IsNullOrEmpty(parameterObj.Adway))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Main_AdvertisementsType.Columns.Adway,extTokens), DO_Main_AdvertisementsType.Columns.Adway,parameterObj.Adway);
			}
			if (!string.IsNullOrEmpty(parameterObj.DefaultHtmlCode))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Main_AdvertisementsType.Columns.DefaultHtmlCode,extTokens), DO_Main_AdvertisementsType.Columns.DefaultHtmlCode,parameterObj.DefaultHtmlCode);
			}
			if (!string.IsNullOrEmpty(parameterObj.DefaultParameter))
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Main_AdvertisementsType.Columns.DefaultParameter,extTokens), DO_Main_AdvertisementsType.Columns.DefaultParameter,parameterObj.DefaultParameter);
			}
			if (parameterObj.EditTime != DateTime.MinValue)
			{
				objectConditions.AddCondition(pt, GetColumnTokenType(tt,DO_Main_AdvertisementsType.Columns.EditTime,extTokens), DO_Main_AdvertisementsType.Columns.EditTime,parameterObj.EditTime);
			}
			return objectConditions;
		}
		#endregion

		#region Query functions

		///<summary>
		///Get all records.
		///</summary>
		public static DO_Main_AdvertisementsType.UOList_Main_AdvertisementsType GetAllList()
		{
			DO_Main_AdvertisementsType da = new DO_Main_AdvertisementsType();
			return da.GetAllList();
		}

		///<summary>
		///Get all records count.
		///</summary>
		public static int GetAllRecordsCount()
		{
			DO_Main_AdvertisementsType da = new DO_Main_AdvertisementsType();
			return da.GetRecordsCount();
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_Main_AdvertisementsType.UO_Main_AdvertisementsType parameterObj)
		{
			return GetRecordsCount(parameterObj, true, TokenTypes.Equal,null);
		}

		///<summary>
		///Get records count.
		///</summary>
		public static int GetRecordsCount(DO_Main_AdvertisementsType.UO_Main_AdvertisementsType parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_Main_AdvertisementsType.Columns, TokenTypes> extTokens)
		{
			DO_Main_AdvertisementsType da = new DO_Main_AdvertisementsType();
			return da.GetRecordsCount(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_Main_AdvertisementsType.UOList_Main_AdvertisementsType GetList(DO_Main_AdvertisementsType.UO_Main_AdvertisementsType parameterObj, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_Main_AdvertisementsType.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetList(GetConditionsByObject(parameterObj, isAnd, tokenTypes, extTokens));
		}

		///<summary>
		///Get list by object.
		///</summary>
		public static DO_Main_AdvertisementsType.UOList_Main_AdvertisementsType GetList(DO_Main_AdvertisementsType.UO_Main_AdvertisementsType parameterObj)
		{
			return GetList(parameterObj, true, TokenTypes.Equal, null);
		}

		///<summary>
		///Get object by primary key.
		///</summary>
		public static DO_Main_AdvertisementsType.UO_Main_AdvertisementsType GetObject(System.Int64 Id)
		{
			DO_Main_AdvertisementsType da = new DO_Main_AdvertisementsType();
			DO_Main_AdvertisementsType.UOList_Main_AdvertisementsType l = da.GetList(GetConditionsByPrimaryKey(Id));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get object by primary key string.
		///</summary>
		public static DO_Main_AdvertisementsType.UO_Main_AdvertisementsType GetObjectByPrimaryKeyString(string primaryKeyString)
		{
			DO_Main_AdvertisementsType da = new DO_Main_AdvertisementsType();
			DO_Main_AdvertisementsType.UOList_Main_AdvertisementsType l = da.GetList(GetConditionsByPrimaryKeyString(primaryKeyString));
			return l.Count > 0 ? l[0] : null;
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_Main_AdvertisementsType.UO_Main_AdvertisementsType, DO_Main_AdvertisementsType.UOList_Main_AdvertisementsType> GetPagingList(DO_Main_AdvertisementsType.UO_Main_AdvertisementsType parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc, bool isAnd, TokenTypes tokenTypes, Dictionary<DO_Main_AdvertisementsType.Columns, TokenTypes> extTokens)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, isAnd, tokenTypes,extTokens), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get paging list.
		///</summary>
		public static PagingResult<DO_Main_AdvertisementsType.UO_Main_AdvertisementsType, DO_Main_AdvertisementsType.UOList_Main_AdvertisementsType> GetPagingList(DO_Main_AdvertisementsType.UO_Main_AdvertisementsType parameterObj,int pageNumber, int pageSize,string sortBy,bool isAsc)
		{
			return parameterObj.GetPagingList(GetConditionsByObject(parameterObj, true, TokenTypes.Like,null), pageNumber, pageSize, sortBy, isAsc);
		}

		///<summary>
		///Get object by Id.
		///</summary>
		public static DO_Main_AdvertisementsType.UO_Main_AdvertisementsType GetObjectById(System.Int64 Id)
		{
			DO_Main_AdvertisementsType da = new DO_Main_AdvertisementsType();
			DO_Main_AdvertisementsType.UOList_Main_AdvertisementsType l = da.GetList(GetConditionsById(Id));
			return l.Count > 0 ? l[0] : null;
		}
		#endregion

		#region Update functions
		///<summary>
		///Update object by primary key.
		///</summary>
		public static bool UpdateObject(DO_Main_AdvertisementsType.UO_Main_AdvertisementsType obj, System.Int64 Id)
		{
			return obj.Update(GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key(with transation).
		///</summary>
		public static bool UpdateObject(DO_Main_AdvertisementsType.UO_Main_AdvertisementsType obj, System.Int64 Id, IDbConnection connection, IDbTransaction transaction)
		{
			return obj.Update(connection, transaction, GetConditionsByPrimaryKey(Id)) > 0;
		}

		///<summary>
		///Update object by primary key string.
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_Main_AdvertisementsType.UO_Main_AdvertisementsType obj, string primaryKeyString)
		{
			return obj.Update(GetConditionsByPrimaryKeyString(primaryKeyString)) > 0;
		}

		///<summary>
		///Update object by primary key string(with transation).
		///</summary>
		public static bool UpdateObjectByPrimaryKeyString(DO_Main_AdvertisementsType.UO_Main_AdvertisementsType obj, string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
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
			DO_Main_AdvertisementsType da = new DO_Main_AdvertisementsType();
			return da.Delete(GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key(with transation).
		///</summary>
		public static int Delete(System.Int64 Id, IDbConnection connection, IDbTransaction transaction)
		{
			DO_Main_AdvertisementsType da = new DO_Main_AdvertisementsType();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKey(Id));
		}

		///<summary>
		///Delete object by primary key string.
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString)
		{
			DO_Main_AdvertisementsType da = new DO_Main_AdvertisementsType();
			return da.Delete(GetConditionsByPrimaryKeyString(primaryKeyString));
		}

		///<summary>
		///Delete object by primary key string(with transation).
		///</summary>
		public static int DeleteByPrimaryKeyString(string primaryKeyString, IDbConnection connection, IDbTransaction transaction)
		{
			DO_Main_AdvertisementsType da = new DO_Main_AdvertisementsType();
			return da.Delete(connection, transaction, GetConditionsByPrimaryKeyString(primaryKeyString));
		}
		#endregion

	}

}