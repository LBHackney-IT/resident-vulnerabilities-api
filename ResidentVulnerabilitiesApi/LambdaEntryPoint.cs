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

        // Placeholder for data pipeline lambda function
        public void RunDataPipeline(ILambdaContext context)
        {
            // TO DO: Add logic for data pipeline
        }
    }
}
