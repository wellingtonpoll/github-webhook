using FluentValidation;
using FluentValidation.Validators;

namespace Github.Webhook.Validators
{
    public class GithubSignatureValidator<T> : PropertyValidator<T, string>
    {
        public override string Name => "GithubSignatureValidator";

        public override bool IsValid(ValidationContext<T> context, string value)
        {
            return WebhookSignatureIsValid(value);
        }

        private bool WebhookSignatureIsValid(string signature)
        {
            if (string.IsNullOrWhiteSpace(signature)) return false;
            if (!signature.StartsWith("sha256=")) return false;
            return true;
        }
    }
}
