using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII___Practico2
{
    internal class Sucursal
    {
        private int numeroSuc;
        private string direccionSuc;

        public Sucursal(int  numeroSuc, string direccionSuc)
        {
            this.numeroSuc = numeroSuc;
            this.direccionSuc = direccionSuc;
        }

        public int getNumeroSuc() { return numeroSuc; }
        public string getDireccionSuc() {  return direccionSuc; }

        public void setNumeroSuc(int numeroSuc) { this.numeroSuc = numeroSuc; }
        public void setDireccionSuc(string direccionSuc) { this.direccionSuc=direccionSuc; }

    }
}
