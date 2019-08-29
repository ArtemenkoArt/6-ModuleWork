using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Logic
{
    public interface IRepositories
    {
        List<ProductCategoryLogic> GetList();
    }
}
