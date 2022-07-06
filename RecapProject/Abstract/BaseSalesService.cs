using RecapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject.Abstract
{
    public abstract class BaseSalesService : ISalesService
    {
        public void SaleByDiscount(Game game, Discount discount, Person person)
        {
            Console.WriteLine(person.FirstName + "has bought the game" +" " +  game.Name + " "+ "Total Price" + " "+(game.Cost - discount.DiscountOffer));
        }

        public void SaleNotDiscount(Game game, Person person)
        {
            Console.WriteLine(person.FirstName + "bought the game" + "  " +game.Name);
        }
    }
}
