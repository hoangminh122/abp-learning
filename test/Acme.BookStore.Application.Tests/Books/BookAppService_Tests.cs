using Acme.BookStore.Students.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BookStore.Books
{
    public class BookAppService_Tests :BookStoreApplicationTestBase
    {
        private readonly IStudentAppService _bookAppService;

        public BookAppService_Tests()
        {
            _bookAppService = GetRequiredService<IStudentAppService>();
        }

        [Face]

    }
}
