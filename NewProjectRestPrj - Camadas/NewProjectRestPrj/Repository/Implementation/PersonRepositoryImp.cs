using NewProjectRestPrj.Business;
using NewProjectRestPrj.Model;
using NewProjectRestPrj.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NewProjectRestPrj.Business.Implementation
{
    public class PersonRepositoryImp : IPersonRepository
    {
        private MySQLContext _context;

        public PersonRepositoryImp(MySQLContext context)
        {
            _context = context;
        }

        //metodo responsavel por criar uma pessoa 
        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        //metodo responsavel por retornar uma pessoa
        public void Delete(long Id)
        {
            var result = _context.Person.SingleOrDefault(p => p.Id.Equals(Id));
            try
            {
                if (result == null) _context.Person.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //return person;
        }

        //metodo responsavel por retornar todas as pessoas
        public List<Person> FindAll()
        {
            return _context.Person.ToList();
        }
               
        //metodo responsavel por retornar uma pessoa
        public Person FindById(long Id)
        {
            return _context.Person.SingleOrDefault(p => p.Id.Equals(Id));
        }

        //metodo responsavel por atualizar os dados de uma pessoa
        public Person Update(Person person)
        {
            if (!Exists(person.Id)) return null;

            var result = _context.Person.SingleOrDefault(p => p.Id.Equals(person.Id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(person);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return person;
        }

        public bool Exists(long? id)
        {
            return _context.Person.Any(p => p.Id.Equals(id));
            //throw new NotImplementedException();
        }
    }
}
