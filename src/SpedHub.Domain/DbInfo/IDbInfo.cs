using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedHub.Domain.DbInfo
{
    public interface IDbInfo
    {
        string ConnectionStrings { get; }
    }
}
