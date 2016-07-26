using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class BusinessTypes
    {
        public virtual Businesses BusinessTypeID { get; set; }
        public string BusinessTypeName { get; set; }

        public virtual ICollection<Businesses> Business { get; set; }
    }
}