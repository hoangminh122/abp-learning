using Acme.BookStore.Authors;
using Acme.BookStore.MongoDB;
using Acme.BookStore.Parents;
using Acme.BookStore.Parents.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.MongoDB;
using Volo.Abp.MongoDB;

namespace Acme.BookStore.MongoDb.Parents
{
    public class MongoDbParentRepository
        :MongoDbRepository<BookStoreMongoDbContext,Parent,Guid>,
        IParentRepository
    {
        public MongoDbParentRepository(
            IMongoDbContextProvider<BookStoreMongoDbContext> dbContextProvider

            ) :base(dbContextProvider)
        {
        }

        public string testHello()
        {
            throw new NotImplementedException();
        }
    }
}
