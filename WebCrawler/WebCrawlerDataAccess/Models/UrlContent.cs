using System;
using System.Collections.Generic;

namespace WebCrawler.Models
{
    public partial class UrlContent
    {
        public Guid Id { get; set; }
        public string HtmlUrl { get; set; }
        public string WebhookUrl { get; set; }
        public string ResultHtml { get; set; }
        public DateTime? CreateDate { get; set; }
        public string Qpath { get; set; }
        public string Qmessage { get; set; }
        public string UrlContentStatus { get; set; }
    }
}
