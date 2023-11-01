using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII___Practico2
{
    internal class Utilitarios : Vehiculo
    {
        private double capCarga;

        public Utilitarios(int id, string matricula, string marca, double alquilerDia, double capTanque, double kmLitro,string estado, string color, double capCarga) : base(id, matricula, marca, alquilerDia, capTanque, kmLitro, estado, color)
        {
            this.capCarga = capCarga;
        }
        
        public double getCapCarga() { return capCarga; }
        public void setCapCarga(double capCarga) { this.capCarga=capCarga; }

    }
}
