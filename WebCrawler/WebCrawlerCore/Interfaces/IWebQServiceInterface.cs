using System;
using System.Collections.Generic;
using System.Text;
using WebCrawlerCore.ViewModels;

namespace WebCrawlerCore.Interfaces
{
    public interface IWebQServiceInterface
    {
        void Send(UrlContentModel model);

        string Recieve(UrlContentModel model);
    }
}
