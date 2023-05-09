using Books.Interfaces;
using Books.Models;
using Microsoft.EntityFrameworkCore;

namespace Books.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly BooksContext _context;

        public ClienteRepository(BooksContext context)
        {
            _context = context;
        }

        public void Alterar(Cliente cliente)
        {
            _context.Entry(cliente).State = EntityState.Modified;
        }

        public void Excluir(Cliente cliente)
        {
            _context.Cliente.Remove(cliente);
        }

        public void Incluir(Cliente cliente)
        {
            _context.Cliente.Add(cliente);
        }

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<Cliente> SelecionarByPk(int id)
        {
            return await _context.Cliente.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Cliente>> SelecionarTodos()
        {
            return await _context.Cliente.ToListAsync();
        }
    }
}
