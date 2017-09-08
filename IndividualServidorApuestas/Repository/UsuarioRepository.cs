using IndividualServidorApuestas.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IndividualServidorApuestas.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Usuario Get(long id)
        {
            return ApplicationDbContext.applicationDbContext.Usuarios.Find(id);
        }

        public Usuario Create(Usuario usuario)
        {
            return ApplicationDbContext.applicationDbContext.Usuarios.Add(usuario);
        }

        public IQueryable<Usuario> GetUsuarios()
        {
            IList<Usuario> lista = new List<Usuario>(ApplicationDbContext.applicationDbContext.Usuarios);
            return lista.AsQueryable();//Si devuelves el IQueryable casca en el lado del cliente.
        }

        public Usuario Delete(long id)
        {
            Usuario usuario = ApplicationDbContext.applicationDbContext.Usuarios.Find(id);
            if (usuario == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Usuarios.Remove(usuario);
            return usuario;
        }

        public void Put(Usuario usuario)
        {
            if (ApplicationDbContext.applicationDbContext.Usuarios.Count(e => e.Id == usuario.Id) == 0)// El private bool PersonaExists(long id) del anterior controlador
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(usuario).State = EntityState.Modified;
        }
    }
}