using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApiClient.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Display(Name="Name")]
        public string Name { get; set; }
        [Display(Name="Address1")]
        public string Address1 { get; set; }
        [Display(Name="Address2")]
        public string Address2 { get; set; }
        [Display(Name = "Address3")]
        public string Address3 { get; set; }
        [Display(Name = "Location")]
        public string Location { get; set; }
        [Display(Name = "PhoneNumber")]
        public string PhoneNumber { get; set; }
    }
}