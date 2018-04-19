using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.IO;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
             string Url = "http://articles.runtings.co.uk/2009/11/easily-extracting-links-from-snippet-of.html";
             HtmlWeb web = new HtmlWeb();
             HtmlDocument doc = web.Load(Url);
            Console.WriteLine(doc.ToString());
             Console.WriteLine(doc.ParsedText);
             doc.Save("C:\\wintel\\index.html");
             Console.Read();
            /*string html = string.Empty;
            string url = "http://articles.runtings.co.uk/2009/11/easily-extracting-links-from-snippet-of.html";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            Console.WriteLine(html);
            Console.Read();*/
        }
    }
}
