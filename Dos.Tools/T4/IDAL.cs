using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dos.Tools.T4
{
    public interface IDAL<T>
    {        
        //Entity GetEntityFromGuid(Guid guid);
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
