using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DBWorks.Entities;

namespace DBWorks.Models
{
    public class RandomCarViewModel
    {
        public Employee Employee { get; set; }
        public Car Car { get; set; }
    }
}