using System;
using System.Collections.Generic;
using System.Text;
using WebCrawlerCore.ViewModels;

namespace WebCrawlerCore.Interfaces
{
    public interface IWebhookUrlInterface
    {
        void SetResultToWebhookUrl(UrlContentModel model);
    }
}
