using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Interface para funciones CRUD 
    /// <para>Programador: Alan Torres</para> 
    /// <para>Fecha: 26-05-2015</para> 
    /// <para>Basado en el codigo de Tugberk Ugurlu: http://www.tugberkugurlu.com/archive/generic-repository-pattern-entity-framework-asp-net-mvc-and-unit-testing-triangle</para>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositorioGenerico<T> where T : class
    {
        #region Sync
        /// <summary>
        /// Metodo Sincrono -Guardar Registro
        /// </summary>
        /// <param name="model"></param>
        void guardarRegistro(T model);
        /// <summary>
        /// Metodo Sincrono -Editar Registro
        /// </summary>
        /// <param name="model"></param>
        void editarRegistro(T model);
        /// <summary>
        /// Metodo Sincrono -Eliminar Registro
        /// </summary>
        /// <param name="model"></param>
        void eliminarRegistro(T model);
        /// <summary>
        /// Metodo Sincrono -Carga Registro
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> cargaRegistro();
        /// <summary>
        /// Metodo Sincrono -Carga Registro, Recibe funcion delegada de T
        /// </summary>
        /// <param name="lambda"></param>
        /// <returns></returns>
        IEnumerable<T> cargaRegistro(Expression<Func<T, bool>> lambda);
        #endregion
        #region Async
        /// <summary>
        /// Metodo Asyncrono -Guardar Registro
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task guardarRegistroAsync(T model);
        /// <summary>
        /// Metodo Asyncrono -Editar Registro
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task editarRegistroAsync(T model);
        /// <summary>
        /// Metodo Asyncrono -Eliminar Registro
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task eliminarRegistroAsync(T model);
        /// <summary>
        /// Metodo Asyncrono -Cargar Registro
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> cargaRegistroAsync();
        /// <summary>
        /// Metodo Asyncrono -Cargar Registro, Recibe funcion delegada de T
        /// </summary>
        /// <param name="lambda"></param>
        /// <returns></returns>
        Task<IEnumerable<T>> cargaRegistroAsync(Expression<Func<T, bool>> lambda);
        #endregion
    }
}
