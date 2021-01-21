using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Tests
{
    public class Test : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }
        //private Test()
        //{

        //}
    }
}
