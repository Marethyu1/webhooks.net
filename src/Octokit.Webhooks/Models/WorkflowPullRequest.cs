﻿namespace Octokit.Webhooks.Models
{
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;

    [PublicAPI]
    public sealed record WorkflowPullRequest
    {
        [JsonPropertyName("url")]
        public string Url { get; init; } = null!;

        [JsonPropertyName("id")]
        public int Id { get; init; }

        [JsonPropertyName("number")]
        public int Number { get; init; }

        [JsonPropertyName("head")]
        public WorkflowPullRequestHead Head { get; init; } = null!;

        [JsonPropertyName("base")]
        public WorkflowPullRequestBase Base { get; init; } = null!;
    }
}
