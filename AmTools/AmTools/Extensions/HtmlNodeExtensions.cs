using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmTools
{
    static class HtmlNodeExtensions
    {
        public static bool HasClass(this HtmlNode node,string className) {
            if (node.Attributes["class"] == null) return false;
            var @class = (
                (node.Attributes["class"]
                ).Value ?? "").Split(' ');
            return @class.Contains(className);
        }
    }
    static class HtmlNodeCollectionExtensions
    {
        public static HtmlNode FindWithClass(this HtmlNodeCollection nodes, string className)
        {
            return nodes.FirstOrDefault(c => c.HasClass(className));
        }
    }
}
