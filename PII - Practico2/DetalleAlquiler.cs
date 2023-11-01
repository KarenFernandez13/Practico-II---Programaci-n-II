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

        public DetalleAlquiler(int cantDias, DateTime fechaRetiro)
        {
            this.cantDias = cantDias;
            this.fechaRetiro = fechaRetiro;
        }
        public int getCantDias() { return cantDias; }
        public DateTime getFechaRetiro() {  return fechaRetiro; }
        public void setCantDias(int cantDias) { this.cantDias=cantDias; }
        public void setFechaRetiro(DateTime fechaR) { this.fechaRetiro = fechaR;}
    }
}
