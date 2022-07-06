using RecapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject.Abstract
{
    public interface IPersonService 
    {
        void Save(Person person);
        void Update(Person person);
        void Delete(Person person);
    }
}
