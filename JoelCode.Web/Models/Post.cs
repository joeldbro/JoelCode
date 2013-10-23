using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JoelCode.Web.Models
{
    public class Post
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime EditedDate { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        public virtual User Author { get; set; }
    }
}