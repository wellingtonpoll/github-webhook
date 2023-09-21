using Github.Webhook.Settings;

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
        /// <exception cref="ArgumentNullException"></exception>
        public static void AddDependencyInjectionConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(nameof(services));
            ArgumentNullException.ThrowIfNull(nameof(configuration));

            // Application

            // Domain - Events

            // Domain - Commands

            // Infra - Data
            var githubSecret = configuration[Secrets.GithubSecretKey];
            ArgumentNullException.ThrowIfNull(nameof(githubSecret));
            services.AddSingleton(c => Secrets.GithubSecret = githubSecret ?? string.Empty);
        }
    }
}