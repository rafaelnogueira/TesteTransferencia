using Domain.Validation;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Transferencia
    {
        public Transferencia(string origem, string destino, float valor)
        {
            Origem = origem;
            Destino = destino;
            Valor = valor;

        }

        public string Origem { get; set; }
        public string Destino { get; set; }
        public float Valor { get; set; }

        public void Validar()
        {
            var validador = new ValidadorTransferencia();
            validador.ValidateAndThrow(this);
        }
    }
}
