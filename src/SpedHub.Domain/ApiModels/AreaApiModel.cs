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
    public class AreaApiModel : IConvertModel<AreaApiModel, Area>
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public int DisabilityId { get; set; }

        public string Description { get; set; } = null!;

        public Area Convert() =>
            new()
            {
                Id = Id,
                DisabilityId = DisabilityId,
                Description = Description,

            };

        public async Task<Area> ConvertAsync() =>
            new()
            {
                Id = Id,
                DisabilityId = DisabilityId,
                Description = Description
            };
    }
}
