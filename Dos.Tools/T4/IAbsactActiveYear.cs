using Dos.Model;

namespace Dos.Tools.T4
{
    public interface IAbsactActiveYear:IDAL<Activeyear>
    {
        Activeyear NewActiveYear { get;  }
    }
}