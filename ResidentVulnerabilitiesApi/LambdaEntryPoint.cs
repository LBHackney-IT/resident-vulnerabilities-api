using Amazon.Lambda.AspNetCoreServer;
using Amazon.Lambda.Core;
using Microsoft.AspNetCore.Hosting;

namespace ResidentVulnerabilitiesApi
{
    public class LambdaEntryPoint : APIGatewayProxyFunction
    {
        protected override void Init(IWebHostBuilder builder)
        {
            builder
                .UseStartup<Startup>();
        }
    }

    // To Do: Add logic for running the data pipeline lambda
    public static class LambdaFunction
    {
        public static void RunDataPipeline()
        {

        }
    }
}
