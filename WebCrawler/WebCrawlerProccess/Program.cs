using System;
using WebCrawlerCore.ViewModels;

namespace WebCrawlerProccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        private void Proccess()
        {
            // Check and get Q message 
            UrlContentModel item = new UrlContentModel()
            {
              
            };
            Services.ResponseQServiceWrapper rs = new Services.ResponseQServiceWrapper();
            string message = rs.Recieve(item);
            item = GetValuesFromStringArray(item, message);

            // Send Url to Crawler
            // recieve responce html string
            // send new message to Q
        }

        private UrlContentModel GetValuesFromStringArray(UrlContentModel item, string message)
        {
            var messageArray = message.Split(',');
            if (messageArray.Length > 0)
                item.Id = Guid.Parse(messageArray[0]);
            if (messageArray.Length > 1)
                item.HtmlUrl = messageArray[0].ToString();
            return item;
        }
    }
}
