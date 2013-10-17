using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Skole_Testsite.Models.HelperModels;

namespace Skole_Testsite.Models
{
    public class MasterModel
    {
        public IEnumerable<NavigationItem> MainNavigation { get; set; }
    }
}