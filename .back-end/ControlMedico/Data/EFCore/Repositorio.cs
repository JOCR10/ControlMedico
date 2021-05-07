using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlMedico.Api.Data.EFCore
{
    public abstract class Repositorio<TEntidad, TContexto> : IRepositorio<TEntidad>
        where TEntidad : class, IEntidad
        where TContexto : DbContext
    {
        private readonly TContexto context;
        public Repositorio(TContexto context)
        {
            this.context = context;
        }
        public async Task<TEntidad> Agregar(TEntidad entity)
        {
            context.Set<TEntidad>().Add(entity);
            await context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntidad> Eliminar(int id)
        {
            var entity = await context.Set<TEntidad>().FindAsync(id);
            if (entity == null)
            {
                return entity;
            }

            context.Set<TEntidad>().Remove(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntidad> Obtener(int id)
        {
            return await context.Set<TEntidad>().FindAsync(id);
        }

        public async Task<List<TEntidad>> Consultar()
        {
            return await context.Set<TEntidad>().ToListAsync();
        }

        public async Task<TEntidad> Actualizar(TEntidad entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return entity;
        }

    }
}
