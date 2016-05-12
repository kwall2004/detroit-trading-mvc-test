using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DetroitTradingMvcTest.Models {
    public class VehicleViewModel {
        [DisplayName("Make")]
        [Range(1, int.MaxValue, ErrorMessage = "The Make field is required")]
        public int MakeId { get; set; }

        [DisplayName("Model")]
        [Range(1, int.MaxValue, ErrorMessage = "The Model field is required")]
        public int ModelId { get; set; }
    }
}