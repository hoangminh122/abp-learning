using Acme.BookStore.Permissions;
using Acme.BookStore.Students.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Students
{
    public class StudentAppService : CrudAppService<
            Student, //The Book entity
            StudentDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateStudentDto>, //Used to create/update a book
            IStudentAppService //implement the IBookAppService
    {
        public StudentAppService(IRepository<Student,Guid> repository):base(repository)
        {
            GetPolicyName = BookStorePermissions.Students.Default;
            GetListPolicyName = BookStorePermissions.Students.Default;
            CreatePolicyName = BookStorePermissions.Students.Create;
            UpdatePolicyName = BookStorePermissions.Students.Edit;
            DeletePolicyName = BookStorePermissions.Students.Delete;
        }

        public string test()
        {
            return "Hello Minh";
        }
    }
}
