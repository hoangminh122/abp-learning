using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Students
{
    public class StudentDto: AuditedEntityDto<Guid>
    {

        public string Name { get; set; }

        public int CardId { get; set; }

        public DateTime PublishDate { get; set; }

        public StudentType Type { get; set; }
    }
}
