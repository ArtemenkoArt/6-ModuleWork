using Module.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Data
{
    public class MyContext : ModuleBase
    {
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries<IDeletable>().Where(x => x.State == EntityState.Deleted))
            {
                entry.Entity.IsDeleted = true;
                entry.Entity.DeletingDate = DateTime.Now;
                entry.State = EntityState.Modified;
            }
            return base.SaveChanges();
        }
    }
}
