using RecapProject.Abstract;
using RecapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject.Concrete
{
    internal class PersonManager:BasePersonService
    {
        IPersonCheckService _personCheckService;

        public PersonManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Person person)
        {
            if (_personCheckService.CheckIfRealPerson(person))
            {
                base.Save(person);
            }

            else
            {
                throw new Exception("not invalid person");
            }

        }

        public override void Update(Person person)
        {
            if (_personCheckService.CheckIfRealPerson(person))
            {
                base.Update(person);
            }

            else
            {
                throw new Exception("not invalid person");
            }
        }

        public override void Delete(Person person)
        {
            if (_personCheckService.CheckIfRealPerson(person))
            {
                base.Delete(person);
            }

            else
            {
                throw new Exception("not invalid person");
            }
        }




    }
}
