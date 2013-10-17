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
    public class TextpageController : Umbraco.Web.Mvc.RenderMvcController
    {
        // bullshity
        public ActionResult Textpage(RenderModel model)
        {
            TextpageRenderModel nm = new TextpageRenderModel(model.Content);

            nm.Header = "Company Bullshit";
            nm.BodyText = model.Content.GetPropertyValue<string>("bodyText");
            nm.skills = new List<string>();
            nm.CustomersStorys = new List<string>();
            nm.CustomerPictures = new List<string>();
            
            string[] list2 = {"C# Devolupment", "awesome Webpages", "Brillient designs"};
            nm.skills.AddRange(list2);
            string CustomersStorysBull = model.Content.GetPropertyValue<string>("CustomerBullshit");
            list2= CustomersStorysBull.Split(';') ;
            nm.CustomersStorys.AddRange(list2);
            list2 = null;
            string[] listw = { "Content/Img/Customers/jack-sparrow-Customer.jpg", "Content/Img/Customers/mr-burns-Customer.gif", "Content/Img/Customers/obama.png" };
            nm.CustomerPictures.AddRange(listw);
            //Do some stuff here, then return the base method
            return View(nm);
        }
    }
}
