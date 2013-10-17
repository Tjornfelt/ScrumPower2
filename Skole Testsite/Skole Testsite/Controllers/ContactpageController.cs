using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skole_Testsite.Models;
using Umbraco.Web.Models;
using Umbraco.Web;

namespace Skole_Testsite.Controllers
{
    public class ContactpageController : Umbraco.Web.Mvc.RenderMvcController
    {
        public ActionResult Contactpage(RenderModel model)
        {
            var page = model.Content;
            ContactpageRenderModel newModel = new ContactpageRenderModel(page);

            newModel.Header = model.Content.GetPropertyValue<string>("header");
            newModel.BodyText = model.Content.GetPropertyValue<string>("bodyText");
            newModel.Navn = model.Content.GetPropertyValue<string>("Navn");
            newModel.Adresse = model.Content.GetPropertyValue<string>("Adresse");
            newModel.Postnr = model.Content.GetPropertyValue<string>("Postnr");
            newModel.Fødselsdag = model.Content.GetPropertyValue<string>("BirthDay");
            newModel.Hårfarve = model.Content.GetPropertyValue<string>("Haircolour");
            //Do some stuff here, then return the base method
            return View(newModel);
        }
    }
}
