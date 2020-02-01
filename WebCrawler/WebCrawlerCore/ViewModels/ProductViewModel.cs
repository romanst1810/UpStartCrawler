using System;
using System.Collections.Generic;
using System.Text;

namespace WebCrawlerCore.Models
{
    public class ProductViewModel
    {
        //Name, Price, Description, Images
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public List<string> Images { get; set; }
        //public string ImageList { get; set; }

        public ProductViewModel()
        {
            this.Images = new List<string>();
        }
    }
}
