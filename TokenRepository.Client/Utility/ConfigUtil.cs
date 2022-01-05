using System.Configuration;

namespace TokenRepository.Client.Utility
{
    public class ConfigUtil
    {
        public static string GetApiHost
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("api.host");
            }
        }

    }
}
