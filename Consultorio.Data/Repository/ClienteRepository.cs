using Consultorio.Core.Domain;
using Consultorio.Data.Context;
using Consultorio.Manager.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Consultorio.Data.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ConsultorioContext _consultorioContext;

        public ClienteRepository(ConsultorioContext consultorioContext)
        {
            _consultorioContext = consultorioContext;
        }

        public async Task<IEnumerable<Cliente>> GetAllClienteAsync()
        {
            return await _consultorioContext.Clientes.AsNoTracking().ToListAsync();
        }

        public async Task<Cliente> GetClientePorIdAsync(int id)
        {
            //return await _consultorioContext.Clientes.Where(c => c.Id == id).FirstOrDefaultAsync();
            //return await _consultorioContext.Clientes.AsNoTracking().FirstOrDefaultAsync(c=> c.Id==id);
            //return await _consultorioContext.Clientes.SingleOrDefaultAsync(c => c.Id == id);
            return await _consultorioContext.Clientes.FindAsync(id);
        }

        public async Task<Cliente> InsertClienteAsync(Cliente cliente)
        {
            await _consultorioContext.AddAsync(cliente);
            await _consultorioContext.SaveChangesAsync();
            return cliente;
        }

        public async Task<Cliente> UpdateClienteAsync(Cliente cliente)
        {
            var clienteConsultado = await GetClientePorIdAsync(cliente.Id);

            if (clienteConsultado == null) { return null; }

            _consultorioContext.Entry(clienteConsultado).CurrentValues.SetValues(cliente);
            await _consultorioContext.SaveChangesAsync();

            return clienteConsultado;
        }

        public async Task DeleteClienteAsync(int id)
        {
            var clienteConsultado = await GetClientePorIdAsync(id);

            _consultorioContext.Clientes.Remove(clienteConsultado);

            await _consultorioContext.SaveChangesAsync();
        }
    }
}