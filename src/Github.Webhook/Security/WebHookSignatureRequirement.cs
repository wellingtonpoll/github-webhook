using Microsoft.AspNetCore.Authorization;

namespace Github.Webhook.Security
{
    /// <summary>
    /// Represents an authorization requirement.
    /// </summary>
    public class WebHookSignatureRequirement : IAuthorizationRequirement
    {
    }
}
