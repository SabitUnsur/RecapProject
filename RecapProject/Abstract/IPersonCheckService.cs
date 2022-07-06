using RecapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Person person);


    }
}
