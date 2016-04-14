using System.Collections.Generic;

namespace Dos.T4
{
    public class IDal2MethodsDefine
    {
        
       static List<Interface2MethodMap> _getIDalMethod = new List<Interface2MethodMap>();

        public static List<Interface2MethodMap> GetIDalMethod
        {
            get
            {
                var IName = "IDal";
                _getIDalMethod.Add(new Interface2MethodMap {InterfaceName = IName,DataOperType = DataOperType.Select,MethodName = "GetEntityFromID" });
                return _getIDalMethod;
            }
        }
    }
}
