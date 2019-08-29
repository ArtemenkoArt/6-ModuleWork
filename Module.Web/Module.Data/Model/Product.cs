using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Data.Model
{
    public class Product : IDeletable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime DeletingDate { get; set; }

        public virtual ICollection<Category> Categories { get; set; }
    }
}
