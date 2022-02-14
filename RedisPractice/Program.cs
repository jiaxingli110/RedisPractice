using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RedisPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Start Redis Study !");
            //ConnectionMultiplexer _conn = RedisConnectionHelp.Instance;//初始化
            //var database = _conn.GetDatabase(0);//指定连接的库 0
            //database.StringSet("namx555", "ccccc");

            List<string> lst = new List<string>();
            var x = lst.Where(x=>x =="").FirstOrDefault();
            if (x!=null)
            {

            }

        }
    }
}
