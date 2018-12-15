using System;
using System.Collections.Generic;
namespace NamFireAPI.Models {

    public class Building {
        public string id { get; set; }
        public string name { get; set; }
        public List<Level> level { get; set; }
    }
}