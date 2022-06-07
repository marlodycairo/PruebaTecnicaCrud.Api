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
                .NotNull().WithMessage("No se aceptan valores nulos. Debe ingresar el nombre completo");

            RuleFor(x => x.FullName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Ingrese el nombre completo");

            RuleFor(x => x.FullName)
                .Cascade(CascadeMode.Stop)
                .Length(0, 250).WithMessage("el nombre excede el tamaño permitido.");

            RuleFor(x => x.BirthDate)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("confirme la fecha");

            RuleFor(x => x.Email)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Debe ingresar un correo");

            RuleFor(x => x.Email)
                .Cascade(CascadeMode.Stop)
                .EmailAddress(FluentValidation.Validators.EmailValidationMode.AspNetCoreCompatible)
                .WithMessage("Ingrese una dirección de correo válida.");

            RuleFor(x => x.Email)
                .Cascade(CascadeMode.Stop)
                .Length(0, 250).WithMessage("El correo excede el tamaño permitido");

            RuleFor(x => x.CityOrigin)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Ingrese la ciudad");

            RuleFor(x => x.CityOrigin)
                .Cascade(CascadeMode.Stop)
                .Length(0, 150).WithMessage("El nombre de la ciudad excede el tamaño permitido");
        }
    }
}
