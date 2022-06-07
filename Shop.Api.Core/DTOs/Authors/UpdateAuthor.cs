using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Core.DTOs.Authors
{
    public class UpdateAuthor
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDate { get; set; }
        public string CityOrigin { get; set; }
        public string Email { get; set; }
    }
}
