using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepositorioGenerico<T,C> : IRepositorioGenerico<T> where T: class where C: ADODataModel.bdTareasEntities,new() 
    {
        private C _entidades = new C();
        public C _contexto
        {
            get { return _entidades; }
            set { _entidades = value; }
        }
        #region Sync
        public void guardarRegistro(T model)
        {
            _contexto.Set<T>().Add(model);
            _contexto.SaveChanges();
        }

        public void editarRegistro(T model)
        {
            _entidades.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void eliminarRegistro(T model)
        {
            _contexto.Set<T>().Remove(model);
            _contexto.SaveChanges();
        }

        public IEnumerable<T> cargaRegistro()
        {
            return _contexto.Set<T>();
        }

        public IEnumerable<T> cargaRegistro(System.Linq.Expressions.Expression<Func<T, bool>> lambda)
        {
            return _contexto.Set<T>().Where(lambda);
        }
        #endregion

        #region Async
        public async Task guardarRegistroAsync(T model)
        {
             _contexto.Set<T>().Add(model);
             await _contexto.SaveChangesAsync();
        }

        public async Task editarRegistroAsync(T model)
        {
            _entidades.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
            await _contexto.SaveChangesAsync();
        }

        public async Task eliminarRegistroAsync(T model)
        {
            _contexto.Set<T>().Remove(model);
            await _contexto.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> cargaRegistroAsync()
        {
            var consulta = Task.Factory.StartNew(()=>_contexto.Set<T>());
            return await consulta;
        }

        public async Task<IEnumerable<T>> cargaRegistroAsync(System.Linq.Expressions.Expression<Func<T, bool>> lambda)
        {
            var consulta = Task.Factory.StartNew(()=>_contexto.Set<T>());
            return await consulta;
        }
        #endregion
    }
}
