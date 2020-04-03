using NewProjectRestPrj.Model;
using NewProjectRestPrj.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;

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
        }

        //metodo responsavel por retornar uma pessoa
        public void Delete(long Id)
        {
            _repository.Delete(Id);
        }

        //metodo responsavel por retornar todas as pessoas
        public List<Person> FindAll()
        {
            return _repository.FindAll();
        }
               
        //metodo responsavel por retornar uma pessoa
        public Person FindById(long Id)
        {
            return _repository.FindById(Id);
        }

        //metodo responsavel por atualizar os dados de uma pessoa
        public Person Update(Person person)
        {
            return _repository.Update(person);
        }
    }
}
