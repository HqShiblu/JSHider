using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JSHider.Models;

namespace JSHider.Controllers
{
    public class JSHiderController : Controller
    {
        public ActionResult Index()
        {
            Random randomNumber = new Random();
            string jsKey = "abcdfdfsfd";
            jsKey = randomNumber.Next(9999).ToString()+"maoxvtay";
            JSSaver.jsKey = jsKey;
            JSSaver.keyUsed = false;
            ViewBag.Key = jsKey;
            return View();
        }

        public string ShowJS(string key)
        {
            if (key == JSSaver.jsKey && JSSaver.keyUsed == false)
            {
                JSSaver.keyUsed = true;
                string filePath = System.Web.Hosting.HostingEnvironment.MapPath("~/Scripts/myScript.js");
                string jsContent = System.IO.File.ReadAllText(filePath);
                return jsContent;
            }
                return "";            
        }
    }
}