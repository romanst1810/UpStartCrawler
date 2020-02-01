using System;
using System.Collections.Generic;
using System.Text;
using WebCrawlerCore.Interfaces;
using WebCrawlerCore.ViewModels;
using WebCrawlerQService;

namespace WebCrawlerProccess.Services
{
    public class ResponseQServiceWrapper
    {
        IWebQServiceInterface Service { get; set; }
        public ResponseQServiceWrapper()
        {
            Service = new QService();
        }

        public void Send(UrlContentModel model)
        {
            Service.Send(model);
        }

        public string Recieve(UrlContentModel model)
        {
            return Service.Recieve(model);
        }
    }
}
