using System.IO;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using WebApi.Helpers;
namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            PublicConstants.blackListedUserTokens.Add("");
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://localhost:4000")
                .Build();
    }
}