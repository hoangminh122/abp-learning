using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Parents.Interfaces
{
    public interface IParentRepository: IRepository<Parent,Guid>
    {
        public string testHello();
        
    }
}
