/* 何问起收藏夹 http://hovertree.com/hovertreescj/ */
using System;
using System.IO;
using System.Net;

namespace HoverTree.HoverTreeFrame.HtNet
{
    public class HtWeb
    {
        public static string GetHtmlByUrl(string url, System.Text.Encoding enCode)
        {
            try
            {
                WebRequest request = WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                Stream resStream = response.GetResponseStream();
                StreamReader sr = new StreamReader(resStream, enCode);
                string page = sr.ReadToEnd();
                resStream.Close();
                return page;
            }
            catch (Exception)
            {
                return "";
            }
        }
    }
}