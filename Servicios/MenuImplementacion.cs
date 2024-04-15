﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamen4ºevaC_.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz de los menus de la aplicacion
    /// irodhan -> 15/04/2024
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {
        public int mostrarMenuYSeleccion()
        {
            Console.WriteLine("|----------------------------|");
            Console.WriteLine("|            Menu            |");
            Console.WriteLine("|----------------------------|");
            Console.WriteLine("| 0. Cerrar aplicacion       |");
            Console.WriteLine("| 1. Dar alta nuevo vehiculo |");
            Console.WriteLine("|----------------------------|");
            Console.WriteLine("\nIntroduce que opcion desea utilizar: ");
            int opcion= Console.ReadKey(true).KeyChar - ('0');
            return opcion;
        }
    }
}
