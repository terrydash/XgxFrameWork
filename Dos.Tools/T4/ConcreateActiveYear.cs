using System;
using System.Collections.Generic;
using Dos.Model;
using Dos.ORM;

namespace Dos.T4
{
    public partial  class ConcreateActiveYear : IAbsactActiveYear
    {
        public Activeyear GetNewActiveYear()
        {
            return new Activeyear();
          
        }

        public bool DeleteEntity(List<int> ids)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(Activeyear t)
        {
            throw new NotImplementedException();
        }

        public bool DeleteEntity(int id)
        {
            throw new NotImplementedException();
        }

        public Activeyear GetEntityFromID(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Activeyear> GetEntityListFromCuston(int ID)
        {
            throw new NotImplementedException();
        }

        public List<Activeyear> GetEntityListFromCuston(int ID, int PageSize, int PageIndex)
        {
            throw new NotImplementedException();
        }

        public bool InsertEntity(List<Activeyear> list)
        {
            throw new NotImplementedException();
        }

        public bool InsertEntity(Activeyear t)
        {
            throw new NotImplementedException();
        }

        public bool UpateEntity(List<Activeyear> list)
        {
            throw new NotImplementedException();
        }

        public bool UpdateEntity(Activeyear t)
        {
            throw new NotImplementedException();
        }
    }
}