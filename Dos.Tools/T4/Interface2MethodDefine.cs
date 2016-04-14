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
                _getIDalMethod.Add(new Interface2MethodMap {InterfaceName = IName, DataOperType = DataOperType.Select, MethodName = "GetEntityListFromCuston" });
                _getIDalMethod.Add(new Interface2MethodMap { InterfaceName = IName, DataOperType = DataOperType.Insert, MethodName = "InsertEntity" });
                _getIDalMethod.Add(new Interface2MethodMap { InterfaceName = IName, DataOperType = DataOperType.Delete, MethodName = "DeleteEntity" });
                _getIDalMethod.Add(new Interface2MethodMap { InterfaceName = IName, DataOperType = DataOperType.Update, MethodName = "UpdateEntity" });
                return _getIDalMethod;
            }
        }
    }
}
