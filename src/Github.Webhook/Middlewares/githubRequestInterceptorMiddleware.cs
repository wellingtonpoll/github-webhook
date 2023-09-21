namespace Github.Webhook.Middlewares
{
    public class githubRequestInterceptorMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            if (context.Request.Path == "/webhook")
            {
                context.Items["GithubEvent"] = context.Request.Headers["X-GitHub-Event"];
                context.Items["GithubSignature"] = context.Request.Headers["X-Hub-Signature"];
                context.Items["GithubDelivery"] = context.Request.Headers["X-GitHub-Delivery"];
                context.Items["GithubSignature256"] = context.Request.Headers["X-Hub-Signature-256"];
                context.Items["Body"] = await new StreamReader(context.Request.Body).ReadToEndAsync();
            }

            await next(context);
        }
    }
}
