using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Github.Webhook.Controllers
{
    /// <summary>
    /// Base api controller
    /// </summary>
    [ApiController]
    [ExcludeFromCodeCoverage]
    [Produces("application/json")]
    public abstract class ApiController : ControllerBase
    {
        private readonly ICollection<string> _errors = new List<string>();

        /// <summary>
        /// Create custom response with dynamic status code and object result
        /// </summary>
        /// <param name="statusCode"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        protected ActionResult CustomResponse(int statusCode, object? value = null) => new ObjectResult(value)
        {
            StatusCode = statusCode
        };
    }
}