using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class RepositorioTransferencia : IRepositorioTransferencia
    {

        public Task TransferirAsync(Transferencia transferencia)
        {
            return Task.Run(() => null);
        }
    }
}
