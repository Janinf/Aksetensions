using System;
using System.Runtime.CompilerServices;

namespace Aksetensions
{
    public static class ParameterCheckExtensions
    {
        public static TSource CheckNotNull<TSource>(this TSource source, string parameterName = null)
        {
            if (source.IsNull()) throw new ArgumentNullException(parameterName ?? nameof(source));

            return source;
        }
    }
}
