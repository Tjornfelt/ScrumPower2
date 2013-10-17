using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Umbraco.Core.Models;
using Skole_Testsite.Mappers;
namespace Skole_Testsite.Models
{
    public class ContactpageRenderModel : MasterModel
    {
        public string Header { get; set; }
        public string BodyText { get; set; }
        public string Navn { get; set; }
        public string Adresse { get; set; }
        public string Postnr { get; set; }
        public string Fødselsdag { get; set; }
        public string Hårfarve { get; set; }   
        
        public ContactpageRenderModel(IPublishedContent page)
        {
            //Set the "master" data on current page.
            MasterMapper.Map(this, page);
        }
    }

        
}