using System;
using System.Collections.Generic;
using System.Text;
using WebCrawlerCore.Interfaces;
using WebCrawlerCore.ViewModels;

namespace WebCrawlerDataAccess
{
    public class DataAccessService : IWebDataInterface
    {
        public IEnumerable<UrlContentModel> Get()
        {
            throw new NotImplementedException();
        }

        public UrlContentModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Set(UrlContentModel item)
        {
            throw new NotImplementedException();
        }

        public void Update(UrlContentModel item)
        {
            throw new NotImplementedException();
        }
    }
}
