using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Refatoring_Kata.Repository
{
    public interface IRepository<T>
    {
        void AtualizarPlacar(T player);
    }
}
