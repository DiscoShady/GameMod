using GameMod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using GameMod.Extensions;
using System.IO;

namespace GameMod.Controllers {
    public class HomeController : Controller {

        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index() {
            var modsInDb = db.Mods.ToList();
            return View(modsInDb);
        }

        public PartialViewResult _PageChange() {
            return PartialView(db.Mods.ToList().Count());
        }


        public ActionResult Mod(int id) {
            //var modName = Helper.ReplaceAllSpaces(name);
            var findMod = db.Mods.Where(x => x.Id == id).SingleOrDefault();
            return View(findMod);
        }
        //websitename.com/mod/1113-name
        public ActionResult Upload() {
            var data = new BaseInfoViewModel() {
                Games = db.Games.ToList(),
                Categories = db.Categories.ToList()
            };
            return View(data);
        }
        [HttpPost]
        public ActionResult Upload(Mod mod, IEnumerable<HttpPostedFileBase> images) {
            string CurrentUserId = User.Identity.GetUserId();
            db.Mods.Add(new Mod {
                Name = mod.Name,
                Description = mod.Description,
                DownloadLink = mod.DownloadLink,
                VideoURL = mod.VideoURL,
                Credits = mod.Credits,
                Version = mod.Version,
                UserID = CurrentUserId
            });
            string fName = "";
            foreach (string fileName in Request.Files) {
                HttpPostedFileBase file = Request.Files[fileName];
                fName = file.FileName;
                if (file != null && file.ContentLength > 0) {
                    var path = Path.Combine(Server.MapPath("~/Content/Images/"));
                    string pathString = Path.Combine(path.ToString());
                    var fileName1 = Path.GetFileName(file.FileName);
                    bool isExists = Directory.Exists(pathString);
                    if (!isExists) Directory.CreateDirectory(pathString);
                    var uploadpath = string.Format("{0}\\{1}", pathString, file.FileName);
                    file.SaveAs(uploadpath);
                }
            }
            return View();
        }


        [HttpPost]
        public ActionResult Like(int PostId) {

            db.Likes.Add(new Like {
                Post_Id = PostId,
                User_Id = User.Identity.GetUserId(),
                Date = DateTime.Now
            });

            db.SaveChanges();
            return Json(new { success = true });
        }

    }

}