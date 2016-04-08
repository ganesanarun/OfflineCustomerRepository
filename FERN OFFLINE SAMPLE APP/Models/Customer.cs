using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FERN_OFFLINE_SAMPLE_APP.Models
{
    public class Customer
    {
        public int CustomerID       { get; set; }
        public string CustomerName  { get; set; }
        public string Address       { get; set; }
        public string Mobile        { get; set; }
    }
}