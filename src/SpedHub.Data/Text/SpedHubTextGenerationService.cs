using System.Text;
using SpedHub.Domain.ApiModels;
using SpedHub.Domain.Entities;
using SpedHub.Domain.Extensions;
using SpedHub.Domain.Supervisor;
using SpedHub.Domain.Text;

namespace SpedHub.Data.Text
{
    public class SpedHubTextGenerationService: ISpedHubTextGenerationService
    {
        private readonly ISpedHubSupervisor _superVisor;

        public SpedHubTextGenerationService(ISpedHubSupervisor superVisor)
        {
            _superVisor = superVisor;
        }

        public async Task<string> GenerateIntroduction(int studentId)
        {
            var student = await _superVisor.GetStudentById(studentId);
            StringBuilder sb = new StringBuilder();

            sb = sb.Append(student.FirstName);
            sb = sb.Append(' ');
            sb = sb.Append("is a student in grade ");
            sb = sb.Append(student.GradeLevel);
            sb = sb.Append(' ');
            sb = sb.Append("who qualifies for special education services as a student with ");

            var disabilities = student.Disabilities;

            var disabilityCount = disabilities.Count;

            await WriteDisabilities(student, sb, disabilityCount);

            var retVal = sb.ToString();

            return retVal;

        }

        private async Task WriteDisabilities(StudentApiModel student, StringBuilder sb, int disabilityCount)
        {
            switch(disabilityCount)
            {
                case 1:
                    {
                        WriteDisabilityType(student.Disabilities[0].Description.ToDisabilityType(), sb);
                        sb = sb.AppendLine(".");
                        break;
                    }
                case 2:
                    {
                        WriteDisabilityType(student.Disabilities[0].Description.ToDisabilityType(), sb);
                        sb = sb.Append(" and ");
                        WriteDisabilityType(student.Disabilities[1].Description.ToDisabilityType(), sb);
                        sb = sb.AppendLine(".");
                        break
                    }
                case 3:
                    {
                        WriteDisabilityType(student.Disabilities[0].Description.ToDisabilityType(),, sb);
                        sb = sb.Append(", ");
                        WriteDisabilityType(student.Disabilities[1].Description.ToDisabilityType(),, sb);
                        sb = sb.Append(", and ");
                        WriteDisabilityType(student.Disabilities[2].Description.ToDisabilityType(),, sb);
                        sb = sb.AppendLine(".");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

        }

        private void WriteDisabilityType(DisabilityType disabilityType, StringBuilder sb)
        {
            switch(disabilityType)
            {
                case DisabilityType.OrthopedicImpairment:
                    sb.Append("an Orthopedic Impairment in the following areas:");
                    break;
                case DisabilityType.OtherHealthImpairment:
                    sb.Append("an Other Health Impairment in the following areas:");
                    break;
                case DisabilityType.AuditoryImpairment:
                    sb.Append("an Auditory Impairment");
                    break;
                case DisabilityType.VisualImpairment:
                    sb.Append("a Visual Impairment");
                    break;
                case DisabilityType.DeafBlind:
                    sb.Append("Deaf-Blindness");
                    break;
                case DisabilityType.IntellectualDisability:
                    sb.Append("an Intellectual Disability");
                    break;
                case DisabilityType.EmotionalDisturbance:
                    sb.Append("Emotional Disturbance");
                    break;
                case DisabilityType.SpecificLearningDisability:
                    sb.Append("a Specific Learning Disability in the following areas:");
                    break;
                case DisabilityType.SpeechImpairment:
                    sb.Append(" Speech Impairment in the following areas:");
                    break;
                case DisabilityType.Autism:
                    sb.Append("Autism");
                    break;
                case DisabilityType.DevelopmentalDelay:
                    sb.Append("a Developmental Delay");
                    break;
                case DisabilityType.TraumaticBrainInjury:
                    sb.Append("Traumatic Brain Injury");
                    break;
                case DisabilityType.NoncategoricalEarlyChildhood:
                    sb.Append("a Non-Categorical Early Childhood Disability");
                    break;
            }
        }
    }
}
