
using System;
using System.Collections.Generic;
namespace NamFireAPI.Models {

    public class Level {
        public string id { get; set; }
        public string name { get; set; }
        public List<Room> room { get; set; }
    }
}