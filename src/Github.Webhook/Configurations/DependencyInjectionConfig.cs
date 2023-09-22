using Github.Webhook.Middlewares;
using Github.Webhook.Settings;
using Github.Webhook.Validators;

namespace Github.Webhook.Configurations
{
    /// <summary>
    /// IoC configuration
    /// </summary>
    public static class DependencyInjectionConfig
    {
        /// <summary>
        /// Add dependency injection
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(nameof(services));
            ArgumentNullException.ThrowIfNull(nameof(configuration));

            // Application
            services.AddScoped(c => new WebhookEventValidator());

            // Domain - Events

            // Domain - Commands

            // Infra - Data
            var githubSecret = configuration[Secrets.ApiGithubSecretKey];
            ArgumentNullException.ThrowIfNull(nameof(githubSecret));
            services.AddSingleton(c => Secrets.ApiGithubSecret = githubSecret ?? string.Empty);
        }
    }
}