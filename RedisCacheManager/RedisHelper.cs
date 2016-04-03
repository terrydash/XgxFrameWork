using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceStack.Redis;

namespace XgxFrameWork.CacheLayer.RedisCacheManager
{
    public static class RedisHelper
    {
        

        public static string stringThings = string.Empty;
        private static RedisClient Redis = new RedisClient("localhost",6379,"xgxxgx");//redis服务IP和端口
        public static bool AddToRedis(string Key,string Value)
        {

            return Redis.Add(Key, Value);
        }
        public static bool GetStringFromRedis(string Key)
        {
            stringThings= Redis.Get(Key).ToString();
            return  true;
        }


    }
}
