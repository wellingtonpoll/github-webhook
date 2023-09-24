namespace Github.Webhook.Settings
{
    /// <summary>
    /// Settings
    /// </summary>
    public static class Secrets
    {
        /// <summary>
        /// Github webhook secret key
        /// </summary>
        public static string ApiGithubSecretKey = "API_GITHUB_SECRET";

        /// <summary>
        /// Github webhook secret value
        /// </summary>
        public static string ApiGithubSecret { get; set; }
    }
}
