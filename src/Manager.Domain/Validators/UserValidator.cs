﻿using FluentValidation;
using Manager.Domain.Entities;

namespace Manager.Domain.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x)
                .NotNull()
                .WithMessage("A entidade não pode ser nula.")

                .NotEmpty()
                .WithMessage("A entidade não pode ser vazia.");

            RuleFor(x => x.Name)
                .NotNull()
                .WithMessage("O nome não pode ser nulo.")

                .NotEmpty()
                .WithMessage("O nome não pode ser vazio.")

                .MinimumLength(3)
                .WithMessage("O nome deve ter no mínimo 3 caracteres.")

                .MaximumLength(60)
                .WithMessage("O nome deve ter no máximo 60 caracteres.");

            RuleFor(x => x.Email)
                .NotNull()
                .WithMessage("O email não pode ser nulo.")

                .NotEmpty()
                .WithMessage("O email não pode ser vazio.")

                .MinimumLength(10)
                .WithMessage("O email deve ter no mínimo 10 caracteres.")

                .MaximumLength(180)
                .WithMessage("O email deve ter no máximo 180 caracteres.")

                .Matches(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$")
                .WithMessage("O email está inválido.");

            RuleFor(x => x.Password)
                .NotNull()
                .WithMessage("A senha não pode ser nula.")

                .NotEmpty()
                .WithMessage("A senha não pode ser vazia.")

                .MinimumLength(6)
                .WithMessage("A senha deve ter no mínimo 6 caracteres.")

                .MaximumLength(30)
                .WithMessage("A senha deve ter no máximo 30 caracteres.");
        }
    }
}
