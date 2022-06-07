using Shop.Api.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Core.Entities
{
    public class Author : BaseEntity
    {
        public string FullName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string CityOrigin { get; set; }
        public string Email { get; set; }
    }
}
