using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skole_Testsite.Models;
using Umbraco.Web.Models;
using Umbraco.Web;
using Umbraco.Web.Mvc;
using Skole_Testsite.Models.HelperModels;

namespace Skole_Testsite.Controllers
{
    public class UserActionsController : Umbraco.Web.Mvc.SurfaceController
    {
        public string CreateUser(CreateReviewUserForm form)
        {
            return "Hello!";
        }
    }
}
