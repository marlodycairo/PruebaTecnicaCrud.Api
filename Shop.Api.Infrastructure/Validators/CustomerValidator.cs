using FluentValidation;
using Shop.Api.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Api.Infrastructure.Validators
{
    public class CustomerValidator : AbstractValidator<CustomerDto>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CompanyName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("debe ingresar el nombre de la compañia");

            RuleFor(x => x.ContactName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("ingrese el nombre de contacto");

            RuleFor(x => x.Address)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("falta ingresar la dirección");

            RuleFor(x => x.City)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("ingrese la ciudad");

            RuleFor(x => x.Country)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("ingrese el pais");

            RuleFor(x => x.Phone)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("ingrese el número telefónico de contacto.");
        }
    }
}
