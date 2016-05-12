using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace DetroitTradingMvcTest.Models {
    [XmlRoot("makes")]
    public class MakeTable {
        [XmlElement("make")]
        public List<Make> Makes { get; set; }

        public class Make {
            [XmlAttribute("id")]
            public int Id { get; set; }

            [XmlAttribute("description")]
            public string Description { get; set; }
        }
    }
}