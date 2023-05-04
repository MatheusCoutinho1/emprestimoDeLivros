using Books.Interfaces;
using Books.Models;

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
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public void Incluir(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        public Task<Cliente> SelecionarByPk(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Cliente>> SelecionarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
