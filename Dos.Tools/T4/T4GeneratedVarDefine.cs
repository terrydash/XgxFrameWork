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

namespace Dos.T4
{
    #region 公用常量定义
    //用于定于常用的变量
    public partial class VarDefine
    {
        public static string TableName { get; set; }
        public static string NameSpace { get; set; }
        public static string ClassName { get; set; }
        public static List<ColumnInfo> Columns { get; set; }
        public static string Apppath { get; set; }
        public static  bool IsView { get; set; }
        public static bool IsSZMDX { get; set; }
        public static string DbType { get; set; }

    }
    #endregion



    #region  生成实体的模版MakeModel.tt的变量定义
    /// <summary>
    /// 生成实体类
    /// </summary>
    public partial class MakeModel
    {
        private List<ColumnInfo> _columns =VarDefine.Columns ;
        private string _nameSpace = VarDefine.NameSpace;
        private string _tableName = VarDefine.TableName;
        private string _className = VarDefine.ClassName;
        public static string _appPath = VarDefine.Apppath;
        private bool _IsView = VarDefine.IsView;
        private bool _isSZMDX = VarDefine.IsSZMDX;
        private string _dbType = VarDefine.DbType;
        

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

                    Cache.Default.AddCacheFilesDependency(cachekeystring, types, DbTypePath);

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
