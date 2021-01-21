using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Students.Interface
{
    public interface IStudentAppService :ICrudAppService<
            StudentDto,
            Guid,
            PagedAndSortedResultRequestDto,
            CreateUpdateStudentDto
            >
    {
        public string test();
    }
}
