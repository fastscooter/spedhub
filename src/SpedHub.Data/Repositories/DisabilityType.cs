using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SpedHub.Data.ApiModels
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DisabilityType
    {
        [JsonStringEnumMemberName("No Disability")]
        NoDisability = 1,

        [JsonStringEnumMemberName("Orthopedic Impairment")]
        OrthopedicImpairment = 2,

        [JsonStringEnumMemberName("Other Health Impairment")]
        OtherHealthImpairment = 3,

        [JsonStringEnumMemberName("Auditory Impairment")]
        AuditoryImpairment = 4,

        [JsonStringEnumMemberName("Visual Impairment")]
        VisualImpairment = 5,

        [JsonStringEnumMemberName("Deaf-Blind")]
        DeafBlind = 6,

        [JsonStringEnumMemberName("Intellectual Disability")]
        IntellectualDisability = 7,

        [JsonStringEnumMemberName("Emotional Disturbance")]
        EmotionalDisturbance = 8,

        [JsonStringEnumMemberName("Specific Learning Disability")]
        SpecificLearningDisability = 9,

        [JsonStringEnumMemberName("Speech Impairment")]
        SpeechImpairment = 10,

        [JsonStringEnumMemberName("Autism")]
        Autism = 11,

        [JsonStringEnumMemberName("Developmental Delay")]
        DevelopmentalDelay = 12,

        [JsonStringEnumMemberName("Traumatic Brain Injury")]
        TraumaticBrainInjury = 13,

        [JsonStringEnumMemberName("Non-categorical Early Childhood")]
        NoncategoricalEarlyChildhood = 14,
    }
}
