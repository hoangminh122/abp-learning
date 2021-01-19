using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Students
{
    public class Student : AuditedAggregateRoot<Guid>
    {

        public string Name { get; set; }

        public int CardId { get; set; }

        public DateTime PublishDate { get; set; }

        public StudentType Type { get; set; }

    }
}
