using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class Ratings
    {
        public int RatingsID { get; set; }
        public int UserID { get; set; }
        public int BusinessID { get; set; }
        public short? Stars { get; set;}//? makes null available
        
        public string TextReview { get; set; }

        public virtual Users User { get; set; }//sets key
        public virtual Businesses Business { get; set; }
    }
}