using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpedHub.Domain.Converters;
using SpedHub.Domain.Entities;

namespace SpedHub.Domain.ApiModels
{
    public class AccommodationApiModel : IConvertModel<AccommodationApiModel, Accommodation>
    {
        [JsonIgnore]
        public int Id { get; set; }

        public int StudentId { get; set; }

        public DateOnly? StartDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public string? Category { get; set; }

        public string Description { get; set; } = null!;

        public bool Elar { get; set; }

        public bool Math { get; set; }

        public bool Science { get; set; }

        public bool SocialStudies { get; set; }

        public Accommodation Convert() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                StartDate = StartDate,
                EndDate = EndDate,
                Category = Category,
                Description = Description,
                Elar = Elar,
                Math = Math,
                Science = Science,
                SocialStudies = SocialStudies
            };

        public async Task<Accommodation> ConvertAsync() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                StartDate = StartDate,
                EndDate = EndDate,
                Category = Category,
                Description = Description,
                Elar = Elar,
                Math = Math,
                Science = Science,
                SocialStudies = SocialStudies
            };
    }
}
