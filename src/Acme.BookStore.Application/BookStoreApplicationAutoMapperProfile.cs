using Acme.BookStore.Authors;
using Acme.BookStore.Authors.dto;
using Acme.BookStore.Students;
using AutoMapper;

namespace Acme.BookStore
{
    public class BookStoreApplicationAutoMapperProfile : Profile
    {
        public BookStoreApplicationAutoMapperProfile()
        {

            CreateMap<Student, StudentDto>();
            CreateMap<CreateUpdateStudentDto,Student>();

            CreateMap<Author, AuthorDto>();

            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
        }
    }
}

