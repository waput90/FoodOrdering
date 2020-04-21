namespace FoodOrdering.Commons.Extensions
{
    public static class StringExtension
    {
        public static string ToID(this string guid) => guid.Replace("-", "");
    }
}