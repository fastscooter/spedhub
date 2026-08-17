using System.Text.Json.Serialization;
using SpedHub.Domain.Converters;
using SpedHub.Domain.Entities;

namespace SpedHub.Domain.ApiModels
{
    public class GoalApiModel: IConvertModel<GoalApiModel, Goal>
    {
        [JsonIgnore]
        public int Id { get; set; }

        [JsonIgnore]
        public int StudentId { get; set; }

        public GoalStatus Status { get; set; }

        public decimal Number { get; set; }

        public bool? IsAcademic { get; set; }

        public DateOnly? StartDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public string? Subject { get; set; }

        public string? Timeframe { get; set; }

        public string? Conditions { get; set; }

        public string? Behavior { get; set; }

        public string? Measurement { get; set; }

        public Goal Convert() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                Number = Number,
                StartDate = StartDate,
                EndDate = EndDate,
                Subject = Subject,
                IsAcademic = IsAcademic,
                Timeframe = Timeframe,
                Conditions = Conditions,
                Behavior = Behavior,
                Measurement = Measurement,
                Status = (int)Status
            };

        public async Task<Goal> ConvertAsync() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                Number = Number,
                StartDate = StartDate,
                EndDate = EndDate,
                Subject = Subject,
                IsAcademic = IsAcademic,
                Timeframe = Timeframe,
                Conditions = Conditions,
                Behavior = Behavior,
                Measurement = Measurement,
                Status = (int)Status
            };
    }
}
