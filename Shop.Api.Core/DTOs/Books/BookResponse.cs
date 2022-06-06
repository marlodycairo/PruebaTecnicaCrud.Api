using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Core.DTOs.Books
{
    public class BookResponse
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int Genre { get; set; }
        public int NumberOfPages { get; set; }
        public int authorId { get; set; }
        public string Message { get; set; }
    }
}
