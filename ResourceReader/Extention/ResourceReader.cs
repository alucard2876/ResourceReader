using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace ResourceReader.Buisness.ResourceReader
{
    public static class ResourceReader
    {
        public static Dictionary<string, Resource> GetResource(this IEnumerable<KeyValuePair<string,Resource>> data, string pathToFile)
            => XDocument.Load(pathToFile).Descendants("data").
            Select(p => new Resource { Value = p.Element("value").Value, Comment = p.Element("comment").Value?? string.Empty})
            .ToDictionary(x=>x.Value,elementSelector=>elementSelector);
    }
}
