using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII___Practico2
{
    internal class Deportivos : Vehiculo
    {
        private int velMaxima;

        public Deportivos(int id, string matricula, string marca, double alquilerDia, double capTanque, double kmLitro, string estado, string color, int velMaxima) : base 
            (id, matricula, marca, alquilerDia, capTanque , kmLitro, estado, color) 
        { 
            this.velMaxima = velMaxima;                       
        }
        public int getVelMaxima() {  return velMaxima; }
        public void setVelMaxima(int velMaxima) { this.velMaxima = velMaxima; }

    }   
}
