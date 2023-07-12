using Microsoft.EntityFrameworkCore;

namespace BE_HelacorTest.Models.Repository
{
    public class RepartoRepository: IRepartoRepository
    {
        private readonly AplicationDbContext _context;

        public RepartoRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public Task<List<Repartos>> GetListRepartos()
        {
            throw new NotImplementedException();
        }

        public Task<Repartos> GetReparto(int id)
        {
            throw new NotImplementedException();
        }
    }
}
