﻿namespace Octokit.Webhooks.Models.CheckRunEvent
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum CheckRunConclusion
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
        [EnumMember(Value = "actionRequired")]
        ActionRequired,
        [EnumMember(Value = "stale")]
        Stale,
        [EnumMember(Value = "skipped")]
        Skipped,
    }
}
