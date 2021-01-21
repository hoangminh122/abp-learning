using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Parents
{
    public class Parent : FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

    }
}
