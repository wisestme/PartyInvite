using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvite.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Abeg put your email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "How you want make we take call you now?")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "We need to know whether make we keep food for you")]
        public bool? WillAttend { get; set; }
    }
}