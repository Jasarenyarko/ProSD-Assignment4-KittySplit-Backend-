using System.Collections.Generic;
using KittySplit.Models;

namespace KittySplit.Data.Repositories
{
    public interface IKittyRepository
    {
        Kitty Create(Kitty kitty);
        void Update(Kitty kitty);
        Kitty GetById(int id);
    }
}
