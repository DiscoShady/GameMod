using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMod.Models {
    public class Game {
        public Game() {
            Active = true;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}