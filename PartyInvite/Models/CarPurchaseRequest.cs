using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvite.Models
{
    public class CarPurchaseRequest
    {
        public string CarManufacturer { get; set; }
        public string CarType { get; set; }
        public string CarModel { get; set; }
        public string YearManufactured { get; set; }

        //public DateTime YearManufactured
        //{
        //    get { return _yearManufactured; }
        //    set
        //    {
        //        _yearManufactured = DateTime.Parse(_yearManufactured.Year.ToString());
        //    }
        //}
        public bool? GetEmailNotification { get; set; }
    }
}