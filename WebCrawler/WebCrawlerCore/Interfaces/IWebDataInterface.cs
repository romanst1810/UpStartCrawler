using System;
using System.Collections.Generic;
using System.Text;
using WebCrawlerCore.ViewModels;

namespace WebCrawlerCore.Interfaces
{
    public interface IWebDataInterface
    {
        IEnumerable<UrlContentModel> Get();

        UrlContentModel Get(Guid id);

        void Set(UrlContentModel item);

        void Update(UrlContentModel item);
    }
}
