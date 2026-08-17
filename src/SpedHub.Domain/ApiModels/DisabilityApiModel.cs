using System.Text.Json.Serialization;
using SpedHub.Domain.Converters;
using SpedHub.Domain.Entities;

namespace SpedHub.Domain.ApiModels
{
    public class DisabilityApiModel: IConvertModel<DisabilityApiModel, Disability>
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public int StudentId { get; set; }

        public string Description { get; set; } = null!;

        public List<string> Areas { get; set; } = new();

        public Disability Convert() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                Description = Description,
            };
        public async Task<Disability> ConvertAsync() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                Description = Description,
            };

    }
}
