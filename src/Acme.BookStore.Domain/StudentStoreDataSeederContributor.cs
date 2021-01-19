using Acme.BookStore.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore
{
    class StudentStoreDataSeederContributor
        : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Student, Guid> _bookRepository;

        public StudentStoreDataSeederContributor(IRepository<Student, Guid> bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _bookRepository.GetCountAsync() <= 0)
            {
                await _bookRepository.InsertAsync(
                    new Student
                    {
                        Name = "1984",
                        Type = StudentType.Studied,
                        PublishDate = new DateTime(1949, 6, 8),
                        CardId = 19
                    },
                    autoSave: true
                );

                await _bookRepository.InsertAsync(
                    new Student
                    {
                        Name = "The Hitchhiker's Guide to the Galaxy",
                        Type = StudentType.Studied,
                        PublishDate = new DateTime(1995, 9, 27),
                        CardId = 42
                    },
                    autoSave: true
                );
            }
        }
    }
}
