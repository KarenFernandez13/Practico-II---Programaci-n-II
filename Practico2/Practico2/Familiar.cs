using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Familiar: Vehiculo
    {
        public double capacidadMaletero;
        public Familiar(int numero, string matricula, string marca, string color, int capacidadTanque, bool disponibilidad, double precioAlquilerDia, int kmLitro, int capacidadMaletero) : base(numero, matricula, marca, color, capacidadTanque, disponibilidad, precioAlquilerDia, kmLitro)
        {
            this.capacidadMaletero = capacidadMaletero;
        }
        public double GetCapacidadMelter() => capacidadMaletero;
        public void SetCapacidadMaletero(double capacidadMaletero) => this.capacidadMaletero = capacidadMaletero;
    }
}
