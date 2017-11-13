using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameMod.Models {
    public class Mod {
        public Mod() {
            DateAdded = DateTime.Now;
            Hidden = false;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CoverImg { get; set; }
        public string DownloadLink { get; set; }
        public ICollection<Image> Images { set; get; }
        public string VideoURL { get; set; }
        public string Credits { get; set; }
        public string UserID { get; set; }
        public int Views { get; set; }
        //orginalLink?
        public Category Category { get; set; }
        public DateTime DateAdded { get; set; }
        public int Downloads { get; set; }
        public int Version { get; set; }
        public int FileSize { get; set; }
        public bool Hidden { get; set; }
    }
}