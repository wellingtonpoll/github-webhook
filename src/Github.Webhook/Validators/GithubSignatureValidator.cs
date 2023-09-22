using FluentValidation;
using FluentValidation.Validators;

namespace Github.Webhook.Validators
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GithubSignatureValidator<T> : PropertyValidator<T, string>
    {
        /// <summary>
        /// 
        /// </summary>
        public override string Name => "GithubSignatureValidator";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="value"></param>
        /// <returns></returns>
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
