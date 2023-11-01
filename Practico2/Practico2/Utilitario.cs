using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Utilitario: Vehiculo
    {
        public double capacidadMaxima;
        public Utilitario(int numero, string matricula, string marca, string color, int capacidadTanque, bool disponibilidad, double precioAlquilerDia, int kmLitro, int capacidadMaxima) : base(numero, matricula, marca, color, capacidadTanque, disponibilidad, precioAlquilerDia, kmLitro)
        {
            this.capacidadMaxima = capacidadMaxima;
        }
        public double GetCapacidadMaxima() => capacidadMaxima;
        public void SetCapacidadMaxima(double capacidadMaxima) => this.capacidadMaxima = capacidadMaxima;
    }
}
