using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.Serialization;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Github.Webhook.Configurations
{
    /// <summary>
    /// Swagger configurations
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class SwaggerConfig
    {
        /// <summary>
        /// Add swagger service
        /// </summary>
        /// <param name="services"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void AddSwaggerConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Github Webhook Project",
                    Description = "Github Webhook Swagger Surface",
                    Contact = new OpenApiContact { Name = "Wellington Nascimento", Email = "wellingtonpoleti@gmail.com", Url = new Uri("https://github.com/wellingtonpoll") },
                    License = new OpenApiLicense { Name = "MIT", Url = new Uri("https://github.com/wellingtonpoll/github-webhook/blob/main/LICENSE") },
                });

                var xmlPath = Path.Combine(AppContext.BaseDirectory, "Github.Webhook.xml");
                c.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);

                c.DocumentFilter<PathLowercaseDocumentFilter>();
                c.SchemaFilter<EnumSchemaFilter>();
            });
        }

        /// <summary>
        /// Use swagger configuration
        /// </summary>
        /// <param name="app"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public static void UseSwaggerSetup(this IApplicationBuilder app)
        {
            if (app == null) throw new ArgumentNullException(nameof(app));

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
                c.RoutePrefix = string.Empty;
            });
        }
    }

    /// <summary>
    /// Make swagger route url lowercase
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class PathLowercaseDocumentFilter : IDocumentFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="swaggerDoc"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var dictionaryPath = swaggerDoc.Paths.ToDictionary(x => ToLowercase(x.Key), x => x.Value);
            var newPaths = new OpenApiPaths();
            foreach (var path in dictionaryPath)
                newPaths.Add(path.Key, path.Value);
            swaggerDoc.Paths = newPaths;
        }

        private static string ToLowercase(string key)
        {
            var parts = key.Split('/').Select(part => part.Contains("}") ? part : part.ToLowerInvariant());
            return string.Join('/', parts);
        }
    }

    /// <summary>
    /// Enum schema description filter
    /// </summary>
    [ExcludeFromCodeCoverage]
    public class EnumSchemaFilter : ISchemaFilter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="model"></param>
        /// <param name="context"></param>
        public void Apply(OpenApiSchema model, SchemaFilterContext context)
        {
            if (context.Type.IsEnum)
            {
                model.Enum.Clear();
                foreach (string enumName in Enum.GetNames(context.Type))
                {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
                    MemberInfo memberInfo = context.Type.GetMember(enumName).FirstOrDefault(m => m.DeclaringType == context.Type);
                    EnumMemberAttribute enumMemberAttribute = memberInfo == null
                     ? null
                     : memberInfo.GetCustomAttributes(typeof(EnumMemberAttribute), false).OfType<EnumMemberAttribute>().FirstOrDefault();
                    string label = enumMemberAttribute == null || string.IsNullOrWhiteSpace(enumMemberAttribute.Value)
                     ? enumName
                     : enumMemberAttribute.Value;
                    model.Enum.Add(new OpenApiString(label));
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
                }
            }
        }
    }
}