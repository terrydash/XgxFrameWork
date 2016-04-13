


using System;
using System.Data;
using System.Collections.Generic;
using System.Data.Common;
using Dos.ORM;
using Dos.ORM.Common;

namespace Dos.T4
{
	public partial interface IDal<T>
    {
        //Entity GetEntityFromGuid(Guid guid);
        //根据主键获取实体ID
        T GetEntityFromID(int id);
        List<T> GetEntityListFromCuston(int id);
        List<T> GetEntityListFromCuston(int id,int pageSize,int pageIndex);
        bool InsertEntity(T t);
        bool InsertEntity(List<T> list);
        bool DeleteEntity(int id);
        bool DeleteEntity(T t);
        bool DeleteEntity(List<int> ids);
        bool UpdateEntity(T t);
        bool UpateEntity(List<T> list);
	}
}