using Acme.BookStore.Authors;
using Acme.BookStore.Authors.Interfaces;
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
    class AuthorStoreDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<Student, Guid> _studentRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly AuthorManager _authorManager;

        public AuthorStoreDataSeederContributor(
            IRepository<Student,Guid> studentRepository,
            IAuthorRepository authorRepository,
            AuthorManager authorManager
        )
        {
            _studentRepository = studentRepository;
            _authorRepository = authorRepository;
            _authorManager = authorManager;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if(await _studentRepository.GetCountAsync() <= 0)
            {
                await _studentRepository.InsertAsync(
                    new Student
                    {
                        Name = "1984",
                        Type = StudentType.Studying,
                        PublishDate = new DateTime(1949,6,8),
                        CardId = 1
                    },
                    autoSave:true
                );

                await _studentRepository.InsertAsync(
                    new Student
                    {
                        Name = "The Hit Guider to the Galaxy",
                        Type = StudentType.Studied,
                        PublishDate = new DateTime(1994,9,23),
                        CardId = 6
                    },
                    autoSave:true
                );
            }

            //added seed data for author

            if (await _authorRepository.GetCountAsync() <= 0)
            {
                await _authorRepository.InsertAsync(
                    await _authorManager.CreateAsync(
                        "George Orwell",
                        new DateTime(1952,03,11),
                        "dddds sdf sdf sd fsD  sd "
                    )
                );


                await _authorRepository.InsertAsync(
                    await _authorManager.CreateAsync(
                        "ss sds D ",
                        new DateTime(1934,2,34),
                        "DD DSFSDF SDF DSF"
                        )
                    );
            }
        } 
    }
}
  