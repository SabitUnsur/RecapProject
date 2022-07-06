using RecapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject.Abstract
{
    public abstract class BasePersonService : IPersonService
    {
        public virtual void Delete(Person person)
        {
            Console.WriteLine("Customer has been deleted from the System" + person.FirstName + person.LastName);
        }

        public virtual void Save(Person person)
        {
            Console.WriteLine("Customer has been saved to the system"+" "+person.FirstName+ " "+person.LastName);
        }

        public virtual void Update(Person person)
        {
           Console.WriteLine("Customer has been uptaded to the system"+person.FirstName+ person.LastName);
        }
    }
}
