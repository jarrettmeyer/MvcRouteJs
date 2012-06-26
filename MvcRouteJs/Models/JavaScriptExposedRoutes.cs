using System.Collections;
using System.Collections.Generic;

namespace MvcRouteJs.Models
{
    public class JavaScriptExposedRoutes : IEnumerable<KeyValuePair<string, string>>
    {
        private readonly Dictionary<string, string> routeDictionary = new Dictionary<string, string>();

        public void Add(string name, string url)
        {
            routeDictionary.Add(name, url);
        }

        public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
        {
            return routeDictionary.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
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