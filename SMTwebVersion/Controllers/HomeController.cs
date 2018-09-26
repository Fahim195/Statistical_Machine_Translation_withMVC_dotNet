using SMTwebVersion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMTwebVersion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Translate(string sourceLanguage)
        {
            posTaggingPhase aPostaggingPhase = new posTaggingPhase();
            string sentence= aPostaggingPhase.postaggingAND_translation(sourceLanguage);
            return Content(sentence,"text/plain");
        }

    }
}