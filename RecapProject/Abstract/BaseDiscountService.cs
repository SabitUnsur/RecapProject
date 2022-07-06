using RecapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject.Abstract
{
    public abstract class BaseDiscountService : IDiscountService
    {
        public void Add(Discount discount)
        {
            Console.WriteLine("Current Discount : " + discount.DiscountOffer);
        }

        public void Delete(Discount discount)
        {
            Console.WriteLine("Offer has not been valid anymore");
        }

        public void Update(Discount discount)
        {
            Console.WriteLine("Offer has been updated, New Discount ID is : " +" "+discount.Id);
        }
    }
}
