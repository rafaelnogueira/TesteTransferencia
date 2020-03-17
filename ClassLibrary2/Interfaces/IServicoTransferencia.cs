﻿using Application.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IServicoTransferencia
    {
        Task RealizarTransferenciaAsync(RealizarTransferenciaViewModel model);
    }
}
