namespace EcommerceMAUI.Helpers.ExtensionMethods
{
    internal static class StringExtensions
    {
        public static Color ToColorFromResourceKey(this string resourceKey)
        {
            return Application.Current.Resources
                .MergedDictionaries.First()[resourceKey] as Color;
        }
    }

}
