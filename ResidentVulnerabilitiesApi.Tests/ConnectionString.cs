using System;

namespace ResidentVulnerabilitiesApi.Tests
{
    public static class ConnectionString
    {
        public static string TestDatabase()
        {
            return $"Host={Environment.GetEnvironmentVariable("DB_HOST") ?? "127.0.0.1"};" +
                   $"Port={Environment.GetEnvironmentVariable("DB_PORT") ?? "5432"};" +
                   $"Username={Environment.GetEnvironmentVariable("DB_USERNAME") ?? "postgres"};" +
                   $"Password={Environment.GetEnvironmentVariable("DB_PASSWORD") ?? "password"};" +
                   $"Database={Environment.GetEnvironmentVariable("DB_DATABASE") ?? "entitycorex"}";
        }
    }
}
