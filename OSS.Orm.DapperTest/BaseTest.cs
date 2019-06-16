using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using OSS.Orm.DapperTests;

namespace OSS.Orm.DapperTest
{
  
    public class BaseTest
    {
        static BaseTest()
        {
            SetConfig();
        }


        private static void SetConfig()
        {
            var basePat = Directory.GetCurrentDirectory();
            var configPath = basePat.Substring(0, basePat.IndexOf("bin"));
            var config = new ConfigurationBuilder()
                .SetBasePath(configPath)
                .Add(new JsonConfigurationSource
                {
                    Path = "appsettings.json",
                    ReloadOnChange = true
                }).Build();

            ConfigUtil.Configuration = config;
        }
    }
}