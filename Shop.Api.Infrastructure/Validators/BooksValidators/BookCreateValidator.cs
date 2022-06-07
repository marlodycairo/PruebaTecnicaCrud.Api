using FluentValidation;
using PruebaTecnicaCrud.Api.Core.DTOs.Books;
using PruebaTecnicaCrud.Api.Core.Entities;
using Shop.Api.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaCrud.Api.Infrastructure.Validators.BooksValidators
{
    public class BookCreateValidator : AbstractValidator<CreateBook>
    {
        private readonly IRepository<Book> _bookRepository;

        public BookCreateValidator(IRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;

            RuleFor(x => x.Title)
                .Cascade(CascadeMode.Stop)
                .NotNull().WithMessage("No se aceptan valores nulos. Debe ingresar el titulo");

            //controlar el # maximo de libros permitido
            //RuleFor(x => x.Title)
            //    .Cascade(CascadeMode.Stop)
            //    . // pendiente por hacer

            //RuleFor(x => x.Title)
            //    .Cascade(CascadeMode.Stop)
            //    .MustAsync(async (book, cancellation) =>
            //    {
            //        var bookObj = (await _bookRepository.GetAll()).Count();
                  
            //        return true;
            //    });

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
