using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public int ZipCode { get; set; }
        public string PickUpDay { get; set; }
        public double BalanceDue { get; set; }
        public DateTime ExtraPickUp { get; set; }
        public DateTime StartSuspendService { get; set; }
        public DateTime EndSuspendService { get; set; }

    }
}