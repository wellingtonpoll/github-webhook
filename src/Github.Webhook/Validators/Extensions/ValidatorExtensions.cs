using FluentValidation;

namespace Github.Webhook.Validators.Extensions
{
    /// <summary>
    /// Validator extensions
    /// </summary>
    public static class ValidatorExtensions
    {
        /// <summary>
        /// Fluent validator cellphone
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ruleBuilder"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public static IRuleBuilderOptions<T, string> GithubSignature<T>(this IRuleBuilder<T, string> ruleBuilder,  string? message = null)
        {
            var validator = new GithubSignatureValidator<T>();
            return !string.IsNullOrEmpty(message)
                ? ruleBuilder.SetValidator(validator).WithMessage(message)
                : ruleBuilder.SetValidator(validator);
        }
    }
}
