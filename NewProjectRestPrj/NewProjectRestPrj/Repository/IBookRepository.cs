using NewProjectRestPrj.Model;
using System.Collections.Generic;

namespace NewProjectRestPrj.Business
{
    public interface IBookRepository
    {
        Book Create(Book book);
        Book FindById(long Id);
        List<Book> FindAll();
        Book Update(Book book);
        void Delete (long Id);

        //bool Exists(long? id);
        bool Exists(long? id);
    }
}
