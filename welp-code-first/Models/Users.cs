using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace welp_code_first.Models
{
    public class Users
    {   
        
        public int UserID { get; set; }
          [MaxLength(50)]
        public string UserName { get; set; }
          [MaxLength (50)]
        public string Password { get; set; }
          [MaxLength(50)]
        public string Email { get; set;}
          [MaxLength(100)]
        public string Address { get; set; }

        //ICollection is for 1 to many or many to many relationships
        public virtual ICollection<Ratings> Ratings { get; set; }
        public virtual ICollection<Businesses> Business { get; set; }
    }

    internal class MaxLengthAttribute : Attribute
    {
        private int v;

        public MaxLengthAttribute(int v)
        {
            this.v = v;
        }
    }
}