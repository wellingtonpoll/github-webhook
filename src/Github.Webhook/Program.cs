using Serilog;
using System.Diagnostics.CodeAnalysis;

namespace Github.Webhook.API
{
    /// <summary>
    /// Program
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var outputTemplate = "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:raw}] {SourceContext} - {Message:lj}{NewLine}{Exception}";
            Log.Logger = new LoggerConfiguration()
                        .Enrich.FromLogContext()
                        .Enrich.WithCorrelationId()
                        .WriteTo.Console(outputTemplate: outputTemplate)
                        .WriteTo.File(
                            "/logs/log.txt",
                            rollingInterval: RollingInterval.Day,
                            outputTemplate: outputTemplate)
                        .CreateLogger();
            try
            {
                var hostBuilder = CreateHostBuilder(args).Build();
                Log.Information("github-webhook-api startup successfuly!");
                hostBuilder.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Host shut down unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        /// <summary>
        /// CreateHostBuilder
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                    .UseSerilog(dispose: true)
                    .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }
}