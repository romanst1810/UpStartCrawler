using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebCrawlerCore.Interfaces;
using WebCrawlerCore.ViewModels;
using WebCrawlerDataAccess;

namespace RestCrawler.ServiceWrappers
{
    public class DataServiceWrapper
    {
        IWebDataInterface DBService { get; set; }
        public DataServiceWrapper()
        {
            DBService = new DataAccessService();
        }

        public IEnumerable<UrlContentModel> Get()
        {
            return DBService.Get();
        }

        public UrlContentModel Get(Guid id)
        {
            return DBService.Get(id);
        }

        public void Set(UrlContentModel item)
        {
            DBService.Set(item);
        }

        public void Update(UrlContentModel item)
        {
            DBService.Update(item);
        }
    }
}
