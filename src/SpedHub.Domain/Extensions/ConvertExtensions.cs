using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpedHub.Domain.Converters;

namespace SpedHub.Domain.Extensions
{
    public static class ConvertExtensions
    {
        public static IEnumerable<TTarget> ConvertAll<TSource, TTarget>(
            this IEnumerable<IConvertModel<TSource, TTarget>> values)
            => values.Select(value => value.Convert());

        public static async Task<IEnumerable<TTarget>> ConvertAllAsync<TSource, TTarget>(
            this IEnumerable<IConvertModel<TSource, TTarget>> values)
            => (IEnumerable<TTarget>)values.Select(value => value.ConvertAsync());
    }
}
