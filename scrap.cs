using System;
using HtmlAgilityPack;


namespace scrap
{
    class Program
    {
        static void Main(string[] args)
        {
            Requests requests = new Requests();
            requests.get("https://manecocaneco.blogspot.com/");
        }
    }

    class Requests
    {
        HtmlWeb web = new HtmlWeb();

        public void get(string url)
        {
            HtmlDocument doc = web.Load(url);
            HtmlNodeCollection linkNodes = doc.DocumentNode.SelectNodes("//h3/a");
            foreach(var x in linkNodes)
            {
                Console.WriteLine(x.InnerText);
            }
        }
    }

}
