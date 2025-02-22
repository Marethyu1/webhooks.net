﻿namespace Octokit.Webhooks.Models.CodeScanningAlertEvent
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum AlertState
    {
        [EnumMember(Value = "open")]
        Open,
        [EnumMember(Value = "dismissed")]
        Dismissed,
        [EnumMember(Value = "fixed")]
        Fixed,
    }
}
