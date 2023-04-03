using System.Collections.Generic;

namespace CSharm_LB5
{
    class Person
    {
        public string surname { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty; 
        public string id { get; set; } = string.Empty; //readers number
        public int countBooks { get; set; } = 0; //count books, which reader get in library
        public List<string> idBooks { get; set; } = new List<string>(); //id numbers books, which get reader
    }

    class Book
    {
        public string name { get; set; } = string.Empty;
        public int countPages { get; set; } = 0;
        public string id { get; set; } = string.Empty;
    }
    
    class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Person> Readers { get; set; } = new List<Person>();
    }
}