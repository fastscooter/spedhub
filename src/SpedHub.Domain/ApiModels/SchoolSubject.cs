using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace SpedHub.Domain.ApiModels
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SchoolSubject
    {
        None = 0,
        [JsonStringEnumMemberName(JsonStrings.ELAR)]
        EnglishLanguageArts = 1,
        Mathematics         = 2,
        Science             = 3,
        [JsonStringEnumMemberName(JsonStrings.SocialStudies)]
        SocialStudies       = 4,
    }
}
