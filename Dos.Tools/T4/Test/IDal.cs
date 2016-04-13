using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;
using Dos.Model;
namespace Dos.Model
{
	public partial interface IDAL<T>
    {
        //Entity GetEntityFromGuid(Guid guid);
        //根据主键获取实体ID
        T GetEntityFromID(int ID);
        List<T> GetEntityListFromCuston(int ID);
        List<T> GetEntityListFromCuston(int ID,int PageSize,int PageIndex);
        bool InsertEntity(T t);
        bool InsertEntity(List<T> list);
        bool DeleteEntity(int id);
        bool DeleteEntity(T t);
        bool DeleteEntity(List<int> ids);
        bool UpdateEntity(T t);
        bool UpateEntity(List<T> list);
	}
}