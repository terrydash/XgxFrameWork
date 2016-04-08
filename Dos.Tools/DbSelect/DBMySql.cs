using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dos.Tools.Common;
using Dos.Tools.DbDAL;
using Dos.Tools.DbDAL.MySql;
using Dos.Tools.Model;

namespace Hxj.Tools.EntityDesign.DbSelect
{
    public partial class DBMySql : Form
    {
        public DBMySql()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cbbServer.Text))
            {
                MessageBox.Show("服务器不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("登陆名不能为空!");
                return;
            }

            try
            {
                IDbObject dbObejct = new DbObject(false, cbbServer.Text, txtUserName.Text, txtPassword.Text, txtport.Text);
                DataTable DBNameTable = dbObejct.GetDBList();
                cbbDatabase.Items.Clear();
                cbbDatabase.Items.Add("全部");
                foreach (DataRow dr in DBNameTable.Rows)
                {
                    cbbDatabase.Items.Add(dr[0].ToString());
                }

                cbbDatabase.Enabled = true;
                cbbDatabase.SelectedIndex = 0;
                MessageBox.Show("连接成功!");

            }
            catch (Exception ex)
            {

                MessageBox.Show("连接失败!\n\r" + ex.Message);
                cbbDatabase.Enabled = false;

            }
        }


        /// <summary>
        /// 确定
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbServer.Text))
            {
                MessageBox.Show("服务器不能为空!");
                return;
            }

            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("登陆名不能为空!");
                return;
            }
            IDbObject dbObejct = new DbObject(false, cbbServer.Text, txtUserName.Text, txtPassword.Text, txtport.Text);
            string tempconnectionstring = dbObejct.DbConnectStr;

            try
            {
                using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(tempconnectionstring))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("连接失败!\n\r" + ex.Message);
                return;

            }



            Connection connectionModel = new Connection();
            connectionModel.Database = cbbDatabase.SelectedIndex == 0 ? "all" : cbbDatabase.Text;
            connectionModel.ID = Guid.NewGuid();
            connectionModel.Name = cbbServer.Text + "(MySql)[" + connectionModel.Database + "]";
            connectionModel.ConnectionString = tempconnectionstring;
            connectionModel.DbType = Dos.ORM.DatabaseType.MySql.ToString();



            Utils.AddConnection(connectionModel);

            this.DialogResult = DialogResult.OK;

            this.Close();
        }


        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
