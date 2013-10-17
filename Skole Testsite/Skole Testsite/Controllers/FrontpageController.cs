using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skole_Testsite.Models;
using Umbraco.Web.Models;
using Umbraco.Web;
using Umbraco.Core.Models;
using Skole_Testsite.Models.HelperModels;
using Skole_Testsite.Mappers;

namespace Skole_Testsite.Controllers
{
    public class FrontpageController : Umbraco.Web.Mvc.RenderMvcController
    {
        public ActionResult Frontpage(RenderModel model)
        {
            IPublishedContent page = model.Content;
            FrontpageRenderModel newModel = new FrontpageRenderModel(page);

            newModel.Header = page.GetPropertyValue<string>("header");
            newModel.Bodytext = page.GetPropertyValue<IHtmlString>("bodyText");
            newModel.CreateReviewUserForm = new CreateReviewUserForm();


            var slideFolder = Umbraco.TypedMedia(page.GetPropertyValue<int>("slideFolder"));

            if (slideFolder != null)
            {
                List<Slide> slides = new List<Slide>();

                foreach (var image in slideFolder.Children)
                {
                    Slide s = new Slide();

                    s.ImageUrl = image.Url;
                    slides.Add(s);
                }
                newModel.Slides = slides;
            }




            //Do some stuff here, then return the base method
            return View(newModel);
        }
    }
}
