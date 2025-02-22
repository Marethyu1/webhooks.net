namespace Octokit.Webhooks.Models.WorkflowJobEvent
{
    using System.Runtime.Serialization;
    using System.Text.Json.Serialization;

    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum WorkflowJobStepConclusion
    {
        [EnumMember(Value = "failure")]
        Failure,
        [EnumMember(Value = "skipped")]
        Skipped,
        [EnumMember(Value = "success")]
        Success,
    }
}
