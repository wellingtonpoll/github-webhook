using FluentValidation;
using Github.Webhook.Models;

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
            ValidateSender();
            ValidateSignature();
            ValidateRepository();
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
            RuleFor(c => c.GithubSignature ?? string.Empty)
                .NotNull()
                .NotEmpty()
                .WithMessage("Missing X-Hub-Signature!");
        }

        private void ValidateRepository()
        {
            RuleFor(c => c.Repository)
                .NotNull()
                .NotEmpty()
                .WithMessage("Missing Repository!");
        }

        private void ValidateSender()
        {
            RuleFor(c => c.Sender)
                .NotNull()
                .NotEmpty()
                .WithMessage("Missing Sender!");
        }
    }
}
