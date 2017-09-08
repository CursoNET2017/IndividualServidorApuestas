using System.Linq;

namespace IndividualServidorApuestas.Service
{
    public interface IUsuarioService
    {
        Usuario Create(Usuario usuario);
        Usuario Delete(long id);
        Usuario Get(long id);
        IQueryable<Usuario> GetUsuarios();
        void Put(Usuario usuario);
    }
}