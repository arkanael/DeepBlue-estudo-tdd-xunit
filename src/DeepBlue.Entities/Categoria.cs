using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;

namespace DeepBlue.Entities
{
    public class Categoria : Notifiable , IValidatable
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Produto> Produtos { get; set; }

        public void Validate()
        {
            AddNotifications(
                new Contract()
                .HasMaxLengthIfNotNullOrEmpty(Nome, 50, "O nome deve conter até 60 caracteres", "Nome é requerido")
                .HasMinLengthIfNotNullOrEmpty(Nome, 3, "O nome deve conter no mínimo 3 caracteres", "O nome é requerido"));
        }
    }
}
