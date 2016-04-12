using Dos.Model;

namespace Dos.T4
{
    public partial interface IAbsactActiveYear:IDAL<Activeyear>
    {
        Activeyear GetNewActiveYear();
    }
}