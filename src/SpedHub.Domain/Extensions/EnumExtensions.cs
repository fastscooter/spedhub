using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpedHub.Domain.ApiModels;

namespace SpedHub.Domain.Extensions
{
    public static class EnumExtensions
    {
        public static ServiceType ToServiceType(this int value)
        {
            return value switch
            {
                1 => ServiceType.InClassSupport,
                2 => ServiceType.CoTeach,
                3 => ServiceType.InClassSupport,
                _ => ServiceType.Default,
            };
        }

        public static SchoolSubject ToSchoolSubject(this int value)
        {
            return value switch
            {
                1 => SchoolSubject.EnglishLanguageArts,
                2 => SchoolSubject.Mathematics,
                3 => SchoolSubject.Science,
                4 => SchoolSubject.SocialStudies,
                _ => SchoolSubject.None,
            };
        }

        public static DisabilityType ToDisabilityType(this string value)
        {
            return value switch
            {
                "00" => DisabilityType.NoDisability,
                "01" => DisabilityType.OrthopedicImpairment,
                "02" => DisabilityType.OtherHealthImpairment,
                "03" => DisabilityType.AuditoryImpairment,
                "04" => DisabilityType.VisualImpairment,
                "05" => DisabilityType.DeafBlind,
                "06" => DisabilityType.IntellectualDisability,
                "07" => DisabilityType.EmotionalDisturbance,
                "08" => DisabilityType.SpecificLearningDisability,
                "09" => DisabilityType.SpeechImpairment,
                "10" => DisabilityType.Autism,
                "12" => DisabilityType.DevelopmentalDelay,
                "13" => DisabilityType.TraumaticBrainInjury,
                "14" => DisabilityType.NoncategoricalEarlyChildhood,
                _ => DisabilityType.NoDisability
            };
        }

        public static Frequency ToFrequency(this string value)
        {
            return value.ToUpper() switch
            {
                "D" => Frequency.Daily,
                "M" => Frequency.Monthly,
                "W" => Frequency.Weekly,
                "Q" => Frequency.Quarterly,
                _ => throw new InvalidDataException(),
            };
        }
    }
}
