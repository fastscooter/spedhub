using System.Text.Json.Serialization;

namespace SpedHub.Domain.ApiModels
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Frequency
    {
        Daily,
        Weekly,
        Monthly,
        Quarterly
    }
}
