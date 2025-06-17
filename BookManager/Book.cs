using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    internal class Book
    {
        // 속성이라 대문자로 선언. ( is는 소문자 )
        // ?는 null
        public string? Isbn { get; set; }
        public string? Name { get; set; }
        public string? Publisher { get; set; }
        public int Page { get; set; }

        public int UserId { get; set; }
        public string? UserName { get; set; }
        public bool isBorrowed { get; set; }
        public DateTime BorrowedAt { get; set; }
    }
}
