using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII___Practico2
{
    internal class DetalleAlquiler
    {
        private int cantDias;
        private DateTime fechaRetiro;
        Vehiculo vehiculo;
        // DUDA--HAY Q RELACIONAR OBJ VEHICULO A ESTA CLASE??
        public DetalleAlquiler(int cantDias, DateTime fechaRetiro, Vehiculo vehiculo)
        {
            this.cantDias = cantDias;
            this.fechaRetiro = fechaRetiro;
            this.vehiculo = vehiculo;
        }
        
        public int getCantDias() { return cantDias; }
        public DateTime getFechaRetiro() {  return fechaRetiro; }
        public Vehiculo getVehiculo() {  return vehiculo; }
        
        public void setCantDias(int cantDias) { this.cantDias=cantDias; }
        public void setFechaRetiro(DateTime fechaR) { this.fechaRetiro = fechaR;}
        public void setVehiculo(Vehiculo vehiculo) { this.vehiculo=vehiculo;}
    }
}
