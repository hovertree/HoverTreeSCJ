using System.Text.RegularExpressions;

namespace HoverTree.HoverTreeFrame.HtText
{
    public class HtHtml
    {

        /// <summary>
        /// 获取html文档的标题(Title) by 何问起
        /// </summary>
        /// <param name="html"></param>
        /// <returns></returns>
        public static string GetTitle(string html)
        {
            string h_title = "";

            string pattern = @"(?si)<title(?:\s+(?:""[^""]*""|'[^']*'|[^""'>])*)?>(?<title>.*?)</title>";
            h_title= Regex.Match(html, pattern).Groups["title"].Value.Trim();

            return h_title;
        }
    }
}