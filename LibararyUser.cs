using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class LibararyUser : User
    {
        public LibararyUser(string name)
        {
            Name = name;   
        }

        public LibararyCard Card { get; set; }

        public void BoworredBooks(Book book , Libarary libarary)
        { 
            libarary.BorrowBooks(book);
        }
    }
}
