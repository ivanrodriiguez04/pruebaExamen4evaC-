using PruebaExamen4ºevaC_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamen4ºevaC_.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de las operaciones que se hagan dentro de la aplicacion
    /// irodhan -> 15/14/2024
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {
        public void darAltaVehiculo(List<VehiculosDto> listaVehiculosAntigua)
        {
            VehiculosDto nuevoVehiculo = crearVehiculo();
            listaVehiculosAntigua.Add(nuevoVehiculo);
        }

        private VehiculosDto crearVehiculo() 
        { 
            VehiculosDto nuevoVehiculo= new VehiculosDto();
            return nuevoVehiculo;
        }
    }
}
