using System;
using Dos.Model;
namespace Dos.T4
{
    public partial class ConcreateDalFactory : IEntityDalFactory
    {
        public IAbsactActiveYear CreatActiveYearDal()
        {
            return new ConcreateActiveYear();
        }
    }   
}