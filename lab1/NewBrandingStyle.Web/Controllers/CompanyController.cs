using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewBrandingStyleWeb.Models;

namespace NewBrandingStyleWeb.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(NewBrandingStyle.Web.Models.CompanyModel company)
        {
            var viewModel = new CompanyAddedViewModel
            {
                NumberOfCharInName = company.Name.Length,
                NumberOfCharsInDescription = company.Description.Length,
                IsHidden = !company.IsVisible
            };

            return View("CompanyModel", viewModel);
        }
    }
}