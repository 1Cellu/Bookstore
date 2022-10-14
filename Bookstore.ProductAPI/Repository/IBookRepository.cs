using Bookstore.BookAPI.Data.ValueObjects;

namespace Bookstore.BookAPI.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<BookVO>> FindAll();

        Task<BookVO> FindById(long id);

        Task<BookVO> Create(BookVO vo);

        Task<BookVO> Update(BookVO vo);

        Task<bool> Delete(long id);
    }
}
