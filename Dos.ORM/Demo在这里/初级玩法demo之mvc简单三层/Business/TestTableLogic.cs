﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.Common;
using Dos.ORM;
using Model;
using Model.Base;
using System.Data.Common;

namespace Business
{
    public class TestTableLogic
    {
        /// <summary>
        /// 获取数据。
        /// </summary>
        public BaseResult GetUser(TestTableParam param)
        {
            var where = new Where<TestTable>();
            #region 模糊搜索条件
            if (!string.IsNullOrWhiteSpace(param.SearchName))
            {
                where.And(d => d.Name.Like(param.SearchName));
            }
            if (!string.IsNullOrWhiteSpace(param.SearchIDNumber))
            {
                where.And(d => d.IDNumber.Like(param.SearchIDNumber));
            }
            if (!string.IsNullOrWhiteSpace(param.SearchMobilePhone))
            {
                where.And(d => d.MobilePhone.Like(param.SearchMobilePhone));
            }
            #endregion
            var fs = Db.MySql.From<TestTable>()
                .Where(where)
                .OrderByDescending(d => new { d.CreateTime, d.Id });
            #region 是否分页
            var dateCount = 0;
            if (param._PageIndex != null && param._PageSize != null)
            {
                //取总数，以计算共多少页。
                dateCount = fs.Count();
                fs.Page(param._PageSize.Value, param._PageIndex.Value);
            }
            #endregion
            var list = fs.ToList();

            #region 测试自连接

           var ll =  Db.MySql.From<TestTable>()
               .LeftJoin<TestTable>((a, b) => a.Id == b.Id)
               .ToList();
            #endregion
            return new BaseResult(true, list, "", dateCount);
        }
        /// <summary>
        /// 新增数据。必须传入姓名Name，手机号MobilePhone，身份证号IDNumber
        /// </summary>
        public BaseResult AddUser(TestTableParam param)
        {
            if (string.IsNullOrWhiteSpace(param.Name) || string.IsNullOrWhiteSpace(param.MobilePhone)
                    || string.IsNullOrWhiteSpace(param.IDNumber))
            {
                return new BaseResult(false, null, "参数错误！");
            }
            var model = new TestTable
            {
                Id = Guid.NewGuid(),
                Name = param.Name,
                IDNumber = param.IDNumber,
                MobilePhone = param.MobilePhone,
                CreateTime = DateTime.Now,
                T2 = 0,
                T3 = 0,
                T4 = true,
                T7 = 0,
                T9 = 0
            };
            var count = Db.MySql.Insert<TestTable>(model);
            return new BaseResult(count > 0, count, count > 0 ? "" : "数据库受影响行数为0！");
        }
        /// <summary>
        /// 删除数据。必须传入Id
        /// </summary>
        public BaseResult DelUser(TestTableParam param)
        {
            if (param.Id == null)
            {
                return new BaseResult(false, null, "参数错误！");
            }
            var count = Db.MySql.Delete<TestTable>(d => d.Id == param.Id);
            return new BaseResult(count > 0, count, count > 0 ? "" : "数据库受影响行数为0！");
        }
        /// <summary>
        /// 修改数据。必须传入Id
        /// </summary>
        public BaseResult UptUser(TestTableParam param)
        {
            if (param.Id == null)
            {
                return new BaseResult(false, null, "参数错误！");
            }
            var model = Db.MySql.From<TestTable>().Where(d => d.Id == param.Id).First();
            if (model == null)
            {
                return new BaseResult(false, null, "不存在要修改的数据！");
            }
            model.Name = param.Name ?? model.Name;
            model.IDNumber = param.IDNumber ?? model.IDNumber;
            model.MobilePhone = param.MobilePhone ?? model.MobilePhone;
            var count = Db.MySql.Update<TestTable>(model);
            return new BaseResult(true);
        }
    }
}
