using NewProjectRestPrj.Model;
using System.Collections.Generic;

namespace NewProjectRestPrj.Services
{
    interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long Id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete (long Id);
    }
}
