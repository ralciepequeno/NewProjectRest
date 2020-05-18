using NewProjectRestPrj.Model;
using System.Collections.Generic;

namespace NewProjectRestPrj.Business.Implementation
{
    public class PersonBusinessImp : IPersonBusiness
    {
        private IPersonRepository _repository;

        public PersonBusinessImp(IPersonRepository repository)
        {
            _repository = repository;
        }

        //metodo responsavel por criar uma pessoa 
        public Person Create(Person person)
        {
            return _repository.Create(person);
            //return person;
        }

        //metodo responsavel por retornar uma pessoa
        public void Delete(long id)
        {
            _repository.Delete(id);
            //return person;
        }

        //metodo responsavel por retornar todas as pessoas
        public List<Person> FindAll()
        {
            return _repository.FindAll();
            //return _repository.FindAll();
        }
               
        //metodo responsavel por retornar uma pessoa
        public Person FindById(long id)
        {
            //return _repository.FindById(id);
            return _repository.FindById(id);
            //return person;
            //return _context.Person.SingleOrDefault(p => p.Id.Equals(Id));
        }

        //metodo responsavel por atualizar os dados de uma pessoa
        public Person Update(Person person)
        {
            return _repository.Update(person);
            //return person;
        }
    }
}
