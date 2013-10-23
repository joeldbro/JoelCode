using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JoelCode.Web.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Name { get; set; }

        public string Website { get; set; }

        [Required]
        public string Body { get; set; }

        public virtual Post Post { get; set; }
    }
}