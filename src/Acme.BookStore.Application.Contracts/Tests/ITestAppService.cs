using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Tests
{
    public interface ITestAppService :IApplicationService
    {
        public string test();
    }
}
