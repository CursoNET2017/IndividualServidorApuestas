using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using IndividualServidorApuestas;
using IndividualServidorApuestas.Models;
using System.Web.Http.Cors;
using IndividualServidorApuestas.Service;

namespace IndividualServidorApuestas.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ApuestasController : ApiController
    {
        //private ApplicationDbContext db = new ApplicationDbContext();
        private IApuestaService apuestaService;

        public ApuestasController(IApuestaService _apuestaService)
        {
            this.apuestaService = _apuestaService;
        }

        // GET: api/Apuestas
        public IQueryable<Apuesta> GetApuestas()
        {
            return apuestaService.GetApuestas();
        }

        // GET: api/Apuestas/5
        [ResponseType(typeof(Apuesta))]
        public IHttpActionResult GetApuesta(int id)
        {
            Apuesta apuesta = apuestaService.Get(id);
            if (apuesta == null)
            {
                return NotFound();
            }

            return Ok(apuesta);
        }

        // PUT: api/Apuestas/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutApuesta(int id, Apuesta apuesta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != apuesta.Id)
            {
                return BadRequest();
            }

            try
            {
                apuestaService.Put(apuesta);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Apuestas
        [ResponseType(typeof(Apuesta))]
        public IHttpActionResult PostApuesta(Apuesta apuesta)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            apuesta = apuestaService.Create(apuesta);

            return CreatedAtRoute("DefaultApi", new { id = apuesta.Id }, apuesta);
        }

        // DELETE: api/Apuestas/5
        [ResponseType(typeof(Apuesta))]
        public IHttpActionResult DeleteApuesta(int id)
        {
            Apuesta apuesta;
            try
            {
                apuesta = apuestaService.Delete(id);
            }
            catch (NoEncontradoException)
            {
                return NotFound();
            }

            return Ok(apuesta);
        }
    }
}