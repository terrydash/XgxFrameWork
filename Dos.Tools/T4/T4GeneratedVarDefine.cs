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
    /// <summary>
    /// 针对数据库操作的类型
    /// </summary>
    public enum DataOperType
    {
        None = 0,
        Select = 1, //查询
        Insert = 2, //增加
        Update = 3, //修改
        Delete = 4 //删除
    }
    /// <summary>
    /// 接口内的方法与与实际操作方法的对应类 便于根据接口里的方法名字生成对应操作
    /// </summary>
    public  class Interface2MethodMap
    {
        public string InterfaceName { get; set; }//接口名
        public string MethodName { get; set; }//生成的方法名
        public DataOperType DataOperType { get;set; }//方法针对数据库是什么操作 用来与Dos.Orm接口对应
    }

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
        public static string connString { get; set; }
        public static string DataBaseType { get; set; }

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
