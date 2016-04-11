using System.Collections.Generic;
using Dos.Model;
using Dos.ORM;

namespace Dos.Tools.T4
{
    public class ConcreateActiveYear:IAbsactActiveYear
    {
        public Entity GetEntityFromID(int ID)
        {
            throw new System.NotImplementedException();
        }

        public List<Entity> GetEntityListFromCuston(int ID)
        {
            throw new System.NotImplementedException();
        }

        public List<Entity> GetEntityListFromCuston(int ID, int PageSize, int PageIndex)
        {
            throw new System.NotImplementedException();
        }

        public Activeyear NewActiveYear { get; }
    }
}