using Microsoft.AspNet.Mvc;

namespace Grp.L2PSite.MobileApp.Controllers
{
    public class MyCourseFilesController : Controller
    {
 
        public IActionResult Hyperlinks()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        public IActionResult SharedDocuments()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        public IActionResult Literature()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        public IActionResult MediaLibrary()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }
        public IActionResult Announcement()
        {
            ViewData["Message"] = "Announcements";
            //int cid = L2PAPIClient.api.Calls.L2PviewAllCourseIfoBySemesterAsync("SS16");
            return View();
        }
        public IActionResult AddAnnouncement()
        {
            ViewData["Message"] = "Add Announcements";
            return View();
        }
    }
}
