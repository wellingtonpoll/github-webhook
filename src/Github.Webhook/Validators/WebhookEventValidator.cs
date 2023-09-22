using FluentValidation;
using Github.Webhook.Models;
using Github.Webhook.Settings;
using Github.Webhook.Validators.Extensions;
using System.Security.Cryptography;
using System.Text;

namespace Github.Webhook.Validators
{
    /// <summary>
    /// 
    /// </summary>
    public class WebhookEventValidator : AbstractValidator<RequestWebhookEventViewModel>
    {
        /// <summary>
        /// 
        /// </summary>
        public WebhookEventValidator()
        {
            ValidateEvent();
            ValidateSignature();
        }

        private void ValidateEvent()
        {
            RuleFor(c => c.GithubEvent)
                .NotNull()
                .NotEmpty()
                .WithMessage("Missing X-GitHub-Event header!");
        }

        private void ValidateSignature()
        {
            var message = "X-Hub-Signature is not valid!";
            RuleFor(c => c.GithubSignature ?? string.Empty)
                .NotNull()
                .NotEmpty()
                .WithMessage("Missing X-Hub-Signature!")
                .GithubSignature(message)
                .Equal(model => GetHash(model))
                .WithMessage(message);
        }

        private static string GetHash(RequestWebhookEventViewModel model)
        {
            string hash = string.Empty;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(model);
            using (var hmac = new HMACSHA256(Encoding.ASCII.GetBytes(Secrets.ApiGithubSecret)))
            {
                var hashBytes = hmac.ComputeHash(Encoding.ASCII.GetBytes(json));
                hash = "sha256=" + BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
            return hash;
        }
    }
}
