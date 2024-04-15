using PruebaExamen4ºevaC_.Dtos;
using PruebaExamen4ºevaC_.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamen4ºevaC_.Controladores
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// irodhan -> 15/04/2024
    /// </summary>
    static class Program
    {
         static void Main(string[] args) 
        {
            //Listas
            List<VehiculosDto> listaVehiculos = new List<VehiculosDto>();
            //Objetos
            MenuInterfaz mI = new MenuImplementacion();
            OperativaInterfaz oi=new OperativaImplementacion();
            //Atributos
            bool cerrarMenu=false;
            int opcionSeleccionada = 0;
            try
            {
                while (!cerrarMenu)
                {
                    opcionSeleccionada = mI.mostrarMenuYSeleccion();

                    switch (opcionSeleccionada)
                    {
                        case 0:
                            Console.WriteLine("[INFO] - La opcion seleccionada ha sido la 0");
                            Console.WriteLine("[INFO] - La aplicacion se va ha cerrar");
                            cerrarMenu = true;
                            break;
                        case 1:
                            Console.WriteLine("[INFO] -  La opcion seleccionada ha sido la opcion 1");
                            oi.darAltaVehiculo(listaVehiculos);
                            break;
                        default:
                            Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna opcion mostrada anteriormente.");
                            break;
                    }
                }
            } 
            catch (Exception ex) 
            { 
                Console.WriteLine(ex.Message);
            }

        }
    }
}
