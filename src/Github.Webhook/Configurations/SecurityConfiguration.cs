using Github.Webhook.Security;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics.CodeAnalysis;

namespace Github.Webhook.Configurations
{
    /// <summary>
    /// Configure authentication and authorization
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class SecurityConfiguration
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="services"></param>
        public static void AddSecurityConfiguration(this IServiceCollection services)
        {
            services.AddSingleton<IAuthorizationHandler, WebHookSignatureHandler>();
            services.AddAuthentication(options =>
            {
                options.AddScheme<CustomAuthenticationHandler>("Webhook", "Webhook");
            });
            services.AddAuthorization(options =>
            {
                options.AddPolicy("Signature", policy =>
                    policy.Requirements.Add(new WebHookSignatureRequirement()));
            });
        }
    }
}
