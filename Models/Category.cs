using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechXii.Models
{
    public class Category
    {
        //look at bookshelf hav ur key then ur properties     
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Reviews> Review { get; set; }
    }
}