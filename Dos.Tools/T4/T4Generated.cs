using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Data;
using Dos.Tools.Common;
using Dos.Tools.Model;
using Dos.ORM;
using Dos.Common;
using Dos.Tools.DbDAL;
using System;
using System.Xml;

namespace Dos.Tools.T4
{
    #region  生成实体类
    /// <summary>
    /// 生成实体类
    /// </summary>
    public partial class MakeEntity
    {
        public List<ColumnInfo> Columns = new List<ColumnInfo>();
        public string _nameSpace = string.Empty;
        public string _tableName = string.Empty;
        public string _className = string.Empty;
        public static string _appPath = string.Empty;
        public bool _IsView = false;
        public bool _isSZMDX = false;
        public string _dbType = string.Empty;
        

    public class DbToCS
        {

            /// <summary>
            /// 类型配置文件
            /// </summary>
            public static readonly string DbTypePath = _appPath+ "/Config/dbtype.xml";


            private const string cachekeystring = "_dbtype_cache_";



            static Dictionary<string, string> loadType()
            {

                Dictionary<string, string> types = Dos.ORM.Cache.Default.GetCache(cachekeystring) as Dictionary<string, string>;

                if (null == types)
                {

                    types = new Dictionary<string, string>();

                    XmlDocument doc = new XmlDocument();

                    doc.Load(DbTypePath);

                    XmlNodeList nodes = doc.SelectNodes("//type");

                    if (null != nodes && nodes.Count > 0)
                    {
                        foreach (XmlNode node in nodes)
                        {
                            XmlAttribute att = node.Attributes["dbtype"];
                            if (null != att)
                            {
                                string dbtypeStr = att.Value.Trim().ToLower();
                                if (!types.ContainsKey(dbtypeStr))
                                {
                                    XmlAttribute attcstype = node.Attributes["cstype"];
                                    if (null != attcstype)
                                    {
                                        types.Add(dbtypeStr, attcstype.Value);
                                    }
                                }
                            }
                        }
                    }

                    Dos.ORM.Cache.Default.AddCacheFilesDependency(cachekeystring, types, DbTypePath);

                }

                return types;
            }


            /// <summary>
            /// 修改TypeName
            /// </summary>
            /// <param name="columns"></param>
            /// <param name="dbType"></param>
            /// <returns></returns>
            public static List<ColumnInfo> DbtoCSColumns(List<ColumnInfo> columns, string dbType)
            {
                Dictionary<string, string> types = loadType();

                foreach (ColumnInfo column in columns)
                {
                    try
                    {
                        if (column.TypeName.Trim().ToLower() == "char" && column.Length == "36"
                            && (dbType == "MySql" || dbType == "Oracle"))
                        {
                            column.TypeName = types["uniqueidentifier"];
                        }
                        else if (column.TypeName.Trim().ToLower() == "tinyint" && column.Length == "1" && dbType == "MySql")
                        {
                            column.TypeName = types["bit"];
                        }
                        else
                        {
                            column.TypeName = types[column.TypeName.Trim().ToLower()];
                        }
                    }
                    catch
                    {
                        column.TypeName = "object";
                    }
                    if (!column.IsIdentity && !column.IsPK && column.cisNull)
                    {
                        if (!column.TypeName.Equals("string") && !column.TypeName.Equals("object") && !column.TypeName.Equals("byte[]"))
                            column.TypeName += "?";
                    }
                }

                return columns;
            }

        }
    }
    #endregion

}
