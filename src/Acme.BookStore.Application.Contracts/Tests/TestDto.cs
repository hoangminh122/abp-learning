using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Tests
{
    public class TestDto : AuditedEntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
