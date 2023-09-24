using Newtonsoft.Json;

namespace Github.Webhook.Models.GithubModels
{
    /// <summary>
    /// Representa um repositório no GitHub.
    /// </summary>
    public class Repository
    {
        /// <summary>
        /// Obtém ou define o ID do repositório.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Obtém ou define o node ID do repositório.
        /// </summary>
        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// Obtém ou define o nome do repositório.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Obtém ou define o nome completo do repositório.
        /// </summary>
        [JsonProperty("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// Obtém ou define se o repositório é privado.
        /// </summary>
        [JsonProperty("private")]
        public bool IsPrivate { get; set; }

        /// <summary>
        /// Obtém ou define o proprietário do repositório.
        /// </summary>
        [JsonProperty("owner")]
        public Owner Owner { get; set; }

        /// <summary>
        /// Obtém ou define a URL HTML do repositório.
        /// </summary>
        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// Obtém ou define a descrição do repositório.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Obtém ou define se é um fork.
        /// </summary>
        [JsonProperty("fork")]
        public bool IsFork { get; set; }

        /// <summary>
        /// Obtém ou define a URL do repositório.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Obtém ou define a URL de forks.
        /// </summary>
        [JsonProperty("forks_url")]
        public string ForksUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de chaves.
        /// </summary>
        [JsonProperty("keys_url")]
        public string KeysUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de colaboradores.
        /// </summary>
        [JsonProperty("collaborators_url")]
        public string CollaboratorsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de equipes.
        /// </summary>
        [JsonProperty("teams_url")]
        public string TeamsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de hooks.
        /// </summary>
        [JsonProperty("hooks_url")]
        public string HooksUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de eventos de issues.
        /// </summary>
        [JsonProperty("issue_events_url")]
        public string IssueEventsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de eventos.
        /// </summary>
        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de assignees.
        /// </summary>
        [JsonProperty("assignees_url")]
        public string AssigneesUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de branches.
        /// </summary>
        [JsonProperty("branches_url")]
        public string BranchesUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de tags.
        /// </summary>
        [JsonProperty("tags_url")]
        public string TagsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de blobs.
        /// </summary>
        [JsonProperty("blobs_url")]
        public string BlobsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de tags Git.
        /// </summary>
        [JsonProperty("git_tags_url")]
        public string GitTagsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de referências Git.
        /// </summary>
        [JsonProperty("git_refs_url")]
        public string GitRefsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de árvores.
        /// </summary>
        [JsonProperty("trees_url")]
        public string TreesUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de statuses.
        /// </summary>
        [JsonProperty("statuses_url")]
        public string StatusesUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de linguagens.
        /// </summary>
        [JsonProperty("languages_url")]
        public string LanguagesUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de stargazers.
        /// </summary>
        [JsonProperty("stargazers_url")]
        public string StargazersUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de contribuidores.
        /// </summary>
        [JsonProperty("contributors_url")]
        public string ContributorsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de assinantes.
        /// </summary>
        [JsonProperty("subscribers_url")]
        public string SubscribersUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de assinatura.
        /// </summary>
        [JsonProperty("subscription_url")]
        public string SubscriptionUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de commits.
        /// </summary>
        [JsonProperty("commits_url")]
        public string CommitsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de commits Git.
        /// </summary>
        [JsonProperty("git_commits_url")]
        public string GitCommitsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de comentários.
        /// </summary>
        [JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de comentários de issues.
        /// </summary>
        [JsonProperty("issue_comment_url")]
        public string IssueCommentUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de conteúdo.
        /// </summary>
        [JsonProperty("contents_url")]
        public string ContentsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de comparação.
        /// </summary>
        [JsonProperty("compare_url")]
        public string CompareUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de mesclagem.
        /// </summary>
        [JsonProperty("merges_url")]
        public string MergesUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de arquivamento.
        /// </summary>
        [JsonProperty("archive_url")]
        public string ArchiveUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de downloads.
        /// </summary>
        [JsonProperty("downloads_url")]
        public string DownloadsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de issues.
        /// </summary>
        [JsonProperty("issues_url")]
        public string IssuesUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de pull requests.
        /// </summary>
        [JsonProperty("pulls_url")]
        public string PullsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de milestones.
        /// </summary>
        [JsonProperty("milestones_url")]
        public string MilestonesUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de notificações.
        /// </summary>
        [JsonProperty("notifications_url")]
        public string NotificationsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de labels.
        /// </summary>
        [JsonProperty("labels_url")]
        public string LabelsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de releases.
        /// </summary>
        [JsonProperty("releases_url")]
        public string ReleasesUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de implantações.
        /// </summary>
        [JsonProperty("deployments_url")]
        public string DeploymentsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a data de criação do repositório.
        /// </summary>
        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Obtém ou define a data de atualização do repositório.
        /// </summary>
        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// Obtém ou define a data do último push.
        /// </summary>
        [JsonProperty("pushed_at")]
        public string PushedAt { get; set; }

        /// <summary>
        /// Obtém ou define a URL Git do repositório.
        /// </summary>
        [JsonProperty("git_url")]
        public string GitUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL SSH do repositório.
        /// </summary>
        [JsonProperty("ssh_url")]
        public string SshUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de clone do repositório.
        /// </summary>
        [JsonProperty("clone_url")]
        public string CloneUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL SVN do repositório.
        /// </summary>
        [JsonProperty("svn_url")]
        public string SvnUrl { get; set; }

        /// <summary>
        /// Obtém ou define a página inicial do repositório.
        /// </summary>
        [JsonProperty("homepage")]
        public object Homepage { get; set; }

        /// <summary>
        /// Obtém ou define o tamanho do repositório.
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// Obtém ou define a contagem de stargazers do repositório.
        /// </summary>
        [JsonProperty("stargazers_count")]
        public int StargazersCount { get; set; }

        /// <summary>
        /// Obtém ou define a contagem de watchers do repositório.
        /// </summary>
        [JsonProperty("watchers_count")]
        public int WatchersCount { get; set; }

        /// <summary>
        /// Obtém ou define a linguagem do repositório.
        /// </summary>
        [JsonProperty("language")]
        public string Language { get; set; }

        /// <summary>
        /// Obtém ou define se o repositório tem issues.
        /// </summary>
        [JsonProperty("has_issues")]
        public bool HasIssues { get; set; }

        /// <summary>
        /// Obtém ou define se o repositório tem projetos.
        /// </summary>
        [JsonProperty("has_projects")]
        public bool HasProjects { get; set; }

        /// <summary>
        /// Obtém ou define se o repositório tem downloads.
        /// </summary>
        [JsonProperty("has_downloads")]
        public bool HasDownloads { get; set; }

        /// <summary>
        /// Obtém ou define se o repositório tem wiki.
        /// </summary>
        [JsonProperty("has_wiki")]
        public bool HasWiki { get; set; }

        /// <summary>
        /// Obtém ou define se o repositório tem páginas.
        /// </summary>
        [JsonProperty("has_pages")]
        public bool HasPages { get; set; }

        /// <summary>
        /// Obtém ou define se o repositório tem discussões.
        /// </summary>
        [JsonProperty("has_discussions")]
        public bool HasDiscussions { get; set; }

        /// <summary>
        /// Obtém ou define a contagem de forks do repositório.
        /// </summary>
        [JsonProperty("forks_count")]
        public int ForksCount { get; set; }

        /// <summary>
        /// Obtém ou define a URL de espelhamento.
        /// </summary>
        [JsonProperty("mirror_url")]
        public object MirrorUrl { get; set; }

        /// <summary>
        /// Obtém ou define se o repositório está arquivado.
        /// </summary>
        [JsonProperty("archived")]
        public bool IsArchived { get; set; }

        /// <summary>
        /// Obtém ou define se o repositório está desabilitado.
        /// </summary>
        [JsonProperty("disabled")]
        public bool IsDisabled { get; set; }

        /// <summary>
        /// Obtém ou define a contagem de issues abertas do repositório.
        /// </summary>
        [JsonProperty("open_issues_count")]
        public int OpenIssuesCount { get; set; }

        /// <summary>
        /// Obtém ou define a licença do repositório.
        /// </summary>
        [JsonProperty("license")]
        public License License { get; set; }

        /// <summary>
        /// Obtém ou define se é permitido criar forks do repositório.
        /// </summary>
        [JsonProperty("allow_forking")]
        public bool AllowForking { get; set; }

        /// <summary>
        /// Obtém ou define se o repositório é um modelo.
        /// </summary>
        [JsonProperty("is_template")]
        public bool IsTemplate { get; set; }

        /// <summary>
        /// Obtém ou define se é necessário aprovação de commit via web.
        /// </summary>
        [JsonProperty("web_commit_signoff_required")]
        public bool WebCommitSignoffRequired { get; set; }

        /// <summary>
        /// Obtém ou define os tópicos associados ao repositório.
        /// </summary>
        [JsonProperty("topics")]
        public object[] Topics { get; set; }

        /// <summary>
        /// Obtém ou define a visibilidade do repositório.
        /// </summary>
        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        /// <summary>
        /// Obtém ou define a contagem de forks do repositório.
        /// </summary>
        [JsonProperty("forks")]
        public int Forks { get; set; }

        /// <summary>
        /// Obtém ou define a contagem de issues abertas do repositório.
        /// </summary>
        [JsonProperty("open_issues")]
        public int OpenIssues { get; set; }

        /// <summary>
        /// Obtém ou define a contagem de watchers do repositório.
        /// </summary>
        [JsonProperty("watchers")]
        public int Watchers { get; set; }

        /// <summary>
        /// Obtém ou define a branch padrão do repositório.
        /// </summary>
        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }
    }

    /// <summary>
    /// Representa o proprietário de um repositório no GitHub.
    /// </summary>
    public class Owner
    {
        /// <summary>
        /// Obtém ou define o nome de login do proprietário.
        /// </summary>
        [JsonProperty("login")]
        public string Login { get; set; }

        /// <summary>
        /// Obtém ou define o ID do proprietário.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Obtém ou define o node ID do proprietário.
        /// </summary>
        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// Obtém ou define a URL do avatar do proprietário.
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Obtém ou define o ID do gravatar do proprietário.
        /// </summary>
        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        /// <summary>
        /// Obtém ou define a URL do perfil do proprietário.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Obtém ou define a URL HTML do perfil do proprietário.
        /// </summary>
        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de seguidores do proprietário.
        /// </summary>
        [JsonProperty("followers_url")]
        public string FollowersUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de seguidos do proprietário.
        /// </summary>
        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de gists do proprietário.
        /// </summary>
        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de repositórios destacados do proprietário.
        /// </summary>
        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de inscrições do proprietário.
        /// </summary>
        [JsonProperty("subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de organizações do proprietário.
        /// </summary>
        [JsonProperty("organizations_url")]
        public string OrganizationsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de repositórios do proprietário.
        /// </summary>
        [JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de eventos do proprietário.
        /// </summary>
        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de eventos recebidos do proprietário.
        /// </summary>
        [JsonProperty("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        /// <summary>
        /// Obtém ou define o tipo do proprietário.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Obtém ou define se o usuário é um administrador do site.
        /// </summary>
        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }
    }

    /// <summary>
    /// Representa a licença de um repositório no GitHub.
    /// </summary>
    public class License
    {
        /// <summary>
        /// Obtém ou define a chave da licença.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// Obtém ou define o nome da licença.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Obtém ou define o ID SPDX da licença.
        /// </summary>
        [JsonProperty("spdx_id")]
        public string SpdxId { get; set; }

        /// <summary>
        /// Obtém ou define a URL da licença.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Obtém ou define o node ID da licença.
        /// </summary>
        [JsonProperty("node_id")]
        public string NodeId { get; set; }
    }

    /// <summary>
    /// Representa o remetente de um evento no GitHub.
    /// </summary>
    public class Sender
    {
        /// <summary>
        /// Obtém ou define o nome de login do remetente.
        /// </summary>
        [JsonProperty("login")]
        public string Login { get; set; }

        /// <summary>
        /// Obtém ou define o ID do remetente.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Obtém ou define o node ID do remetente.
        /// </summary>
        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// Obtém ou define a URL do avatar do remetente.
        /// </summary>
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }

        /// <summary>
        /// Obtém ou define o ID do gravatar do remetente.
        /// </summary>
        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        /// <summary>
        /// Obtém ou define a URL do perfil do remetente.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Obtém ou define a URL HTML do perfil do remetente.
        /// </summary>
        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de seguidores do remetente.
        /// </summary>
        [JsonProperty("followers_url")]
        public string FollowersUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de seguidos do remetente.
        /// </summary>
        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de gists do remetente.
        /// </summary>
        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de repositórios destacados do remetente.
        /// </summary>
        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de inscrições do remetente.
        /// </summary>
        [JsonProperty("subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de organizações do remetente.
        /// </summary>
        [JsonProperty("organizations_url")]
        public string OrganizationsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de repositórios do remetente.
        /// </summary>
        [JsonProperty("repos_url")]
        public string ReposUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de eventos do remetente.
        /// </summary>
        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        /// <summary>
        /// Obtém ou define a URL de eventos recebidos do remetente.
        /// </summary>
        [JsonProperty("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        /// <summary>
        /// Obtém ou define o tipo do remetente.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Obtém ou define se o usuário é um administrador do site.
        /// </summary>
        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }
    }
}
