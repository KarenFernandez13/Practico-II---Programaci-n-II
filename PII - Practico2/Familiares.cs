using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII___Practico2
{
    internal class Familiares : Vehiculo
    {
        private double capMaletero;

        public Familiares(int id, string matricula, string marca, double alquilerDia, double capTanque, double kmLitro, string estado, string color, double capMaletero) : base(id, matricula, marca, alquilerDia, capTanque, kmLitro, estado, color)
        {
            this.capMaletero = capMaletero;
        }

        public double getCapMaletero() { return capMaletero; }
        public void setCapMaletero(double capMaletero) { this.capMaletero=capMaletero; }


    }
}
