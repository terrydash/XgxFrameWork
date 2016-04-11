using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dos.ORM;
namespace Dos.Tools.T4
{
    public interface IDAL
    {        
        //Entity GetEntityFromGuid(Guid guid);
        Entity GetEntityFromID(int ID);
        List<Entity> GetEntityListFromCuston(int ID);
        List<Entity> GetEntityListFromCuston(int ID,int PageSize,int PageIndex);
        
    }
}
