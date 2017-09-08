using System.Linq;

namespace IndividualServidorApuestas.Repository
{
    public interface IApuestaRepository
    {
        Apuesta Create(Apuesta apuesta);
        Apuesta Delete(long id);
        Apuesta Get(long id);
        IQueryable<Apuesta> GetApuestas();
        void Put(Apuesta apuesta);
    }
}