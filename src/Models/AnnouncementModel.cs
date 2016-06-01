using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grp.L2PSite.MobileApp.Models
{
    public class AnnouncementModel
    {
        public int cid { get ; set;}
        public int itemid { get; set; }
        public string downloadurl { get; set; }
        public string filename { get; set; }
        public int filesize { get; set; }
        public DateTime createdtime { get; set; }
        public DateTime modifytime { get; set; }
        public int createdby_id { get; set; }
        public string subject { get; set; }
    }
}
