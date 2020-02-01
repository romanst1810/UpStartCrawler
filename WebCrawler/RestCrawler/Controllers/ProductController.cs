using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestCrawler.ServiceWrappers;
using WebCrawlerCore.Interfaces;
using WebCrawlerCore.ViewModels;

namespace RestCrawler.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Hello";
        }

        public string GetUrlContent(UrlContentModel request)
        {
            DataServiceWrapper ds = new DataServiceWrapper();
            ds.Set(request);
            // Send message to MSMQ
            RequestQServiceWrapper rs = new RequestQServiceWrapper();
            request.QMessage = request.Id + "," + request.HtmlUrl;
            rs.Send(request);

            return "success";
        }
    }
}
