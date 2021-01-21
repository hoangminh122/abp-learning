using Acme.BookStore.Parents.dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Parents
{
    public interface IParentAppService: IApplicationService
    {
        Task<ParentDto> GetAsync(Guid id);
        public string hello();

    }
}
