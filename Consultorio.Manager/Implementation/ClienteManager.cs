using Consultorio.Core.Domain;
using Consultorio.Manager.Interfaces;
using System.Collections.Generic;
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

        public async Task<Cliente> InsertClienteAsync(Cliente cliente)
        {
            return await _clienteRepository.InsertClienteAsync(cliente);
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            return await _clienteRepository.UpdateClienteAsync(cliente);
        }

        public async Task DeleteClienteAsync(int id)
        {
            await _clienteRepository.DeleteClienteAsync(id);
        }
    }
}