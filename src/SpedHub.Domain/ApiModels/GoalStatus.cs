using System.Text.Json.Serialization;

namespace SpedHub.Domain.ApiModels
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum GoalStatus
    {
        [JsonStringEnumMemberName(JsonStrings.NotStarted)]
        NotStarted = 0,
        [JsonStringEnumMemberName(JsonStrings.InProgress)]
        InProgress = 1,
        [JsonStringEnumMemberName(JsonStrings.Completed)]
        Completed = 2,
    }
}
