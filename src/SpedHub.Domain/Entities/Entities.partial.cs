using SpedHub.Domain.ApiModels;
using SpedHub.Domain.Converters;
using SpedHub.Domain.Extensions;

namespace SpedHub.Domain.Entities
{
    public partial class Disability: IConvertModel<Disability, DisabilityApiModel>
    {
        public DisabilityApiModel Convert() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                Description = Description,
            };

        public async Task<DisabilityApiModel> ConvertAsync() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                Description = Description,
            };
    }

    public partial class Goal: IConvertModel<Goal, GoalApiModel>
    {
        public GoalApiModel Convert() =>
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
                Measurement = Measurement
            };

        public async Task<GoalApiModel> ConvertAsync() =>
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
                Measurement = Measurement
            };

    }


    public partial class Service: IConvertModel<Service, ServiceApiModel>
    {
        public ServiceApiModel Convert() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                Type = Type.ToServiceType(),
                Subject = Subject.ToSchoolSubject(),
                Minutes = Minutes,
                Frequency = Frequency.ToFrequency(),
                StartDate = StartDate,
                EndDate = EndDate
            };

        public async Task<ServiceApiModel> ConvertAsync() =>
            new()
            {
                Id = Id,
                StudentId = StudentId,
                Type = Type.ToServiceType(),
                Subject = Subject.ToSchoolSubject(),
                Minutes = Minutes,
                Frequency = Frequency.ToFrequency(),
                StartDate = StartDate,
                EndDate = EndDate
            };

    }

    public partial class Student: IConvertModel<Student, StudentApiModel>
    {
        public StudentApiModel Convert() =>
            new()
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                DateOfBirth = DateOfBirth,
                Gender = Gender,
                GradeLevel = GradeLevel,
                Goals = Goals.Select(o => o.Convert()).ToList(),
                Services = Services.Select(o => o.Convert()).ToList(),
                Accommodations = Accommodations.Select(o => o.Convert()).ToList(),
            };

        public async Task<StudentApiModel> ConvertAsync() =>
            new()
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                DateOfBirth = DateOfBirth,
                Gender = Gender,
                GradeLevel = GradeLevel,
                Goals = Goals.Select(o => o.Convert()).ToList(),
                Services = Services.Select(o => o.Convert()).ToList(),
                Accommodations = Accommodations.Select(o => o.Convert()).ToList(),
            };

    }

    public partial class Accommodation: IConvertModel<Accommodation, AccommodationApiModel>
    {
        public AccommodationApiModel Convert() =>
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

        public async Task<AccommodationApiModel> ConvertAsync() =>
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
