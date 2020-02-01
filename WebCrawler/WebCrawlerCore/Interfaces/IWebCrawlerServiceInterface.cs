using System;
using System.Collections.Generic;
using System.Text;

namespace WebCrawlerCore.Interfaces
{
    public interface IWebCrawlerServiceInterface
    {
        string Get(string htmlUrl);
    }
}
