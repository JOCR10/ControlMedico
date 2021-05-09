using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlMedico.Api.Data
{
    public interface IRepositorio<Modelo> where Modelo : class, IEntidad
    {
        Task<List<Modelo>> Consultar();
        Task<Modelo> Obtener(int id);
        Task<Modelo> Agregar(Modelo entidad);
        Task<Modelo> Actualizar(Modelo entidad);
        Task<Modelo> Eliminar(int id);
    }
}
