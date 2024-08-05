using System.Linq;
using KittySplit.Models;
using KittySplit.Data;


namespace KittySplit.Data.Repositories
{
    public class KittyRepository : IKittyRepository
    {
        private readonly DataContext _context;

        public KittyRepository(DataContext context)
        {
            _context = context;
        }

        public Kitty Create(Kitty kitty)
        {
            _context.Kitties.Add(kitty);
            _context.SaveChanges();
            return kitty;
        }

        public void Update(Kitty kitty)
        {
            _context.Kitties.Update(kitty);
            _context.SaveChanges();
        }

        public Kitty GetById(int id)
        {
            return _context.Kitties.FirstOrDefault(k => k.Id == id);
        }
    }
}
