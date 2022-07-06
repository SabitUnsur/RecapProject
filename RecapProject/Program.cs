using RecapProject.Abstract;
using RecapProject.Adapter;
using RecapProject.Concrete;
using RecapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game { Id=1,Name="Battlefield V",Cost=469};

            Discount discount = new Discount { Id = 1, Name = "Winter Sales", DiscountOffer = 228 };

            Person person = new Person { Id=1,FirstName="Sabit",LastName="Ünsür",DateOfBirth=2002,NationalityId=5465451 };

            BasePersonService basePersonService = new PersonManager(new CheckPersonManager());
            basePersonService.Save(person);

            BaseDiscountService baseDiscountService = new DiscountManager();
            baseDiscountService.Add(discount);

            BaseSalesService baseSalesService=new SalesManager();

            if (discount.DiscountOffer > 1)
            {
                baseSalesService.SaleByDiscount(game, discount, person);
            }

            else
            {
                baseSalesService.SaleNotDiscount(game, person);
            }




        }
    }
}
