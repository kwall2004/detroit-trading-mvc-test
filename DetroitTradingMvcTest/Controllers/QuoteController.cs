using DetroitTradingMvcTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DetroitTradingMvcTest.Controllers {
    /// <summary>
    /// Controller that serves the quoting portion of the website
    /// </summary>
    public class QuoteController : Controller {
        /// <summary>
        /// Index action / landing page
        /// </summary>
        /// <returns>A ViewResult</returns>
        public ViewResult Index() {
            var model = new VehicleViewModel();

            return View(model);
        }

        [HttpPost]
        public PartialViewResult SaveVehicle(VehicleViewModel model) {
            return PartialView("_ThankYou", model);
        }
    }
}