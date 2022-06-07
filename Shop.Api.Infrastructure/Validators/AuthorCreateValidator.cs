using FluentValidation;
using PruebaTecnicaCrud.Api.Core.DTOs.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Infrastructure.Validators
{
    public class AuthorCreateValidator : AbstractValidator<CreateAuthor>
    {
        public AuthorCreateValidator()
        {
            RuleFor(x => x.FullName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().Length(0, 250).WithMessage("Ingrese el nombre completo");

            RuleFor(x => x.FullName)
                .Cascade(CascadeMode.Stop)
                .NotNull().Length(0, 250).WithMessage("No se aceptan valores nulos. Debe ingresar el nombre completo");

            RuleFor(x => x.BirthDate)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("confirme la fecha");

            RuleFor(x => x.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Debe ingresar un correo");

            RuleFor(x => x.CityOrigin)
                .Cascade(CascadeMode.Stop)
                .NotEmpty();
        }
    }
}
