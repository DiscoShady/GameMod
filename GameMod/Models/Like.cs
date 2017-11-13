using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMod.Models {
    public class Like {
        public int Id { get; set; }
        public int Post_Id { get; set; }
        public string User_Id { get; set; }
        public DateTime Date { get; set; }
    }
}