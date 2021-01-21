using Acme.BookStore.Authors.dto;
using Acme.BookStore.Authors.Interfaces;
using Acme.BookStore.Parents.dto;
using Acme.BookStore.Parents.Interfaces;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.ObjectMapping;

namespace Acme.BookStore.Parents
{
    public class ParentAppService :BookStoreAppService,IParentAppService
    {

        private readonly IParentRepository _parentRepository;


        public Task<ParentDto> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }


        public ParentAppService(
                IParentRepository parentRepository
        )
        {
            _parentRepository = parentRepository;
        }

        public string hello()
        {
            return "pkssss";
        }
    }
}
