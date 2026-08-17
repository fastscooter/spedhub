using SpedHub.Domain.Converters;
using SpedHub.Domain.Entities;

namespace SpedHub.Domain.ApiModels
{
    public class StudentApiModel: IConvertModel<StudentApiModel, Student>
    {
        public int Id { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Gender { get; set; }

        public int GradeLevel { get; set; }

        public DateOnly? DateOfBirth { get; set; }

        public List<DisabilityApiModel> Disabilities { get; set; } = new();

        public List<GoalApiModel> Goals { get; set; } = new();

        public List<AccommodationApiModel> Accommodations { get; set; } = new();

        public List<ServiceApiModel> Services { get; set; } = new();



        public Student Convert() =>
            new()
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                DateOfBirth = DateOfBirth,
                Gender = Gender,
                GradeLevel = GradeLevel,
                Goals = Goals.Select(x => x.Convert()).ToList(),
                Services = Services.Select(x => x.Convert()).ToList(),
                Disabilities = Disabilities.Select(x => x.Convert()).ToList(),
                Accommodations = Accommodations.Select(x => x.Convert()).ToList(),
            };

        public async Task<Student> ConvertAsync() =>
            new()
            {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                DateOfBirth = DateOfBirth,
                Gender = Gender,
                GradeLevel = GradeLevel,
                Goals = Goals.Select(x => x.Convert()).ToList(),
                Services = Services.Select(x => x.Convert()).ToList(),
                Disabilities = Disabilities.Select(x => x.Convert()).ToList(),
                Accommodations = Accommodations.Select(x => x.Convert()).ToList(),
            };
    }
}
