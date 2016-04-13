using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using XgxFrameWork.CacheLayer.RedisCacheManager;
using Dos.Model;

namespace XgxFrameWork.Presentation.Client.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            #region 生成接口拥有的方法
            var type = typeof (IDal<AppendCC>);
            var gettype = type.GetMethods();

            StringBuilder Methods = new StringBuilder();
            string returnType= string.Empty;
            string classType = string.Empty;
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder stringBuilder2 = new StringBuilder();
            foreach (var VARIABLE in gettype)
            {
                returnType = VARIABLE.ReturnType.ToString()
                                
                                .Replace(typeof(List<>).Namespace+".", string.Empty)
                                .Replace(typeof(int).Namespace + ".", string.Empty)
                                .Replace(typeof(AppendCC).Namespace+".",string.Empty)
                                .Replace("`1", "")
                                .Replace("[", "<")
                                .Replace("]", ">");



                
                if (VARIABLE.IsPublic)
                {
                    classType = "Public ";
                }
                if (VARIABLE.IsPrivate)
                {
                    classType = "Public ";
                }
                if (VARIABLE.IsStatic)
                {
                    classType += " Static";
                }
                var Parameters = VARIABLE.GetParameters();
                foreach (var VARIABLEP in Parameters)
                { 
                        stringBuilder.Append(",");
                        stringBuilder.Append(
                            VARIABLEP.ToString()
                               .Replace(typeof(List<>).Namespace + ".", string.Empty)
                                .Replace(typeof(int).Namespace + ".", string.Empty)
                                .Replace(typeof(AppendCC).Namespace + ".", string.Empty)
                                .Replace("`1", "")
                                .Replace("[", "<")
                                .Replace("]", ">"));




                }
                if (Parameters.Length > 0)
                {
                    stringBuilder.Remove(0, 1);

                }
                else
                {
                    stringBuilder.Clear();
                }
                
                
                
                stringBuilder2.Append(classType).Append(returnType).Append(" ").Append(VARIABLE.Name).Append("(").Append(stringBuilder).Append(")");
                stringBuilder.Clear();
                stringBuilder2.AppendLine();
                stringBuilder2.AppendLine("{");
                stringBuilder2.AppendLine("     throw new NotImplementedException();");
                stringBuilder2.AppendLine("}");
                Methods.Append(stringBuilder2);




                stringBuilder2.Clear();

            }

            


           
            #endregion
        }
        public class MyClass
        {

            public void a()
            {
                #region 生成接口拥有的方法
                var type = typeof(IDal<AppendCC>);
                var gettype = type.GetMethods();

                StringBuilder Methods = new StringBuilder();
                string returnType = string.Empty;
                string classType = string.Empty;
                StringBuilder stringBuilder = new StringBuilder();
                StringBuilder stringBuilder2 = new StringBuilder();
                foreach (var VARIABLE in gettype)
                {
                    returnType = VARIABLE.ReturnType.ToString()

                                    .Replace(typeof(List<>).Namespace + ".", string.Empty)
                                    .Replace(typeof(int).Namespace + ".", string.Empty)
                                    .Replace(typeof(AppendCC).Namespace + ".", string.Empty)
                                    .Replace("`1", "")
                                    .Replace("[", "<")
                                    .Replace("]", ">");




                    if (VARIABLE.IsPublic)
                    {
                        classType = "Public ";
                    }
                    if (VARIABLE.IsPrivate)
                    {
                        classType = "Public ";
                    }
                    if (VARIABLE.IsStatic)
                    {
                        classType += " Static";
                    }
                    var Parameters = VARIABLE.GetParameters();
                    foreach (var VARIABLEP in Parameters)
                    {
                        stringBuilder.Append(",");
                        stringBuilder.Append(
                            VARIABLEP.ToString()
                               .Replace(typeof(List<>).Namespace + ".", string.Empty)
                                .Replace(typeof(int).Namespace + ".", string.Empty)
                                .Replace(typeof(AppendCC).Namespace + ".", string.Empty)
                                .Replace("`1", "")
                                .Replace("[", "<")
                                .Replace("]", ">"));




                    }
                    if (Parameters.Length > 0)
                    {
                        stringBuilder.Remove(0, 1);

                    }
                    else
                    {
                        stringBuilder.Clear();
                    }



                    stringBuilder2.Append(classType).Append(returnType).Append(" ").Append(VARIABLE.Name).Append("(").Append(stringBuilder).Append(")");
                    stringBuilder.Clear();
                    stringBuilder2.AppendLine();
                    stringBuilder2.AppendLine("{");
                    stringBuilder2.AppendLine("     throw new NotImplementedException();");
                    stringBuilder2.AppendLine("}");
                    Methods.Append(stringBuilder2);




                    stringBuilder2.Clear();

                }





                #endregion

            }
        }
    }
}
