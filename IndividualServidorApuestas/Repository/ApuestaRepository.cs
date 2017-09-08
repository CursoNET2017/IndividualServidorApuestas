using IndividualServidorApuestas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IndividualServidorApuestas.Repository
{
    public class ApuestaRepository : IApuestaRepository
    {
        public Apuesta Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Apuestas.Find(id);
        }

        public Apuesta Create(Apuesta apuesta)
        {
            return ApplicationDbContext.applicationDbContext.Apuestas.Add(apuesta);
        }

        public IQueryable<Apuesta> GetApuestas()
        {
            IList<Apuesta> lista = new List<Apuesta>(ApplicationDbContext.applicationDbContext.Apuestas);
            return lista.AsQueryable();//Si devuelves el IQueryable casca en el lado del cliente.
        }

        public Apuesta Delete(long id)
        {
            Apuesta apuesta = ApplicationDbContext.applicationDbContext.Apuestas.Find(id);
            if (apuesta == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Apuestas.Remove(apuesta);
            return apuesta;
        }

        public void Put(Apuesta apuesta)
        {
            if (ApplicationDbContext.applicationDbContext.Apuestas.Count(e => e.Id == apuesta.Id) == 0)// El private bool PersonaExists(long id) del anterior controlador
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(apuesta).State = EntityState.Modified;
        }
    }
}