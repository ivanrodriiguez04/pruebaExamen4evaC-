using PruebaExamen4ºevaC_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamen4ºevaC_.Servicios
{
    /// <summary>
    /// Interfaz de todos las opciones que se puedan hacer en la aplicacion
    /// irodhan -> 15/04/2024
    /// </summary>
    internal interface OperativaInterfaz
    {
        /// <summary>
        /// Metodo que sirve para dar el alta a un nuevo vehuiculo
        /// irodhan -> 15/04/2024
        /// </summary>
        public void darAltaVehiculo(List<VehiculosDto> listaVehiculosAntigua);
    }
}
