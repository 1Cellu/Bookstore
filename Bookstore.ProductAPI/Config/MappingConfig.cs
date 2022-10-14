using AutoMapper;
using Bookstore.BookAPI.Data.ValueObjects;
using Bookstore.BookAPI.Model;

namespace Bookstore.BookAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<BookVO, Book>();
                config.CreateMap<Book, BookVO>();
            });
            return mappingConfig;
        }
    }
}
