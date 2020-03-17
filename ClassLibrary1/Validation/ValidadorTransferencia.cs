using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Domain.Validation
{
    public class ValidadorTransferencia : AbstractValidator<Transferencia>
    {
        public ValidadorTransferencia()
        {
        }
    }
}
