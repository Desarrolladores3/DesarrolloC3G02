using ProyBaseMuestra.Shared.Entity;
using System.Collections.Generic;

namespace ProyBaseMuestra.Client.Services
{
    //las interfaces son abstractas, no implementan los metodos
    public interface IServiceActor
    {
        List<Actor> GetActors();
    }
}