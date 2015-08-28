using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.ViewModels;

namespace Test1.Filters
{
    public class HeaderFooterFilter : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var v = filterContext.Result as ViewResult;
            // v will null when v is not a ViewResult
            if (v == null) 
                return;
            
            var bvm = v.Model as BaseViewModel;
            //bvm will be null when we want a view without Header and footer
            if (bvm == null) 
                return;
            
            bvm.UserName = HttpContext.Current.User.Identity.Name;
            bvm.FooterData = new FooterViewModel();
            bvm.FooterData.CompanyName = "StepByStepSchools";//Can be set to dynamic value
            bvm.FooterData.Year = DateTime.Now.Year.ToString();
        }
    }
}