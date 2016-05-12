namespace DetroitTradingMvcTest {
    using Models;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Xml.Serialization;
    /// <summary>
    /// Provides vehicle information
    /// </summary>
    public class VehicleController : ApiController {
        /// <summary>
        /// Returns vehicle makes
        /// api/vehicle/makes
        /// </summary>
        /// <returns>An IEnumberable of vehicle makes</returns>
        [HttpGet]
        public IEnumerable<MakeTable.Make> Makes() {
            MakeTable list;

            XmlSerializer serializer = new XmlSerializer(typeof(MakeTable));
            using (FileStream fileStream = new FileStream(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/makes.xml"), FileMode.Open)) {
                list = (MakeTable)serializer.Deserialize(fileStream);
            }

            return list.Makes;
        }

        /// <summary>
        /// Returns vehicle models
        /// api/vehicle/models
        /// </summary>
        /// <returns>An IEnumberable of vehicle models by make ID</returns>
        [HttpGet]
        public IEnumerable<ModelTable.Make.Model> Models(int id) {
            ModelTable list;

            XmlSerializer serializer = new XmlSerializer(typeof(ModelTable));
            using (FileStream fileStream = new FileStream(System.Web.Hosting.HostingEnvironment.MapPath(@"~/App_Data/modelsbymake.xml"), FileMode.Open)) {
                list = (ModelTable)serializer.Deserialize(fileStream);
            }

            return from make in list.Makes
                   from models in make.Models
                   where make.Id == id
                   select models;
        }
    }
}