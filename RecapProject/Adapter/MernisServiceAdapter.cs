using RecapProject.Abstract;
using RecapProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapProject.Adapter
{
    public class MernisServiceAdapter:IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            MernisServiceReference.KPSPublicSoapClient client = new MernisServiceReference.KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(person.NationalityId,person.FirstName.ToUpper(),
                person.LastName.ToUpper(), person.DateOfBirth);
        }
    }
}
