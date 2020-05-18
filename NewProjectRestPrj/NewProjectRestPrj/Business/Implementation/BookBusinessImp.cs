using NewProjectRestPrj.Data.Converters;
using NewProjectRestPrj.Data.VO;
using NewProjectRestPrj.Model;
using NewProjectRestPrj.Repository.Generic;
using System.Collections.Generic;

namespace NewProjectRestPrj.Business.Implementation
{
    public class BookBusinessImp : IBookBusiness
    {
        private IRepository<Book> _repository;
        private readonly BookConverter _converter;

        public BookBusinessImp(IRepository<Book> repository)
        {
            _repository = repository;
            _converter = new BookConverter();
        }

        

        //metodo responsavel por criar uma pessoa 
        public BookVO Create(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Create(bookEntity);
            return _converter.Parse(bookEntity);
        }

        //metodo responsavel por retornar uma pessoa
        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        //metodo responsavel por retornar todas as pessoas
        public List<BookVO> FindAll()
        {
            return _converter.ParseList(_repository.FindAll());
        }

        //metodo responsavel por retornar uma pessoa
        public BookVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        //metodo responsavel por atualizar os dados de uma pessoa
        public BookVO Update(BookVO book)
        {
            var bookEntity = _converter.Parse(book);
            bookEntity = _repository.Update(bookEntity);
            return _converter.Parse(bookEntity);
        }

        public bool Exists(long id)
        {
            return _repository.Exists(id);
        }
    }
}
