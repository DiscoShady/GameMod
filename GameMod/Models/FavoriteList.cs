using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMod.Models {
    public class FavoriteList {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Creator { get; set; }
        public bool Public { get; set; }
        //collection of items
        public DateTime Created { get; set; }

    }
}