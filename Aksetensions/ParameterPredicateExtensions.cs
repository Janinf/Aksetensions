namespace Aksetensions
{
    public static class ParameterPredicateExtensions
    {
        public static bool IsNull<TSource>(this TSource source) => source == null;

        public static bool IsNotNull<TSource>(this TSource source) => source != null;
    }
}
