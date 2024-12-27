using EmlakPortali1.Models;
using EmlakPortali1.Repositories;

namespace EmlakPortali1.Repositories
{
    public class TodoRepository : GenericRepository<Todo>
    {
        public TodoRepository(AppDbContext context) : base(context)
        {
        }
    }
}


