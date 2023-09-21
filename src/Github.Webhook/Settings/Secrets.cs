namespace Github.Webhook.Settings
{
    /// <summary>
    /// Settings
    /// </summary>
    public static class Secrets
    {
        public static string GithubSecretKey = "GITHUB_SECRET";

        /// <summary>
        /// Github webhook secret
        /// </summary>
        public static string GithubSecret { get; set; } = string.Empty;
    }
}
