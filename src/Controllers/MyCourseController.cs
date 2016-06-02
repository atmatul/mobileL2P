using Microsoft.AspNet.Mvc;
using System.Threading.Tasks;

namespace Grp.L2PSite.MobileApp.Controllers
{
    public class MyCourseController : Controller
    {
        public static string selectedcourse_id;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowSubject(string id)
        {
            ViewData["CourseId"] = id;
            selectedcourse_id = id;
            return View();
        }



        public IActionResult LearningMaterials()
        {
            return View();
        }
        public IActionResult SharedDocuments()
        {
            return View();
        }

        public IActionResult Hyperlinks()
        {
            return View();
        }

        public IActionResult Literature()
        {
            return View();
        }
        public IActionResult MediaLibrary()
        {
            return View();
        }

        public IActionResult Assignments()
        {
            return View();
        }
        public IActionResult Announcement()
        {
            ViewData["CourseId"] = selectedcourse_id;
            return View();
        }
        public IActionResult AddAnnouncement()
        {
            ViewData["CourseId"] = selectedcourse_id;
            return View();
        }
        public IActionResult AddLiterature()
        {
            ViewData["CourseId"] = selectedcourse_id;
            return View();
        }
        public IActionResult AddHyperlink()
        {
            ViewData["CourseId"] = selectedcourse_id;
            return View();
        }

    }
}
