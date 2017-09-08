using IndividualServidorApuestas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividualServidorApuestas.Service
{
    public class ApuestaService : IApuestaService
    {
        private IApuestaRepository apuestaRepository;
        public ApuestaService(IApuestaRepository _apuestaRepository)
        {
            this.apuestaRepository = _apuestaRepository;
        }

        public Apuesta Get(long id)
        {
            return apuestaRepository.Get(id);
        }

        public Apuesta Create(Apuesta apuesta)
        {
            return apuestaRepository.Create(apuesta);
        }


        public IQueryable<Apuesta> GetApuestas()
        {
            return apuestaRepository.GetApuestas();
        }

        public Apuesta Delete(long id)
        {

            return apuestaRepository.Delete(id);
        }

        public void Put(Apuesta apuesta)
        {
            apuestaRepository.Put(apuesta);
        }
    }
}