using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
