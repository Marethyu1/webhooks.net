﻿namespace Octokit.Webhooks.Events
{
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;
    using Octokit.Webhooks.Converter;

    [PublicAPI]
    [WebhookEventType(WebhookEventType.DeploymentStatus)]
    [JsonConverter(typeof(WebhookConverter<DeploymentStatusEvent>))]
    public abstract record DeploymentStatusEvent : WebhookEvent
    {
        [JsonPropertyName("deployment_status")]
        public Models.DeploymentStatusEvent.DeploymentStatus DeploymentStatus { get; init; } = null!;

        [JsonPropertyName("deployment")]
        public Models.DeploymentStatusEvent.Deployment Deployment { get; init; } = null!;
    }
}
