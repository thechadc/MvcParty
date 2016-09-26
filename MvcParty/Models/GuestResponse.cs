using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcParty.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage="Please enter your e-mail address")]
        public string Email { get; set; }
        public string Phone { get; set; }
        [Display(Name="Will you attend?")]
        public bool? WillAttend { get; set; }
    }
}