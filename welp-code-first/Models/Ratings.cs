using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class Ratings
    {
        public int RatingsID { get; set; }
        public virtual Users UserID { get; set; }
        public virtual Businesses BusinessID { get; set; }
        public int Stars { get; set;}
        public string Reviews { get; set; }
    }
}