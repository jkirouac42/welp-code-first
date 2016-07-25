using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class Businesses
    {
        public int BusinessID { get; set; }
        public string BusinessName { get; set; }
        public int BusinessTypeID { get; set; }
        public string Address { get; set; }
        public string Hours { get; set; }
        public string Phone { get; set; }
        public string Menu { get; set; }

        public virtual Users User { get; set; }

    }

    
}