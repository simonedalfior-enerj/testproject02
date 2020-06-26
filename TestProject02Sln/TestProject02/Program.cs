using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace TestProject02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Start");
            CreateWebHostBuilder(args).Build().Run();
            Console.WriteLine("Stop");
            Console.WriteLine("Bye Bye");
        }

        public static void Test() { var a = 5; }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
