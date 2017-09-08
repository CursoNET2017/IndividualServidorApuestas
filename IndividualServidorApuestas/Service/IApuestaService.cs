using System.Linq;

namespace IndividualServidorApuestas.Service
{
    public interface IApuestaService
    {
        Apuesta Create(Apuesta apuesta);
        Apuesta Delete(long id);
        Apuesta Get(long id);
        IQueryable<Apuesta> GetApuestas();
        void Put(Apuesta apuesta);
    }
}