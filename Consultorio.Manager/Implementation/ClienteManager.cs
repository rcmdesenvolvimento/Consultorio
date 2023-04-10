using Consultorio.Core.Domain;
using Consultorio.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Manager.Implementation
{
    public class ClienteManager : IClienteManager
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteManager(IClienteRepository clienteRepository)
        {
            this._clienteRepository = clienteRepository;
        }

        public Task<Cliente> GetClientesAsync(int id)
        {
            return _clienteRepository.GetClientePorIdAsync(id);
        }

        public Task<IEnumerable<Cliente>> GetClientesAsync()
        {
            return _clienteRepository.GetAllClienteAsync();
        }
    }
}
