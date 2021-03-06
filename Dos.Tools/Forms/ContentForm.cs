﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Dos.Tools.Common;
using Dos.Tools.DbDAL;
using Dos.Tools.DbDAL.Sqlite;
using Dos.Tools.Model;
using Dos.T4;
using System.Collections;
using System.Reflection;
using Dos.Tools.T4;

namespace Hxj.Tools.EntityDesign
{
    public partial class ContentForm : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public ContentForm()
        {
            InitializeComponent();
        }
        private string fileName { get; set; }
        private string Filtername { get; set; }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        private string content;


        private Connection connectionModel;

        public Connection ConnectionModel
        {
            set { connectionModel = value; }
            get { return connectionModel; }
        }

        private string tableName;
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        private bool isView = false;
        public bool IsView
        {
            get { return isView; }
            set { isView = value; }
        }

        private string databaseName;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        /// <summary>
        /// 加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContentForm_Load(object sender, EventArgs e)
        {
            IDbObject dbObject = null;
          
            
            if (ConnectionModel.DbType.Equals(Dos.ORM.DatabaseType.SqlServer.ToString()))
            {
                dbObject = new Dos.Tools.DbDAL.SQL2000.DbObject(ConnectionModel.ConnectionString);
            }
            else if (ConnectionModel.DbType.Equals(Dos.ORM.DatabaseType.SqlServer9.ToString()))
            {;
                dbObject = new Dos.Tools.DbDAL.SQL2005.DbObject(ConnectionModel.ConnectionString);
            }
            else if (ConnectionModel.DbType.Equals(Dos.ORM.DatabaseType.MsAccess.ToString()))
            {
                dbObject = new Dos.Tools.DbDAL.OleDb.DbObject(ConnectionModel.ConnectionString);
            }
            else if (ConnectionModel.DbType.Equals(Dos.ORM.DatabaseType.Oracle.ToString()))
            {
                dbObject = new Dos.Tools.DbDAL.Oracle.DbObject(ConnectionModel.ConnectionString);
            }
            else if (ConnectionModel.DbType.Equals(Dos.ORM.DatabaseType.Sqlite3.ToString()))
            {
                dbObject = new DbObject(ConnectionModel.ConnectionString);
            }
            else if (ConnectionModel.DbType.Equals(Dos.ORM.DatabaseType.MySql.ToString()))
            {
                dbObject = new Dos.Tools.DbDAL.MySql.DbObject(ConnectionModel.ConnectionString);
            }
            else
            {
                MessageBox.Show("未知数据库类型!");
                return;
            }
            
            columnsdt = dbObject.GetColumnInfoList(DatabaseName, TableName);

            gridColumns.DataSource = columnsdt;

            DataTable primarykeydt = dbObject.GetKeyName(DatabaseName, TableName);

            cbPrimarykey.Items.Clear();

            if (null != primarykeydt && primarykeydt.Rows.Count > 0)
            {
                foreach (DataRow dr in primarykeydt.Rows)
                {
                    cbPrimarykey.Items.Add(dr["ColumnName"].ToString());
                }

                cbPrimarykey.SelectedIndex = 0;
            }

            txtClassName.Text = TableName.Trim().Replace(' ', '_');
            txtnamespace.Text = Utils.ReadNamespace();

        }

        DataTable columnsdt = null;

        /// <summary>
        /// 添加主键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddPrimarykey_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = gridColumns.SelectedRows;
            if (null != rows && rows.Count > 0)
            {
                foreach (DataGridViewRow row in rows)
                {
                    object temp = row.Cells[1].Value;

                    if (!cbPrimarykey.Items.Contains(temp))
                    {
                        cbPrimarykey.Items.Add(temp);
                    }
                }

                cbPrimarykey.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 删除主键
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemovePrimarykey_Click(object sender, EventArgs e)
        {
            if (cbPrimarykey.SelectedIndex >= 0)
            {
                cbPrimarykey.Items.RemoveAt(cbPrimarykey.SelectedIndex);
            }

            if (cbPrimarykey.Items.Count > 0)
                cbPrimarykey.SelectedIndex = 0;
        }

        private void VariableAssignment()
        {
            if (!CheckContent())
            {
                return;
            }
            Utils.WriteNamespace(txtnamespace.Text);

            List<ColumnInfo> columns = Utils.GetColumnInfos(columnsdt);

            VarDefine.TableName = Utils.ReplaceSpace(TableName);
            VarDefine.NameSpace = Utils.ReplaceSpace(txtnamespace.Text);
            VarDefine.IsView = IsView;
            VarDefine.ClassName = Utils.ReplaceSpace(txtClassName.Text);
            VarDefine.Columns = columns;
            VarDefine.IsSZMDX = cbToupperFrstword.Checked;
            VarDefine.Apppath = Application.StartupPath;
            VarDefine.DbType = ConnectionModel.DbType;
            VarDefine.connString = connectionModel.ConnectionString;
            VarDefine.DataBaseType = connectionModel.Database;
        }


        /// <summary>
        /// 代码生成
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            VariableAssignment();
            fileName = txtClassName.Text;
            var mk = new MakeModel();
            Filtername = "CS 文件|*.cs";
            txtContent.Text = mk.TransformText();

            tabControl1.SelectedIndex = 1;
        }


        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveEntity.FileName = fileName;
            saveEntity.Filter = Filtername;

            if (saveEntity.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveEntity.FileName, false, Encoding.UTF8))
                {
                    sw.Write(txtContent.Text);
                    sw.Close();
                }
            }
        }

        private void Btn_MakeDal_Click(object sender, EventArgs e)
        {
            VariableAssignment();
            MakeIDal mkIDal = new MakeIDal();
            fileName = "IDal";
            Filtername= "CS 文件|*.cs";
            txtContent.Text = mkIDal.TransformText();
            tabControl1.SelectedIndex = 1;


        }

        private bool CheckContent()
        {
            if (string.IsNullOrEmpty(txtnamespace.Text))
            {
                MessageBox.Show("命名空间不能为空!");
                return false;
            }
            if (string.IsNullOrEmpty(txtClassName.Text))
            {
                MessageBox.Show("类名不能为空!");
                return false;
            }
            return true;
        }

        private void tp1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VariableAssignment();
            fileName = txtClassName.Text;
            IEntity ie = new IEntity();
            fileName = "I"+ txtClassName.Text;
            Filtername = "CS 文件|*.cs";
            txtContent.Text = ie.TransformText();
            tabControl1.SelectedIndex = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VariableAssignment();
            fileName = "ModelFactory";
            Filtername = "TT 文件|*.tt";
            var makeT4Factory = new MakeT4MainFactory();
            txtContent.Text = makeT4Factory.TransformText();
            tabControl1.SelectedIndex = 1;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            VariableAssignment();
            fileName = txtClassName.Text + "Factory";
            Filtername = "CS 文件|*.cs";
            var makeEntityFactoryMethods = new MakeEntityFactoryMethods();
            txtContent.Text = makeEntityFactoryMethods.TransformText();
            tabControl1.SelectedIndex = 1;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            VariableAssignment();
            fileName = "DBsession";
            Filtername = "CS 文件|*.cs";
            var makeDBsession = new MakeDBsession();
            txtContent.Text = makeDBsession.TransformText();
            tabControl1.SelectedIndex = 1;

        }
    }
}
