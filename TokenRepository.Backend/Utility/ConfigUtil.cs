using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace TokenRepository.Backend.Utility
{
    public static class ConfigUtil
    {
        public static T GetValue<T>(this IConfiguration configuration, string key) where T : class
        {
            return configuration.GetValue<T>(key);
        }
        public static string GetDefaultConnectionString(this IConfiguration configuration)
        {
            var connectionStringBuilder = new MySqlConnectionStringBuilder(configuration.GetConnectionString("Default"));
            connectionStringBuilder.Password = Encoder.ToDeconding(connectionStringBuilder.Password.Replace("<?>", "="));
            return connectionStringBuilder.ToString();
        }
    }
}
