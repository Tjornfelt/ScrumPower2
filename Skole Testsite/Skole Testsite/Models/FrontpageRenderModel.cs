using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Skole_Testsite.Models.HelperModels;
using Skole_Testsite.Mappers;
using Umbraco.Core.Models;
using Skole_Testsite.Models.HelperModels;

namespace Skole_Testsite.Models
{
    public class FrontpageRenderModel : MasterModel
    {
        public string Header { get; set; }
        public IHtmlString Bodytext { get; set; }
        public IEnumerable<Slide> Slides { get; set; }
        public CreateReviewUserForm CreateReviewUserForm { get; set; }

        public FrontpageRenderModel(IPublishedContent page)
        {
            //Set the "master" data on current page.
            MasterMapper.Map(this, page);
        }
    }
}