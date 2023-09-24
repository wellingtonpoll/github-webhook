using AutoFixture;
using FluentAssertions;
using Github.Webhook.Controllers;
using Github.Webhook.Models;
using Github.Webhook.Validators;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

public class GithubControllerTests
{
    private readonly Fixture _fixture;
    public GithubControllerTests()
    {
        _fixture = new Fixture();
    }

    [Fact]
    [Trait("Controllers", "GithubController")]
    public async Task PostAsync_ValidRequest_ReturnsAccepted()
    {
        // Arrange
        var loggerMock = new Mock<ILogger<GithubController>>();
        var webhookEventValidator = new WebhookEventValidator();

        var controller = new GithubController(loggerMock.Object, webhookEventValidator);

        var githubEvent = "push";
        var githubSignature = "valid-signature";
        var githubDelivery = "delivery-id";
        var githubSignature256 = "valid-signature-256";

        var webhookEventViewModel = _fixture.Create<RequestWebhookEventViewModel>();

        // Act
        var result = await controller.PostAsync(githubEvent, githubSignature, githubDelivery, githubSignature256, webhookEventViewModel);

        // Assert
        result.Should().NotBeNull();
        result.Should().BeAssignableTo<ObjectResult>();
        Assert.Equal(StatusCodes.Status202Accepted, ((ObjectResult)result).StatusCode);
    }
}
