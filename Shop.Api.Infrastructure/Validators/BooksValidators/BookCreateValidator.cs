using FluentValidation;
using PruebaTecnicaCrud.Api.Core.DTOs.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Infrastructure.Validators.BooksValidators
{
    public class BookCreateValidator : AbstractValidator<CreateBook>
    {
        public BookCreateValidator()
        {
            RuleFor(x => x.Title)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("No se aceptan valores nulos. Debe ingresar el titulo");

            RuleFor(x => x.NumberOfPages)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Ingrese el numero de paginas");

            RuleFor(x => x.Genre)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Debe ingresar un correo");

            RuleFor(x => x.Date)
                .Cascade(CascadeMode.Stop)
                .NotNull()
                .WithMessage("Ingrese una dirección de correo válida.");

            RuleFor(x => x.authorId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty()
                .WithMessage("El correo excede el tamaño permitido");
        }
    }
}
