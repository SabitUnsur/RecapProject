using RecapProject.Abstract;
using RecapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject.Concrete
{
    public class CheckPersonManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            return true;
        }
    }
}
