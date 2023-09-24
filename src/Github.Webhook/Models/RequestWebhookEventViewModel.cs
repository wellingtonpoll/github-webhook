using Github.Webhook.Models.GithubModels;
using Newtonsoft.Json;

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
        [JsonProperty("_ref")]
        public string Ref { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ref_type")]
        public string RefType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("master_branch")]
        public string MasterBranch { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("description")]
        public object Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("pusher_type")]
        public string PusherType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("repository")]
        public Repository Repository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("sender")]
        public Sender Sender { get; set; }

        /// <summary>
        /// Verify if event type is push
        /// </summary>
        /// <returns></returns>
        public bool IsPushEvent() => GithubEvent == "push";
    }
}
