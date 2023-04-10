using Consultorio.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio.Manager.Interfaces
{
    public interface IClienteManager
    {
        Task<Cliente> GetClientesAsync(int id);
        Task<IEnumerable<Cliente>> GetClientesAsync();
    }
}
