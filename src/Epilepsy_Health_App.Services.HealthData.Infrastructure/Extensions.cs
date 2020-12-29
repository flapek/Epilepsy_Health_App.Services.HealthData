using Epilepsy_Health_App.Services.HealthData.Infrastructure.Exceptions;
using Epilepsy_Health_App.Services.HealthData.Infrastructure.Mongo;
using Joint;
using Joint.Builders;
using Joint.CQRS.Queries;
using Joint.DB.Mongo;
using Joint.DBRedis;
using Joint.Discovery.Consul;
using Joint.Exception;
using Microsoft.AspNetCore.Builder;

namespace Epilepsy_Health_App.Services.HealthData.Infrastructure
{
    public static class Extensions
    {
        public static IJointBuilder AddInfrastructure(this IJointBuilder builder)
        {

            return builder
                .AddMongo()
                //.AddMongoRepository<UserDocument, Guid>("users")
                //.AddMongoRepository<RefreshTokenDocument, Guid>("refreshTokens")
                .AddRedis()
                .AddConsul()
                .AddErrorHandler<ExceptionToResponseMapper>()
                .AddQueryHandlers()
                .AddInMemoryQueryDispatcher();
        }

        public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
        {
            app.UseErrorHandler()
                .UseJoint()
                .UseMongo()
                .UseAuthentication()
                .UseAuthorization();

            return app;
        }
    }
}
