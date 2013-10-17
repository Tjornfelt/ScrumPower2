using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Skole_Testsite.Models;
using Skole_Testsite.Models.HelperModels;
using Umbraco.Core.Models;
using Umbraco.Web;

namespace Skole_Testsite.Mappers
{
    public static class MasterMapper
    {
        //Here we are able to map data into the MasterModel
        //The only requirement is that the model we feed to this method inherits from MasterModel
        public static TModel Map<TModel>(TModel model, IPublishedContent currentPage)
        where TModel : MasterModel
        {
            var frontPage = currentPage.AncestorOrSelf(1);

            List<NavigationItem> mainNavigation = new List<NavigationItem>();

            foreach (var page in frontPage.Children)
            {
                NavigationItem n = new NavigationItem();

                n.Name = page.Name;
                n.Url = page.Url;

                mainNavigation.Add(n);
            }
            model.MainNavigation = mainNavigation;
            return model;
        }
    }
}