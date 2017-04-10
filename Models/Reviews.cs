using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TechXii.Models
{
    public class Reviews
    { [Key]
        public int ID { get; set; }//this is your key and your primary id
        public string TitleOfReview { get; set; }
        public string AuthorOfReview { get; set; }
        public string ReviewDescription { get; set; }
        public string CategoryIdForKey { get; set; }
        public DateTime ReviewPostTime { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}