using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PragimASP.Models
{
    public class Appliances
    {
        public int ApplianceID { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string DateInstalled { get; set; }
    }
}