using NewProjectRestPrj.Model;
using System;
using System.Collections.Generic;
using System.Threading;

namespace NewProjectRestPrj.Services.Implementation
{
    public class PersonServiceImp : IPersonService
    {
        //Contador responsavel por gerar um fake Id já que ainda não estamos acessando o banco
        private volatile int count;

        //metodo responsavel por criar uma pessoa 
        public Person Create(Person person)
        {
            return person;
            //throw new NotImplementedException();
        }

        //metodo responsavel por retornar uma pessoa
        public void Delete(long Id)
        {
            //throw new NotImplementedException();
        }

        //metodo responsavel por retornar todas as pessoas
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
               
        //metodo responsavel por retornar uma pessoa
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

        //metodo responsavel por atualizar os dados de uma pessoa
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
