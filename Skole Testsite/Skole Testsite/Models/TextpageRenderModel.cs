using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Skole_Testsite.Mappers;

namespace Skole_Testsite.Models
{
   
    public class TextpageRenderModel : MasterModel
    {
        // bullshity
        public string Header { get; set; }
        public string BodyText { get; set; }
        public List<string> skills { get; set; }
        public List<string> CustomersStorys { get; set; }
        public List<string> CustomerPictures { get; set; }
        public TextpageRenderModel(IPublishedContent page)
        {
            //Set the "master" data on current page.
            MasterMapper.Map(this, page);
        }
    }
}