using Module.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Logic
{
    public class MyRepository : IRepositories
    {
        public List<ProductCategoryLogic> GetList()
        {
            //List<ProductCategoryWeb> productCategories = new List<ProductCategoryWeb>();
            List<ProductCategoryLogic> result = null;
            using (var db = new MyContext())
            {
                result = db.Products.Join(db.Categories,
                                            p => p.Id,
                                            c => c.Id,
                                            (p, c) => new ProductCategoryLogic()
                                            { CategoryName = c.Name,
                                                ProductName = p.Name }
                                            ).ToList();
            };

            if (result != null)
            {
                return result;
            }
            else
            {
                return new List<ProductCategoryLogic>();
            }
            
        }
    }
}
