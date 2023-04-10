using Consultorio.Core.Domain;
using FluentValidation;
using System;

namespace Consultorio.Manager.Validator
{
    public class ClienteValidator : AbstractValidator<Cliente>
    {
        public ClienteValidator()
        {
            RuleFor(c => c.Nome).NotNull().NotEmpty().MinimumLength(10).MaximumLength(50);
            RuleFor(c => c.DataNascimento).NotNull().NotEmpty().LessThan(DateTime.Now).GreaterThan(DateTime.Now.AddYears(-130));
            RuleFor(c => c.Documento).NotNull().NotEmpty().MinimumLength(4).MaximumLength(10);
            RuleFor(c => c.Telefone).NotNull().NotEmpty().Matches("[2-9][0-9]{10}").WithMessage("O Telefone tem que ter o formato [2-9][0-9]{10}");
            RuleFor(c => c.Sexo).NotNull().NotEmpty().Must(IsMorF).WithMessage("Sexo precisa ser M ou F");
        }

        private bool IsMorF(char sexo)
        {
            return sexo == 'M' || sexo == 'F';
        }
    }
}