using FluentValidation;
using Github.Webhook.Models;
using Github.Webhook.Settings;
using Github.Webhook.Validators.Extensions;
using System.Security.Cryptography;
using System.Text;

namespace Github.Webhook.Validators
{
    public class WebhookEventValidator : AbstractValidator<RequestWebhookEventViewModel>
    {
        public WebhookEventValidator()
        {
            ValidateBody();
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
            RuleFor(c => c.GithubSignature)
                .NotNull()
                .NotEmpty()
                .WithMessage("Missing X-Hub-Signature!")
                .GithubSignature()
                .Equal(model => GetHash(model))
                .WithMessage("X-Hub-Signature is not valid!");
        }

        private void ValidateBody()
        {
            RuleFor(c => c.Body)
                .NotNull()
                .NotEmpty()
                .WithMessage("Body is required!");
        }

        private static string GetHash(RequestWebhookEventViewModel model)
        {
            string hash = string.Empty;
            using (var hmac = new HMACSHA256(Encoding.ASCII.GetBytes(Secrets.ApiGithubSecret)))
            {
                var hashBytes = hmac.ComputeHash(Encoding.ASCII.GetBytes(model.Body));
                hash = "sha256=" + BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
            return hash;
        }
    }
}
