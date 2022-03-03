using System;

namespace ApiControllers.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}