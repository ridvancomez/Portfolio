using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string CoverLetter { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
        public string Content { get; set; }

        public ICollection<Comment> Comments { get; set; }

    }
}
