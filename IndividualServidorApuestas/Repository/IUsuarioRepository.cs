using System.Linq;

namespace IndividualServidorApuestas.Repository
{
    public interface IUsuarioRepository
    {
        Usuario Create(Usuario usuario);
        Usuario Delete(long id);
        Usuario Get(long id);
        IQueryable<Usuario> GetUsuarios();
        void Put(Usuario usuario);
    }
}