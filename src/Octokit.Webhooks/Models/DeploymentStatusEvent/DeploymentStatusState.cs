﻿namespace Octokit.Webhooks.Models.DeploymentStatusEvent
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum DeploymentStatusState
    {
        [EnumMember(Value = "pending")]
        Pending,
        [EnumMember(Value = "success")]
        Success,
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "error")]
        Error,
    }
}
