using System.Text.Json.Serialization;
using SpedHub.Domain.Converters;
using SpedHub.Domain.Entities;
using SpedHub.Domain.Extensions;
using SpedHub.Domain.Helpers;

namespace SpedHub.Domain.ApiModels
{
    public class ServiceApiModel: IConvertModel<ServiceApiModel, Service>
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public int StudentId { get; set; }

        public ServiceType Type { get; set; }

        public SchoolSubject Subject { get; set; }

        public int Minutes { get; set; }

        public Frequency Frequency { get; set; }

        public DateOnly? StartDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public int DaysRemaining
        {
            get
            {
                return SchoolDaysRemainingHelper.GetDaysRemaining(EndDate);
            }
        }

        public Service Convert() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                Type = (int) Type,
                Subject = (int) Subject,
                Minutes = Minutes,
                Frequency = Enum.GetName(Frequency),
                StartDate = StartDate,
                EndDate = EndDate
            };

        public async Task<Service> ConvertAsync() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                Type = (int) Type,
                Subject = (int) Subject,
                Minutes = Minutes,
                Frequency = Enum.GetName(Frequency),
                StartDate = StartDate,
                EndDate = EndDate
            };
    }
}
