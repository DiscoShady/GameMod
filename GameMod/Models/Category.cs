using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMod.Models {
    public class Category {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Mod> Mod { get; set; }
        public Game Game { get; set; }
    }
}