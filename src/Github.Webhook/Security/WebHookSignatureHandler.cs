using Github.Webhook.Settings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Primitives;
using System.Security.Cryptography;
using System.Text;

namespace Github.Webhook.Security
{
    /// <summary>
    /// Authorization handler that validate github header signature.
    /// </summary>
    public class WebHookSignatureHandler : AuthorizationHandler<WebHookSignatureRequirement>
    {
        /// <summary>
        /// Handler
        /// </summary>
        /// <param name="context"></param>
        /// <param name="requirement"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            WebHookSignatureRequirement requirement)
        {
            var signatureIsValid = false;
            if (context.Resource is DefaultHttpContext defaultHttpContext)
            {
                defaultHttpContext.HttpContext.Request.EnableBuffering();

                string payload = null;
                using (var reader = new StreamReader(defaultHttpContext.HttpContext.Request.Body, Encoding.ASCII, leaveOpen: true))
                {
                    payload = await reader.ReadToEndAsync();
                    defaultHttpContext.HttpContext.Request.Body.Position = 0;
                }

                defaultHttpContext.HttpContext.Request.Headers.TryGetValue("x-hub-signature-256", out StringValues signatureSHA256);

                byte[] key = Encoding.UTF8.GetBytes(Secrets.ApiGithubSecret);
                using (HMACSHA256 hmac = new HMACSHA256(key))
                {
                    byte[] computedSig = hmac.ComputeHash(Encoding.ASCII.GetBytes(payload));
                    var builder = new StringBuilder(computedSig.Length * 2);
                    foreach (byte b in computedSig)
                        builder.AppendFormat("{0:x2}", b);

                    var computedHash = builder.ToString();

                    signatureIsValid = $"sha256={computedHash}" == signatureSHA256;
                }
            }

            if (signatureIsValid)
                context.Succeed(requirement);
            else
                context.Fail(new AuthorizationFailureReason(this, "Invalid github signature hash!"));
        }
    }
}
