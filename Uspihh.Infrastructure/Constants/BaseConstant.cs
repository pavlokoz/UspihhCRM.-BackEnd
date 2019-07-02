using System.Configuration;

namespace Uspihh.Infrastructure.Constants
{
    public static class BaseConstants
    {
        public static class CORSConstants
        {
            public const string FrontEndUrl = "http://localhost:4200";
        }

        public static class ConnectionStrings
        {
            public static string DatabaseConnectionString = ConfigurationManager
                .ConnectionStrings["UspihhDBConnectionString"].ConnectionString;
        }
    }
}
