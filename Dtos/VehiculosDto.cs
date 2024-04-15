using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaExamen4ºevaC_.Dtos
{
    /// <summary>
    /// Clase que contiene toda la informacion necesaria de los vehiculos
    /// irodhan -> 15/04/2024
    /// </summary>
    internal class VehiculosDto
    {
        //Atributos
        long idVehiculo;
        string matricula = "aaaaa";
        string tipoVehiculo = "aaaaa";
        string zonasDestino = "aaaaa";
        bool mercancia=false;
        DateTime fchPasoControl=DateTime.Now;
        //Constructores
        public VehiculosDto(long idVehiculo, string matricula, string tipoVehiculo, string zonasDestino, bool mercancia, DateTime fchPasoControl)
        {
            this.IdVehiculo = idVehiculo;
            this.Matricula = matricula;
            this.TipoVehiculo = tipoVehiculo;
            this.ZonasDestino = zonasDestino;
            this.Mercancia = mercancia;
            this.FchPasoControl = fchPasoControl;
        }
        public VehiculosDto() 
        { 
        }
        //Getters & Setters

        public long IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string TipoVehiculo { get => tipoVehiculo; set => tipoVehiculo = value; }
        public string ZonasDestino { get => zonasDestino; set => zonasDestino = value; }
        public bool Mercancia { get => mercancia; set => mercancia = value; }
        public DateTime FchPasoControl { get => fchPasoControl; set => fchPasoControl = value; }
    }
}
