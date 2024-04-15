using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamen4ºevaC_.Servicios
{
    /// <summary>
    /// Interfaz de los menus de la aplicacion
    /// irodhan -> 15/04/2024
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo que muestra el menu principal de la aplicacion
        /// irodhan -> 15/04/2024
        /// </summary>
        /// <returns>Devuelve la opcion indicada por el usuario</returns>
        public int mostrarMenuYSeleccion();
    }
}
