using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cibrary.Models
{
    public class Borrow
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
    }
}
