using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PII___Practico2
{
    internal class Cliente
    {
        private int documento;
        private string nombre;
        private string apellido;
        private int telefono;

        public Cliente(int documento, string nombre, string apellido, int telefono)
        {
            this.documento = documento;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
        }
        public int getDocumento() { return documento; } 
        public string getNombre() {  return nombre; } 
        public string getApellido() { return apellido; }
        public int getTelefono() {  return telefono; }

        public void setDocumento(int documento){this.documento = documento;}
        public void setNombre(string nombre) { this.nombre=nombre;}
        public void setApellido(string apellido) { this.apellido=apellido;}
        public void setTelefono(int telefono) { this.telefono=telefono;}

    }
}
