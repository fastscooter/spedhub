using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedHub.Domain.Text
{
    public interface ISpedHubTextGenerationService
    {
        Task<string> GenerateIntroduction(int studentId);
    }
}
