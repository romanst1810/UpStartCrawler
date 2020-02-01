using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using WebCrawlerCore.Interfaces;
using WebCrawlerCore.ViewModels;

namespace WebCrawlerQService
{
    public class QService : IWebQServiceInterface
    {
        public static Queue<string> Queue { get; set; }
        public static string Message { get; set; }

        public void Send(UrlContentModel model)
        {
            Queue.Enqueue(model.QMessage);
        }

        public string Recieve(UrlContentModel model)
        {
            Message = Queue.Dequeue();
            return Message;
        }
    }
}
