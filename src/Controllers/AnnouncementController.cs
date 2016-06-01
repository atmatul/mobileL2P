using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Grp.L2PSite.MobileApp.Models;
using L2PAPIClient.DataModel;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace Grp.L2PSite.MobileApp.Controllers
{
    public class AnnouncementController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            //List<L2PAPIClient.DataModel.L2PAnnouncementElement> announcementlist = L2PAPIClient.api.Calls.L2PviewAllAnnouncements("16ss-03279").Result.dataSet;
            return View();
        }

        
    }
}
