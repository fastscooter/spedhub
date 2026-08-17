using System.Text.Json.Serialization;

namespace SpedHub.Domain.ApiModels
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ServiceType
    {
        Default = 0,

        [JsonStringEnumMemberName(JsonStrings.InClassSupport)]
        InClassSupport = 1,

        [JsonStringEnumMemberName(JsonStrings.CoTeach)]
        CoTeach = 2,
        Modified = 3,
    }
}
