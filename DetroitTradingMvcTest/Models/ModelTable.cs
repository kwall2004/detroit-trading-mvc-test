using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DetroitTradingMvcTest.Models {
    [XmlRoot("modelsbymake")]
    public class ModelTable {
        [XmlElement("make")]
        public List<Make> Makes { get; set; }

        public class Make {
            [XmlAttribute("id")]
            public int Id { get; set; }

            [XmlElement("model")]
            public List<Model> Models { get; set; }

            public class Model {
                [XmlAttribute("id")]
                public int Id { get; set; }

                [XmlAttribute("description")]
                public string Description { get; set; }
            }
        }
    }
}