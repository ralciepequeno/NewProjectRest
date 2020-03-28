using NewProjectRestPrj.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace NewProjectRestPrj.Services.Implementation
{
    public class PersonServiceImp : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
            //throw new NotImplementedException();
        }

        public void Delete(long Id)
        {
            //throw new NotImplementedException();
        }

        public List<Person> FindAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPearson(i);
                persons.Add(person);
            }
            return persons;
        }
               
        //Ira retornar uma nova instancia de pessoa
        public Person FindById(long Id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Name",
                LastName = "Surname",
                Addres = "My Addres",
                Gender = "Male"
            };            
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPearson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Name" + i,
                LastName = "Surname" + i,
                Addres = "My Addres" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
