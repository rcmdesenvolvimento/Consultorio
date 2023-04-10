using Consultorio.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Manager.Interfaces
{
    public interface IClienteManager
    {
        Task DeleteClienteAsync(int id);
        Task<Cliente> GetClientesAsync(int id);
        Task<IEnumerable<Cliente>> GetClientesAsync();
        Task<Cliente> InsertClienteAsync(Cliente cliente);
        Task<Cliente> UpdateClienteAsync(Cliente cliente);

    }
}
