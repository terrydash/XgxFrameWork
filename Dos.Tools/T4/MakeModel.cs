﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 14.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，则所做更改将丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Dos.T4
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System.Data;
    using Dos.Tools.Common;
    using Dos.Tools.Model;
    using Dos.ORM;
    using Dos.Common;
    using Dos.T4;
    using Dos.Tools.DbDAL;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public partial class MakeModel : MakeModelBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("//------------------------------------------------------------------------------\r" +
                    "\n// <auto-generated>\r\n//     来自于DOS.TOOLS生成的实体模板\r\n//     生成时间：");
            
            #line 4 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(DateTime.Now));
            
            #line default
            #line hidden
            this.Write("\r\n//\t   运行库版本:");
            
            #line 5 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Environment.Version.ToString()));
            
            #line default
            #line hidden
            this.Write(@"
//     基于T4模板生成
//     修改人:徐国旭(mybest13@163.com)
//     说明如下: 
//      TableName 表名称  
//      namespace 命名空间  
//      isNewModel 是否为新模型   
//     
//                 
// </auto-generated>
//------------------------------------------------------------------------------
");
            
            #line 16 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
 
//首字母大写
 if (_isSZMDX)
{
   _className = Utils.ToUpperFirstword(_className);
}
_className=Utils.ReplaceSpace(_className);
_nameSpace = Utils.ReplaceSpace(_nameSpace);
_columns = DbToCS.DbtoCSColumns(_columns,_dbType);




            
            #line default
            #line hidden
            this.Write("using System;\r\nusing System.Data;\r\nusing System.Data.Common;\r\nusing Dos.ORM;\r\nusi" +
                    "ng Dos.ORM.Common;\r\n\r\n\r\nnamespace ");
            
            #line 36 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_nameSpace));
            
            #line default
            #line hidden
            this.Write("\r\n{\r\n\r\n\t /// <summary>\r\n     /// 实体类\"");
            
            #line 40 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_className));
            
            #line default
            #line hidden
            this.Write("\"。(属性说明自动提取数据库字段的描述信息)\r\n     /// </summary>\r\n\t[Table(\"");
            
            #line 42 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_tableName));
            
            #line default
            #line hidden
            this.Write("\")]\t\r\n\t[Serializable]\r\n\tpublic partial class ");
            
            #line 44 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_className));
            
            #line default
            #line hidden
            this.Write(" : Entity \r\n\t{\r\n\tpublic   ");
            
            #line 46 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_className));
            
            #line default
            #line hidden
            this.Write("   ():base (\"");
            
            #line 46 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_tableName));
            
            #line default
            #line hidden
            this.Write("\")   {}\r\n\tpublic ");
            
            #line 47 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(VarDefine.ClassName));
            
            #line default
            #line hidden
            this.Write(" GetNew");
            
            #line 47 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(VarDefine.ClassName));
            
            #line default
            #line hidden
            this.Write("(){return new ");
            
            #line 47 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(VarDefine.ClassName));
            
            #line default
            #line hidden
            this.Write("();}\r\n\r\n\t#region Model\r\n\t");
            
            #line 50 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BuildModel()));
            
            #line default
            #line hidden
            this.Write("\r\n\r\n\t#endregion\r\n\r\n\t#region Method\r\n\t");
            
            #line 55 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BuildMethod()));
            
            #line default
            #line hidden
            this.Write("\r\n\t#endregion\r\n\r\n\t#region Field\r\n\t");
            
            #line 59 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(BuilderField()));
            
            #line default
            #line hidden
            this.Write("\r\n\t#endregion\t\t\t\r\n\r\n\t\t\t\r\n\r\n\r\n\t}\r\n}\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 67 "G:\develop\workplace\dotnet\my\XgxFrameWork\Dos.Tools\T4\MakeModel.tt"


//生成Model方法
private string BuildModel()
{
			
			StringPlus plus = new StringPlus();
            StringPlus plus2 = new StringPlus();
            StringPlus plus3 = new StringPlus();
			foreach(ColumnInfo column in _columns)
            {
				plus2.AppendSpaceLine(2, "private " + column.TypeName + " _" + column.ColumnName + ";");
				plus3.AppendSpaceLine(2, "/// <summary>");
                plus3.AppendSpaceLine(2, "/// " + column.DeText);
                plus3.AppendSpaceLine(2, "/// </summary>");
                plus3.AppendSpaceLine(2, "public " + column.TypeName + " " + column.ColumnName);
                plus3.AppendSpaceLine(2, "{");
                plus3.AppendSpaceLine(3, "get{ return _" + column.ColumnName + "; }");
                plus3.AppendSpaceLine(3, "set");
                plus3.AppendSpaceLine(3, "{");
                plus3.AppendSpaceLine(4, "this.OnPropertyValueChange(_." + column.ColumnName + ",_" + column.ColumnName + ",value);");
                plus3.AppendSpaceLine(4, "this._" + column.ColumnName + "=value;");
                plus3.AppendSpaceLine(3, "}");
                plus3.AppendSpaceLine(2, "}");
			
			}
			plus.Append(plus2.Value);
            plus.Append(plus3.Value);
			return plus.ToString();            
}
//生成Method
 private string BuildMethod()
{
            StringPlus plus = new StringPlus();

            //只读
            if (_IsView)
            {
                plus.AppendSpaceLine(2, "/// <summary>");
                plus.AppendSpaceLine(2, "/// 是否只读");
                plus.AppendSpaceLine(2, "/// </summary>");
                plus.AppendSpaceLine(2, "public override bool IsReadOnly()");
                plus.AppendSpaceLine(2, "{");
                plus.AppendSpaceLine(3, "return true;");
                plus.AppendSpaceLine(2, "}");
            }

            ColumnInfo identityColumn = _columns.Find(delegate(ColumnInfo col) { return col.IsIdentity; });
            if (null != identityColumn)
            {
                plus.AppendSpaceLine(2, "/// <summary>");
                plus.AppendSpaceLine(2, "/// 获取实体中的标识列");
                plus.AppendSpaceLine(2, "/// </summary>");
                plus.AppendSpaceLine(2, "public override Field GetIdentityField()");
                plus.AppendSpaceLine(2, "{");
                plus.AppendSpaceLine(3, "return _." + identityColumn.ColumnName + ";");
                plus.AppendSpaceLine(2, "}");
            }

            List<ColumnInfo> primarykeyColumns = _columns.FindAll(delegate(ColumnInfo col) { return col.IsPK; });
            if (null != primarykeyColumns && primarykeyColumns.Count > 0)
            {
                plus.AppendSpaceLine(2, "/// <summary>");
                plus.AppendSpaceLine(2, "/// 获取实体中的主键列");
                plus.AppendSpaceLine(2, "/// </summary>");
                plus.AppendSpaceLine(2, "public override Field[] GetPrimaryKeyFields()");
                plus.AppendSpaceLine(2, "{");
                plus.AppendSpaceLine(3, "return new Field[] {");
                StringPlus plus2 = new StringPlus();
                foreach (ColumnInfo col in primarykeyColumns)
                {
                    plus2.AppendSpaceLine(4, "_." + col.ColumnName + ",");
                }
                plus.Append(plus2.ToString().TrimEnd().Substring(0, plus2.ToString().TrimEnd().Length - 1));
                plus.AppendLine("};");
                plus.AppendSpaceLine(2, "}");
            }



            plus.AppendSpaceLine(2, "/// <summary>");
            plus.AppendSpaceLine(2, "/// 获取列信息");
            plus.AppendSpaceLine(2, "/// </summary>");
            plus.AppendSpaceLine(2, "public override Field[] GetFields()");
            plus.AppendSpaceLine(2, "{");
            plus.AppendSpaceLine(3, "return new Field[] {");
            StringPlus plus3 = new StringPlus();
            foreach (ColumnInfo col in _columns)
            {
                plus3.AppendSpaceLine(4, "_." + col.ColumnName + ",");
            }
            plus.Append(plus3.ToString().TrimEnd().Substring(0, plus3.ToString().TrimEnd().Length - 1));
            plus.AppendLine("};");
            plus.AppendSpaceLine(2, "}");


            plus.AppendSpaceLine(2, "/// <summary>");
            plus.AppendSpaceLine(2, "/// 获取值信息");
            plus.AppendSpaceLine(2, "/// </summary>");
            plus.AppendSpaceLine(2, "public override object[] GetValues()");
            plus.AppendSpaceLine(2, "{");
            plus.AppendSpaceLine(3, "return new object[] {");
            StringPlus plus4 = new StringPlus();
            foreach (ColumnInfo col in _columns)
            {
                plus4.AppendSpaceLine(4, "this._" + col.ColumnName + ",");
            }
            plus.Append(plus4.ToString().TrimEnd().Substring(0, plus4.ToString().TrimEnd().Length - 1));
            plus.AppendLine("};");
            plus.AppendSpaceLine(2, "}");

            plus.AppendLine();          

            return plus.ToString();


}
 public string  BuilderField()
        {
            StringPlus plus = new StringPlus();
            
            plus.AppendSpaceLine(2, "/// <summary>");
            plus.AppendSpaceLine(2, "/// 字段信息");
            plus.AppendSpaceLine(2, "/// </summary>");
            plus.AppendSpaceLine(2, "public class _");
            plus.AppendSpaceLine(2, "{");
            plus.AppendSpaceLine(3, "/// <summary>");
            plus.AppendSpaceLine(3, "/// * ");
            plus.AppendSpaceLine(3, "/// </summary>");
            plus.AppendSpaceLine(3, "public readonly static Field All = new Field(\"*\",\"" +  _tableName + "\");");
            foreach (ColumnInfo col in _columns)
            {
                plus.AppendSpaceLine(3, "/// <summary>");
                plus.AppendSpaceLine(3, "/// " + col.DeText);
                plus.AppendSpaceLine(3, "/// </summary>");
                plus.AppendSpaceLine(3, "public readonly static Field " + col.ColumnName + " = new Field(\"" + col.ColumnNameRealName + "\",\"" +  _tableName + "\",\"" + (string.IsNullOrEmpty(col.DeText) ? col.ColumnNameRealName : col.DeText) + "\");");
            }
            plus.AppendSpaceLine(2, "}");
            
            plus.AppendLine();
            return plus.ToString();
        }

    




        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "14.0.0.0")]
    public class MakeModelBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
