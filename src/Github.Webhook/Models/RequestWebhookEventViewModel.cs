using Github.Webhook.Models.GithubModels;

namespace Github.Webhook.Models
{
    /// <summary>
    /// Request webhook view model
    /// </summary>
    public class RequestWebhookEventViewModel
    {
        /// <summary>
        /// Github event type name header
        /// </summary>
        public string GithubEvent { get; set; }

        /// <summary>
        /// Github signature sha-256 header
        /// </summary>
        public string GithubSignature256 { get; set; }

        /// <summary>
        /// Github delivery id header
        /// </summary>
        public string GithubDelivery { get; set; }

        /// <summary>
        /// Github security signature
        /// </summary>
        public string GithubSignature { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string _ref { get; set; }
        public string ref_type { get; set; }
        public string master_branch { get; set; }
        public object description { get; set; }
        public string pusher_type { get; set; }
        public Repository repository { get; set; }
        public Sender sender { get; set; }

        /// <summary>
        /// Verify if event type is push
        /// </summary>
        /// <returns></returns>
        public bool IsPushEvent() => GithubEvent == "push";
    }
}
