using NewProjectRestPrj.Business;
using NewProjectRestPrj.Model;
using NewProjectRestPrj.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace NewProjectRestPrj.Business.Implementation
{
    public class BookRepositoryImp : IBookRepository
    {
        private MySQLContext _context;

        public BookRepositoryImp(MySQLContext context)
        {
            _context = context;
        }

        //metodo responsavel por criar uma pessoa 
        public Book Create(Book book)
        {
            try
            {
                _context.Add(book);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return book;
        }

        //metodo responsavel por retornar uma pessoa
        public void Delete(long Id)
        {
            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(Id));
            try
            {
                if (result != null) _context.Books.Remove(result);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            //return person;
        }

        //metodo responsavel por retornar todas as pessoas
        public List<Book> FindAll()
        {
            return _context.Books.ToList();
        }
               
        //metodo responsavel por retornar uma pessoa
        public Book FindById(long Id)
        {
            return _context.Books.SingleOrDefault(p => p.Id.Equals(Id));
        }

        //metodo responsavel por atualizar os dados de uma pessoa
        public Book Update(Book book)
        {
            if (!Exists(book.Id)) return null;

            var result = _context.Books.SingleOrDefault(p => p.Id.Equals(book.Id));
            try
            {
                _context.Entry(result).CurrentValues.SetValues(book);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

        public bool Exists(long? id)
        {
            return _context.Books.Any(p => p.Id.Equals(id));
        }
    }
}
