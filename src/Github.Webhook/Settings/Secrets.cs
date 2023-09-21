namespace Github.Webhook.Settings
{
    /// <summary>
    /// Settings
    /// </summary>
    public static class Secrets
    {
        public static string ApiGithubSecretKey = "API_GITHUB_SECRET";

        /// <summary>
        /// Github webhook secret
        /// </summary>
        public static string ApiGithubSecret { get; set; } = string.Empty;
    }
}
