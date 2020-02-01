using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using WebCrawlerCore.ViewModels;

namespace WebCrawler.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        public ActionResult<string> GetUrlContent(WebCrawlerCore.UrlContentRequestModel request)
        {
            //if (string.IsNullOrEmpty(request.HtmlUrl) && string.IsNullOrEmpty(request.WebhookUrl))
            //{
            //    var message = string.Format("request values can't be null or empty : WebhookHtml={0} , HtmlUrl={1}", request.WebhookUrl, request.HtmlUrl);
            //    HttpError err = new HttpError(message);
            //    return Request.CreateResponse(HttpStatusCode.NotFound, err);
            //}

            //UrlContentModel item = UrlContentHandler.PrepareNewItemContentModel(request.HtmlUrl, request.WebhookUrl);
            //// save new item
            //Services.DataServiceWrapper ds = new Services.DataServiceWrapper();
            //ds.Set(item);
            //// Send message to MSMQ
            //Services.RequestQServiceWrapper rs = new Services.RequestQServiceWrapper();
            //item.QPath = @".\Private$\RequestQ";
            //item.QMessage = item.Id + "," + item.HtmlUrl;
            //rs.Send(item);

            return "success";
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
