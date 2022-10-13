using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Test_2022F.Models;

namespace Test_2022F.Services
{
    public class BookService
    {
        public bool IsPublicDomain(Book book)
        {
            // TestNote: Return true if the book was published 75 years ago or more
            int book1 = Convert.ToInt32(book.Published);

            return book1 > 75;
        }
    }
}