using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eClerx.Program3.Kishore.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string MobileNo { get; set; }
        public string EmailId { get; set; }
        public DateTime CraetedDate { get; set; } = DateTime.Now;
        public DateTime Modifieddate { get; set; }
    }
}