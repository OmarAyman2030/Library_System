using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Libarian : User
    {
        public int EmployeeNo { get; set; }

        public Libarian(string name)
        {
            Name = name;
        }

        public void AddBook(Book newBook , Libarary libarary)
        {
            libarary.AddBook(newBook);
        }

        public void RemoveBook(Book newBook , Libarary libarary)
        {
            //Add logic
            libarary.RemoveBook(newBook);
        }
    }
}
