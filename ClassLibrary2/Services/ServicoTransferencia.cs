using Application.Interfaces;
using Application.Models;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ServicoTransferencia : IServicoTransferencia
    {
        private readonly IRepositorioTransferencia repositorioTransferencia;
        public ServicoTransferencia(IRepositorioTransferencia repositorioTransferencia)
        {
            this.repositorioTransferencia = repositorioTransferencia;
        }
        public async Task RealizarTransferenciaAsync(RealizarTransferenciaViewModel model)
        {
            var transferencia = new Transferencia(model.Origem, model.Destino, model.Valor);
            transferencia.Validar();
            await repositorioTransferencia.TransferirAsync(transferencia);
        }
    }
}
