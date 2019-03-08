using System;

namespace Aksetensions
{
    public static class StandardFunctions
    {
        public static TSource Use<TSource>(this TSource source, Action<TSource> action)
        {
            action.CheckNotNull(nameof(action)).Invoke(source.CheckNotNull(nameof(source)));
            return source;
        }

        public static TSource Use<TSource>(this TSource source, Action action)
        {
            action.CheckNotNull(nameof(action)).Invoke();
            return source;
        }

        public static TOutput Map<TSource, TOutput>(this TSource source, Func<TSource, TOutput> function)
        {
            return function.CheckNotNull(nameof(function)).Invoke(source.CheckNotNull(nameof(source)));
        }
    }
}
