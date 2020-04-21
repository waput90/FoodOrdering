using Newtonsoft.Json;

namespace FoodOrdering.Commons.Extensions
{
    public static class ObjectExtension
    {
        public static bool IsNull<TData>(this TData compare1) where TData: new()
        {
            if (compare1 == null)
                return true;
            else
            {   
                var comparer1 = JsonConvert.SerializeObject(compare1);
                var comparer2 = JsonConvert.SerializeObject(new TData());
                return comparer1.Equals(comparer2);
            }
        }
    }
}