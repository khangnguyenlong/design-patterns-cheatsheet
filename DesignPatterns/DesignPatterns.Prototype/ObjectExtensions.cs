using System.Text.Json;

namespace DesignPatterns.Prototype
{
    public static class ObjectExtensions
    {
        public static T DeepClone<T>(this T source) where T : class
        {
            if (source is null)
            {
                return default;
            }

            var json = JsonSerializer.Serialize(source);

            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
