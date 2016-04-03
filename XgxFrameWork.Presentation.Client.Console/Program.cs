using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using XgxFrameWork.CacheLayer.RedisCacheManager;
namespace XgxFrameWork.Presentation.Client.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press a key followed by ENTER: ");
            var key = (char)Console.Read(); // get a char
            Console.Write("Press a value followed by ENTER: ");
            var value = (char)Console.Read(); // get a char
            RedisHelper.AddToRedis(key.ToString(), value.ToString());
        }
    }
}
