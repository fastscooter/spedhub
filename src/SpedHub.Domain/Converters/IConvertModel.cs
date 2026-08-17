using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpedHub.Domain.Converters
{
    public interface IConvertModel<TSource, TTarget>
    {
        TTarget Convert();
        Task<TTarget> ConvertAsync();
    }
}
