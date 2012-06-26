using System.Collections.Generic;

namespace MvcRouteJs.Models
{
    public class JavaScriptExposedRoutes
    {
        private readonly Dictionary<string, string> routeDictionary = new Dictionary<string, string>();

        public void Add(string name, string url)
        {
            routeDictionary.Add(name, url);
        }

        public string ToJavaScriptString()
        {
            var routeStrings = new List<string>();
            foreach (var item in routeDictionary)
            {
                var routeString = string.Format("{0}:\"{1}\"", item.Key, item.Value);
                routeStrings.Add(routeString);
            }
            return "routes={" + string.Join(",", routeStrings) + "};";
        }

        public override string ToString()
        {
            return ToJavaScriptString();
        }
    }
}