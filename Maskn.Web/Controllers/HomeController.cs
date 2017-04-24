﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Maskn.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MasknControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}