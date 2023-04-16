using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai5._2.Models
{
    public class Mail
    {
        public string mailFrom { get; set; }
        public string password { get; set; }
        public string mailTo { get; set; }
        public string subject { get; set; }
        public string message { get; set; }
    }
}