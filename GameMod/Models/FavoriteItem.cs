using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMod.Models {
    public class FavoriteItem {
        public int Id { get; set; }
        public int ListId { get; set; }
        public int ModId { get; set; }
        public DateTime Created { get; set; }
    }
}