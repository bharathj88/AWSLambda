using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using System.Text.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into .NET classes.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace MyLambdaFunction
{
    public class MyLambdaFunction
    {
        public APIGatewayProxyResponse FunctionHandler(APIGatewayProxyRequest request, ILambdaContext context)
        {
            var body = new { message = "Hello from .NET Lambda", path = request.Path, method = request.HttpMethod };
            return new APIGatewayProxyResponse
            {
                StatusCode = 200,
                Body = JsonSerializer.Serialize(body),
                Headers = new System.Collections.Generic.Dictionary<string, string> { { "Content-Type", "application/json" } }
            };
        }
    }
}