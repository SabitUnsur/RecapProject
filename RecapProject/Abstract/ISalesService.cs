using RecapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject.Abstract
{
    public interface ISalesService
    {  
        void SaleByDiscount(Game game, Discount discount, Person person);
        void SaleNotDiscount(Game game, Person person);
    }
}
