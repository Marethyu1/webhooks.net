﻿namespace Octokit.Webhooks.Models
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum WorkflowRunConclusion
    {
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "neutral")]
        Neutral,
        [EnumMember(Value = "cancelled")]
        Cancelled,
        [EnumMember(Value = "timed_out")]
        TimedOut,
        [EnumMember(Value = "action_required")]
        ActionRequired,
        [EnumMember(Value = "stale")]
        Stale,
    }
}
