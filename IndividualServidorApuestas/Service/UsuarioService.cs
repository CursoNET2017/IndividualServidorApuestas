using IndividualServidorApuestas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IndividualServidorApuestas.Service
{
    public class UsuarioService : IUsuarioService
    {
        private IUsuarioRepository usuarioRepository;
        public UsuarioService(IUsuarioRepository _usuarioRepository)
        {
            this.usuarioRepository = _usuarioRepository;
        }

        public Usuario Get(long id)
        {
            return usuarioRepository.Get(id);
        }

        public Usuario Create(Usuario usuario)
        {
            return usuarioRepository.Create(usuario);
        }


        public IQueryable<Usuario> GetUsuarios()
        {
            return usuarioRepository.GetUsuarios();
        }

        public Usuario Delete(long id)
        {

            return usuarioRepository.Delete(id);
        }

        public void Put(Usuario usuario)
        {
            usuarioRepository.Put(usuario);
        }
    }
}