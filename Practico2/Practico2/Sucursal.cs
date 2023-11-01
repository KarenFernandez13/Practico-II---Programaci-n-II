using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Sucursal
    {
        private int numero;
        private string direccion;
        private List<Alquiler> colAlquileres;
        private List<Vehiculo> colVehiculos;

        public Sucursal(int numero, string direccion, List<Alquiler> alquileres, List<Vehiculo> vehiculos)
        {
            this.numero = numero;
            this.direccion = direccion;
            this.alquileres = alquileres;
            this.vehiculos = vehiculos;
        }
        public int GetNumero() => numero; 
        public string GetDireccion() => direccion;
        public List<Alquiler> GetColAlquileres() => colAlquileres;
        public List<Vehiculo> GetColVehiculos() => colVehiculos;
        
        public void SetNumero(int numero) => this.numero = numero;
        public void SetDireccion(string direccion) => this.direccion = direccion;
        public void SetColAlquileres(List<Alquiler> colAlquileres) => this.colAlquileres = colAlquileres;
        public void SetColVehiculos(List<Vehiculo> colVehiculos) => this.colVehiculos = colVehiculos;

    }
}
