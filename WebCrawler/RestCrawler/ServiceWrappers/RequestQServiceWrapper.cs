using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCrawlerCore.Interfaces;
using WebCrawlerCore.ViewModels;
using WebCrawlerQService;

namespace RestCrawler.ServiceWrappers
{
    public class RequestQServiceWrapper
    {
        IWebQServiceInterface Service { get; set; }
        public RequestQServiceWrapper()
        {
            Service = new QService();
        }

        public void Send(UrlContentModel model)
        {
            Service.Send(model);
        }
    }
}
