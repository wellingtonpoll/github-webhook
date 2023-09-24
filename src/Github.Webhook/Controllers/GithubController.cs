using Github.Webhook.Models;
using Github.Webhook.Validators;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Github.Webhook.Controllers
{
    /// <summary>
    /// Github event controller
    /// </summary>
    [Route("webhook/[controller]")]
    public class GithubController : ApiController
    {
        private readonly ILogger<GithubController> _logger;
        private readonly WebhookEventValidator _webhookEventValidator;

        /// <summary>
        /// Initialize new instance
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="webhookEventValidator"></param>
        public GithubController(
            ILogger<GithubController> logger,
            WebhookEventValidator webhookEventValidator)
        {
            _logger = logger;
            _webhookEventValidator = webhookEventValidator;
        }

        /// <summary>
        /// Github event webhook receiver
        /// </summary>
        /// <param name="githubEvent"></param>
        /// <param name="githubSignature"></param>
        /// <param name="githubDelivery"></param>
        /// <param name="githubSignature256"></param>
        /// <param name="webhookEventViewModel">Github event model</param>
        /// <returns></returns>
        /// <response code="202">Github event accepted</response>
        /// <response code="400">Bad request</response>
        /// <response code="403">Forbidden</response>
        /// <response code="500">Internal server error</response> 
        /// <response code="503">Service unavailable</response> 
        [HttpPost("event")]
        [Authorize(AuthenticationSchemes = "Webhook", Policy = "Signature")]
        [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status202Accepted)]
        [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status403Forbidden)]
        [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(typeof(ResponseViewModel), StatusCodes.Status503ServiceUnavailable)]
        public async Task<IActionResult> PostAsync(
            [FromHeader(Name = "X-GitHub-Event")] string githubEvent,
            [FromHeader(Name = "X-Hub-Signature")] string githubSignature,
            [FromHeader(Name = "X-GitHub-Delivery")] string githubDelivery,
            [FromHeader(Name = "X-Hub-Signature-256")] string githubSignature256,
            [FromBody] RequestWebhookEventViewModel webhookEventViewModel)
        {
            _logger.LogInformation("Received github event request webhook");

            webhookEventViewModel.GithubEvent = githubEvent;
            webhookEventViewModel.GithubSignature = githubSignature;
            webhookEventViewModel.GithubDelivery = githubDelivery;
            webhookEventViewModel.GithubSignature256 = githubSignature256;

            var validationResult = await _webhookEventValidator.ValidateAsync(webhookEventViewModel);
            _logger.LogInformation("Validating model {@Model} - {@ValidationResult}", webhookEventViewModel, validationResult);

            if (!validationResult.IsValid)
                return CustomResponse(StatusCodes.Status400BadRequest, validationResult);

            if (webhookEventViewModel.IsPushEvent())
            {
                // Aqui você pode processar o evento de push para a branch master
                // Certifique-se de implementar a lógica necessária
            }

            _logger.LogInformation("Received github event successfully!");

            return CustomResponse(StatusCodes.Status202Accepted);
        }
    }
}
