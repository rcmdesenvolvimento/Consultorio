using Consultorio.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Manager.Interfaces
{
    public interface IClienteRepository
    {
        Task DeleteClienteAsync(int id);
        Task<IEnumerable<Cliente>> GetAllClienteAsync();
        Task<Cliente> GetClientePorIdAsync(int id);
        Task<Cliente> InsertClienteAsync(Cliente cliente);
        Task<Cliente> UpdateClienteAsync(Cliente cliente);
    }
}
