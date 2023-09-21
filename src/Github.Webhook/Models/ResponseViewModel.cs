using FluentValidation.Results;

namespace Github.Webhook.Models
{
    /// <summary>
    /// Response view model
    /// </summary>
    public class ResponseViewModel
    {
        /// <summary>
        /// Initialize new instance
        /// </summary>
        /// <param name="data"></param>
        /// <param name="validationResult"></param>
        public ResponseViewModel(object data, ValidationResult validationResult)
        {
            Data = data;
            ValidationResult = validationResult;
        }

        /// <summary>
        /// Dynamic response data
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Validation result
        /// </summary>
        public ValidationResult ValidationResult { get; set; }
    }
}
