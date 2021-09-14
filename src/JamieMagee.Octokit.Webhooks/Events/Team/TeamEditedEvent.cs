namespace JamieMagee.Octokit.Webhooks.Events.Team
{
    using System.Text.Json.Serialization;
    using JamieMagee.Octokit.Webhooks.Models;
    using JamieMagee.Octokit.Webhooks.Models.TeamEvent;

    [WebhookActionType(TeamActionValue.Edited)]
    public sealed record TeamEditedEvent : TeamEvent
    {
        [JsonPropertyName("action")]
        public override string Action => TeamAction.Edited;

        [JsonPropertyName("changes")]
        public Changes Changes { get; init; } = null!;
    }
}
